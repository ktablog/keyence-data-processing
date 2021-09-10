using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Net;
using System.Threading;
using LJV7_DllSampleAll;
using LJV7_DllSampleAll.Datas;

namespace KeyenceDataProcessing
{
    #region KeyenceConnectionType
    public enum KeyenceConnectionType
    {
        Usb,
        Ethernet
    }
    #endregion


    #region KeyenceCommunicationOptions
    public struct KeyenceCommunicationOptions
    {
        public int DeviceId;
        public KeyenceConnectionType ConnectionType;
        public KeyenceEthernetOpenOptions EthernetOptions;

        public void Init()
        {
            DeviceId = 0;
            ConnectionType = KeyenceConnectionType.Usb;
            EthernetOptions.Init();
        }
    }
    #endregion


    #region KeyenceEthernetOpenOptions
    public struct KeyenceEthernetOpenOptions
    {
        public string Ip;
        public int Port;

        public void Init()
        {
            Ip = "";
            Port = 0;
        }
    }
    #endregion


    #region KeyenceReaderData
    public class KeyenceReaderData
    {
        public double[] ProfileData = null;
        public double YStart = 0;
        public double YPitch = 0;
    }
    #endregion


    #region Delegate
    public delegate void KeyenceNotify();
    #endregion


    #region KeyenceCommunication
    class KeyenceCommunication
    {
        #region Property
        public bool Opened
        {
            get
            {
                return _opened;
            }
        }

        public KeyenceCommunicationOptions CommunicationOptions { get; set; }
        public KeyenceReaderData ReaderData
        {
            get
            {
                return _readerData;
            }
        }
        public event KeyenceNotify ReadSuccessed;
        public event KeyenceNotify ReadFailed;
        
        #endregion


        #region Field
        private bool _opened = false;
        private KeyenceCommunicationOptions _startedCommuncationOptions;
        private Thread _thread = null;
        private volatile bool _terminate = true;
        private volatile KeyenceReaderData _readerData = null;
        #endregion


        #region Method

        public void Start()
        {
            Stop();

            if (Open())
            {
                ThreadStart threadStart = new ThreadStart(this.Run);
                _thread = new Thread(threadStart);
                _terminate = false;
                _thread.Start();
            }
        }


        public void Stop()
        {
            _terminate = true;
            _thread = null;

            Close();
        }


        public void Run()
        {
            while (!_terminate)
            {
                try
                {
                    Read();
                    OnReadSuccess();
                }
                catch
                {
                    OnReadError();
                }

                Thread.Sleep(1/*000*/);
            }
         }


        private void Read()
        {
            _readerData = KeyenceReadProfile();
        }


        private bool Open()
        {
            if (Opened)
            {
                Close();
            }

            _startedCommuncationOptions = CommunicationOptions;
            return _startedCommuncationOptions.ConnectionType == KeyenceConnectionType.Usb
               ? UsbOpen(ref _startedCommuncationOptions)
               : NetOpen(ref _startedCommuncationOptions);
        }


        private bool UsbOpen(ref KeyenceCommunicationOptions options)
        {
            int rc = NativeMethods.LJV7IF_UsbOpen(options.DeviceId);
            _opened = rc == (int)Rc.Ok;
            return _opened;
        }


        private bool NetOpen(ref KeyenceCommunicationOptions options)
        {
            LJV7IF_ETHERNET_CONFIG ethernetConfig = new LJV7IF_ETHERNET_CONFIG();

            byte[] ipBytes;
            try
            {
                ipBytes = IPAddress.Parse(options.EthernetOptions.Ip).GetAddressBytes();
            }
            catch
            {
                return false;
            }

            if (options.EthernetOptions.Port < 0)
            {
                return false;
            }
            ethernetConfig.wPortNo = (ushort)options.EthernetOptions.Port;

            int rc = NativeMethods.LJV7IF_EthernetOpen(options.DeviceId, ref ethernetConfig);
            return rc == (int)Rc.Ok;
        }


        private void Close()
        {
            if (_opened)
            {
                _opened = false; ;
                NativeMethods.LJV7IF_CommClose(_startedCommuncationOptions.DeviceId);
            }
        }


        KeyenceReaderData KeyenceReadProfile()
        {
            LJV7IF_PROFILE_INFO profileInfo = new LJV7IF_PROFILE_INFO();
            LJV7IF_MEASURE_DATA[] measureData = new LJV7IF_MEASURE_DATA[NativeMethods.MeasurementDataCount];	

            int profileDataSize = Define.MAX_PROFILE_COUNT +
                (Marshal.SizeOf(typeof(LJV7IF_PROFILE_HEADER)) + Marshal.SizeOf(typeof(LJV7IF_PROFILE_FOOTER))) / Marshal.SizeOf(typeof(int));
            int[] receiveBuffer = new int[profileDataSize];	 

            using (PinnedObject pin = new PinnedObject(receiveBuffer))
            {
                Rc rc = (Rc)NativeMethods.LJV7IF_GetProfileAdvance(_startedCommuncationOptions.DeviceId, ref profileInfo, pin.Pointer,
                (uint)(receiveBuffer.Length * Marshal.SizeOf(typeof(int))), measureData);

                if (rc != Rc.Ok)
                {
                    return null;
                }
            }

            ProfileData profileData = new ProfileData(receiveBuffer, 0, profileInfo);
            int[] intProfileDataArr = profileData.ProfDatas;
            double[] doubleProfileDataArr = new double[intProfileDataArr.Length];
            for (int i = 0; i < intProfileDataArr.Length; i++)
            {
                doubleProfileDataArr[i] = 0.00001 * intProfileDataArr[i];
            }

            KeyenceReaderData readerData = new KeyenceReaderData();
            readerData.ProfileData = doubleProfileDataArr;
            readerData.YStart = profileInfo.lXStart;
            readerData.YPitch = profileInfo.lXPitch;

            return readerData;
        }


        private void OnReadSuccess()
        {
            if (ReadSuccessed != null)
            {
                ReadSuccessed.Invoke();
            }
        }

        private void OnReadError()
        {
            if (ReadFailed != null)
            {
                ReadFailed.Invoke();
            }
        }
        #endregion
    }
    #endregion
}

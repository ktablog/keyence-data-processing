using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Sharp7;

namespace KeyenceDataProcessing
{
    class SimaticCommunication
    {
        public bool Opened
        {
            get { return isOpened(); }
        }
        public CommunicationOptions CommunicationOptions { get; set; }
        public CommunicationData CommunicationData
        { 
            get 
            {
                return _communicationData;
            }
            set
            {
                Monitor.Enter(_communicationData);
                _communicationData = value;
                Monitor.Exit(_communicationData);
            } 
        }

        private Thread _thread = null;
        private volatile bool _terminate = true;
        private S7Client _s7Client = null;
        private CommunicationOptions _startedCommuncationOptions;
        private CommunicationData _communicationData;
 
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
            Console.Out.WriteLine("Thread started");
            CommunicationData data;
            while (!_terminate)
            {
                Monitor.Enter(_communicationData);
                data = _communicationData;
          
                Monitor.Exit(_communicationData);
               

                Thread.Sleep(1000);
            }
            Console.Out.WriteLine("Thread stopped");
        }


        private bool Open()
        {
            if (Opened)
            {
                Close();
            }

            _startedCommuncationOptions = CommunicationOptions;
            try
            {
                if (checkCommuncationOptions(_startedCommuncationOptions))
                {
                    _s7Client = OpenImpl();
                }
            }
            catch(Exception ex)
            {
                Console.Out.WriteLine(ex);
            }
 
            return Opened;
        }

        private S7Client OpenImpl()
        {
            S7Client client = new S7Client();
            int result = client.ConnectTo(
                _startedCommuncationOptions.Ip,
                _startedCommuncationOptions.Rack,
                _startedCommuncationOptions.Slot);
            if (result == 0)
            {
                return client;
            }
            return null;
        }


        private void Close()
        {
            if (isOpened())
            {
                try
                {
                    _s7Client.Disconnect();
                }
                catch
                {
                }
                _s7Client = null;
            }
        }


        public bool isOpened()
        {
            return _s7Client == null ? false : _s7Client.Connected;
        }


        private bool checkCommuncationOptions(CommunicationOptions options)
        {
            return checkRack(options.Rack)
                && checkSlot(options.Slot)
                && options.Ip != null
                && options.Ip.Length == 0
                && checkValueAddress(options.ResultYAddress)
                && checkValueAddress(options.ResultZAddress)
                && checkValueAddress(options.QualityAddress)
                && checkValueAddress(options.CounterAddress);
        }


        private bool checkRack(int rack)
        {
            return rack >= 0;
        }


        private bool checkSlot(int slot)
        {
            return slot >= 0;
        }


        private bool checkValueAddress(int address)
        {
            return address >= 0;
        }


        private bool checkBlockNumber(int blockNumber)
        {
            return blockNumber > 10;
        }


        private Int32 readInt32(int blockNumber, int address)
        {
            return 0;
        }


        private float readFloat(int blockNumber, int address)
        {
            byte[] buff = new byte[4];
            _s7Client.DBRead(blockNumber, address, buff.Length, buff);
            Array.Reverse(buff);
            return BitConverter.ToSingle(buff, 0);
        }


        private void writeInt32(int blockNumber, int address, Int32 value)
        {
            byte[] buff = BitConverter.GetBytes(value);
            Array.Reverse(buff);
            _s7Client.DBWrite(blockNumber, address, 4, buff);
        }


        private void writeFloat(int blockNumber, int address, float value)
        {
            byte[] buff = BitConverter.GetBytes(value);
            Array.Reverse(buff);
            _s7Client.DBWrite(blockNumber, address, 4, buff);
        }
    }

    internal struct CommunicationOptions
    {
        internal string Ip;
        internal int Rack;
        internal int Slot;
        internal int Block;
        internal int ResultYAddress;
        internal int ResultZAddress;
        internal int QualityAddress;
        internal int CounterAddress;
    }


    internal struct CommunicationData
    {
        internal double ResultY;
        internal double ResultZ;
        internal bool Quality;
        internal int Counter;
    }
}

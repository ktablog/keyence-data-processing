using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using LJV7_DllSampleAll;
using LJV7_DllSampleAll.Datas;

namespace KeyenceDataProcessing
{
    enum KeyenceConnectionType
    {
        Usb,
        Ethernet
    }


    class KeyenceCommunication
    {

        #region Field


        #endregion


        #region Property


        #endregion


        public KeyenceCommunication()
        {
        }


        public bool Open()
        {
            return true;
        }


        public void Close()
        {
        }


        KeyenceReaderData KeyenceReadProfile()
        {
            LJV7IF_PROFILE_INFO profileInfo = new LJV7IF_PROFILE_INFO();
            LJV7IF_MEASURE_DATA[] measureData = new LJV7IF_MEASURE_DATA[NativeMethods.MeasurementDataCount];		 // OUT1 to OUT16 measurement value

            int profileDataSize = Define.MAX_PROFILE_COUNT +
                (Marshal.SizeOf(typeof(LJV7IF_PROFILE_HEADER)) + Marshal.SizeOf(typeof(LJV7IF_PROFILE_FOOTER))) / Marshal.SizeOf(typeof(int));
            int[] receiveBuffer = new int[profileDataSize];	 // 3,207 (total of the header, the footer, and the 3,200 data entries)

            using (PinnedObject pin = new PinnedObject(receiveBuffer))
            {
                Rc rc = (Rc)NativeMethods.LJV7IF_GetProfileAdvance(Define.DEVICE_ID, ref profileInfo, pin.Pointer,
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
            readerData.YPitch = profileInfo.lXStart;
            readerData.YPitch = profileInfo.lXPitch;

            return readerData;
        }
    }


}

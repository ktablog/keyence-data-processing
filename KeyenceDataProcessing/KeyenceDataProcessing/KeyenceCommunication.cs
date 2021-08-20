using System;
using System.Collections.Generic;
using System.Text;

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
    }


}

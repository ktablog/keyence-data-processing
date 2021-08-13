using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Sharp7;

namespace KeyenceDataProcessing
{
    class SimaticCommunication
    {
        private Thread _thread = null;
        private volatile bool _terminate = true;

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
            while (!_terminate)
            {
                Thread.Sleep(1000);
            }
            Console.Out.WriteLine("Thread stopped");
        }


        private bool Open()
        {
            return true;
        }


        private void Close()
        {
        }
    }
}

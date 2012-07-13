using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    class DuplexServiceCallback : ServiceLibrary.IDuplexServiceCallback
    {
        public void SendData(string data)
        {
            Console.WriteLine("Recieved: " + data);
        }
    }
}

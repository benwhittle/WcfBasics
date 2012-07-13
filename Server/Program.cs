using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using ServiceLibrary;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------");
            Console.WriteLine(" SERVER");
            Console.WriteLine("----------------");
            Console.WriteLine();

            //InitViaCode();
            InitViaConfig();

            Console.WriteLine("Host is running, press <ENTER> to exit.");
            Console.ReadLine();
        }

        private static void InitViaCode()
        {
            ServiceHost svc = new ServiceHost(typeof(DuplexService));
            svc.AddServiceEndpoint(typeof(IDuplexService),
                new NetTcpBinding(),
                "net.tcp://localhost:9001/DuplexService");
            svc.Open();
        }

        private static void InitViaConfig()
        {
            ServiceHost svc = new ServiceHost(typeof(DuplexService));
            svc.Open();;
        }
    }
}

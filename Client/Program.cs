using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using ServiceLibrary;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------");
            Console.WriteLine(" CLIENT");
            Console.WriteLine("----------------");
            Console.WriteLine();

            Console.WriteLine("press <ENTER> to start.");
            Console.ReadLine();

            IDuplexService svc;
            //svc = InitViaCode();
            svc = InitViaConfig();
            svc.DoWork();

            Console.ReadLine();
        }

        private static IDuplexService InitViaCode()
        {
            DuplexChannelFactory<IDuplexService> cf =
              new DuplexChannelFactory<IDuplexService>(
                  new DuplexServiceCallback(),
                  new NetTcpBinding(),
                  new EndpointAddress("net.tcp://localhost:9001/DuplexService"));
            IDuplexService svc = cf.CreateChannel();
            return svc;
        }

        private static IDuplexService InitViaConfig()
        {
            DuplexChannelFactory<IDuplexService> cf = new DuplexChannelFactory<IDuplexService>(new DuplexServiceCallback(), "Callback");
            IDuplexService svc = cf.CreateChannel();
            return svc;
        }
    }
}

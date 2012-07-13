using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLibrary
{
    public class DuplexService : IDuplexService
    {
        public void DoWork()
        {
            IDuplexServiceCallback callback = OperationContext.Current.GetCallbackChannel<IDuplexServiceCallback>();
            callback.SendData("Service method starting."); 
            for (int i = 10; i > 0; i--)
            {
                Random r = new Random();
                int interval = r.Next(200, 1000);
                System.Threading.Thread.Sleep(interval);
                callback.SendData("data = " + i.ToString());
            }
            callback.SendData("Service method ending."); 
        }
    }
}

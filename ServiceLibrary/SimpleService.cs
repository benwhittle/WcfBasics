using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLibrary
{
    public class SimpleService : ISimpleService
    {
        public string DoWork()
        {
            return "Some work is done at " + DateTime.Now.ToString();
        }
    }
}

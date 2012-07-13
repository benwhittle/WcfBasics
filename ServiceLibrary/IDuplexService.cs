using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDuplexService" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(IDuplexServiceCallback),  SessionMode = SessionMode.Required)]
    public interface IDuplexService
    {
        [OperationContract(IsOneWay = true)]
        void DoWork();
    }
}

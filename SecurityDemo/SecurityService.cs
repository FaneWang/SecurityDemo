using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace SecurityDemo
{
    [ServiceContract]
    public interface SecurityService
    {
        [OperationContract]
        string SayingHello(string name);
    }
}

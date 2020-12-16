using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF1
{    
    [ServiceContract]
    public interface IServicePessoa
    {
        [OperationContract]
        Pessoa GetPessoa(int id);       
    }    
}

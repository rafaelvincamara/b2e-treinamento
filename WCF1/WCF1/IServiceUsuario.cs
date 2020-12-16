using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF1
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IServiceUsuario" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IServiceUsuario
    {
        [OperationContract]
        void DoWork();
    }
}

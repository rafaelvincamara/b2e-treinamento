using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;
using WCF1.DAO;

namespace WCF1
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class ServicePessoa : IServicePessoa
    {
        private IPessoaDAO pessoaDAO;

        public Pessoa GetPessoa(int id)
        {
            pessoaDAO = new PessoaDAO();
            Thread.Sleep(2000);
            return pessoaDAO.GetPessoa(id);
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF1_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = GetPessoa().Result;
            Console.WriteLine("depois de chamar o serviço");
            Console.WriteLine(pessoa.Nome);
            
            Console.ReadLine();
        }

        private static async Task<ServicePessoa.Pessoa> GetPessoa()
        {
            ServicePessoa.ServicePessoaClient pessoaClient = new ServicePessoa.ServicePessoaClient();
            var pessoa = await pessoaClient.GetPessoaAsync(10);
            return pessoa;
        }
    }
}

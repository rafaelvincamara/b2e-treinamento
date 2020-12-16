using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF1.DAO
{
    public class PessoaDAO: IPessoaDAO
    {
        public Pessoa GetPessoa(int id)
        {
            //TODO: Recuperar Pessoa do Banco
            return new Pessoa() { Id = 1, Nome = "Maria do Bairro" };
        }
    }
}
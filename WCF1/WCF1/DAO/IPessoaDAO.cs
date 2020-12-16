using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF1.DAO
{
    public interface IPessoaDAO
    {
        Pessoa GetPessoa(int id);
        void Inserir(Pessoa pessoa);
        void Atualizar(Pessoa pessoa);
        void Excuir(Pessoa pessoa);
    }
}

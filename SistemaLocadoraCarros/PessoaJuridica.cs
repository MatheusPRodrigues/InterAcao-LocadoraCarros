using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraCarros
{
    public class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }
        public PessoaJuridica(string nome, DateOnly dataNascimento, string cnpj) : base(nome, dataNascimento)
        {
            this.Cnpj = cnpj;
        }
    }
}

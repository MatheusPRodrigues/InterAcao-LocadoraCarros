using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraCarros
{
    public class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; private set; }
        public PessoaJuridica(string nome, DateOnly dataNascimento, string cnpj) : 
            base(nome, dataNascimento)
        {
            this.Cnpj = cnpj;
        }

        public override string ToString()
        {
            return $"Razão social: {this.Nome}\n" +
                $"CNPJ: {this.Cnpj}\n" +
                $"Data de registro: {this.DataNascimento}\n";
        }
    }
}

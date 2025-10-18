using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraCarros
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }

        public PessoaFisica(string nome, DateOnly dataNascimento, string cpf) : base(nome, dataNascimento)
        {
            this.Cpf = cpf;
        }
    }
}

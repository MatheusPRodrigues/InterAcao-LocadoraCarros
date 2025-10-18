using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraCarros
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; private set; }

        public PessoaFisica(string nome, DateOnly dataNascimento, string cpf) :
            base(nome, dataNascimento)
        {
            this.Cpf = cpf;
        }

        public override string ToString()
        {
            return $"Nome: {this.Nome}\n" +
                $"CPF: {this.Cpf}\n" +
                $"Data de nascimento: {this.DataNascimento}\n";
        }
    }
}

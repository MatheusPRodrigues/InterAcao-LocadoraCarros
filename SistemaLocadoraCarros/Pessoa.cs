using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraCarros
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public DateOnly DataNascimento { get; set; }

        protected Pessoa(string nome, DateOnly dataNascimento)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
        }
    }
}

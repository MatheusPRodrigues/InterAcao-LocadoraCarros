using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraCarros
{
    public abstract class Veiculo
    {
        public string Marca { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }
        public double ValorVeiculo { get; set; }

        public Veiculo(string marca, string cor, int ano, double valorVeiculo)
        {
            this.Marca = marca;
            this.Cor = cor;
            this.Ano = ano;
            this.ValorVeiculo = valorVeiculo;
        }
    }
}

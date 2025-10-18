using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraCarros
{
    public class Locacao
    {
        public int Id { get; private set; }
        public DateTime DataLocacao { get; set; }
        public Pessoa Cliente { get; set; }
        public Veiculo VeiculoLocado { get; set; }
        public double ValorLocacao { get; set; }

        public Locacao(int id, Pessoa cliente, Veiculo veiculoLocado)
        {
            this.Id = id;
            this.DataLocacao = DateTime.Now;
            this.Cliente = cliente;
            this.VeiculoLocado = veiculoLocado;
            this.ValorLocacao = DefinirValorLocacao(cliente, veiculoLocado.ValorVeiculo);
        }

        private double DefinirValorLocacao(Pessoa cliente, double valorVeiculo)
        {
            const double ADICIONALPESSOAFISICA = 0.1;
            const double ADICIONALPESSOAJURIDICA = 0.15;

            if (cliente is PessoaJuridica)
                return valorVeiculo + (valorVeiculo * ADICIONALPESSOAJURIDICA);
            else
                return valorVeiculo + (valorVeiculo * ADICIONALPESSOAFISICA);
        }

        public override string ToString()
        {
            return "";
        }
    }
}

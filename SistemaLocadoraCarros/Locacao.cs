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
        public DateTime DataDevolucao { get; set; }
        public Pessoa Cliente { get; set; }
        public Veiculo VeiculoLocado { get; set; }
        public double ValorLocacao { get; set; }

        private static int contadorId = 1;

        public Locacao(Pessoa cliente, Veiculo veiculoLocado, DateTime dataDevolucao)
        {
            this.Id = contadorId++;
            DateTime dataLocacao = DateTime.Now;
            this.DataLocacao = dataLocacao;
            this.Cliente = cliente;
            this.VeiculoLocado = veiculoLocado;
            this.DataDevolucao = dataDevolucao;
            this.ValorLocacao = DefinirValorLocacao(cliente, veiculoLocado.ValorVeiculo, dataLocacao, dataDevolucao);
        }

        private double DefinirValorLocacao(Pessoa cliente, double valorVeiculo, 
            DateTime dataLocacao, DateTime dataDevolucao)
        {
            const double ADICIONALPESSOAFISICA = 0.1;
            const double ADICIONALPESSOAJURIDICA = 0.15;

            if (cliente is PessoaJuridica)
                return (valorVeiculo + (valorVeiculo * ADICIONALPESSOAJURIDICA)) * DiasDeLocacao(dataLocacao, dataDevolucao);
            else
                return (valorVeiculo + (valorVeiculo * ADICIONALPESSOAFISICA)) * DiasDeLocacao(dataLocacao, dataDevolucao);
        }

        private int DiasDeLocacao(DateTime dataLocacao, DateTime dataDevolucao)
        {
            TimeSpan tempoEntreDatas = dataDevolucao.Date - dataLocacao.Date;
            return tempoEntreDatas.Days;
        }

        public override string ToString()
        {
            return $"Id da locação: {this.Id}\n" +
                $"Data de locação: {this.DataLocacao}\n" +
                $"Data de devolução: {this.DataDevolucao}\n" +
                $"================ VEÍCULO ================\n" +
                $"{VeiculoLocado.ExibirInformacoes()}" +
                $"================ CLIENTE ================\n" +
                $"{Cliente.ToString()}" +
                $"============== VALOR LOCACÃO ===============\n" +
                $"Valor da locação (total): {this.ValorLocacao:C}\n";
        }
    }
}

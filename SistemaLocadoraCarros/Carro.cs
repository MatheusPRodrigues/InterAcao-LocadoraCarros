using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraCarros
{
    public class Carro : Veiculo
    {
        public int QtdPortas { get; set; }
        
        public Carro(string placa, string marca, string cor, int ano, int qtdPortas, double valorVeiculo) :
            base(placa, marca, cor, ano, valorVeiculo)
        {
            this.QtdPortas = qtdPortas;
        }

        public override string ExibirInformacoes()
        {
            return base.ExibirInformacoes() + $"Quantidade de portas: {this.QtdPortas}\n";
        }
    }
}

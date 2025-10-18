using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraCarros
{
    public class Caminhao : Veiculo
    {
        public double QtdCargaSuportada { get; set; }
        
        public Caminhao(string placa, string marca, string cor, int ano, double qtdCargaSuportada, double valorVeiculo) :
            base(placa, marca, cor, ano, valorVeiculo)
        {
            this.QtdCargaSuportada = qtdCargaSuportada;
        }

        public override string ExibirInformacoes()
        {
            return base.ExibirInformacoes() + $"Carga suportada: {this.QtdCargaSuportada:F2}\n";
        }
    }
}

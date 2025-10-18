using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraCarros
{
    public class Caminhao : Veiculo
    {
        public double QtdCarga { get; set; }
        
        public Caminhao(string marca, string cor, int ano, double qtdCarga, double valorVeiculo) :
            base(marca, cor, ano, valorVeiculo)
        {
            this.QtdCarga = qtdCarga;
        }
    }
}

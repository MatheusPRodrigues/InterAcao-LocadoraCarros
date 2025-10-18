using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraCarros
{
    public class Moto : Veiculo
    {
        public bool VemComBau { get; set; }
        
        public Moto(string marca, string cor, int ano, double valorVeiculo, bool vemComBau) :
            base(marca, cor, ano, valorVeiculo)
        {
            this.VemComBau = vemComBau;
        }
    }
}

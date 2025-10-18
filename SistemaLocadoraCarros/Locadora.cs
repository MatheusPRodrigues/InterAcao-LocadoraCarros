using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraCarros
{
    public class Locadora
    {
        public List<Pessoa> Clientes { get; set; }
        public List<Veiculo> Veiculos { get; set; }
        public List<Locacao> Locacoes { get; set; }

        public Locadora()
        {
            this.Clientes = new List<Pessoa>();
            this.Veiculos = new List<Veiculo>();
            this.Locacoes = new List<Locacao>();
        }
    }
}

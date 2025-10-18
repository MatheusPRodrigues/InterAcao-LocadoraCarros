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

        public void CadastrarCliente(Pessoa cliente)
        {
            this.Clientes.Add(cliente);
        }

        public void CadastrarVeiculo(Veiculo veiculo)
        {
            this.Veiculos.Add(veiculo);
        }

        public void RealizarLocacao(Pessoa cliente, Veiculo veiculo)
        {
            this.Locacoes.Add(new Locacao(
                cliente,
                veiculo));
        }

        public void ExibirClientes()
        {
            if (this.Clientes.Count > 0)
            {
                Console.WriteLine("======== CLIENTES ========");
                foreach (var c in this.Clientes)
                {
                    c.ToString();
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("Não há clientes cadastrados no sistema!");
        }

        public void ExibirVeiculos()
        {
            if (this.Veiculos.Count > 0)
            {
                Console.WriteLine("======== VEÍCULOS ========");
                foreach (var v in this.Veiculos)
                {
                    v.ExibirInformacoes();
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("Não há veículos cadastrados no sistema!");
        }

        public void ExibirLocacoes()
        {
            if (this.Locacoes.Count > 0)
            {
                Console.WriteLine("======== LOCAÇÕES ========");
                foreach (var l in this.Locacoes)
                {
                    l.ToString();
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("Não há locações realizadas ainda no sistema!");
        }
    }
}

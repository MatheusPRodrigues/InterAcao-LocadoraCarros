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

        public List<PessoaFisica> SelecionarApenasPessoaFisica()
        {
            List<PessoaFisica> pessoasFisica = new List<PessoaFisica>();
            foreach (var c in this.Clientes)
            {
                if (c is PessoaFisica)
                {
                    PessoaFisica p = (PessoaFisica)c;
                    pessoasFisica.Add(p);
                }
            }

            return pessoasFisica;
        }

        private bool VerificarSeClientePessoaFisicaJaExiste(PessoaFisica pessoa)
        {
            List<PessoaFisica> pessoasFisica = SelecionarApenasPessoaFisica();

            return pessoasFisica.Exists(p => pessoa.Cpf == p.Cpf);
        }

        public List<PessoaJuridica> SelecionarApenasPessoaJuridica()
        {
            List<PessoaJuridica> pessoasJuridica = new List<PessoaJuridica>();
            foreach (var c in this.Clientes)
            {
                if (c is PessoaJuridica)
                {
                    PessoaJuridica p = (PessoaJuridica)c;
                    pessoasJuridica.Add(p);
                }
            }

            return pessoasJuridica;
        }

        private bool VerificarSeClientePessoaJuridicaJaExiste(PessoaJuridica empresa)
        {
            List<PessoaJuridica> pessoasJuridica = SelecionarApenasPessoaJuridica();

            return pessoasJuridica.Exists(p => empresa.Cnpj == p.Cnpj);
        }

        public void CadastrarCliente(Pessoa cliente)
        {
            if (cliente is PessoaFisica)
            {
                PessoaFisica p = (PessoaFisica) cliente;
                if (VerificarSeClientePessoaFisicaJaExiste(p))
                {
                    Console.WriteLine("Este cliente já se encontra cadastrado no sistema!");
                    return;
                }                                  
            }
            else
            {
                PessoaJuridica e = (PessoaJuridica) cliente;
                if (VerificarSeClientePessoaJuridicaJaExiste(e))
                {
                    Console.WriteLine("Está empresa já está cadastrada em nosso sistema!");
                    return;
                }                
            }

            this.Clientes.Add(cliente);
            Console.WriteLine("Cadastro realizado com sucesso!");
        }

        public void CadastrarVeiculo(Veiculo veiculo)
        {
            this.Veiculos.Add(veiculo);
            Console.WriteLine("Veículo cadastrado com sucesso!");
        }

        public void RealizarLocacao(Pessoa cliente, Veiculo veiculo, DateTime dataDevolucao)
        {
            this.Locacoes.Add(new Locacao(
                cliente,
                veiculo,
                dataDevolucao));
            Console.WriteLine("\nLocação realizada com sucesso!");
        }

        public void ExibirClientes()
        {
            if (this.Clientes.Count > 0)
            {
                Console.WriteLine("======== CLIENTES ========");
                foreach (var c in this.Clientes)
                {
                    Console.WriteLine(c.ToString());
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
                    Console.WriteLine(v.ExibirInformacoes());
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("Não há veículos cadastrados no sistema!");
        }

        public Veiculo SelecionarApenasUmVeiculo(string marca)
        {
            return this.Veiculos.FirstOrDefault(v => v.Marca == marca)!;
        }

        public void ExibirLocacoes()
        {
            if (this.Locacoes.Count > 0)
            {
                Console.WriteLine("================ LOCAÇÕES ================");
                Console.WriteLine();
                foreach (var l in this.Locacoes)
                {
                    Console.WriteLine(l.ToString());
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("Não há locações realizadas ainda no sistema!");
        }

        public Locacao BuscarLocacaoPorId(int id)
        {
            return this.Locacoes.FirstOrDefault(l => l.Id == id);
        }

        public List<Locacao> BuscarLocacoesPorCliente(string nome)
        {
            return this.Locacoes.FindAll(l => l.Cliente.Nome == nome);
        }
    }
}

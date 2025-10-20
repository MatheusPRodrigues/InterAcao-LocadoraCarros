// Sistema de Locadora de Carros

using SistemaLocadoraCarros;

void PressioneEnterParaContinuar()
{
    Console.WriteLine("Pressione a teclar 'ENTER' para continuar");
    Console.ReadLine();
}

bool VerificarSeTemCaractereDiferenteDeNumero(string texto)
{
    return !(long.TryParse(texto, out var numeros));
}

string InserirCpfValido()
{
    bool cpfInvalido;
    string cpf;
    do
    {
        Console.WriteLine("Digite o CPF do cliente (somente os números):");
        cpf = Console.ReadLine();

        cpfInvalido = cpf.Length != 11 || VerificarSeTemCaractereDiferenteDeNumero(cpf);

        if (cpfInvalido)
            Console.WriteLine("CPF inválido! Tente novamente!");

    } while (cpfInvalido);

    return cpf;
}

string InserirCnpjValido()
{
    bool cnpjInvalido;
    string cnpj;
    do
    {
        Console.WriteLine("Digite o CNPJ do cliente (somente os números):");
        cnpj = Console.ReadLine();

        cnpjInvalido = cnpj.Length != 14 || VerificarSeTemCaractereDiferenteDeNumero(cnpj);

        if (cnpjInvalido)
            Console.WriteLine("CPF inválido! Tente novamente!");

    } while (cnpjInvalido);

    return cnpj;
}

string SelecionarTipoDePessoa(string mensagem)
{
    string opcao;
    bool respostaInvalida;

    Console.WriteLine(mensagem);
    do
    {
        Console.WriteLine("1 - Pessoa Física | 2 - Pessoa Jurídica");
        Console.Write(": ");
        opcao = Console.ReadLine() ?? "";

        respostaInvalida = opcao != "1" && opcao != "2";

        if (respostaInvalida)
            Console.WriteLine("\nOpção inválida! Tente novamente!");

    }
    while (respostaInvalida);

    return opcao;
}

PessoaFisica CadastrarPessoaFisica()
{
    Console.WriteLine("Digite o seu nome:");
    string nomeCliente = Console.ReadLine();

    string cpfCliente = InserirCpfValido();

    Console.WriteLine("Digite a sua data de nascimento:");
    DateOnly dataNascimento = DateOnly.Parse(Console.ReadLine() ?? "00/00/0000");

    return new PessoaFisica(nomeCliente, dataNascimento, cpfCliente);
}

PessoaJuridica CadastrarPessoaJuridica()
{
    Console.WriteLine("Digite a razão social da organização:");
    string razaoSocial = Console.ReadLine();

    string cnpj = InserirCnpjValido();

    Console.WriteLine("Digite a data de fundação da organização");
    DateOnly dataFundacao = DateOnly.Parse(Console.ReadLine() ?? "00/00/0000");

    return new PessoaJuridica(razaoSocial, dataFundacao, cnpj);
}

void CadastrarCliente(Locadora locadora)
{
    string opcao = SelecionarTipoDePessoa("===== CADASTRAR CLIENTE =====");

    if (opcao == "1")
        locadora.CadastrarCliente(CadastrarPessoaFisica());
    else
        locadora.CadastrarCliente(CadastrarPessoaJuridica());

    PressioneEnterParaContinuar();
}

Carro CadastrarCarro()
{
    Console.WriteLine("Digite a marca do carro:");
    string marca = Console.ReadLine();

    Console.WriteLine("Digite a cor do carro:");
    string cor = Console.ReadLine();

    Console.WriteLine("Digite o ano de fabricação do carro:");
    int ano = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite a quantidade de portas do carro:");
    int qtdPortas = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o valor de locação do carro: ");
    double valorLocacao = Convert.ToDouble(Console.ReadLine());

    return new Carro(marca, cor, ano, qtdPortas, valorLocacao);
}

bool MotoPossuiBau()
{
    string opcao;
    bool respostaInvalida;
    Console.WriteLine("A moto possuí baú?");
    do
    {
        Console.Write("(1 - Sim | 0 - Não): ");
        opcao = Console.ReadLine(); 

        respostaInvalida = opcao != "1" && opcao != "0";
        if (respostaInvalida)
            Console.WriteLine("Resposta inválida! Escolha '1' ou '0'\n");
    }
    while (respostaInvalida);

    if (opcao == "1")
        return true;
    else
        return false;
}

Moto CadastrarMoto()
{
    Console.WriteLine("Digite a marca da moto:");
    string marca = Console.ReadLine();

    Console.WriteLine("Digite a cor da moto:");
    string cor = Console.ReadLine();

    Console.WriteLine("Digite o ano de fabricação da moto:");
    int ano = Convert.ToInt32(Console.ReadLine());

    bool bau = MotoPossuiBau();

    Console.WriteLine("Digite o valor de locação da moto: ");
    double valorLocacao = Convert.ToDouble(Console.ReadLine());

    return new Moto(marca, cor, ano, valorLocacao, bau);
}

Caminhao CadastrarCaminhao()
{
    Console.WriteLine("Digite a marca do caminhão:");
    string marca = Console.ReadLine();

    Console.WriteLine("Digite a cor do caminhão:");
    string cor = Console.ReadLine();

    Console.WriteLine("Digite o ano de fabricação do caminhão:");
    int ano = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite a quantidade de carga suportada pelo caminhão (em Kg):");
    double qtdCarga = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite o valor de locação do caminhão: ");
    double valorLocacao = Convert.ToDouble(Console.ReadLine());

    return new Caminhao(marca, cor, ano, qtdCarga, valorLocacao);
}

void CadastrarVeiculo(Locadora locadora)
{
    string opcao;
    bool respostaInvalida;

    Console.WriteLine("===== CADASTRAR VEÍCULO =====");
    do
    {
        Console.WriteLine("1 - Carro | 2 - Moto | 3 - Caminhão");
        Console.Write(": ");
        opcao = Console.ReadLine() ?? "";

        respostaInvalida = opcao != "1" && opcao != "2" && opcao != "3";

        if (respostaInvalida)
            Console.WriteLine("\nOpção inválida! Tente novamente!");

    }
    while (respostaInvalida);

    if (opcao == "1")
        locadora.CadastrarVeiculo(CadastrarCarro());
    else if (opcao == "2")
        locadora.CadastrarVeiculo(CadastrarMoto());
    else
        locadora.CadastrarVeiculo(CadastrarCaminhao());

    PressioneEnterParaContinuar();
}

PessoaFisica BuscarClientePessoaFisica(Locadora locadora)
{
    List<PessoaFisica> pessoas = locadora.SelecionarApenasPessoaFisica();
    foreach (var p in pessoas)
    {
        Console.WriteLine(p.ToString());
    }

    string cpf = InserirCpfValido();

    PessoaFisica pessoaFisica = pessoas.FirstOrDefault(p => p.Cpf == cpf)!;

    return pessoaFisica;
}

PessoaJuridica BuscarClientePessoaJuridica(Locadora locadora)
{
    List<PessoaJuridica> empresas = locadora.SelecionarApenasPessoaJuridica();
    foreach (var e in empresas)
    {
        Console.WriteLine(e.ToString());
    }

    string cnpj = InserirCnpjValido();

    PessoaJuridica empresa = empresas.FirstOrDefault(e => e.Cnpj == cnpj)!;

    return empresa;
}

Veiculo SelecionarVeiculoParaLocacao(Locadora locadora)
{
    ExibirVeiculos(locadora);

    Console.WriteLine("Digite a marca do veículo para realizar a locação:");
    string marca = Console.ReadLine();

    return locadora.SelecionarApenasUmVeiculo(marca);
}

void RealizarLocacao(Locadora locadora)
{
    string opcao = SelecionarTipoDePessoa("Qual tipo de cliente deseja realizar a locação?");
    Pessoa cliente;

    if (opcao == "1")
        cliente = BuscarClientePessoaFisica(locadora);
    else
        cliente = BuscarClientePessoaJuridica(locadora);

    if (cliente == null)
    {
        Console.WriteLine("Cliente não encontrado! Tente novamente!");
        PressioneEnterParaContinuar();
        return;
    }

    Veiculo veiculo = SelecionarVeiculoParaLocacao(locadora);

    if (veiculo == null)
    {
        Console.WriteLine("Veículo não encontrado! Tente novamente!");
        PressioneEnterParaContinuar();
        return;
    }

    locadora.RealizarLocacao(cliente, veiculo);
    PressioneEnterParaContinuar();
}

void ExibirClientes(Locadora locadora)
{
    Console.Clear();
    locadora.ExibirClientes();
    PressioneEnterParaContinuar();
}

void ExibirVeiculos(Locadora locadora)
{
    Console.Clear();
    locadora.ExibirVeiculos();
    PressioneEnterParaContinuar();
}

void ExibirLocacoes(Locadora locadora)
{
    Console.Clear();
    locadora.ExibirLocacoes();
    PressioneEnterParaContinuar();
}

void MenuPrincipal()
{
    Locadora locadora = new Locadora();

    bool repetir = true;
    do
    {
        Console.Clear();

        Console.WriteLine("1 - Cadastrar cliente");
        Console.WriteLine("2 - Exibir clientes");
        Console.WriteLine("3 - Cadastrar veículo");
        Console.WriteLine("4 - Exibir veículos");
        Console.WriteLine("5 - Realizar locação de um veículo");
        Console.WriteLine("6 - Exibir locações");
        Console.WriteLine("0 - Sair do sistema");
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                CadastrarCliente(locadora);
                break;
            case "2":
                ExibirClientes(locadora);
                break;
            case "3":
                CadastrarVeiculo(locadora);
                break;
            case "4":
                ExibirVeiculos(locadora);
                break;
            case "5":
                //TODO: Realizar locação
                RealizarLocacao(locadora);
                break;
            case "6":
                ExibirLocacoes(locadora);
                break;
            case "0":
                Console.Clear();
                Console.WriteLine("Encerrar sistema!");
                repetir = false;
                break;
            default:
                Console.WriteLine("Opção inválida! Tente novamente!");
                PressioneEnterParaContinuar();
                break;
        }
    }
    while (repetir);
}

MenuPrincipal();    
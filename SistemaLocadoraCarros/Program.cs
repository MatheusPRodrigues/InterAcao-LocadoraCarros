// Sistema de Locadora de Carros

using SistemaLocadoraCarros;

void PressioneEnterParaContinuar()
{
    Console.WriteLine("Pressione a teclar 'ENTER' para continuar");
    Console.ReadLine();
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
                break;
            case "2":
                ExibirClientes(locadora);
                break;
            case "3":
                break;
            case "4":
                ExibirVeiculos(locadora);
                break;
            case "5":
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
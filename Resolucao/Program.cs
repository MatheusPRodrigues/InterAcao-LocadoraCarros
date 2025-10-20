using Resolucao.Abstract;
using Resolucao.Entities;
using Resolucao.Model;

RentalCompany rentalCompany = new RentalCompany();

List<string> mainOptions = new List<string>()
{
    "Menu Clientes",
    "Menu Veículos",
    "Menu Locações",
    "Sair"
};

List<string> customersOptions = new List<string>()
{
    "Cadastrar Cliente",
    "Listar Clientes",
    "Atualizar Cliente",
    "Remover Cliente",
    "Voltar ao Menu Principal"
};

List<string> vehiclesOptions = new List<string>()
{
    "Cadastrar Veículos",
    "Listar Veículos",
    "Atualizar Veículo",
    "Remover Veículo",
    "Voltar ao Menu Principal"
};

List<string> rentalsOptions = new List<string>()
{
    "Cadastrar Locação",
    "Listar Locações",
    "Finalizar Locação",
    "Remover Locação",
    "Voltar ao Menu Principal"
};

void CreateCustomer()
{
    Console.WriteLine("Informe o nome do cliente:");
    string name = Console.ReadLine() ?? "";
    
    Console.WriteLine("Informe a data de nascimento do cliente:");
    DateOnly birthDate = DateOnly.Parse(Console.ReadLine() ?? "");
    
    Console.WriteLine("Informe o email do cliente:");
    string email = Console.ReadLine() ?? "";
    
    Console.WriteLine("Informe o logradouro do cliente: ");
    string street = Console.ReadLine() ?? "";
    
    Console.WriteLine("Informe o número do endereço do cliente: ");
    int number = int.Parse(Console.ReadLine() ?? "");
    
    Console.WriteLine("Informe o complemento do endereço do cliente: ");
    string complement = Console.ReadLine() ?? "";
    
    Console.WriteLine("Informe o bairro do cliente: ");
    string neighborhood = Console.ReadLine() ?? "";
    
    Console.WriteLine("Informe a cidade do cliente: ");
    string city = Console.ReadLine() ?? "";
    
    Console.WriteLine("Informe o estado do cliente: ");
    string state = Console.ReadLine() ?? "";
    
    Console.WriteLine("Informe o CEP do cliente: ");
    string zipCode = Console.ReadLine() ?? "";

    var contact = new Contact(email, null);
    var address = new Address(street, number, neighborhood, zipCode, complement, city, state, "BR");

    Console.WriteLine("Qual tipo do cliente está cadastrando? (1 para PF, 2 para PJ):");
    int customerType = int.Parse(Console.ReadLine() ?? "1");

    if (customerType == 1)
    {
        Console.WriteLine("Informe o número da CNH:");
        string cnh = Console.ReadLine() ?? "";

        Console.WriteLine("Informe o numero do CPF:");
        string cpf = Console.ReadLine() ?? "";

        var customer = new CustomerPF(name, birthDate, contact, address, cnh, cpf);
        rentalCompany.Customers.Add(customer);
    }
    else
    {
        Console.WriteLine("Informe o CNPJ da empresa:");
        string cnpj = Console.ReadLine() ?? "";

        var customer = new CustomerPJ(name, birthDate, contact, address, cnpj);
        rentalCompany.Customers.Add(customer);
    }
}



void ListCustomers()
{
    if (rentalCompany.Customers.Count > 0)
    {
        Console.WriteLine("====== Lista de Clientes ======");
        foreach (var c in rentalCompany.Customers)
        {
            Console.WriteLine(c); // Ele já exibe o ToString()
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Não clientes cadastrados no sistema!");
    }
}

Person FindCustomerByName(string name)
{
    return rentalCompany.Customers.Find(c => c.GetName() == name);
}

Person UpdatePhone()
{
    Console.WriteLine("Informe o nome do cliente a ser atualizado:");
    string name = Console.ReadLine() ?? "";

    var customer = FindCustomerByName(name);

    if (customer is not null)
    {
        Console.WriteLine("Informe o telefone do cliente: ");
        string phone = Console.ReadLine() ?? "";
        customer.SetContactPhone(phone);
        Console.WriteLine("Telefone atualizado com sucesso!");
    }
    else
    {
        Console.WriteLine("Cliente não encontrado!");        
    }
    return customer;
}

void DeleteCustomer()
{
    Console.WriteLine("Informe o nome do cliente a ser removido:");
    string name = Console.ReadLine() ?? "";

    var customer = FindCustomerByName(name);

    if (customer is not null)
    {
        rentalCompany.Customers.Remove(customer);
        Console.WriteLine("Cliente removido com sucesso!");
    }
    else
    {
        Console.WriteLine("Cliente não encontrado!");
    }
}

void CustomerMenu(int option)
{
    switch (option)
    {
        case 1:
            CreateCustomer();
            break;
        case 2:
            ListCustomers();
            break;
        case 3:
            Console.WriteLine(UpdatePhone());
            break;
        case 4:
            DeleteCustomer();
            break;
    }
}

void CreateVehicle()
{
    throw new NotImplementedException();
}

void ListVehicles()
{
    throw new NotImplementedException();
}

void DeleteVehicle()
{
    throw new NotImplementedException();
}

void VehicleMenu(int option)
{
    switch (option)
    {
        case 1:
            CreateVehicle();
            break;
        case 2:
            ListVehicles();
            break;
        case 3:
            //TODO: Alguma atualização
            break;
        case 4:
            DeleteVehicle();
            break;
    }
}

do
{
    int mainChoice = Menu.Display("====== Menu Principal ======", mainOptions);

    switch (mainChoice)
    {
        case 1:
            int customerChoice = Menu.Display("====== Menu Clientes ======", customersOptions);
            CustomerMenu(customerChoice);
            break;
        case 2:
            int vehicleChoice = Menu.Display("====== Menu Veículos ======", vehiclesOptions);
            VehicleMenu(vehicleChoice);
            break;
        case 3:
            int rentalChoice = Menu.Display("====== Menu Locações ======", rentalsOptions);
            break;
        case 4:
            Console.WriteLine("Saindo do programa...");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente!");
            break;
    }    
}
while (true);
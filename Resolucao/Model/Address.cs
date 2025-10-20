namespace Resolucao.Model;

public class Address
{
    private string Street { get; set; }
    private int Number { get; set; }
    private string Neighborhood { get; set; } = String.Empty;
    private string ZipCode { get; set; }
    private string? Complement { get; set; }
    private string City { get; set; }
    private string State { get; set; }
    private string Country { get; set; } = "BR";

    public Address(
        string street,
        int number,
        string neighborhood,
        string zipCode,
        string? complement,
        string city,
        string state,
        string? country
    )
    {
        this.Street = street;
        this.Number = number;
        this.Neighborhood = neighborhood;
        this.ZipCode = zipCode;
        this.Complement = complement;
        this.City = city;
        this.State = state;
        this.Country = country;
    }
    public override string ToString()
    {
        return $"Endereço: {Street}, {Number}\n" +
                $"Bairro: {Neighborhood}\n" +
                $"CEP: {ZipCode}\n" +
                $"Complemento: {Complement}\n" +
                $"Cidade: {City}\n" +
                $"Estado: {State}\n" +
                $"País: {Country}";
    }
}
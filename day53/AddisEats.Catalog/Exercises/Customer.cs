namespace AddisEats.Catalog;

//public record Customer(string Name, string Phone);
public class Customer
{
    public string Name { get; set; }
    public string Phone { get; set; }

    public Customer(string name, string phone)
    {
        Name = name;
        Phone = phone;
    }
}
//Records compare objects by their values by default,
//while classes compare object references by default.
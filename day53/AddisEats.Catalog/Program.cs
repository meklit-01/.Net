using AddisEats.Catalog;
//Exercise 1
DeliveryCalculator calculator = new();

Console.WriteLine(calculator.DeliveryFee("Bole", true));

Console.WriteLine(calculator.DeliveryFee("Saris", isVip: false));

Console.WriteLine(calculator.DeliveryFee("Bole"));
//Exercise 2

DescribeService service = new();

service.Describe(10);
service.Describe("Addis Eats");
service.Describe(250.50m);

//Exercise 3

Restaurant restaurant = new()
{
    Id = 1,
    Name = "Addis",
    Area = "Bole"
};

Console.WriteLine(restaurant.Id);
Console.WriteLine(restaurant.Name);
Console.WriteLine(restaurant.DisplayName);
// Change the name
restaurant.Name = "Bole Burger";

Console.WriteLine(restaurant.DisplayName);
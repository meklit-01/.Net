using AddisEats.Catalog;

DeliveryCalculator calculator = new();

Console.WriteLine(calculator.DeliveryFee("Bole", true));

Console.WriteLine(calculator.DeliveryFee("Saris", isVip: false));

Console.WriteLine(calculator.DeliveryFee("Bole"));
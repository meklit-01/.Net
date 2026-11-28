namespace AddisEats.Catalog;

public class DescribeService
{
    public void Describe(int value)
    {
        Console.WriteLine("Integer was chosen");
    }
    public void Describe(string value)
    {
        Console.WriteLine("String was chosen");
    }
    public void Describe(decimal value)
    {
        Console.WriteLine("Decimal was chosen");
    }
}
namespace AddisEats.Catalog;

public class DeliveryCalculator
{
    public decimal DeliveryFee(string area, bool isVip = false)
    {
        if (isVip)
        {
            return 0;
        }

        return area switch
        {
            "Bole" => 50,
            "Saris" => 80,
            "Kazanchis" => 100,
            _ => 120
        };
    }
}
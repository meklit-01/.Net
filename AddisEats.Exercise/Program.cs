using System.Globalization;
//Exercise 2
Console.WriteLine("Meklit");   
Console.WriteLine(DateTime.Today.ToString("dd MMM yyyy"));
Console.WriteLine("CodeOps Module 4 — .NET track");

//Exercise 3
int orderId = 10482;
long customerPhone = 251911234567L;
short tableNumber = 12;
byte portions = 2;
float rating = 4.5f;
double distanceKm = 3.7;
decimal price = 185.50m;
bool isOpen = true;
char sizeCode = 'L';
string restaurant = "Yod Abyssinia";

Console.WriteLine($"orderId = {orderId} ({orderId.GetType().Name})");
Console.WriteLine($"customerPhone = {customerPhone} ({customerPhone.GetType().Name})");
Console.WriteLine($"tableNumber = {tableNumber} ({tableNumber.GetType().Name})");
Console.WriteLine($"portions = {portions} ({portions.GetType().Name})");
Console.WriteLine($"rating = {rating} ({rating.GetType().Name})");
Console.WriteLine($"distanceKm = {distanceKm} ({distanceKm.GetType().Name})");
Console.WriteLine($"price = {price} ({price.GetType().Name})");
Console.WriteLine($"isOpen = {isOpen} ({isOpen.GetType().Name})");
Console.WriteLine($"sizeCode = {sizeCode} ({sizeCode.GetType().Name})");
Console.WriteLine($"restaurant = {restaurant} ({restaurant.GetType().Name})");
//Exercise 4

decimal subtotal = 1480.5m;
decimal deliveryFee = 60m;
decimal total = subtotal + deliveryFee;

Console.WriteLine($"{"Subtotal:",-14}{subtotal,10:N2}");
Console.WriteLine($"{"Delivery fee:",-14}{deliveryFee,10:N2}");
Console.WriteLine($"{"Total:",-14}{total,10:N2}");
//Exercise 5
Console.WriteLine(7 / 2);          
Console.WriteLine((decimal)7 / 2);

//Exercise 6
int a = 5;
int b = a;
b = 99;
Console.WriteLine($"a = {a}, b = {b}");
List<string> original = new() { "Shiro", "Tibs" };
List<string> copy = original;
copy.Add("Kitfo");
Console.WriteLine($"original = {string.Join(", ", original)}");
Console.WriteLine($"copy     = {string.Join(", ", copy)}");

//Exercise 7
string?[] notes = { null, "extra injera" };

foreach (string? note in notes)
{
    // 1. explicit null check
    int len1 = note != null ? note.Length : 0;

    // 2. ?? supplies a fallback string when note is null
    int len2 = (note ?? "").Length;

    // 3. ?. short-circuits to null; ?? 0 turns that null into a number
    int len3 = note?.Length ?? 0;

    Console.WriteLine($"note = {note ?? "(null)"} -> {len1}, {len2}, {len3}");
}
//Exercise 8
Console.Write("Enter amount in ETB: ");
string? input = Console.ReadLine();

if (!decimal.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal amount))
{
    Console.WriteLine("That is not a number.");
    return;
}

if (amount <= 0)
{
    Console.WriteLine("Amount must be greater than zero.");
    return;
}

Console.WriteLine($"Amount: {amount:N2} ETB");
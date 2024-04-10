using fundamentals.Models;

Person citizen = new Person();

citizen.Name = "Derp";
citizen.Age = 59;
citizen.Presentation();

Console.WriteLine("\n ---------------------------------------- \n");

string salutation = "Hello, you're welcome";
int quantity = 1;
double height = 1.80;
decimal price = 1.80M;

Console.WriteLine($"value of salutation: {salutation}");
Console.WriteLine($"value of quantity: {quantity}");
Console.WriteLine($"value of height: {height.ToString("0.00")}");
Console.WriteLine($"value of price: {price}");

Console.WriteLine("\n ---------------------------------------- \n");

DateTime actualDate = DateTime.Now.AddDays(3);
Console.WriteLine(actualDate);

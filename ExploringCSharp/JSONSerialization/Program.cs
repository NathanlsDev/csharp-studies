using JSONSerialization.Models;
using Newtonsoft.Json;

Sale transaction = new Sale(1, "Office supplies", 25.00M);

string serialized = JsonConvert.SerializeObject(transaction, Formatting.Indented);
Console.WriteLine(serialized);
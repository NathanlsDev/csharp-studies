using JSONSerialization.Models;
using Newtonsoft.Json;

DateTime actualDate = DateTime.Now;

List<Sale> salesList = new List<Sale>();

Sale transaction = new Sale(1, "Office supplies", 25.00M, actualDate);
Sale transaction2 = new Sale(2, "Software License", 110.00M, actualDate);

salesList.Add(transaction);
salesList.Add(transaction2);

string serialized = JsonConvert.SerializeObject(salesList, Formatting.Indented);

File.WriteAllText("archives/sales.json", serialized);

Console.WriteLine(serialized);
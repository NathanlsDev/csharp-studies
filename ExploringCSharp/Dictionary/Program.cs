Dictionary<string, string> states = new Dictionary<string, string>();

states.Add("SP", "São Paulo");
states.Add("BA", "Bahia");
states.Add("MG", "Minas Gerais");

foreach (KeyValuePair<string, string> item in states)
{
  Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
}

// states.Add("SP", "Alagoas");

states["MG"] = "Minas Gerais - altered";

states.Remove("BA");

Console.WriteLine("\n------------\n");

string key = "AC";
Console.WriteLine($"Checking the element: {key}");

if(states.ContainsKey(key))
{
  Console.WriteLine($"Existing values:");
} else 
{
  Console.WriteLine($"Value does not exist, it is safe to add the key: {key}\n");
  states.Add($"{key}", "Acre");
}

foreach (KeyValuePair<string, string> item in states)
{
  Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
}

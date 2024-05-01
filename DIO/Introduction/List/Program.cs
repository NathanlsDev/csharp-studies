List<string> listString = new List<string>();

listString.Add("SP");
listString.Add("BH");
listString.Add("MG");
listString.Add("RJ");

Console.WriteLine($"Items in my list: {listString.Count} - List capacity: {listString.Capacity}");

listString.Add("SC");
Console.WriteLine($"Items in my list: {listString.Count} - List capacity: {listString.Capacity}");

listString.Remove("MG");
Console.WriteLine($"Items in my list: {listString.Count} - List capacity: {listString.Capacity}");


// Console.WriteLine("\nfor loop:");
// for (int i = 0; i < listString.Count; i++){
//   Console.WriteLine($"index: {i} - value: {listString[i]}");
// }

// Console.WriteLine("\nforeach:");
// foreach (string str in listString) { 
//   Console.WriteLine(str);
// }
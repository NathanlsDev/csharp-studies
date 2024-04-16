using Tuple.Models;

ReadArchive archive = new ReadArchive();

var (success, lines, totalLines) = archive.ReadingArchive("./archive/WickedGame.txt");

if (success)
{
  Console.WriteLine($"Total file lines: {totalLines}\n");
  foreach(string line in lines)
  {
    Console.WriteLine(line);
  }
} else 
{
  Console.WriteLine("It was not possible to read the file.");
}








// (int, string, string, decimal) tuple = (1, "Derp", "Derpson", 1.63M);

// ValueTuple<int, string, string, decimal> tuple2 = (1, "Derp", "Derpson", 1.63M);

// var tuple3 = tuple2.Create(1, "Derp", "Derpson", 1.63M);

// Console.WriteLine($"Id: {tuple.Item1}");
// Console.WriteLine($"Name: {tuple.Item2}");
// Console.WriteLine($"Last Name: {tuple.Item3}");
// Console.WriteLine($"Height: {tuple.Item4}");
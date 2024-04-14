try
{
  string[] lines = File.ReadAllLines("./KnightsOfCydoni458a.txt");

  foreach (string line in lines)
  {
    Console.WriteLine(line);
  }
} catch(Exception except)
{
  Console.WriteLine($"A generic exception occurred: {except.Message}");
}

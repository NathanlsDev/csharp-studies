try
  {
    string[] lines = File.ReadAllLines("./KnightsOfCydoni458a.txt"); //wrong path

    foreach (string line in lines)
    {
      Console.WriteLine(line);
    }
  }
catch(FileNotFoundException except)
  {
    Console.WriteLine($"An error occurred in the reading of the file. File not found: {except.Message}");
  }
catch(DirectoryNotFoundException except)
  {
    Console.WriteLine($"An error occurred in the reading of the file. Folder path not found: {except.Message}");
  }
catch(Exception except)
  {
    Console.WriteLine($"A generic exception occurred: {except.Message}");
  }
finally
  {
    Console.WriteLine("Default output.");
  }

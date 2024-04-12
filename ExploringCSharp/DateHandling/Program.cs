using System.Globalization;

string stringDate = "2025-13-09 18:00";

// DateTime date = DateTime.Now;
// DateTime date = DateTime.Parse(stringDate);

bool success = DateTime
  .TryParseExact
  (
    stringDate, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture,
    DateTimeStyles.None, out DateTime date
  );

  if (success)
  {
    Console.WriteLine($"Success converted date: {date}");
  }
  else 
  {
    Console.WriteLine($"${stringDate} isn't a valid date!");
  }

// Console.WriteLine(date.ToString("dd/MM/yyyy HH:mm"));
// Console.WriteLine(date.ToShortDateString());
// Console.WriteLine(date.ToShortTimeString());
// Console.WriteLine(date);

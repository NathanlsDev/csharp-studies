using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

Console.WriteLine(monetaryValue.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
decimal monetaryValue = 1582.25M;

Console.WriteLine(percentage.ToString("P"));
double percentage = .3421;

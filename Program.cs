

using RiskDev.Models;
using RiskDev.Services;



var service = new RiskCategorizationService();

DateTime database = new DateTime(2020, 12, 11);

Console.WriteLine(Enum.GetName(service.Evaluate(new Trade(2000000, "Private", new DateTime(2025, 12, 29)), database)));
Console.WriteLine(Enum.GetName(service.Evaluate(new Trade(400000, "public", new DateTime(2020, 7, 01)), database)));
Console.WriteLine(Enum.GetName(service.Evaluate(new Trade(5000000, "public", new DateTime(2024, 1, 2)), database)));
Console.WriteLine(Enum.GetName(service.Evaluate(new Trade(3000000, "public", new DateTime(2023, 10, 26)), database)));




//new Start().Run();






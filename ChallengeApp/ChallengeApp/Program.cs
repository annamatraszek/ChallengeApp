using ChallengeApp;

var employee = new Employee("Adam", "Kowalski");
employee.AddGrade(40);
employee.AddGrade(6);
employee.AddGrade(4.56);
employee.AddGrade("30");
employee.AddGrade(3.5f);


var statistics = employee.GetStatisticsWithForeEach();

Console.WriteLine( employee.Name + " " + employee.Surname);
Console.WriteLine(" ... GetStatisticsWithForeEach");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}");

var statistics2 = employee.GetStatisticsWithFor();

Console.WriteLine(" ... GetStatisticsWithFor");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}");

var statistics3 = employee.GetStatisticsWithDoWhile();

Console.WriteLine(" ... GetStatisticsWithDoWhile");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N3}");

var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine(" ... GetStatisticsWithWhile");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N1}");

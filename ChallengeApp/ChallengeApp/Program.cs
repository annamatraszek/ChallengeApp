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
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine($"Average: {statistics2.Average:N2}");

var statistics3 = employee.GetStatisticsWithDoWhile();

Console.WriteLine(" ... GetStatisticsWithDoWhile");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine($"Average: {statistics3.Average:N3}");

var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine(" ... GetStatisticsWithWhile");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");
Console.WriteLine($"Average: {statistics4.Average:N1}");

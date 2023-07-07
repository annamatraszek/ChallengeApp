using ChallengeApp;

var employee = new Employee("Adam", "Kowalski");
employee.AddGrade(40);
employee.AddGrade(6);
employee.AddGrade(4.56);
employee.AddGrade("30");
employee.AddGrade(3.5f);


var statistics = employee.GetStatistics();

Console.WriteLine( employee.Name + " " + employee.Surname);
Console.WriteLine(" ... GetStatisticsWithForeEach");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}");


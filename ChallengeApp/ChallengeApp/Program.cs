using ChallengeApp;

var employee = new Employee("Adam", "Kowalski");
employee.AddGrade(4033333);
employee.AddGrade(6);
employee.AddGrade(4.56);
employee.AddGrade("30");
employee.AddGrade(3.5f);


var statistics = employee.GetStatistics();

Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}");

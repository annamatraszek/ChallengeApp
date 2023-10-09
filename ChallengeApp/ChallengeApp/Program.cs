using ChallengeApp;

Console.WriteLine("Witamy w Programie XYZ do oceny pracowników");
Console.WriteLine("===============================================");
Console.WriteLine();

var employee = new EmployeeInMemory("Adam", "Nowak");
employee.GradeAdded += EmployeeGradeAdded;

static void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("dodano nową ocenę");
}
//employee.AddGrade(50f);

while (true)
{
    Console.WriteLine("podaj ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"exception catched: {e.Message}");
    }
}

var statistics = ((EmployeeInMemory)employee).GetStatistics();
{
    Console.WriteLine("---------------------");
    Console.WriteLine();
    Console.WriteLine(employee.Name + " " + employee.Surname);
    Console.WriteLine();
    Console.WriteLine("Statystyki:");
    Console.WriteLine($"Min: {statistics.Min}");
    Console.WriteLine($"Max: {statistics.Max}");
    Console.WriteLine($"Average: {statistics.Average:N2}");
    Console.WriteLine();
    Console.WriteLine($"Ocena:{statistics.AverageLetter}");
}
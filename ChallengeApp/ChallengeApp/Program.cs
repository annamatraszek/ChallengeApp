using ChallengeApp;

Console.WriteLine("Witamy w Programie XYZ do oceny pracowników");
Console.WriteLine("===============================================");
Console.WriteLine();

var employee = new Employee("Apolonia" , "Nowak");

while(true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if(input == "q") 
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();
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


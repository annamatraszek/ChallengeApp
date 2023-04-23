using ChallengeApp;

Employee employee1 = new Employee("Adam", "Kowalski", "30");
Employee employee2 = new Employee("Ewa", "Kowalska", "25");
Employee employee3 = new Employee("Anna", "Kowalska", "28");

employee1.AddScore(6);
employee1.AddScore(2);
employee1.AddScore(10);
employee1.AddScore(3);
employee1.AddScore(0);

employee2.AddScore(10);
employee2.AddScore(10);
employee2.AddScore(8);
employee2.AddScore(10);
employee2.AddScore(6);

employee3.AddScore(5);
employee3.AddScore(1);
employee3.AddScore(2);
employee3.AddScore(8);
employee3.AddScore(3);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee1.Result > maxResult)
    {
        employeeWithMaxResult = employee1;
        maxResult = employee1.Result;
    }
    else if (employee2.Result > maxResult)
    {
        employeeWithMaxResult = employee2;
        maxResult = employee2.Result;
    }
    else if (employee3.Result > maxResult)
    {
        employeeWithMaxResult = employee3;
        maxResult = employee3.Result;
    }

}

Console.WriteLine(employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " lat " + employeeWithMaxResult.Age );
Console.WriteLine("Największy wynik: " + maxResult);

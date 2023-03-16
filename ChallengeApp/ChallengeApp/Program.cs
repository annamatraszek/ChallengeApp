// Napisz Program.cs 
// - zmienna z imieniem 
// - zmienna z płcią
// - zmienna z wiekiem
// - zweryfikować dane i wyświetlić
// - jeden z komunikatów:
// (1) "Kobieta poniżej 30 lat"
// (2) "Ewa , lat 30"
// (3) "Niepełnoletni mężczyzna" 


string myName = "Anna";
var plec = "Kobieta";
int myAge = 25;
string txt1 = "Kobieta poniżej 30 lat";
string txt2 = "Kobieta powyżej 30 lat";
string txt3 = "Niepełnoletni mężczyzna";


if (plec == "Kobieta")
{
    if (myAge < 30)
    {
        Console.WriteLine(txt1);
        Console.WriteLine(myName + ", lat " + myAge);
    }
    else if (myAge >= 30)
    {
        Console.WriteLine(txt2);
        Console.WriteLine(myName + ", lat " + myAge);
    }
}
else
{
    Console.WriteLine(txt3);
}


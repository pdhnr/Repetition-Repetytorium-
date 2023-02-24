//Linq on ex: https://e.wsei.edu.pl/mod/quiz/attempt.php?attempt=95558&cmid=19205&page=2



var split = Console.ReadLine().Split(' ');


//suranme - nazwisko
string surname = split[0];


//age of the person - wiek osoby
int age_of_the_person = int.Parse(split[1]);


//retirement age - wiek emerytalny
int retirement_age = int.Parse(split[2]);

////////////////////////////////////////////////

if(age_of_the_person < 0 || retirement_age < 0)
{
    Console.WriteLine("Wiek nie może być ujemny!");
}
else if(age_of_the_person < retirement_age)
{

    int x = retirement_age - age_of_the_person;


    if (x % 10 == 1)
        Console.WriteLine($"Witaj {surname}! Do emerytury brakuje Ci {x} rok!");
    else if (x % 10 >= 2 && x % 10 <= 4)
        Console.WriteLine($"Witaj {surname}! Do emerytury brakuje Ci {x} lata!");
    else
        Console.WriteLine($"Witaj {surname}! Do emerytury brakuje Ci {x} lat!");
}
else
    Console.WriteLine($"Witaj emerycie {surname}!");

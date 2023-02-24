//Linq on ex:https://e.wsei.edu.pl/mod/quiz/attempt.php?attempt=95558&cmid=19205&page=1


//suranme - nazwisko
string suranme = Console.ReadLine();

/********************************************************/

//age of the person - wiek osoby
string age_of_the_person = Console.ReadLine();
Int32.TryParse(age_of_the_person, out int aP);

/********************************************************/

//retirement age - wiek emerytalny
string retirement_age = Console.ReadLine();
Int32.TryParse(retirement_age, out int aR);

/////////////////////////////////////////////////////////////////////////////


Console.WriteLine($"Witaj, {suranme}!");

if(aP < 0 || aR < 0)
{
    Console.WriteLine("Wiek nie może być ujemny!");
}
else if(aR > aP)
{
    int formula = aR - aP;

    if(formula % 10 == 1)
        Console.WriteLine($"Do emerytury brakuje Ci {formula} rok!");
    else if(formula % 10 >= 2 && formula % 10 <= 4)
        Console.WriteLine($"Do emerytury brakuje Ci {formula} lata!");
    else
        Console.WriteLine($"Do emerytury brakuje Ci {formula} lat!");
}
else if(aP >= aR )
{
    Console.WriteLine("Jesteś emerytem!");
}


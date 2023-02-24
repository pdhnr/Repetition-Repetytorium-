//Linq on ex:https://e.wsei.edu.pl/mod/quiz/attempt.php?attempt=95558&cmid=19205&scrollpos=1272.727294921875




//Suranme - nazwisko
string Surname = Console.ReadLine();

/********************************************************/

//age of the person - wiek osoby
string age_of_the_person = Console.ReadLine();

Int32.TryParse(age_of_the_person, out int aP);


/********************************************************/

//retirement age - wiek emerytalny
string retirement_age = Console.ReadLine();
Int32.TryParse(retirement_age, out int aR);

/////////////////////////////////////////////////////////////////////////////

Console.WriteLine($"Hello, {Surname}!");//Console.WriteLine($"Witaj, {Surname}!");

if (aP < 0 ||  aR < 0 )
{
    Console.WriteLine("Age cannot be negative!");//Console.WriteLine("Wiek nie może być ujemny!"); 
}
else if(aR > aP)
{
    int x = aR - aP;
    Console.WriteLine($"You are {x} years away from retirement!");//Console.WriteLine($"Do emerytury brakuje Ci {x} lat!");
}
else if(aP >= aR)
{
    Console.WriteLine("You are a pensioner!");//Console.WriteLine("Jesteś emerytem!");
}






using System.Globalization;

//Linq on ex: https://e.wsei.edu.pl/mod/quiz/attempt.php?attempt=119751&cmid=19204

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US"); // Zeby była kropka(.) zamiast przecinka(,) 

var split = Console.ReadLine().Split("; ");

Double.TryParse(split[0], out double a);
Double.TryParse(split[1], out double b);
Double.TryParse(split[2], out double c);

if (a < 0 || b < 0 || c < 0)
    Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!");
else if (a + b < c || b + c < a || a + c < b)
    Console.WriteLine("Błędne dane. Trójkąta nie można zbudować!");
else
{
    double obwód = a + b + c; //Obwód - Периметр/Область/Окружність
    Console.WriteLine("obwód = {0:N2}", obwód); //{0:N2} - Zeby była kropka(.) zamiast przecinka(,) . Pracuje z funkc. "en-US"


    /***************************************/

    double P = (a + b + c) / 2; //%

    double pole = Math.Sqrt(P * (P - a) * (P - b) * (P - c)); //Pole - Площина/Поле  //Math.Sqrt(...); - Корінь
    Console.WriteLine("pole = {0:N2}", pole);

    /***************************************/

    double kątA = Math.Pow(a, 2); //Math.Pow(... , 2) - в степенні 2/або в кдвадраті

    double kątB = Math.Pow(b, 2);

    double kątC = Math.Pow(c, 2);

    /***************************************/

    if (kątC < kątA + kątB)
    {
        Console.WriteLine("trójkąt jest ostrokątny");
    }
    else if (kątC == kątA + kątB)
    {
        Console.WriteLine("trójkąt jest prostokątny");
    }
    else if (kątC > kątA + kątB)
    {
        Console.WriteLine("trójkąt jest rozwartokątny");
    }

    /***************************************/

    if (a == b && b == c && c == a)
    {
        Console.WriteLine("trójkąt równoboczny");
    }
    else if (a == b || b == c || a == c)
    {
        Console.WriteLine("trójkąt równoramienny");
    }
}






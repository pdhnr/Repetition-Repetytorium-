
using System.Globalization;

class Program
{
    //Linq on ex: https://e.wsei.edu.pl/mod/quiz/attempt.php?attempt=95752&cmid=19235


    static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

        Int32.TryParse(Console.ReadLine(), out int a);
        Int32.TryParse(Console.ReadLine(), out int b);
        Int32.TryParse(Console.ReadLine(), out int c);

        QuadraticEquation(a, b, c);
    }


    public static void QuadraticEquation(int a, int b, int c)
    {
        double D = Math.Pow(b, 2) - 4 * a * c;


        if (a == 0 && b == 0 && c == 0)
        {
            Console.WriteLine("infinity");
        }
        else if (D < 0)
        {
            Console.WriteLine("empty");
        }
        else if (Math.Round(D) > 0)
        {
            double x1 = (-b - Math.Sqrt(D)) / 2 * a;
            double x2 = (-b + Math.Sqrt(D)) / 2 * a;
            Console.WriteLine("x1={0:N2}", x1);
            Console.WriteLine("x2={0:N2}", x2);
        }
        else if (Math.Round(D) == 0)
        {
            double x = (-b + Math.Sqrt(Math.Round(D))) / 2 * a;
            Console.WriteLine("x={0:N2}", x);
        }

    }
}


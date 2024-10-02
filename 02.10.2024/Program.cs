using System;

public class ok
{
    public static void Main(string[] args)
    {
        Console.WriteLine("zadanie 1");

        Console.WriteLine("podaj liczbe na osi x");
        int x = 
            Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("podaj liczbe na osi y");
        int y =
            Convert.ToInt32(Console.ReadLine());
        if (x > 0 && y > 0)
        {
            Console.WriteLine("jest to ćwiartka 1");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("jest to ćwiartka 2");
        }
        else if(x < 0 && y < 0)
        {
            Console.WriteLine("jest to ćwiartka 3");
        }
        else if(x > 0 && y < 0)
        {
            Console.WriteLine("jest to ćwiartka 4");
        }
        else if(y == 0 && x == 0)
        {
            Console.WriteLine("liczby nie wystepuja w żadnej ćwiartce");
        }

        Console.WriteLine("zadanie 2");

        Console.WriteLine("podaj pierwszy bok trojkata: ");
        int a =
            Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("podaj drugi bok trojkata: ");
        int b =
            Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("podaj podstawe trojkata: ");
        int c =
            Convert.ToInt32(Console.ReadLine());
        if (a < b + c && b < a + c && c < a + b)
        {
            Console.WriteLine("pole to: ");
            Console.WriteLine(0.25 * (Math.Sqrt(4 * a * a * b * b - (a * a + b * b - c * c) * (a * a + b * b - c * c))));
        }
        else if (a + b < c)
        {
            Console.WriteLine("nie mozna utworzyc takiego trojkata ");
        }
        Console.WriteLine("obwod to: ");
        Console.WriteLine(a + b + c);

        Console.WriteLine("zadanie 4");
        Console.WriteLine("podaj 1 liczbe: ");
        var v = 
            Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("podaj 2 liczbe: ");
        var o =
            Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("wybierz operacje jaką chcesz wykonać");

        
    }
    
}

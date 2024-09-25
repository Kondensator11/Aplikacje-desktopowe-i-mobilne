using System;

public class jd
{
    public static void Main(string[] args)
    {
        Console.WriteLine("zad1");
        Console.WriteLine("Witaj Świecie");

        Console.WriteLine("zad2");
        string imie = Console.ReadLine();
        Console.Write("cześć ");
        Console.WriteLine(imie);

        Console.WriteLine("zad3");
        string liczba1 = Console.ReadLine();
        string liczba2 = Console.ReadLine();
        var liczba5 = Convert.ToDouble(liczba1);
        var liczba6 = Convert.ToDouble(liczba2);

        var liczba3 = Convert.ToInt32(liczba5);
        var liczba4 = Convert.ToInt32(liczba6);
        Console.WriteLine(liczba3 + liczba4);

        Console.WriteLine("zad4");
        var promien = Console.ReadLine();
        var promien2 = Convert.ToDouble(promien);
        Console.WriteLine(3.14*(promien2 * promien2));

        Console.WriteLine("zad5");
        var temp = Console.ReadLine();
        var temp2 = Convert.ToDouble(temp);
        Console.WriteLine((temp2 * 9/5) + 32);

        Console.WriteLine("zad6");
        int a = int.Parse(Console.ReadLine());
        string b = Convert.ToString(a);
        Console.WriteLine(b);

        Console.WriteLine("zad7");
        double liczba7 = int.Parse(Console.ReadLine());
        double liczba8 = int.Parse(Console.ReadLine());
        Console.WriteLine((liczba7+liczba8)/2);

        Console.WriteLine("zad8");
        double liczba9 = int.Parse(Console.ReadLine());
        double liczba10 = Convert.ToDouble(liczba9);
        Console.WriteLine(liczba9 * liczba9);

        Console.WriteLine("zad9");
        double liczba11 = double.Parse(Console.ReadLine());
        int liczba12 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(liczba12);
       






    }
}


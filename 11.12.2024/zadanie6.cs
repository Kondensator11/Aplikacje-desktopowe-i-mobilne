using System;

public class program
{
    public static int a = 55;
    public static int b = 55;
    public static void Main(string[] args)
    {
        Console.WriteLine("zadanie 6");

        if(a>b)
        {
            Console.WriteLine("wieksza jest " + a);
        }
        else if(a<b)
        {
            Console.WriteLine("wieksza jest " + b);
        }
        else if(a==b)
        {
            Console.WriteLine("obie sa rowne");
        }
    }
}

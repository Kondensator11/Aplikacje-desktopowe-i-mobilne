using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("zadanie4");

        int i = Convert.ToInt32(Console.ReadLine());
        int x = 0;

        while (i >= 1)
        {
            for (x = 1; x < i; x++)
            {
                Console.Write("*");
            }
            i--;
            Console.WriteLine("*");
        }
    }
}
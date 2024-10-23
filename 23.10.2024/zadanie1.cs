using System;
public class zadanie1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("zadanie 1");

        int y = 1;
        Console.WriteLine("podaj liczbe n: ");
        int n =
        Convert.ToInt32(Console.ReadLine());
        while (y <= n)
        {
            if (y % 2 == 1)
            {
                Console.WriteLine(y + " ");
            }
            y++;
        }
        










    }
}

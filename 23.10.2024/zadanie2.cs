using System;

public class program


{
    public static void Main(string[] args)
    {
        Console.WriteLine("zadanie 2");

        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        while (x <= y)
        {
            Console.Write(x + " ");
            x++;
            Console.WriteLine((x * 9/5) + 32);
        }
    }
}

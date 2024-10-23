using System;
public class Program
{
    
    public static void Main(string[] args)
    {
        Console.WriteLine("zadanie 5");
        
        double y = 0;
        while (true)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            if (x == 0)
            {
                break;
            }
            else
            {
                {
                    y += x;
                }
            }
            Console.WriteLine("Ilosc liczb: " + (y));
        }
    }
}
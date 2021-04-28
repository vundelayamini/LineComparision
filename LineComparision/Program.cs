using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision");//Welcome message
            int x1, x2, y1, y2;                         //Take inputs from the user
            Console.WriteLine("Pass The values x1 & y1");
            x1 = Convert.ToInt32(Console.ReadLine());    //Convert x1 value to integer
            y1 = Convert.ToInt32(Console.ReadLine());     //Convert y1 value to integer
            Console.WriteLine("Pass The values of x2 & y2");
            x2 = Convert.ToInt32(Console.ReadLine());    //Convert x2 value to integer
            y2 = Convert.ToInt32(Console.ReadLine());     //Convert y2 value to integer
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)) // Calculate LenghthofLine using Math.Sqrt formula
            Console.WriteLine("The length of the Line is = " + length);
        }
    }
}

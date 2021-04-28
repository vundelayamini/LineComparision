using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision");//Welcome message
            int x1, x2, y1, y2, x3, y3, x4, y4;                         //Take inputs from the user
            Console.WriteLine("Pass The values x1 & y1");
            x1 = Convert.ToInt32(Console.ReadLine());    //Convert x1 value to integer
            y1 = Convert.ToInt32(Console.ReadLine());     //Convert y1 value to integer
            Console.WriteLine("Pass The values of x2 & y2");
            x2 = Convert.ToInt32(Console.ReadLine());    //Convert x2 value to integer
            y2 = Convert.ToInt32(Console.ReadLine());     //Convert y2 value to integer
            Console.WriteLine("Pass The values x3 & y3 for Second Line");//pass the values for x3,y3 values for second line
            x3 = Convert.ToInt32(Console.ReadLine());      //Convert x3 value to integer
            y3 = Convert.ToInt32(Console.ReadLine());       //Convert y3 value to intger
            Console.WriteLine("Pass The values x4 & y4 for Second Line");//pass the values x4,y4 values for second line
            x4 = Convert.ToInt32(Console.ReadLine());       //Convert x4 value to integer
            y4 = Convert.ToInt32(Console.ReadLine());       //Convert y4 value to integer
            double length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));//Calculate length1 using math.sqrt formula
            double length2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));//Calculate length2 using math.sqrt formula
            if (length1 == length2)
                Console.WriteLine("Two Lines are equal in length");  //Check Two lines are equal or not
            else
                Console.WriteLine("Two Lines are not equal in length");

           
        }
        
    }
}

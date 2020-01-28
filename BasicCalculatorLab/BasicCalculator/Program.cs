using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC CALCULATOR ***");

            Console.WriteLine("Enter the temperature in degrees Fahrenheit");

            // int.Parse will take a string data type and convert it to an int data type
            int dF = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the relative humidity");
            int rh = int.Parse(Console.ReadLine());

            int dP = dF-9*(100-rh)/25;

            Console.WriteLine("The dew point is " + dP);
            
            Console.WriteLine("Enter the windspeed");
            int ws = int.Parse(Console.ReadLine());


            double wc = 35.74 
                + 0.6215 * dF 
                - 35.75 * Math.Pow(ws, 0.16) 
                + 0.4275*dF * Math.Pow(ws, 0.16);
            Console.WriteLine("The wind chill is " + wc);
        }
    }
}

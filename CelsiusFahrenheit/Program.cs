using System;

namespace CelsiusFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            Console.WriteLine("Enter air temperature in Celsius");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("In Fahrenheit = " + Converting(temp));
            Console.ReadKey();

            Console.WriteLine("Enter air temperature in Fahrenheit");
            double temp1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine( "In Celsius = " + ConvertingInF(temp1));
            Console.ReadKey();

        }

       public static double Converting(double temp)
        {


            double result = (temp * 9 / 5) + 32;
            return result;
        }

       public  static double ConvertingInF(double temp1)
        {
            double result = (temp1 - 32) * 5 / 9;
            return result;
        }




    }
}
  

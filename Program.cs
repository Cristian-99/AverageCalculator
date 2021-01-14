using System;

namespace Avergae
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1;
            Console.WriteLine("Input a number");
           num1 = Convert.ToInt32 (Console.ReadLine() );

            int num2;
            Console.WriteLine("Input a number");
            num2 = Convert.ToInt32 (Console.ReadLine() );

            int num3;
            Console.WriteLine("Input a number");
           num3 = Convert.ToInt32 (Console.ReadLine() );


            int result = (num1 + num2 + num3) / 3;
            Console.WriteLine("The average is " + result);




        }
    }
}

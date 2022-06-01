using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            int x = 17;
            int y = 4;

            int add = x+y;
            int subtract = x-y;
            int multiply = x*y;
            int divide = x/y;
            int mod = x%y;

            Console.WriteLine("{0} + {1} = {2}", x, y, add);//add
            Console.WriteLine("{0} - {1} = {2}", x, y, subtract);//subtract
            Console.WriteLine("{0} * {1} = {2}", x, y, multiply);//multiply
            Console.WriteLine("{0} / {1} = {2} remainder {3}", x, y, divide, mod);//divide

            //Exercise 2
            

            Console.WriteLine("What is the radious of your circle?");
            var radious = Convert.ToDouble(Console.ReadLine());


            double area = (Math.PI * Math.Pow(radious, 2));
            Console.WriteLine("The area of the radious is {0}", area);
        }
    }
}

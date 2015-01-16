using System;
    class Program
    {
        static void Main(string[] args)
        {
            //ite a program that safely compares floating-point numbers (double) with precision eps = 0.000001
            double a = 5.3;
            double b = 6.01;
            Console.WriteLine("{0} and {1} are equal: " + (Math.Abs(a - b) < 0.000001), a , b);
            a = 5.00000001;
            b = 5.00000003;
            Console.WriteLine("{0} and {1} are equal: " + (Math.Abs(a - b) < 0.000001), a , b);
            a = -0.0000007;
            b = 0.00000007;
            Console.WriteLine("{0} and {1} are equal: " + (Math.Abs(a - b) < 0.000001), a, b);
            a = -4.999999;
            b = -4.999998;
            Console.WriteLine("{0} and {1} are equal: " + (Math.Abs(a - b) < 0.000001), a, b);
            a = 4.999999;
            b = 4.999998;
            Console.WriteLine("{0} and {1} are equal: " + (Math.Abs(a - b) < 0.000001), a, b);
        }
    }

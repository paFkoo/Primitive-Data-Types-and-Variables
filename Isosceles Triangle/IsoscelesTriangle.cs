using System;
using System.Text;
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            //Write a program that prints an isosceles triangle of 9 copyright symbols ©
            char copyright = '\u00a9';
            Console.WriteLine("    " + copyright + "\n   " + copyright + " " + copyright + "\n  " + copyright + 
                "   " + copyright + "\n " + copyright + " " + copyright + " " + copyright + " " + copyright);
        }
    }
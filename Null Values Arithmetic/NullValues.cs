using System;
    class NullValues
    {
        static void Main(string[] args)
        {
            /*Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.*/
            int? nullableInt = null;
            double? nullableDouble = null;
            Console.WriteLine("Integer with null value: " + nullableInt);
            Console.WriteLine("Double with null value: " + nullableDouble);
            nullableInt = 500;
            nullableDouble = 65.23;
            Console.WriteLine("Integer with new value: " + nullableInt);
            Console.WriteLine("Double with new value: " + nullableDouble);
        }
    }

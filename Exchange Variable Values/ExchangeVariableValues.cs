using System;
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            /*Declare two integer variables a and b and assign them with 5 and 10 and after that 
             * exchange their values by using some programming logic.
                Print the variable values before and after the exchange.*/
            int a = 5;
            int b = 10;
            Console.WriteLine("Before exchange a = {0}", a);
            Console.WriteLine("Before exchange b = {0}" ,b);
            a = 10;
            b = 5;
            Console.WriteLine("After exchange a = {0}" , a);
            Console.WriteLine("After exchange b = {0}" , b);
        }
    }

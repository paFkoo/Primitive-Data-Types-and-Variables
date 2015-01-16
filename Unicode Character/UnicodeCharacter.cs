using System;
    class UnicodeCharacter
    {
        static void Main(string[] args)
        {
            /*Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) 
            using the \u00XX syntax, and then print it.*/
            int number = 0x2a;
            char symbol = (char)number;
            Console.WriteLine(symbol);
        }
    }

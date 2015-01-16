using System;
    class DeclareVariables
    {
        static void Main(string[] args)
        /*Declare five variables choosing for each of them the most appropriate of the types byte, sbyte,
         * short, ushort, int, uint, long, ulong to represent the following values: 52130, 
         * -115, 4825932, 97, -10000.*/
        {
            ushort firstVariable = 52130;
            sbyte secondVariable = -115;
            uint thirdVariable = 4825932;
            byte fourthVariable = 97;
            short fifthVariable = -10000;
            Console.WriteLine("ushort: " + firstVariable + "\nsbyte:" + secondVariable + 
                                "\nuint:" + thirdVariable + "\nbyte:" + fourthVariable + 
                                "\nshort:" + fifthVariable);
        }
    }

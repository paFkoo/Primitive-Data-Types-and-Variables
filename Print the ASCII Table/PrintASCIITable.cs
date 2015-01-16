using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Find online more information about ASCII (American Standard Code for 
             * Information Interchange) and write a program that prints the entire ASCII table 
             * of characters on the console (characters from 0 to 255).*/
            int asci = 0;
            Console.WriteLine((char)asci);
            { 
                for( asci = 0; asci < 256; asci++)
                    Console.WriteLine("Normal character - {0} , ASCII character - {1}" ,(int)asci , (char)asci);
            }
        }
    }
}

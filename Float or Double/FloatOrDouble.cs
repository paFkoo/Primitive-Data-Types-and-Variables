using System;
    class FloatOrDouble
    {
        static void Main(string[] args)
        {
            /*Which of the following values can be assigned to a variable of type float and which to a variable 
            of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?*/
            double fPn1 = 34.567839023;
            float fPn2 = 12.345f;
            double fPn3 = 8923.1234857;
            float fPn4 = 3456.091f;
            Console.WriteLine("double:" + fPn1+ "\nfloat:" +fPn2 + "\ndouble:" + fPn3 + "\nfloat:" + fPn4);
        }
    }

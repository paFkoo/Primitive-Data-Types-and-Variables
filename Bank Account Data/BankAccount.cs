using System;
    class BankAccount
    {
        static void Main(string[] args)
        {
            /*A bank account has a holder name (first name, middle name and last name), available amount of 
             * money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
               Declare the variables needed to keep the information for a single bank account using the appropriate 
             * data types and descriptive names.*/
            string firstName = "Mnogo";
            string secondName = " Bogat";
            string lastName = " Chichko";
            Console.WriteLine("Holder name: " + firstName + secondName + lastName);
            ulong balance = ulong.MaxValue;
            Console.WriteLine("Balance: " + balance);
            string bankName = "Fat Uncle Bank";
            Console.WriteLine("Bank name: " + bankName);
            object iban = "BG29RZBB91551002040299";
            Console.WriteLine("IBAN: " + iban);
            ulong creditCard1 = 1234567890111213;
            Console.WriteLine("Credit card number: " + creditCard1);
            ulong creditCard2 = 3121110987654321;
            Console.WriteLine("Credit card number: " + creditCard2);
            ulong creditCard3 = 09876543211234567;
            Console.WriteLine("Credit card number: " + creditCard3);
        }
    }

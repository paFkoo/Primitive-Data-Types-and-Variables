using System;
    class EmployeeData
    {
        static void Main(string[] args)
        {
         /*A marketing company wants to keep record of its employees. Each record would have the following characteristics:

            First name
            Last name
            Age (0...100)
            Gender (m or f)
            Personal ID number (e.g. 8306112507)
            Unique employee number (27560000…27569999)*/
            string firstName = "Misho";
            Console.WriteLine("First name: " + firstName);
            string lastName = "Peshov";
            Console.WriteLine("Last name: " + lastName);
            byte age = 37;
            Console.WriteLine("Age: " + age);
            char gender = 'm';
            Console.WriteLine("Gender: " + gender);
            ulong idNumber = 8306112507;
            Console.WriteLine("ID number: " + idNumber);
            uint employeeNumber = 27563456;
            Console.WriteLine("Employee number: " + employeeNumber);

        }
    }

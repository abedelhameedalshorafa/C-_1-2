using System;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
          {

            ///// 1 /////
            
            Console.Write("Enter a string: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("You entered: " + userInput);


            ///// 2 /////
            
            double doubleVariable = 3.14;
            string stringVariable = "Hello World!";
            char charVariable = 'L';
            bool boolVariable = true;
            int intVariable = 42;
            const int constantVariable = 100; 

            Console.WriteLine("Double Variable: " + doubleVariable);
            Console.WriteLine("String Variable: " + stringVariable);
            Console.WriteLine("Char Variable: " + charVariable);
            Console.WriteLine("Bool Variable: " + boolVariable);
            Console.WriteLine("Int Variable: " + intVariable);
            Console.WriteLine("Constant Variable: " + constantVariable);


            ///// 3 /////

            string[] cars = { "Toyota", "Honda", "Ford"};
            Console.WriteLine("List of Cars:");
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine("Number of Cars: " + cars.Length);


            ///// 4 /////

            string firstName, lastName;
            int yearOfBirth;

            Console.Write("Input your firstname: ");
            firstName = Console.ReadLine();

            Console.Write("Input your lastname: ");
            lastName = Console.ReadLine();

            Console.Write("Input your year of birth: ");
            
            while (!int.TryParse(Console.ReadLine(), out yearOfBirth))
            {
                Console.WriteLine("Invalid input. Please enter a valid year of birth.");
                Console.Write("Input your year of birth: ");
            }

            Console.WriteLine($"{firstName} {lastName} {yearOfBirth}");

            ///// 5 /////

            int[] elements = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter element - {i}: ");

                while (!int.TryParse(Console.ReadLine(), out elements[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.Write($"Enter element - {i}: ");
                }
            }

            Console.Write("Elements in array are: ");
            foreach (int element in elements)
            {
                Console.Write(element + " ");
            }


            ///// 6 /////

            int[] numbers = { 1, 2, 3, 4 };
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter element - {i}: ");

                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.Write($"Enter element - {i}: ");
                }
            }

            Console.WriteLine("Sum of all elements stored in the array is :" + numbers.Sum());

        }
    }
}

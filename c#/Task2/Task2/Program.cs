using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ///// 1 /////

            //Console.Write("Enter the first integer: ");

            //if (!int.TryParse(Console.ReadLine(), out int firstNumber))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    return;
            //}

            
            //Console.Write("Enter the second integer: ");

            //if (!int.TryParse(Console.ReadLine(), out int secondNumber))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    return;
            //}

            //int smallerNumber = Math.Min(firstNumber, secondNumber);

            //Console.WriteLine("The smaller number is: " + smallerNumber);


            /////// 2 /////

            //Console.Write("Enter a number: ");

            //if (!int.TryParse(Console.ReadLine(), out int number))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    return;
            //}

            //string sign = (number > 0) ? "-" : (number < 0) ? "+" : "zero";

            //Console.WriteLine($"The sign is {sign}");


            ///// 3 /////

            //Console.Write("Enter the first number: ");
            //if (!int.TryParse(Console.ReadLine(), out int number1))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    return;
            //}

            //Console.Write("Enter the second number: ");
            //if (!int.TryParse(Console.ReadLine(), out int number2))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    return;
            //}

            //Console.Write("Enter the third number: ");
            //if (!int.TryParse(Console.ReadLine(), out int number3))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    return;
            //}
            //int temp;
            //if (number1 > number2)
            //{
            //    temp = number1;
            //    number1 = number2;
            //    number2 = temp;
            //}

            //if (number2 > number3)
            //{
            //    temp = number2;
            //    number2 = number3;
            //    number3 = temp;
            //}

            //if (number1 > number2)
            //{
            //    temp = number1;
            //    number1 = number2;
            //    number2 = temp;
            //}

            //// Display the sorted numbers
            //Console.WriteLine($"Sorted numbers in ascending order: {number3}, {number2}, {number1}");


            ///// 4 /////


            Console.Write("Enter the first number: ");
            if (!int.TryParse(Console.ReadLine(), out int number1))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            Console.Write("Enter the second number: ");
            if (!int.TryParse(Console.ReadLine(), out int number2))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            Console.Write("Enter the third number: ");
            if (!int.TryParse(Console.ReadLine(), out int number3))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            Console.Write("Enter the fourth number: ");
            if (!int.TryParse(Console.ReadLine(), out int number4))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            Console.Write("Enter the fifth number: ");
            if (!int.TryParse(Console.ReadLine(), out int number5))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            int maxNumber = Math.Max(Math.Max(Math.Max(Math.Max(number1, number2), number3), number4), number5);

            Console.WriteLine($"The maximum number is: {maxNumber}");


            ///// 5 /////
            
            Console.Write("Input kilometers per hour: ");
            if (!double.TryParse(Console.ReadLine(), out double kmPerHour))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            const double ConversionFactor = 0.621371;

            double milesPerHour = kmPerHour * ConversionFactor;

            Console.WriteLine($"{kmPerHour} kilometers per hour is equal to {milesPerHour} miles per hour");


            ///// 6 /////

            //Console.Write("Input hours: ");
            //if (!int.TryParse(Console.ReadLine(), out int hours))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer for hours.");
            //    return;
            //}

            //Console.Write("Input minutes: ");
            //if (!int.TryParse(Console.ReadLine(), out int minutes))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer for minutes.");
            //    return;
            //}

            //int totalMinutes = hours * 60 + minutes;

            //Console.WriteLine($"Total: {totalMinutes} minutes.");



            ///// 7 /////

            Console.Write("Input minutes: ");
            if (!int.TryParse(Console.ReadLine(), out int totalMinutes))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for minutes.");
                return;
            }

            int hours = totalMinutes / 60;
            int remainingMinutes = totalMinutes % 60;

            Console.WriteLine($"{totalMinutes} minutes is equal to {hours} Hours, {remainingMinutes} Minutes");


            ///// 8 /////
            

            string[] sentences = {
            "This is a short sentence.",
            "Programming is fun and rewarding.",
            "C# is a versatile programming language.",
            "Arrays help store and organize data.",
            "Learning new things is exciting!"
            };

            Console.WriteLine("Sentences with Fixed Length:");
            foreach (string sentence in sentences)
            {
                Console.WriteLine(sentence.PadRight(30)); 
            }

            Console.WriteLine(reverseOdd("Bananas")); 
            Console.WriteLine(reverseOdd("One two three four"));


        }

        static string reverseOdd(string input)
        {
            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 != 0)
                {
                    char[] charArray = words[i].ToCharArray();
                    Array.Reverse(charArray);
                    words[i] = new string(charArray);
                }
            }

            
            string result = string.Join(" ", words);

            return result;
        }
    }


}

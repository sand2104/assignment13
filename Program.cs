using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace assignment13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1- Hello World

            Console.WriteLine("Hello, World!");


            //Task2-Variable and User input

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");


            //Task 3 -Basic Arithmetic

            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;

            if (num2 != 0)
            {
                int division = num1 / num2;
                int modulus = num1 % num2;
                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine($"Difference: {difference}");
                Console.WriteLine($"Product: {product}");
                Console.WriteLine($"Division: {division}");
                Console.WriteLine($"Modulus: {modulus}");
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }


            //Task 4-Control Structure

            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }


            //Task 5-Loops

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }


            //Task 6-Arrays

            int[] numbers = { 20, 30, 40, 50, 60 };

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");


            //Task 7-Methods

            Console.Write("Enter a positive integer: ");
            int num = int.Parse(Console.ReadLine());

            int factorial = CalculateFactorial(num);

            Console.WriteLine($"Factorial of {num} is: {factorial}");
        }

        static int CalculateFactorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num * CalculateFactorial(num - 1);
            }


            //Task 8-Exception handling

            int age;
            while (true)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out age))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else if (age >= 18 && age <= 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior.");
            }

        }
    }
}
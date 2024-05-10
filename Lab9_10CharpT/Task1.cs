using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT
{
    internal class Task1
    {
       public void Task1FromLab2()
        {
            Console.WriteLine("Task2 !");
            Console.Write("Number = ");
            string? str = Console.ReadLine();
            int number = 0;
            try
            {
                if (str != null && str.Length == 2)
                {
                    number = Convert.ToInt32(str);
                }
                else
                {
                    throw new TwoDigitNumberException("Input must be a two-digit number.");
                }

                int firstnum = number / 10;
                int secondnum = number % 10;
                int sum = firstnum + secondnum;

                checked // Enable overflow checking for arithmetic operations in this block
                {
                    int result = firstnum + secondnum;
                    Console.WriteLine($"The sum of the numbers is {result}.");
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero occurred.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow occurred during arithmetic operation.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}

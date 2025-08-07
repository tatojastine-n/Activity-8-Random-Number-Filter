using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Number_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter 10 numbers:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Number {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    numbers.Add(num);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    i--; 
                }
            }
            List<int> filteredNumbers = numbers.Where(n => n > 50).ToList();

            Console.WriteLine("\nResults:");
            Console.WriteLine($"Original count: {numbers.Count}");
            Console.WriteLine($"Filtered count (>50): {filteredNumbers.Count}");

            if (filteredNumbers.Count > 0)
            {
                Console.WriteLine("Filtered numbers (>50):");
                foreach (int num in filteredNumbers)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp85
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int sum;

            Console.Write("Enter first integer :");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer:");
            number2 = int.Parse(Console.ReadLine());
            sum = number1 + number2;

            Console.WriteLine($"Sum is{sum}");
            Console.ReadLine();
        }
    }
}

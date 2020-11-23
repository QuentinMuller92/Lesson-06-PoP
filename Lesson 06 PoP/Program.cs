using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_PoP
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // PersonManager.CreatePersonList(2);

            while (true)
            {
                TestCalculator();
            }
        }

        private static void TestCalculator()
        {
            Console.Clear();
            Console.Write("Value A:");

            if (!float.TryParse(Console.ReadLine(), out float valueA))
            {
                Console.WriteLine("Incorrect value A!");
                Console.ReadLine();
                return;
            }

            Console.Write("Value B:");

            if (!float.TryParse(Console.ReadLine(), out float valueB))
            {
                Console.WriteLine("Incorrect value B!");
                Console.ReadLine();
                return;
            }

            Console.Write("Operation ('+', '/') :");

            string operation = Console.ReadLine();

            Calculator calculator = new Calculator
            {
                ValueA = valueA,
                ValueB = valueB,
                Operation = operation
            };

            try
            {
                string calcResult = calculator.Calculate();
                Console.WriteLine(calcResult);
            }
            catch (Exception ex)
            {
                Console.Write("Calculator.Calculate thrown an error " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}

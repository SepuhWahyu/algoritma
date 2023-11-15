using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine()); // 3
            int number = rows - 1; // 2

            for (int i = 1; i <= rows; i++) // 3x
            {
                for (int space = 1; space <= number; space++) // 2x
                {
                    Console.Write(" ");
                }
                
                number--; // 1
                for (int star = 1; star <= 2 * i - 1; star++) // (2 x 1 - 1)=1 (2 x 2 - 1)=3 (2 x 3 - 1)=5
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

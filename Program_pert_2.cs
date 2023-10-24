using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertemuan2
{
    class Program
    {
        static void Main(string[] args)
        {
            TestElseIf(40);
            TestSwitch(10, 20, '+');
        }

        public static void TestElseIf(int n)
        {
            if (n < 10)
            {
                Console.WriteLine("N is less than 10");
            }
            else if (n < 20)
            {
                Console.WriteLine("N is less than 20");
            }
            else
            {
                Console.WriteLine("N is greater than or equal to 20");
            }
        }

        public static void TestSwitch(int op1, int op2, char opr)
        {
            int result;
            switch (opr)
            {
                case '+':
                    result = op1 + op2;
                    break;
                case '-':
                    result = op1 - op2;
                    break;
                case '*':
                    result = op1 * op2;
                    break;
                case '/':
                    result = op1 / op2;
                    break;
                default:
                    Console.WriteLine("Unknown Operatior");
                    return;
            }
            Console.WriteLine("Result: {0}", result);
            return;
        }

    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIlangPuh
{
    class Program
    {
        static void Main(string[] args)
        {
            // WhileTest();
            // Console.WriteLine();
            // DoWhileTest();
            // Console.WriteLine();
            // ForTest();
            // Console.WriteLine();
            // ForEachTest();
            // Console.WriteLine();

            // long result = Factorial(5);
            // Console.WriteLine(result);
            // Console.WriteLine();

            // ExceptionTest();
            // Console.WriteLine();
        }

        public static void WhileTest()
        {
            int y = 1;
            while (y <= 10)
            {
                Console.WriteLine("The value of y = {0}", y);
                y++;
            }
        }

        public static void DoWhileTest()
        {
            int x = 1;
            do
            {
                Console.WriteLine("The value of x = {0}", x);
                x++;
            }
            while (x <= 10);
        }

        public static void ForTest()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("The value of i = {0}", i);
            }
        }

        public static void ForEachTest()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int z in numbers)
            {
                Console.WriteLine("The value of z = {0}", z);
            }
        }

        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        private static void ExceptionTest()
        {
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(@"c:\data.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

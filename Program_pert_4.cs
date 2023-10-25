using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertemuan3
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionTest();
        }

        private static void ExceptionTest()
        {
            StreamReader sr = null;
            sr = File.OpenText(@"C:\data.txt");
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}

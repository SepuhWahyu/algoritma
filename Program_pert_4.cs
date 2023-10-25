using System;
using System.IO;
using System.Collections.Generic;
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

            // Pilih salah satu

            // 1
            sr = File.OpenText(@"C:\data.txt");
            Console.WriteLine(sr.ReadToEnd());

            // 2
            try
            {
                sr = File.OpenText(@"C:\data.txt");
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

            // 3
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}

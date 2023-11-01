using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertemuan5
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("=========================");
                Console.WriteLine("|        Alfamart       |");
                Console.WriteLine("=========================");
                Console.WriteLine("");
                try
                {
                    Console.Write("Masukan harga: Rp. ");
                    int harga = Int32.Parse(Console.ReadLine());
                    Console.Write("Masukan jumlah barang: ");
                    int jumlah = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Harga yang harus dibayarkan: Rp.{0}", DiscountHarga(harga, jumlah));
                }
                catch
                {
                    Console.WriteLine("Tolong masukan angka yang benar.");
                }
                Console.WriteLine("");
                Console.WriteLine("      Terima kasih");
                Console.WriteLine("");
                return;
            }
            while (true);
        }

        public static int DiscountHarga(int harga, int jumlah)
        {
            int totalHarga = harga * jumlah;
            int diskon;
            int jumlahDiskon;
            int hargaBayar;

            if (jumlah >= 100)
                diskon = 20;
            else if (jumlah >= 50)
                diskon = 15;
            else if (jumlah >= 10)
                diskon = 10;
            else
                diskon = 5;

            jumlahDiskon = totalHarga * diskon / 100;
            hargaBayar = totalHarga - jumlahDiskon;

            Console.WriteLine("Total harga: Rp.{0}", totalHarga);
            Console.WriteLine("Diskon yang didapatkan: {0}%", diskon);

            return hargaBayar;
        }
    }
}

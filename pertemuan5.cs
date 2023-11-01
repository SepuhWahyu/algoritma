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
            Console.Write("Masukan harga: Rp. ");
            int harga = Int32.Parse(Console.ReadLine());
            Console.Write("Masukan jumlah barang: ");
            int jumlah = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Harga yang harus dibayarkan: Rp. {0}", DiscountHarga(harga, jumlah));
        }

        private static int CalculateDiscount(int quantity)
        {
            int discount;

            if (quantity >= 100)
                discount = 20;
            else if (quantity >= 50)
                discount = 15;
            else if (quantity >= 10)
                discount = 10;
            else
                discount = 5;

            return discount;
        }

        public static double DiscountHarga(int harga, int jumlah)
        {
            int totalHarga = harga * jumlah;
            int diskon;
            double jumlahDiskon;
            double hargaBayar;

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

            Console.WriteLine("Total harga: Rp. {0}", totalHarga);
            Console.WriteLine("Diskon yang didapatkan: {0}%", diskon);

            return hargaBayar;
        }
    }
}

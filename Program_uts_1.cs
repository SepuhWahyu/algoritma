using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulangan_Tengah_semester_1
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Masukan harga: Rp. ");
                int harga = Int32.Parse(Console.ReadLine());
                Console.Write("Masukan jumlah barang: ");
                int jumlah = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Harga yang harus dibayarkan: Rp.{0}", DiscountHarga(harga, jumlah));
        }

        public static int DiscountHarga(int harga, int jumlah)
        {
            int totalHarga = harga * jumlah;
            int diskon;
            int jumlahDiskon;
            int hargaBayar;

            if (jumlah < 20)
                diskon = 2;
            else if (jumlah < 40)
                diskon = 4;
            else if (jumlah < 60)
                diskon = 6;
            else if (jumlah < 80)
                diskon = 8;
            else if (jumlah < 100)
                diskon = 10;
            else
                diskon = 20;

            jumlahDiskon = totalHarga * diskon / 100;
            hargaBayar = totalHarga - jumlahDiskon;

            Console.WriteLine("Total harga: Rp.{0}", totalHarga);
            Console.WriteLine("Diskon yang didapatkan: {0}%", diskon);

            return hargaBayar;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uts_2303040098
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("masukan harga: rp.");
                    int harga = Int32.Parse(Console.ReadLine());
                    Console.Write("masukan jumlah barang: ");
                    int jumlah = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("harga yang harus dibayarkan: rp.{0}", DiscountHarga(harga, jumlah));
                    return;
                }
                catch
                {
                    Console.WriteLine("Tolong hanya memasukan bilangan bulat saja.");
                }
            }
        }

        private static int DiscountHarga(int harga, int jumlah)
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
            Console.WriteLine("Total diskon: Rp.{0}", jumlahDiskon);

            return hargaBayar;
        }
    }
}

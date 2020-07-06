using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectProduk
{
    class Program
    {
        static List<Produk> daftarProduk = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
            bool ulang = true;
            while (ulang)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4:
                        ulang = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih menu Aplikasi\n");
            Console.WriteLine("1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar");
        }

        static void TambahProduk()
        {
            Console.Clear();

            Produk baru = new Produk();
            Console.WriteLine("Tambah Data Produk");
            Console.Write("\nKode Produk : ");
            baru.Kode_Produk = Console.ReadLine();
            Console.Write("Nama Produk : ");
            baru.Nama_Produk = Console.ReadLine();
            Console.Write("Harga Beli : ");
            baru.Harga_Beli = double.Parse(Console.ReadLine());
            Console.Write("Harga Jual : ");
            baru.Harga_Jual = double.Parse(Console.ReadLine());

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            int nomor = -1, delete = -1;

            Console.WriteLine("Hapus Data Produk");
            Console.Write("Kode Produk : ");
            string kod = Console.ReadLine();

            foreach (Produk product in daftarProduk)
            {
                nomor++;
                if(product.Kode_Produk == kod)
                {
                    delete = nomor;
                }
            }
            if (delete != -1)
            {
                daftarProduk.RemoveAt(delete);
                Console.WriteLine("\nData produk berhasil di hapus");
            }
            else
            {
                Console.WriteLine("\nKode produk tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();

            int sort = 0;
            Console.WriteLine("Data Produk");

            foreach (Produk product in daftarProduk)
            {
                sort++;
                Console.WriteLine("{0}. Kode Produk: {1}, Nama Produk: {2}, Harga Beli: {3}, Harga Jual: {4}", sort, product.Kode_Produk, product.Nama_Produk, product.Harga_Beli, product.Harga_Jual);
            }
            if (sort < 1)
            {
                Console.WriteLine("Data Produk Kosong");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}

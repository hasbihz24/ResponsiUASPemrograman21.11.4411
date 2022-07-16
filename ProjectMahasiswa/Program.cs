using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi : ");
            Console.WriteLine("1. Tambah Mahasiswa  ");
            Console.WriteLine("2. Tampilkan Mahasiswa ");
            Console.WriteLine("3. Keluar");

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahMahasiswa()
        {
            string kelamin;
            Mahasiswa mhs = new Mahasiswa();
            Console.Clear();
            Console.WriteLine("Tambah Mahasiswa : ");
            Console.WriteLine("");
            Console.Write("NIM : ");
            mhs.NIM = Console.ReadLine();
            Console.Write("Nama : ");
            mhs.Nama = Console.ReadLine();
            Console.Write("Kelamin[L/P] : ");
            kelamin = Console.ReadLine();
            Console.Write("Nilai : ");
            mhs.IPK = Console.ReadLine();
            if(kelamin == "L" || kelamin == "l")
            {
                mhs.Kelamin = "Laki-Laki";
            }
            else
            {
                mhs.Kelamin = "Perempuan";
            }

            daftarMahasiswa.Add(mhs);
            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();
            Console.WriteLine("Data Mahasiswa : ");
            int i=1;
            foreach (Mahasiswa mhs in daftarMahasiswa) 
            {
                Console.WriteLine(i +".  "+mhs.NIM + ",  " + mhs.Nama + ",  " + mhs.Kelamin + ",  " + mhs.IPK);
                i++;
            }
            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}

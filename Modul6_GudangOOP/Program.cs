using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Modul6_GudangOOP.Models;

namespace Modul6_GudangOOP
{
    class Program
    {
        // Fungsi untuk membaca data dari file stok (Post-Test Bab 6)
        public static void BacaFileStok(string pathFile)
        {
            if (File.Exists(pathFile))
            {
                Console.WriteLine($"\nIsi file '{Path.GetFileName(pathFile)}':");
                string[] barisData = File.ReadAllLines(pathFile);
                foreach (string baris in barisData)
                {
                    Console.WriteLine(baris);
                }
            }
            else
            {
                Console.WriteLine($"File '{pathFile}' tidak ditemukan.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== PRAKTIKUM MODUL 6: EXCEPTION HANDLING & FILE I/O ===");

            // Langkah 1 & 2: Try-Catch Input & Custom Exception StokNegatifException
            Console.WriteLine("\n--- Langkah 1 & 2: Input Stok & Penanganan Exception ---");
            try
            {
                Console.Write("Jumlah Stok: ");
                string? input = Console.ReadLine();
                if (input == null)
                {
                    // Nilai default jika dijalankan di environment non-interaktif
                    input = "50";
                    Console.WriteLine(input);
                }

                int stok = int.Parse(input);
                Barang barang = new Barang("B001", "Laptop", stok, "Elektronik");
                barang.TampilkanInfo();
            }
            catch (FormatException)
            {
                Console.WriteLine("Input harus berupa angka!");
            }
            catch (StokNegatifException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Demonstrasi Try-Catch menangkap StokNegatifException secara eksplisit
            Console.WriteLine("\n--- Pengujian Validasi StokNegatifException ---");
            try
            {
                Console.WriteLine("Mencoba membuat Barang dengan stok -15:");
                Barang barangNegatif = new Barang("B000", "Barang Uji", -15, "Elektronik");
                barangNegatif.TampilkanInfo();
            }
            catch (StokNegatifException ex)
            {
                Console.WriteLine($"Tertangkap StokNegatifException: {ex.Message}");
            }

            // Demo Post-Test: KodeBarangDuplikatException
            Console.WriteLine("\n--- Demo Post-Test: Validasi KodeBarangDuplikatException ---");
            List<Barang> daftarBarangValidasi = new List<Barang>()
            {
                new Barang("B001", "Laptop", 30, "Elektronik"),
                new Barang("B002", "Smartphone", 60, "Elektronik")
            };

            try
            {
                string kodeBaru = "B001";
                Console.WriteLine($"Mencoba menambahkan barang baru dengan kode '{kodeBaru}'...");
                if (daftarBarangValidasi.Any(b => b.KodeBarang == kodeBaru))
                {
                    throw new KodeBarangDuplikatException($"Kode barang '{kodeBaru}' sudah ada dalam daftar!");
                }

                daftarBarangValidasi.Add(new Barang(kodeBaru, "Tablet", 10, "Elektronik"));
            }
            catch (KodeBarangDuplikatException ex)
            {
                Console.WriteLine($"Tertangkap KodeBarangDuplikatException: {ex.Message}");
            }

            // Langkah 3: Simpan Daftar Barang ke File data_barang.txt
            Console.WriteLine("\n--- Langkah 3: Menyimpan Daftar Barang ke File data_barang.txt ---");
            List<Barang> daftarBarang = new List<Barang>()
            {
                new Barang("B001", "Laptop", 30, "Elektronik"),
                new Barang("B002", "Smartphone", 60, "Elektronik"),
                new Barang("B003", "Kulkas", 20, "Elektronik"),
                new Barang("B004", "Televisi", 10, "Elektronik"),
                new Barang("B005", "Mesin Cuci", 5, "Elektronik")
            };

            string pathDataBarang = Path.Combine(Directory.GetCurrentDirectory(), "data_barang.txt");
            File.WriteAllText(pathDataBarang, "Kode\tNama\tStok\n");
            foreach (var b in daftarBarang)
            {
                File.AppendAllText(pathDataBarang, $"{b.KodeBarang}\t{b.NamaBarang}\t{b.JumlahStok}\n");
            }
            Console.WriteLine($"Data barang berhasil disimpan ke: {pathDataBarang}");

            // Langkah 4: Membaca Data Barang dari File data_barang.txt
            Console.WriteLine("\n--- Langkah 4: Membaca Data Barang dari File data_barang.txt ---");
            if (File.Exists(pathDataBarang))
            {
                string[] barisData = File.ReadAllLines(pathDataBarang);
                foreach (string baris in barisData)
                {
                    Console.WriteLine(baris);
                }
            }
            else
            {
                Console.WriteLine("File data_barang.txt tidak ditemukan.");
            }

            // Post-Test Bab 6: Membaca File stok.txt jika file tersebut ada
            Console.WriteLine("\n--- Post-Test: Membaca File stok.txt ---");
            string pathStok = Path.Combine(Directory.GetCurrentDirectory(), "stok.txt");
            if (!File.Exists(pathStok))
            {
                // Contoh data file stok.txt untuk pengujian
                File.WriteAllText(pathStok, "Kode\tStok\nB001\t30\nB002\t60\nB003\t20\nB004\t10\nB005\t5\n");
            }
            BacaFileStok(pathStok);
        }
    }
}

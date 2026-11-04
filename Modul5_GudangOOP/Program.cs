using System;
using System.Collections.Generic;
using Modul5_GudangOOP.Models;

namespace Modul5_GudangOOP
{
    class Program
    {
        // Langkah 4: Method Generic CariData<T>
        public static T? CariData<T>(List<T> list, Func<T, bool> predicate)
        {
            return list.Find(new Predicate<T>(predicate));
        }

        // Tambahan Post-Test Bab 5: Method Generic AmbilPertama<T>
        public static T? AmbilPertama<T>(List<T> list)
        {
            return list.Count > 0 ? list[0] : default;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== PRAKTIKUM MODUL 5: COLLECTION & GENERIC ===");

            // Langkah 1: Penggunaan List<Barang>
            Console.WriteLine("\n--- Langkah 1: Menampilkan Daftar Barang (List<Barang>) ---");
            List<Barang> daftarBarang = new List<Barang>();
            daftarBarang.Add(new Barang("BRG001", "Karton", 100, "Kemasan"));
            daftarBarang.Add(new Barang("BRG002", "Peti", 50, "Penyimpanan"));

            foreach (var barang in daftarBarang)
            {
                barang.TampilkanInfo();
            }

            // Langkah 2: Pencarian Barang dengan .Find()
            Console.WriteLine("\n--- Langkah 2: Pencarian Barang (Kode: BRG002) dengan .Find() ---");
            var hasil = daftarBarang.Find(b => b.KodeBarang == "BRG002");
            if (hasil != null)
            {
                hasil.TampilkanInfo();
            }
            else
            {
                Console.WriteLine("Barang tidak ditemukan.");
            }

            // Langkah 3: Penggunaan Dictionary<string, Barang>
            Console.WriteLine("\n--- Langkah 3: Penggunaan Dictionary<string, Barang> ---");
            Dictionary<string, Barang> indeksBarang = new Dictionary<string, Barang>();
            indeksBarang.Add("BRG001", new Barang("BRG001", "Karton", 100, "Kemasan"));

            if (indeksBarang.ContainsKey("BRG001"))
            {
                Console.WriteLine("Barang ditemukan dalam Dictionary:");
                indeksBarang["BRG001"].TampilkanInfo();
            }
            else
            {
                Console.WriteLine("Kunci tidak ditemukan dalam Dictionary.");
            }

            // Langkah 4: Pengujian Method Generic CariData<T>
            Console.WriteLine("\n--- Langkah 4: Pengujian Method Generic CariData<T> ---");
            Barang? hasilCari = CariData(daftarBarang, b => b.Kategori == "Penyimpanan");
            if (hasilCari != null)
            {
                Console.WriteLine("Hasil CariData (Kategori 'Penyimpanan'):");
                hasilCari.TampilkanInfo();
            }
            else
            {
                Console.WriteLine("Data tidak ditemukan menggunakan CariData.");
            }

            // Tambahan Post-Test Bab 5: Pengujian Method Generic AmbilPertama<T>
            Console.WriteLine("\n--- Post-Test: Pengujian Method Generic AmbilPertama<T> ---");
            Barang? barangPertama = AmbilPertama(daftarBarang);
            if (barangPertama != null)
            {
                Console.WriteLine("Elemen pertama dari daftarBarang:");
                barangPertama.TampilkanInfo();
            }
            else
            {
                Console.WriteLine("List kosong.");
            }
        }
    }
}

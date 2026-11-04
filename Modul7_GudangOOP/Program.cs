using System;
using Modul7_GudangOOP.Factories;
using Modul7_GudangOOP.Helpers;
using Modul7_GudangOOP.Interfaces;
using Modul7_GudangOOP.Models;
using Modul7_GudangOOP.Services;

namespace Modul7_GudangOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PRAKTIKUM MODUL 7: DESIGN PATTERN & REFACTORING SOLID ===");

            IBarangPrinter printer = new PencetakBarang();

            // 1. Penggunaan Factory Pattern (BarangFactory.BuatBarang)
            Console.WriteLine("\n--- 1. Pembuatan Barang Menggunakan BarangFactory.BuatBarang ---");
            Barang bElektronik = BarangFactory.BuatBarang("Elektronik");
            Barang bMakanan = BarangFactory.BuatBarang("Makanan");
            Barang bUmum = BarangFactory.BuatBarang("Lainnya");

            Console.WriteLine("Mencetak barang hasil Factory menggunakan IBarangPrinter:");
            printer.Cetak(bElektronik);
            printer.Cetak(bMakanan);
            printer.Cetak(bUmum);

            // 2. Tambahan Post-Test Bab 7: Factory Method untuk class turunan BarangElektronik & BarangMakanan
            Console.WriteLine("\n--- 2. Post-Test: Factory untuk Class Turunan (BarangElektronik & BarangMakanan) ---");
            BarangElektronik elk = BarangFactory.BuatBarangElektronik("ELK999", "Smart TV 55 Inch", 12, "Elektronik", 120);
            elk.TampilkanInfo();
            Console.WriteLine($"Evaluasi Resiko: {elk.EvaluasiResiko()}");

            Console.WriteLine();
            BarangMakanan mkn = BarangFactory.BuatBarangMakanan("MAK999", "Yoghurt Probiotik", 25, "Makanan", DateTime.Today.AddDays(30));
            mkn.TampilkanInfo();
            Console.WriteLine($"Status Kadaluarsa: {(mkn.ApakahKadaluarsa() ? "Sudah Kadaluarsa" : "Masih Layak Konsumsi")}");

            // 3. Demonstrasi Single Responsibility Principle & Helper: InputBarang & InputHelper
            Console.WriteLine("\n--- 3. Input Data Barang Menggunakan InputBarang & InputHelper ---");
            InputBarang serviceInput = new InputBarang();
            Console.WriteLine("Masukkan data barang (uji coba validasi stok):");
            Barang barangInput = serviceInput.AmbilInput();

            Console.WriteLine("\nInformasi barang yang diinput (dicetak dengan IBarangPrinter):");
            printer.Cetak(barangInput);
        }
    }
}

using System;
using Modul4_GudangOOP.Models;

class Program
{
    static void Main()
    {
        // Pengujian dari modul sebelumnya (tetap dipertahankan)
        Barang b1 = new Barang("BRG001", "Peti Plastik", 80, "Kemasan");
        BarangElektronik b2 = new BarangElektronik("ELK001", "Handheld Scanner", 10, "Elektronik", 25);
        BarangMakanan b3 = new BarangMakanan("MKN001", "Susu Kotak", 30, "Makanan", new DateTime(2026, 12, 31));

        b1.TampilkanInfo();
        b2.TampilkanInfo();
        b3.TampilkanInfo();

        Console.WriteLine("\n--- Pengujian Modul 4 (Abstract Class & Interface) ---");

        // Langkah 4: Uji Class dan Interface di Program.cs
        ItemGudang item1 = new BarangKimia("KIM001", "Asam Sulfat");
        ItemGudang item2 = new BarangMakanan("MAK001", "Susu Kental", DateTime.Parse("2023-12-01"));

        item1.CetakInfo();
        Console.WriteLine(item1.EvaluasiResiko());

        item2.CetakInfo();
        Console.WriteLine(item2.EvaluasiResiko());

        if (item2 is IPeriksaKadaluarsa periksa)
        {
            Console.WriteLine(periksa.ApakahKadaluarsa() ? "Kadaluarsa" : "Masih berlaku");
        }

        Console.WriteLine("\n--- Pengujian Tugas: BarangElektronik & Garansi ---");

        // Kasus 1: Barang Elektronik dengan garansi yang masih berlaku
        // Pembelian 15 Januari 2026 dengan masa garansi 24 bulan (berlaku hingga Jan 2028)
        Garansi garansiScanner = new Garansi(24, new DateTime(2026, 1, 15));
        BarangElektronik elk1 = new BarangElektronik("ELK001", "Kulkas", 25, garansiScanner);

        elk1.CetakInfo();
        Console.WriteLine(elk1.EvaluasiResiko());
        if (elk1 is IPeriksaGaransi periksaElk1)
        {
            if (periksaElk1.ApakahMasihGaransi())
            {
                Console.WriteLine($"Status: Garansi MASIH BERLAKU, sisa: {periksaElk1.SisaGaransiBulan()} bulan.");
            }
            else
            {
                Console.WriteLine("Status: Garansi SUDAH HABIS.");
            }
        }

        Console.WriteLine();

        // Kasus 2: Barang Elektronik dengan garansi yang sudah habis
        // Pembelian 10 Mei 2024 dengan masa garansi 12 bulan (berlaku hingga Mei 2025)
        Garansi garansiPrinter = new Garansi(12, new DateTime(2024, 5, 10));
        BarangElektronik elk2 = new BarangElektronik("ELK002", "TV", 60, garansiPrinter);

        elk2.CetakInfo();
        Console.WriteLine(elk2.EvaluasiResiko());
        if (elk2 is IPeriksaGaransi periksaElk2)
        {
            if (periksaElk2.ApakahMasihGaransi())
            {
                Console.WriteLine($"Status: Garansi MASIH BERLAKU, sisa: {periksaElk2.SisaGaransiBulan()} bulan.");
            }
            else
            {
                Console.WriteLine("Status: Garansi SUDAH HABIS.");
            }
        }
    }
}
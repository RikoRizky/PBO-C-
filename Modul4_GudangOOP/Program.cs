using System;
using Modul4_GudangOOP.Models;

class Program
{
    static void Main()
    {
        // Pengujian dari modul sebelumnya (tetap dipertahankan)
        Barang b1 = new Barang("BRG001", "Peti Plastik", 80, "Kemasan");
        Barang b2 = new BarangElektronik("ELK001", "Handheld Scanner", 10, "Elektronik", 25);
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
    }
}
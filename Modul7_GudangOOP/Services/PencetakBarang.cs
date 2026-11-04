using System;
using Modul7_GudangOOP.Interfaces;
using Modul7_GudangOOP.Models;

namespace Modul7_GudangOOP.Services
{
    public class PencetakBarang : IBarangPrinter
    {
        public void Cetak(Barang barang)
        {
            Console.WriteLine($"Kode: {barang.KodeBarang}");
            Console.WriteLine($"Nama: {barang.NamaBarang}");
            Console.WriteLine($"Stok: {barang.JumlahStok}");
            Console.WriteLine($"Kategori: {barang.Kategori}");
        }
    }
}

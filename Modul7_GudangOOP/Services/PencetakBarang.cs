using System;
using Modul7_GudangOOP.Interfaces;
using Modul7_GudangOOP.Models;

namespace Modul7_GudangOOP.Services
{
    public class PencetakBarang : IBarangPrinter
    {
        public void Cetak(Barang barang)
        {
            Console.WriteLine($"[Kode: {barang.KodeBarang}] Nama: {barang.NamaBarang} | Stok: {barang.JumlahStok} ({barang.Status}) | Kategori: {barang.Kategori}");
        }
    }
}

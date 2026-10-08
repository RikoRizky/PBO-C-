using System;
using System.Collections.Generic;
using System.Text;

namespace Modul1_GudangOOP.Models
{
    internal class Barang
    {
        public string KodeBarang;
        public string NamaBarang;
        public int JumlahStok;
        public string Kategori;

        public Barang(string kode, string nama, int stok, string kategori)
        {
            KodeBarang = kode;
            NamaBarang = nama;
            JumlahStok = stok;
            Kategori = kategori;
        }

        public void TampilkanInfo()
        {
            Console.WriteLine($"[{KodeBarang}] {NamaBarang} - Stok: {JumlahStok}, Kategori:{Kategori}");
        }
    }
}

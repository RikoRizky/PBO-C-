using System;
using System.Collections.Generic;
using System.Text;

namespace Modul2_GudangOOP.Models
{
    public class Barang
    {
        public string KodeBarang;
        public string NamaBarang;
        private int jumlahStok;
        public string Kategori { get; set; }
        public int JumlahStok
        {
            get => jumlahStok;
            set
            {
                if (value >= 0) jumlahStok = value;
            }
        }
        public string Status => JumlahStok > 50 ? "Aman" : "Perlu Reorder";

        public Barang(string kode, string nama, int stok, string kategori)
        {
            KodeBarang = kode;
            NamaBarang = nama;
            JumlahStok = stok;
            Kategori = kategori;
        }

        public virtual void TampilkanInfo()
        {
            Console.WriteLine($"[{KodeBarang}] {NamaBarang} - Stok: {JumlahStok}, Kategori:{Kategori}");
        }
    }
}

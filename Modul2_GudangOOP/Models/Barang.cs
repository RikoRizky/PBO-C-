using System;

namespace Modul2_GudangOOP.Models
{
    public class Barang
    {
        // Field & Property
        public string KodeBarang;
        public string NamaBarang;
        public string Kategori { get; set; }

        // Field private untuk enkapsulasi stok
        private int jumlahStok;

        // Property dengan validasi (tidak boleh negatif)
        public int JumlahStok
        {
            get => jumlahStok;
            set
            {
                if (value >= 0) jumlahStok = value;
            }
        }

        // Property read-only untuk status
        public string Status => JumlahStok > 50 ? "Aman" : "Perlu Reorder";

        // Constructor 4 parameter
        public Barang(string kodeBarang, string namaBarang, int stokAwal, string kategori)
        {
            KodeBarang = kodeBarang;
            NamaBarang = namaBarang;
            JumlahStok = stokAwal; // Melewati validasi property
            Kategori = kategori;
        }

        // Method menampilkan info
        public void TampilkanInfo()
        {
            Console.WriteLine($"Kode: {KodeBarang} | Nama: {NamaBarang} | Kategori: {Kategori} | Stok: {JumlahStok} | Status: {Status}");
        }
    }
}
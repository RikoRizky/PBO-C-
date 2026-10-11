using System;

namespace Modul2_GudangOOP.Models
{
    public class BarangMakanan : Barang
    {
        public DateTime TanggalKadaluarsa { get; set; }

        public BarangMakanan(string kode, string nama, int stok, string kategori, DateTime tanggalKadaluarsa)
            : base(kode, nama, stok, kategori)
        {
            TanggalKadaluarsa = tanggalKadaluarsa;
        }

        // Overload constructor yang menerima string (misal: "2025-12-31" atau "31/12/2025")
        public BarangMakanan(string kode, string nama, int stok, string kategori, string tanggalKadaluarsa)
            : base(kode, nama, stok, kategori)
        {
            TanggalKadaluarsa = DateTime.Parse(tanggalKadaluarsa);
        }

        public override void TampilkanInfo()
        {
            base.TampilkanInfo();
            Console.WriteLine($"Tanggal Kadaluarsa: {TanggalKadaluarsa:dd/MM/yyyy}");
        }
    }
}

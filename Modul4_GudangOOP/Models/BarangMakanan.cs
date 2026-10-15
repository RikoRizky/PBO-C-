using System;

namespace Modul4_GudangOOP.Models
{
    public class BarangMakanan : ItemGudang, IPeriksaKadaluarsa
    {
        public DateTime TanggalKadaluarsa { get; set; }

        public BarangMakanan(string kode, string nama)
            : base(kode, nama)
        {
        }

        public BarangMakanan(string kode, string nama, DateTime kadaluarsa)
            : base(kode, nama)
        {
            TanggalKadaluarsa = kadaluarsa;
        }

        public BarangMakanan(string kode, string nama, int stok, string kategori, DateTime kadaluarsa)
            : base(kode, nama)
        {
            TanggalKadaluarsa = kadaluarsa;
        }

        public override string EvaluasiResiko()
        {
            return "Perlu suhu penyimpanan stabil.";
        }

        public bool ApakahKadaluarsa()
        {
            return TanggalKadaluarsa < DateTime.Today;
        }

        public void TampilkanInfo()
        {
            CetakInfo();
            Console.WriteLine($"Tanggal Kadaluarsa: {TanggalKadaluarsa:dd/MM/yyyy}");
        }
    }
}
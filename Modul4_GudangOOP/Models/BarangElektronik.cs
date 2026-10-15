using System;

namespace Modul4_GudangOOP.Models
{
    public class BarangElektronik : ItemGudang, IPeriksaGaransi
    {
        public int DayaListrik { get; set; }
        public Garansi? Garansi { get; set; }

        // Constructor standar dengan objek Garansi
        public BarangElektronik(string kode, string nama, int daya, Garansi? garansi = null)
            : base(kode, nama)
        {
            DayaListrik = daya;
            Garansi = garansi;
        }

        // Overload constructor langsung dengan parameter masa garansi & tanggal beli
        public BarangElektronik(string kode, string nama, int daya, int masaGaransiBulan, DateTime tanggalBeli)
            : base(kode, nama)
        {
            DayaListrik = daya;
            Garansi = new Garansi(masaGaransiBulan, tanggalBeli);
        }

        // Overload constructor lama dari Modul 3 agar kode sebelumnya tetap kompatibel
        public BarangElektronik(string kode, string nama, int stok, string kategori, int daya)
            : base(kode, nama)
        {
            DayaListrik = daya;
        }

        public override string EvaluasiResiko()
        {
            return "Perlu disimpan di ruangan kering dan terlindung dari lonjakan listrik.";
        }

        public bool ApakahMasihGaransi()
        {
            return Garansi != null && Garansi.ApakahMasihGaransi();
        }

        public int SisaGaransiBulan()
        {
            return Garansi != null ? Garansi.HitungSisaBulan() : 0;
        }

        public void TampilkanInfo()
        {
            CetakInfo();
            Console.WriteLine($"Daya: {DayaListrik} Watt");
            if (Garansi != null)
            {
                Garansi.TampilkanInfoGaransi();
            }
        }
    }
}

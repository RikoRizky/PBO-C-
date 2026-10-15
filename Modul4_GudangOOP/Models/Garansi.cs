using System;

namespace Modul4_GudangOOP.Models
{
    public class Garansi
    {
        public int MasaGaransiBulan { get; set; }
        public DateTime TanggalBeli { get; set; }

        public DateTime TanggalAkhirGaransi => TanggalBeli.AddMonths(MasaGaransiBulan);

        public Garansi(int masaGaransiBulan, DateTime tanggalBeli)
        {
            MasaGaransiBulan = masaGaransiBulan;
            TanggalBeli = tanggalBeli;
        }

        // Cek apakah garansi masih aktif
        public bool ApakahMasihGaransi()
        {
            return DateTime.Today <= TanggalAkhirGaransi;
        }

        // Menghitung sisa bulan garansi
        public int HitungSisaBulan()
        {
            if (!ApakahMasihGaransi())
            {
                return 0;
            }

            int sisaBulan = ((TanggalAkhirGaransi.Year - DateTime.Today.Year) * 12) + (TanggalAkhirGaransi.Month - DateTime.Today.Month);
            if (DateTime.Today.Day > TanggalAkhirGaransi.Day)
            {
                sisaBulan--;
            }

            return Math.Max(0, sisaBulan);
        }

        public void TampilkanInfoGaransi()
        {
            Console.WriteLine($"  - Tanggal Pembelian : {TanggalBeli:dd/MM/yyyy}");
            Console.WriteLine($"  - Masa Garansi      : {MasaGaransiBulan} Bulan");
            Console.WriteLine($"  - Garansi Berakhir  : {TanggalAkhirGaransi:dd/MM/yyyy}");
            if (ApakahMasihGaransi())
            {
                Console.WriteLine($"  - Status Garansi    : Masih Berlaku (Sisa {HitungSisaBulan()} bulan)");
            }
            else
            {
                Console.WriteLine("  - Status Garansi    : Sudah Habis");
            }
        }
    }
}

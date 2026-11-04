using System;
using Modul7_GudangOOP.Models;

namespace Modul7_GudangOOP.Factories
{
    public static class BarangFactory
    {
        // Factory Method Standar Praktikum Bab 7
        public static Barang BuatBarang(string tipe)
        {
            if (string.Equals(tipe, "Elektronik", StringComparison.OrdinalIgnoreCase))
            {
                return new Barang("ELK001", "Scanner", 10, "Elektronik");
            }
            else if (string.Equals(tipe, "Makanan", StringComparison.OrdinalIgnoreCase))
            {
                return new Barang("MAK001", "Susu", 50, "Makanan");
            }
            else
            {
                return new Barang("GEN001", "Barang Umum", 20, "Umum");
            }
        }

        // --- Tambahan Post-Test Bab 7: Factory Method untuk Class Turunan ---

        // Factory Method untuk membuat instance BarangElektronik (dengan stok & kategori)
        public static BarangElektronik BuatBarangElektronik(string kode = "ELK002", string nama = "Laptop Gudang", int stok = 15, string kategori = "Elektronik", int daya = 65)
        {
            return new BarangElektronik(kode, nama, stok, kategori, daya);
        }

        // Overload Factory Method untuk membuat BarangElektronik dengan objek Garansi
        public static BarangElektronik BuatBarangElektronikDenganGaransi(string kode, string nama, int daya, int masaGaransiBulan, DateTime tanggalBeli)
        {
            return new BarangElektronik(kode, nama, daya, masaGaransiBulan, tanggalBeli);
        }

        // Factory Method untuk membuat instance BarangMakanan (dengan stok & kategori & kadaluarsa)
        public static BarangMakanan BuatBarangMakanan(string kode = "MAK002", string nama = "Biskuit Kaleng", int stok = 40, string kategori = "Makanan", DateTime? kadaluarsa = null)
        {
            DateTime tgl = kadaluarsa ?? DateTime.Today.AddMonths(12);
            return new BarangMakanan(kode, nama, stok, kategori, tgl);
        }

        // Overload Factory Method untuk membuat BarangMakanan standar
        public static BarangMakanan BuatBarangMakanan(string kode, string nama, DateTime kadaluarsa)
        {
            return new BarangMakanan(kode, nama, kadaluarsa);
        }
    }
}

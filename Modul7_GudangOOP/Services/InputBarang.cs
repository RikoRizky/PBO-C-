using System;
using Modul7_GudangOOP.Helpers;
using Modul7_GudangOOP.Models;

namespace Modul7_GudangOOP.Services
{
    public class InputBarang
    {
        public Barang AmbilInput()
        {
            Console.Write("Kode Barang: ");
            string? kode = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(kode))
            {
                kode = "BRG001";
                Console.WriteLine(kode);
            }

            Console.Write("Nama Barang: ");
            string? nama = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nama))
            {
                nama = "Barang Contoh";
                Console.WriteLine(nama);
            }

            int stok = InputHelper.AmbilStokValid();

            Console.Write("Kategori: ");
            string? kategori = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(kategori))
            {
                kategori = "Umum";
                Console.WriteLine(kategori);
            }

            return new Barang(kode, nama, stok, kategori);
        }
    }
}

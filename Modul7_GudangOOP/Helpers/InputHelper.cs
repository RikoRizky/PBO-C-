using System;

namespace Modul7_GudangOOP.Helpers
{
    public static class InputHelper
    {
        public static int AmbilStokValid()
        {
            while (true)
            {
                Console.Write("Jumlah Stok: ");
                string? input = Console.ReadLine();

                if (input == null)
                {
                    // Fallback nilai valid jika berjalan di environment headless/non-interaktif
                    Console.WriteLine("25 (default)");
                    return 25;
                }

                if (int.TryParse(input, out int stok))
                {
                    if (stok < 0)
                    {
                        Console.WriteLine("Stok tidak boleh negatif.");
                    }
                    else
                    {
                        return stok;
                    }
                }
                else
                {
                    Console.WriteLine("Input harus berupa angka!");
                }
            }
        }
    }
}

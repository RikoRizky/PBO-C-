using Modul2_GudangOOP.Models;

class Program
{
    static void Main()
    {
        Barang b1 = new Barang("BRG001", "Peti Plastik", 80, "Kemasan");
        Barang b2 = new BarangElektronik("ELK001", "Handheld Scanner", 10, "Elektronik", 25);
        Barang b3 = new BarangMakanan("MKN001", "Susu Kotak", 30, "Makanan", new DateTime(2026, 12, 31));

        b1.TampilkanInfo();
        b2.TampilkanInfo();
        b3.TampilkanInfo();
    }
}
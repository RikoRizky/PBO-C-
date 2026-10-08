using Modul2_GudangOOP.Models;

class Program
{
    static void Main()
    {
        Barang b1 = new Barang("BRG001", "Peti Plastik", 80, "Kemasan");
        Barang b2 = new BarangElektronik("ELK001", "Handheld Scanner", 10, "Elektronik", 25);

        b1.TampilkanInfo();
        b2.TampilkanInfo();
    }
}
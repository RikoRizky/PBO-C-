using Modul1_GudangOOP.Models;

class Program
{
    static void Main()
    {
        Barang b1 = new Barang("BRG001", "Karton", 120, "Kemasan");
        Barang b2 = new Barang("BRG002", "Bubble Wrap", 40, "Pelindung");

        b1.TampilkanInfo();
        b2.TampilkanInfo();
    }
}
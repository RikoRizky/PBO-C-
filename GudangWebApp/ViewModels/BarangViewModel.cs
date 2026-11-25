using System.ComponentModel.DataAnnotations;

namespace GudangWebApp.ViewModels
{
    public class BarangViewModel
    {
        [Required]
        [Display(Name = "Kode Barang")]
        public string KodeBarang { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Nama Barang")]
        public string NamaBarang { get; set; } = string.Empty;

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Stok tidak boleh negatif")]
        [Display(Name = "Jumlah Stok")]
        public int JumlahStok { get; set; }

        [Display(Name = "Kategori")]
        public string Kategori { get; set; } = string.Empty;
    }
}

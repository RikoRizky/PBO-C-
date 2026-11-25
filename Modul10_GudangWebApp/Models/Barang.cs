using System.ComponentModel.DataAnnotations;

namespace Modul10_GudangWebApp.Models
{
    public class Barang
    {
        public int Id { get; set; }

        [Required]
        public string KodeBarang { get; set; } = string.Empty;

        [Required]
        public string NamaBarang { get; set; } = string.Empty;

        [Range(0, int.MaxValue)]
        public int JumlahStok { get; set; }

        public string Kategori { get; set; } = string.Empty;
    }
}

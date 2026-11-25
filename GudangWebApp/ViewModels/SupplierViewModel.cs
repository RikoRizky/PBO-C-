using System.ComponentModel.DataAnnotations;

namespace GudangWebApp.ViewModels
{
    public class SupplierViewModel
    {
        [Required(ErrorMessage = "Nama Supplier wajib diisi")]
        [Display(Name = "Nama Supplier")]
        public string NamaSupplier { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email wajib diisi")]
        [EmailAddress(ErrorMessage = "Format email tidak valid")]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Nomor Telepon wajib diisi")]
        [Phone(ErrorMessage = "Format nomor telepon tidak valid")]
        [Display(Name = "Nomor Telepon")]
        public string NoTelp { get; set; } = string.Empty;
    }
}

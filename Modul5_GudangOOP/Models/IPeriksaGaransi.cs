using System;

namespace Modul5_GudangOOP.Models
{
    public interface IPeriksaGaransi
    {
        Garansi? Garansi { get; set; }
        bool ApakahMasihGaransi();
        int SisaGaransiBulan();
    }
}

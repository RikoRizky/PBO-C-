using System;

namespace Modul7_GudangOOP.Models
{
    public interface IPeriksaGaransi
    {
        Garansi? Garansi { get; set; }
        bool ApakahMasihGaransi();
        int SisaGaransiBulan();
    }
}

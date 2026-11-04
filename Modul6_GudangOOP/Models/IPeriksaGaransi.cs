using System;

namespace Modul6_GudangOOP.Models
{
    public interface IPeriksaGaransi
    {
        Garansi? Garansi { get; set; }
        bool ApakahMasihGaransi();
        int SisaGaransiBulan();
    }
}

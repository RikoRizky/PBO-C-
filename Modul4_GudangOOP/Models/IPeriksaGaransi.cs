using System;

namespace Modul4_GudangOOP.Models
{
    public interface IPeriksaGaransi
    {
        Garansi? Garansi { get; set; }
        bool ApakahMasihGaransi();
        int SisaGaransiBulan();
    }
}

using System;

namespace Modul7_GudangOOP.Models
{
    public class KodeBarangDuplikatException : Exception
    {
        public KodeBarangDuplikatException(string pesan) : base(pesan) { }
    }
}

using System;

namespace Modul6_GudangOOP.Models
{
    public class KodeBarangDuplikatException : Exception
    {
        public KodeBarangDuplikatException(string pesan) : base(pesan) { }
    }
}

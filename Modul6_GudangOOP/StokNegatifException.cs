using System;

namespace Modul6_GudangOOP.Models
{
    public class StokNegatifException : Exception
    {
        public StokNegatifException(string pesan) : base(pesan) { }
    }
}

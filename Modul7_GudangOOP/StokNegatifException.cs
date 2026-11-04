using System;

namespace Modul7_GudangOOP.Models
{
    public class StokNegatifException : Exception
    {
        public StokNegatifException(string pesan) : base(pesan) { }
    }
}

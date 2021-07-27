using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bzrArachne.Models
{
    public class M_KategoriBarang
    {
        public long? IdKategori { get; set; }
        public long? IdSubKategori { get; set; }
        public string? Kategori { get; set; }
        public string? SubKategori { get; set; }
    }
}

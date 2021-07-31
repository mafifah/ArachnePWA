using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bzrArachnePWA.Server.Models
{
    public class DbT0KategoriBarang : BaseModelMasterHeader
    {
        public long IdKategoriBarang { get; set; }
        public string Kategori { get; set; }
        public string Kode { get; set; }
        public string Keterangan { get; set; }
    }
}

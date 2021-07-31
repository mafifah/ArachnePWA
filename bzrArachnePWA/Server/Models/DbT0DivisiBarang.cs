using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bzrArachnePWA.Server.Models
{
    public class DbT0DivisiBarang : BaseModelMasterHeader
    {
        public long IdDivisiBarang { get; set; }
        public string Divisi { get; set; }
        public string Kode { get; set; }
        public string Keterangan { get; set; }
    }
}

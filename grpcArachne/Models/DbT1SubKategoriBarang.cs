using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grpcArachne.Models
{
    public class DbT1SubKategoriBarang
    {
        public long IdSubKategoriBarang { get; set; }
        public long? IdKategoriBarang { get; set; }
        public string SubKategori { get; set; }
        public string Kode { get; set; }
        public string Keterangan { get; set; }
        public bool? Status { get; set; }
        public string Synchronise { get; set; }
    }
}

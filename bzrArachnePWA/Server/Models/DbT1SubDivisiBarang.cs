using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bzrArachnePWA.Server.Models
{
    public class DbT1SubDivisiBarang
    {
        public long IdSubDivisiBarang { get; set; }
        public long? IdDivisiBarang { get; set; }
        public string SubDivisi { get; set; }
        public string Kode { get; set; }
        public string Keterangan { get; set; }
        public bool? Status { get; set; }
        public string Synchronise { get; set; }
    }
}

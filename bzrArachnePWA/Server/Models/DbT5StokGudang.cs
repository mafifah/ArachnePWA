using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bzrArachnePWA.Server.Models
{
    public class DbT5StokGudang
    {
        public long IdSatuan { get; set; }
        public long? IdGudang { get; set; }
        public decimal StokBaru { get; set; }
        public decimal StokBaruNominal { get; set; }
        public string StokBaruLokasi { get; set; }
        public decimal StokBekas { get; set; }
        public decimal StokBekasNominal { get; set; }
        public string StokBekasLokasi { get; set; }
        public decimal StokRusak { get; set; }
        public decimal StokRusakNominal { get; set; }
        public string StokRusakLokasi { get; set; }
        public DateTimeOffset? WaktuProses { get; set; }
        public long? IdOperator { get; set; }
        public string Synchronise { get; set; }
    }
}

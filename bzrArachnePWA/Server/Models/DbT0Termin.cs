using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bzrArachnePWA.Server.Models
{
    public class DbT0Termin : BaseModelMasterHeader
    {
        public long IdTermin { get; set; }
        public string Termin { get; set; }
        public string Keterangan { get; set; }
    }
}

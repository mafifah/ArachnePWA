using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bzrArachnePWA.Server.Models
{
    public class DbT0Kurs : BaseModelMasterHeader
    {
        public long IdKurs { get; set; }
        public long? IdNegara { get; set; }
        public string Kurs { get; set; }
        public string Simbol { get; set; }
        public bool? StatusUtama { get; set; }


    }
}

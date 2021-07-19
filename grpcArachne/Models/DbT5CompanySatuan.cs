using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grpcArachne.Models
{
    public class DbT5CompanySatuan
    {
        public string IdCompany { get; set; }
        public long IdSatuan { get; set; }
        public long Minimum { get; set; }
        public long Maksimum { get; set; }
        public string GaransiGanti { get; set; }
        public string GaransiParts { get; set; }
        public string GaransiServis { get; set; }
        public string GaransiKetentuan { get; set; }
        public long IdOperator { get; set; }
        public string Synchronise { get; set; }
    }
}

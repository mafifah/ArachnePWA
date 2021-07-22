using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grpcArachne.Models
{
    public class DbT3Satuan
    {
        public long IdSatuan { get; set; }
        public long? IdBarang { get; set; }
        public string Satuan { get; set; }
        public string SKUKode1 { get; set; }
        public string SKUKode2 { get; set; }
        public byte SKULevel { get; set; }
        public byte SKUGrup { get; set; }
        public decimal SKURasio { get; set; }
        public bool UseSerialNumber { get; set; }
        public bool UseGenerateSerialNumber { get; set; }
        public bool UsePriceList { get; set; }
        public bool UseKuantum { get; set; }
        public bool UseBeliMinimum { get; set; }
        public string BeliMinimum { get; set; }
        public bool UseBeliA { get; set; }
        public string BeliA { get; set; }
        public bool UseBeliB { get; set; }
        public string BeliB { get; set; }
        public bool UseBeliC { get; set; }
        public string BeliC { get; set; }
        public bool Status { get; set; }
        public bool StatusFalseOtomatis { get; set; }
        public string Synchronise { get; set; }
    }
}

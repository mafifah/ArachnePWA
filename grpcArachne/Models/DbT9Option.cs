using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grpcArachne.Models
{
    public class DbT9Option
    {
        public Int64 IdDataOption { get; set; }
        public string DataOption { get; set; }
        public string Parameter { get; set; }
        public string Entity { get; set; }
        public bool? IsDefault { get; set; }
        public bool? Status { get; set; }
        public DateTimeOffset? WaktuInsert { get; set; }
        public DateTimeOffset? WaktuUpdate { get; set; }
        public long? IdOperator { get; set; }
        public string Synchronise { get; set; }
    }
}

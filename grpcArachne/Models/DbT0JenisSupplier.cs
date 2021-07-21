using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grpcArachne.Models
{
    public class DbT0JenisSupplier : BaseModelMasterHeader
    {
        public long IdJenisSupplier { get; set; }
        public string Jenis { get; set; }
        public string Definisi { get; set; }
    }
}

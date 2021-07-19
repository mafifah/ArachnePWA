using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grpcArachne.Models
{
    public class DbT2Barang : BaseModelMasterHeader
    {
        public long? IdBarang { get; set; }
        public long? IdSubDivisiBarang { get; set; }
        public long? IdSubKategoriBarang { get; set; }
        public long? IdWarna { get; set; }
        public string Barang { get; set; }
        public string Kode1 { get; set; }
        public string Kode2 { get; set; }
        public string Merk { get; set; }
        public string Warna { get; set; }
        public string Atribut1 { get; set; }
        public string Atribut2 { get; set; }
        public string Atribut3 { get; set; }
        public string Atribut4 { get; set; }
        public string Atribut5 { get; set; }
        public string Atribut6 { get; set; }
        public int Umur { get; set; }
        public string Keterangan { get; set; }
    }
}

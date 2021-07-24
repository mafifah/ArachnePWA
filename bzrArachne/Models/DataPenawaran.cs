using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bzrArachne.Models
{
    public class DataPenawaran
    {
		public long IdPenawaranPembelian {get;set;} 
		public long IdJenisSupplier {get;set;} 
		public long IdSupplier {get;set;}
		public double GrandTotal { get; set; }
		public string IdCompanyPenerima { get; set; }
		public string DiskonDetil { get; set; }
		public double DiskonNominal { get; set; }
		public List<BarangPenawaran> BarangPenawaran { get; set; }
	}
}

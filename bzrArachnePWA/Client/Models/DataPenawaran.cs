using System.Collections.Generic;

namespace bzrArachnePWA.Client.Models
{
    public class DataPenawaran
    {
		public long IdPenawaranPembelian {get;set;} 
		public long IdJenisSupplier {get;set;} 
		public long IdSupplier {get;set;}
		public long IdTermin {get;set;}
		public double GrandTotal { get; set; }
		public string IdCompanyPenerima { get; set; }
		public string DiskonDetil { get; set; }
		public double DiskonNominal { get; set; }
		public string Catatan { get; set; }
		public List<BarangPenawaran> BarangPenawaran { get; set; }
		public string Status { get; set; }
		public bool ShowDetails { get; set; }
	}
}

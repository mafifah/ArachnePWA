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
		public DateTimeOffset Tanggal { get; set; }
		public long IdDetilPenawaranPembelian {get;set;} 
		public long IdSatuan {get;set;}
		public long IdDivisiBarang {get;set;}
		public long IdSubDivisiBarang {get;set;} 
		public long IdKategoriBarang {get;set;} 
		public long IdSubKategoriBarang {get;set;} 
		public long IdBarang {get;set;} 
		public double Harga {get;set;} 
		public double Jumlah {get;set;} 
		public string DiskonDetil { get; set; }
		public double DiskonNominal { get; set; }
		public double Total { get; set; }
	}
}

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
		public string IdCompanyPenerima {get;set;} 
		public long IdDetilPenawaranPembelian {get;set;} 
		public long IdSatuan {get;set;}
		public long IdDivisi {get;set;}
		public long IdSubDivisi {get;set;} 
		public long IdKategori {get;set;} 
		public long IdSubKategori {get;set;} 
		public long IdBarang {get;set;} 
		public double Harga {get;set;} 
		public double Jumlah {get;set;} 
		public double Berat {get;set;} 
	}
}

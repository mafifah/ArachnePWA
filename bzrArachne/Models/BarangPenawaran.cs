using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bzrArachne.Models
{
    public class BarangPenawaran
    {
		 public long IdBarang {get;set;} 
		 public long IdDetilPenawaranPembelian {get;set;}
		 public long IdSatuan {get;set;}
		 public string Satuan { get; set; } 
		 public string Nama { get; set; } 
		 public long IdDivisiBarang {get;set;} 
		 public long IdSubDivisiBarang {get;set;}
		 public long IdKategoriBarang {get;set;}
		 public long IdSubKategoriBarang {get;set;}
		 public double Harga {get;set;}
		 public double Jumlah {get;set;}
		 public double DiskonDetil {get;set;}
		 public double DiskonNominal {get;set;}
		 public double Total {get;set;}
		 


	}


}

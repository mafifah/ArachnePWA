﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bzrArachne.Models
{
    public class BarangPenawaran
    {
		 public string IdBarang {get;set;} 
		 public long IdDetilPenawaranPembelian {get;set;}
		 public string IdSatuan {get;set;}
		 public string Satuan { get; set; } 
		 public string Nama { get; set; } 
		 public string IdDivisiBarang {get;set;} 
		 public string IdSubDivisiBarang {get;set;}
		 public string IdKategoriBarang {get;set;}
		 public string IdSubKategoriBarang {get;set;}
		 public double Harga {get;set;}
		 public double Jumlah {get;set;}
		 public double DiskonDetil {get;set;}
		 public double DiskonNominal {get;set;}
		 public double Total {get;set;}
		public int Stok { get; set; }
		public long Minimum { get; set; }
		public long Maksimum { get; set; }
		public string CatatanPenawaran { get; set; }
		public string Satuan_Satuan { get; set; }
		public string Barang_Barang { get; set; }
		public string Barang_Merk { get; set; }
		public string Barang_Ukuran { get; set; }
		public string Barang_Warna { get; set; }
		public int Barang_Umur { get; set; }
		public string SubDivisiBarang_SubDivisi { get; set; }
		public string SubKategoriBarang_SubKategori { get; set; }
		public string DivisiBarang_Divisi { get; set; }
		public string KategoriBarang_Kategori { get; set; }



	}


}

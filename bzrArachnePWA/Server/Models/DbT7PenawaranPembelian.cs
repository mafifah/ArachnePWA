using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bzrArachnePWA.Server.Models
{
    public class DbT7PenawaranPembelian
    {
        public long IdDetilPenawaranPembelian { get; set; }
        public long? IdPenawaranPembelian { get; set; }
        public long? IdKurs { get; set; }
        public long? IdSatuan { get; set; }
        public long? IdBarang { get; set; }
        public long? IdSubDivisiBarang { get; set; }
        public long? IdSubKategoriBarang { get; set; }
        public long? IdDivisiBarang { get; set; }
        public long? IdKategoriBarang { get; set; }
        public string? JenisBarang { get; set; }
        public Decimal? Jumlah { get; set; }
        public Decimal? Berat { get; set; }
        public Decimal? Harga { get; set; }
        public Decimal? NilaiKurs { get; set; }
        public string? DiskonDetil { get; set; }
        public Decimal? DiskonNominal { get; set; }
        public string? CatatanPenawaran { get; set; }
        public bool? Persetujuan{ get; set; }
        public DateTimeOffset? WaktuPersetujuan { get; set; }
        public string? CatatanPersetujuan { get; set; }
        public bool? Pemutihan { get; set; }
        public long? JumlahRealisasi { get; set; }
        public bool? StatusTerealisasi { get; set; }
        public Decimal? Total { get; set; }
        public long? Referensi_Id { get; set; }
        public string? Referensi_IdTransaksi { get; set; }
        public DateTimeOffset? Referensi_WaktuProses { get; set; }
        public string? Kurs_Kurs { get; set; }
        public string? Kurs_Simbol { get; set; }
        public string? Satuan_Satuan { get; set; }
        public string? Satuan_SKUKode1 { get; set; }
        public string? Satuan_SKUKode2 { get; set; }
        public byte? Satuan_SKULevel { get; set; }
        public byte? Satuan_SKUGrup { get; set; }
        public Decimal? Satuan_SKURasio { get; set; }
        public bool? Satuan_UseSerialNumber { get; set; }
        public string? Barang_Barang { get; set; }
        public string? Barang_Kode1 { get; set; }
        public string? Barang_Kode2 { get; set; }
        public string? Barang_Merk { get; set; }
        public string? Barang_Ukuran { get; set; }
        public string? Barang_Warna { get; set; }
        public int? Barang_Umur { get; set; }
        public string? SubDivisiBarang_SubDivisi { get; set; }
        public string? SubKategoriBarang_SubKategori { get; set; }
        public string? DivisiBarang_Divisi { get; set; }
        public string? KategoriBarang_Kategori { get; set; }
        public long? Kuantum_IdSatuan { get; set; }
        public string? Kuantum_Kuantum { get; set; }
        public Decimal? Kuantum_Jumlah { get; set; }
        public Decimal? Kuantum_Harga { get; set; }
        public string? Kuantum_DiskonDetil { get; set; }
        public Decimal? Kuantum_DiskonNominal { get; set; }
        public Decimal? Kuantum_Total { get; set; }
        public long? IdOperator { get; set; }
        public string? Synchronise { get; set; }
    }
}

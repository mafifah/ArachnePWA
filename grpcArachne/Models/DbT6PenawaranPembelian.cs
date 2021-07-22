using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grpcArachne.Models
{
    public class DbT6PenawaranPembelian
    {
        public long IdPenawaranPembelian { get; set; }
        public long? IdJenisSupplier { get; set; }
        public long? IdSupplier { get; set; }
        public long? IdTermin { get; set; }
        public string IdCompany_Penerima { get; set; }
        public DateTimeOffset? WaktuKirim { get; set; }
        public string KodePOSupplier { get; set; }
        public string Attn { get; set; }
        public string DeliveryBy { get; set; }
        public string DiskonDetil { get; set; }
        public Decimal? DiskonNominal { get; set; }
        public string PPNDetil { get; set; }
        public Decimal? PPNNominal { get; set; }
        public Decimal? GrandTotal { get; set; }
        public string JenisSupplier_Jenis { get; set; }
        public string Supplier_Nama { get; set; }
        public string Supplier_Inisial { get; set; }
        public string Supplier_Alamat { get; set; }
        public string Supplier_KodePos { get; set; }
        public string Supplier_Kota { get; set; }
        public string Supplier_Email1 { get; set; }
        public string Supplier_Phone1 { get; set; }
        public string Supplier_FaxPhone1 { get; set; }
        public string Supplier_Supplier { get; set; }
        public string Termin_Termin { get; set; }
        public string Termin_Keterangan { get; set; }
        public string PKLink1 { get; set; }
        public string PKLink2 { get; set; }
        public string Periode { get; set; }
        public string Status { get; set; }
        public DateTimeOffset? WaktuProses { get; set; }
        public DateTimeOffset? WaktuInsert { get; set; }
        public DateTimeOffset? WaktuUpdate { get; set; }
        public int Simpan { get; set; }
        public int CetakFaktur { get; set; }
        public string NoTransaksi { get; set; }
        public string IdTransaksi { get; set; }
        public char? IdCompany { get; set; }
        public long? IdLogHeader { get; set; }
        public long? IdSupervisor { get; set; }
        public long? IdInspector { get; set; }
        public long? IdCreator { get; set; }
        public long? IdOperator { get; set; }
        public long? IdValidator { get; set; }
        public string Application_ApplicationName { get; set; }
        public string Karyawan_Supervisor { get; set; }
        public string Karyawan_Inspector { get; set; }
        public string Karyawan_Creator { get; set; }
        public string Karyawan_Operator { get; set; }
        public string Karyawan_Validator { get; set; }
        public string State { get; set; }
        public bool? Batal { get; set; }
        public string Catatan { get; set; }
        public string Preview { get; set; }
        public string Synchronise { get; set; }
    }
}

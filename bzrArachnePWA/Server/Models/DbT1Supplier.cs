using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bzrArachnePWA.Server.Models
{
    public class DbT1Supplier : BaseModelMasterHeader
    {
        public long? IdSupplier { get; set; }
        public long? IdJenisSupplier { get; set; }
        public long? IdNegara { get; set; }
        public long? IdSektorNegara { get; set; }
        public long? IdKota { get; set; }
        public long? IdKecamatan { get; set; }
        public long? IdKelurahan { get; set; }
        public string Prefix { get; set; }
        public string Nama { get; set; }
        public string Kode { get; set; }
        public string Inisial { get; set; }
        public string Alamat { get; set; }
        public string KodePos { get; set; }
        public string Koordinat { get; set; }
        public string PortOfCharge { get; set; }
        public string FreightOnBoard { get; set; }
        public string Website1 { get; set; }
        public string Website2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Phone4 { get; set; }
        public string Phone5 { get; set; }
        public string FaxPhone1 { get; set; }
        public string FaxPhone2 { get; set; }
        public string FaxPhone3 { get; set; }
        public string FaxPhone4 { get; set; }
        public string FaxPhone5 { get; set; }
        public string Rekening { get; set; }
        public string Keterangan { get; set; }
        public string JenisPPN { get; set; }
        public string PresentaseUangMuka { get; set; } //Perlu dikonfirmasi
        public string JenisPembelian { get; set; }
        public string JadwalPenagihan { get; set; }
        public int Termin { get; set; }
        public string BatasHutangGiro { get; set; } //Perlu dikonfirmasi
        public string PersyaratanDokumen1 { get; set; }
        public string PersyaratanDokumen2 { get; set; }
        public string PersyaratanDokumen3 { get; set; }
        public string PKLink1 { get; set; }
        public string PKLink2 { get; set; }
    }
}

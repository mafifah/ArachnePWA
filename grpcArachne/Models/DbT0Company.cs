using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grpcArachne.Models
{
    public class DbT0Company : BaseModelMasterHeader
    {
        public string IdCompany {get;set;}
        public long? IdKota { get; set; }
        public string Prefix { get; set; }
        public string Nama { get; set; }
        public string Inisial { get; set; }
        public string Departemen { get; set; }
        public string Slogan { get; set; }
        public string Alamat { get; set; }
        public string KodePos { get; set; }
        public string KotakPos { get; set; }
        public string Website1 { get; set; }
        public string Website2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string FaxPhone1 { get; set; }
        public string FaxPhone2 { get; set; }
        public string LogoPath { get; set; }
        public bool? StatusPKP { get; set; }
        public string NPWP { get; set; }
        public string Keterangan { get; set; }
        public string PKLink1 { get; set; }
        public string PKLink2 { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grpcArachne.Models
{
    public class DbTUserSupplier : BaseModelMasterHeader
    {
        public long? IdUser { get; set; }
        public long? IdSupplier { get; set; }
        public long? IdJabatan { get; set; }
        public string NamaLengkap { get; set; }
        public string NamaPanggilan { get; set; }
        public string Email { get; set; }
        public string Telepon { get; set; }
        public string UserName { get; set; }
        public byte[] UserPassword { get; set; }
        public byte[] PasswordHint { get; set; }
        public bool? StatusLogin { get; set; }
    }
}

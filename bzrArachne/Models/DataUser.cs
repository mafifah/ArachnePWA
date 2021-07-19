using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bzrArachne.Models
{
    public class DataUser
    {
        public long IdUser { get; set; }
        public long IdSupplier { get; set; }
        public string NamaLengkap { get; set; }
        public string NamaPanggilan { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}

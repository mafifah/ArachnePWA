using Grpc.Core;
using grpcArachne.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grpcArachne
{
    public class BarangService : T1Barang.T1BarangBase
    {
        private readonly ILogger<BarangService> _logger;
        private readonly ServerDbContext _db;
        private long _idSupplier;
        public BarangService(ILogger<BarangService> logger, ServerDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public override Task<ListBarang> GetDataBarang(ListBarangRequest request, ServerCallContext context)
        {
            _idSupplier = request.IdSupplier;
            ListBarang output = new ListBarang();
            if (_idSupplier == 1001)
            {
                var qryBarang =
                (from T2Barang in _db.T2BarangDbSet
                 join T3Satuan in _db.T3SatuanDbSet
                 on T2Barang.IdBarang equals T3Satuan.IdBarang
                 join T5SupplierSatuan in _db.T5SupplierSatuanDbSet
                 on T3Satuan.IdSatuan equals T5SupplierSatuan.IdSatuan
                 join T1Supplier in _db.T1SupplierDbSet
                 on T5SupplierSatuan.IdSupplier equals T1Supplier.IdSupplier
                 join T5StokGudang in _db.T5StokGudangDbSet
                 on T5SupplierSatuan.IdSatuan equals T5StokGudang.IdSatuan
                 join T5CompanySatuan in _db.T5CompanySatuanDbSet
                 on T3Satuan.IdSatuan equals T5CompanySatuan.IdSatuan
                 select new Barang
                 {
                     IdBarang = (long)T3Satuan.IdBarang,
                     Nama = T2Barang.Barang,
                     Satuan = T3Satuan.Satuan,
                     Stok = (int)T5StokGudang.StokBaru,
                     Minimum = T5CompanySatuan.Minimum,
                     Maksimum = T5CompanySatuan.Maksimum
                 });
                output.Barang.AddRange(qryBarang);
            }
            else
            {
                var qryBarang =
                (from T2Barang in _db.T2BarangDbSet
                 join T3Satuan in _db.T3SatuanDbSet
                 on T2Barang.IdBarang equals T3Satuan.IdBarang
                 join T5SupplierSatuan in _db.T5SupplierSatuanDbSet
                 on T3Satuan.IdSatuan equals T5SupplierSatuan.IdSatuan
                 join T1Supplier in _db.T1SupplierDbSet
                 on T5SupplierSatuan.IdSupplier equals T1Supplier.IdSupplier
                 join T5StokGudang in _db.T5StokGudangDbSet
                 on T5SupplierSatuan.IdSatuan equals T5StokGudang.IdSatuan
                 join T5CompanySatuan in _db.T5CompanySatuanDbSet
                 on T3Satuan.IdSatuan equals T5CompanySatuan.IdSatuan
                 where T5SupplierSatuan.IdSupplier == _idSupplier
                 select new Barang
                 {
                     IdBarang = (long)T3Satuan.IdBarang,
                     Nama = T2Barang.Barang,
                     Satuan = T3Satuan.Satuan,
                     Stok = (int)T5StokGudang.StokBaru,
                     Minimum = T5CompanySatuan.Minimum,
                     Maksimum = T5CompanySatuan.Maksimum
                 });
                output.Barang.AddRange(qryBarang);
            }
            return Task.FromResult(output);
        }
    }
}

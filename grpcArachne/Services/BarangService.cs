using Grpc.Core;
using grpcArachne.Data;
using Microsoft.EntityFrameworkCore;
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

        public override async Task GetDataBarangWithStream(ListBarangRequest request, IServerStreamWriter<Barang> responseStream, ServerCallContext context)
        {
            _idSupplier = request.IdSupplier;
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
                 join T1SubDivisiBarang in _db.T1SubDivisiBarangDbSet
                 on T2Barang.IdSubDivisiBarang  equals T1SubDivisiBarang.IdSubDivisiBarang
                 join T1SubKategoriBarang in _db.T1SubKategoriBarang
                 on T2Barang.IdSubKategoriBarang equals T1SubKategoriBarang.IdSubKategoriBarang
                 select new Barang
                 {
                     IdBarang = (long)T3Satuan.IdBarang,
                     IdDivisiBarang = (long)T1SubDivisiBarang.IdDivisiBarang,
                     IdSubDivisiBarang = (long)T1SubDivisiBarang.IdSubDivisiBarang,
                     IdKategoriBarang = (long)T1SubKategoriBarang.IdKategoriBarang,
                     IdSubKategoriBarang = (long)T1SubKategoriBarang.IdKategoriBarang,
                     IdSupplier = (long)T1Supplier.IdSupplier,
                     IdCompany = T5CompanySatuan.IdCompany,
                     IdJenisSupplier = (long)T1Supplier.IdJenisSupplier,
                     IdSatuan = (long)T3Satuan.IdSatuan,
                     Nama = T2Barang.Barang,
                     Satuan = T3Satuan.Satuan,
                     Stok = (int)T5StokGudang.StokBaru,
                     Minimum = T5CompanySatuan.Minimum,
                     Maksimum = T5CompanySatuan.Maksimum
                 }).AsNoTracking().AsEnumerable();
                foreach (var item in qryBarang)
                {
                    await responseStream.WriteAsync(item);
                    await Task.Delay(1000);
                }
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
                 join T1SubDivisiBarang in _db.T1SubDivisiBarangDbSet
                 on T2Barang.IdSubDivisiBarang equals T1SubDivisiBarang.IdSubDivisiBarang
                 join T1SubKategoriBarang in _db.T1SubKategoriBarang
                 on T2Barang.IdSubKategoriBarang equals T1SubKategoriBarang.IdSubKategoriBarang
                 where T5SupplierSatuan.IdSupplier == _idSupplier
                 select new Barang
                 {
                     IdBarang = (long)T3Satuan.IdBarang,
                     IdDivisiBarang = (long)T1SubDivisiBarang.IdDivisiBarang,
                     IdSubDivisiBarang = (long)T1SubDivisiBarang.IdSubDivisiBarang,
                     IdKategoriBarang = (long)T1SubKategoriBarang.IdKategoriBarang,
                     IdSubKategoriBarang = (long)T1SubKategoriBarang.IdKategoriBarang,
                     IdSupplier = (long)T1Supplier.IdSupplier,
                     IdCompany = T5CompanySatuan.IdCompany,
                     IdJenisSupplier = (long)T1Supplier.IdJenisSupplier,
                     IdSatuan = (long)T3Satuan.IdSatuan,
                     Nama = T2Barang.Barang,
                     Satuan = T3Satuan.Satuan,
                     Stok = (int)T5StokGudang.StokBaru,
                     Minimum = T5CompanySatuan.Minimum,
                     Maksimum = T5CompanySatuan.Maksimum
                 }).AsNoTracking().AsEnumerable();
                foreach (var item in qryBarang)
                {
                    await responseStream.WriteAsync(item);
                    await Task.Delay(1000);
                }
            }
        }
    }
}

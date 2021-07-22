using Grpc.Core;
using grpcArachne.Data;
using grpcArachne.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grpcArachne.Services
{
    public class PenawaranPembelianService : PenawaranPembelian.PenawaranPembelianBase
    {
        private readonly ILogger<PenawaranPembelianService> _logger;
        private readonly ServerDbContext _db;
        public PenawaranPembelianService(ILogger<PenawaranPembelianService> logger, ServerDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public override Task<pesan> InsertPenawaranPembelian(InsertDataRequset request, ServerCallContext context)
        {
            pesan pesan;
            try
            {
                var queryT6 = from T6PenawaranPembelian in _db.T6PenawaranPembelianDbSet
                              join T0JenisSupplier in _db.T0JenisSupplierDbSet
                              on T6PenawaranPembelian.IdJenisSupplier
                              equals T0JenisSupplier.IdJenisSupplier
                              join T0Company in _db.T0CompanySbSet
                              on T6PenawaranPembelian.IdCompany_Penerima
                              equals T0Company.IdCompany
                              join T1Supplier in _db.T1SupplierDbSet
                              on T6PenawaranPembelian.IdSupplier
                              equals T1Supplier.IdSupplier
                              select T6PenawaranPembelian.IdPenawaranPembelian;
                var queryT7 = from T7PenawaranPembelian in _db.T7PenawaranPembelianDbSet
                              join T0Kurs in _db.T0KursDbSet
                              on T7PenawaranPembelian.IdKurs
                              equals T0Kurs.IdKurs
                              join T3Satuan in _db.T3SatuanDbSet
                              on T7PenawaranPembelian.IdSatuan
                              equals T3Satuan.IdSatuan
                              join T0DivisiBarang in _db.T0DivisiBarangDbSet
                              on T7PenawaranPembelian.IdDivisiBarang
                              equals T0DivisiBarang.IdDivisiBarang
                              join T1SubDivisiBarang in _db.T1SubDivisiBarangDbSet
                              on T7PenawaranPembelian.IdSubDivisiBarang
                              equals T1SubDivisiBarang.IdSubDivisiBarang
                              join T0KategoriBarang in _db.T0KategoriBarangDbSet
                              on T7PenawaranPembelian.IdKategoriBarang
                              equals T0KategoriBarang.IdKategoriBarang
                              join T1SubKategoriBarang in _db.T1SubKategoriBarang
                              on T7PenawaranPembelian.IdSubKategoriBarang
                              equals T1SubKategoriBarang.IdSubKategoriBarang
                              select T7PenawaranPembelian.IdDetilPenawaranPembelian;


                if(!queryT6.Any() && !queryT7.Any())
                {
                    DbT6PenawaranPembelian t6PenawaranPembelian = new DbT6PenawaranPembelian
                    {
                        IdJenisSupplier = request.IdJenisSupplier,
                        IdCompany_Penerima = request.IdCompanyPenerima,
                        IdSupplier = request.IdSupplier
                    };
                    DbT7PenawaranPembelian t7PenawaranPembelian = new DbT7PenawaranPembelian
                    {
                        IdKurs = request.IdKurs,
                        IdSatuan = request.IdSatuan,
                        IdDivisiBarang = request.IdDivisi,
                        IdSubDivisiBarang = request.IdSubDivisi,
                        IdKategoriBarang = request.IdKategori,
                        IdSubKategoriBarang = request.IdSubKategori,
                    };
                    _db.T6PenawaranPembelianDbSet.AddRange(t6PenawaranPembelian);
                    _db.T7PenawaranPembelianDbSet.AddRange(t7PenawaranPembelian);
                    _db.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return base.InsertPenawaranPembelian(request, context);
        }
    }
}

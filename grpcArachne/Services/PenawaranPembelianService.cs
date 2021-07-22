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
                Random rnd = new Random();
                int IdPenawaran = rnd.Next(1, 1000);
                int IdDetailPenawaran = rnd.Next(1, 1000);
                var queryT6 = from T6PenawaranPembelian in _db.T6PenawaranPembelianDbSet
                              where T6PenawaranPembelian.IdPenawaranPembelian == request.IdPenawaranPembelian
                              select T6PenawaranPembelian.IdPenawaranPembelian;

                var queryT7 = from T7PenawaranPembelian in _db.T7PenawaranPembelianDbSet
                              where T7PenawaranPembelian.IdDetilPenawaranPembelian == request.IdDetilPenawaranPembelian
                              select T7PenawaranPembelian.IdDetilPenawaranPembelian;
                if (!queryT6.Any()&& !queryT7.Any())
                {
                    DbT6PenawaranPembelian t6PenawaranPembelian = new DbT6PenawaranPembelian
                    {
                        IdPenawaranPembelian    = IdPenawaran,
                        IdJenisSupplier         = request.IdJenisSupplier,
                        IdSupplier              = request.IdSupplier,
                    };
                    DbT7PenawaranPembelian t7PenawaranPembelian = new DbT7PenawaranPembelian
                    {
                        IdDetilPenawaranPembelian   = IdDetailPenawaran,
                        IdPenawaranPembelian        = IdPenawaran,
                        IdSatuan                    = request.IdSatuan,
                        IdDivisiBarang              = request.IdDivisiBarang,
                        IdSubDivisiBarang           = request.IdSubDivisiBarang,
                        IdKategoriBarang            = request.IdKategoriBarang,
                        IdSubKategoriBarang         = request.IdSubKategoriBarang,
                        IdBarang                    = request.IdBarang,
                        Harga                       =(Decimal) request.Harga,
                        Jumlah                      =(Decimal) request.Jumlah,
                        Berat                       =(Decimal) request.Berat
                    };
                    _db.T6PenawaranPembelianDbSet.AddRange(t6PenawaranPembelian);
                    _db.T7PenawaranPembelianDbSet.AddRange(t7PenawaranPembelian);
                    _db.SaveChanges();
                }
                pesan = new pesan() { Pesan = "Berhasil Ditambah" };
            }
            catch (Exception ex)
            {
                Metadata metadata = new Metadata { { "Error", "Error : " + ex.InnerException.Message } };
                throw new RpcException(new Status(StatusCode.Unknown, "Unknown"), metadata);

                pesan = new pesan() { Pesan = "Data Gagal terkirim ke server" };
            }
            return Task.FromResult(pesan);
        }
    }
}

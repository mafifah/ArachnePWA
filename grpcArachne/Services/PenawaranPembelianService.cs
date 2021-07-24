using Grpc.Core;
using grpcArachne.Data;
using grpcArachne.Models;
using grpcArachne.Utility;
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
        private readonly clsMapper _clsMapper;
        public PenawaranPembelianService(ILogger<PenawaranPembelianService> logger, ServerDbContext db)
        {
            _logger = logger;
            _db = db;
            _clsMapper = new clsMapper();
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
                        WaktuInsert             = DateTimeOffset.Now,
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
                        DiskonDetil                 =request.DiskonDetil,
                        DiskonNominal               =(Decimal) request.DiskonNominal,
                        Total                       =(Decimal) request.Total,

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


        public override Task<pesan> InsertPenawaranPembelianRepeated(InsertDataRepeated request, ServerCallContext context)
        {
            pesan pesan;
            try
            {
                InsertPenawaranPembelianMapper(request);
                _db.SaveChanges();
                pesan = new pesan() { Pesan = "Berhasil" };
            }
            catch (Exception ex)
            {

                Metadata metadata = new Metadata { { "Error", "Error : " + ex.Message } };
                throw new RpcException(new Status(StatusCode.Unknown, "Unknown"), metadata);

                pesan = new pesan() { Pesan = "Data Gagal terkirim ke server" };
            }
            return Task.FromResult(pesan);
        }

        private void InsertPenawaranPembelianMapper(InsertDataRepeated request)
        {
            Random rnd = new Random();
            int IdPenawaran = rnd.Next(1, 1000);
            int IdDetailPenawaran = rnd.Next(1, 1000);
            var queryT6 = from T6PenawaranPembelian in request.InsertDataRequsetRepeated
                          join DbT6PenawaranPembelian in _db.T6PenawaranPembelianDbSet on T6PenawaranPembelian.IdPenawaranPembelian equals DbT6PenawaranPembelian.IdPenawaranPembelian
into gj
                          where !gj.Any()
                          select T6PenawaranPembelian;
            var t6PenawaranPembelians = _clsMapper.Mapper.Map<IEnumerable<DbT6PenawaranPembelian>>(queryT6);
            t6PenawaranPembelians.ToList().ForEach(fea =>
            {
                fea.IdPenawaranPembelian = IdDetailPenawaran;
            });
            _db.T6PenawaranPembelianDbSet.AddRange(t6PenawaranPembelians);

            var queryT7 = from T7PenawaranPembelian in request.InsertDataRequsetRepeated join DbT7PenawaranPembelian in _db.T7PenawaranPembelianDbSet on T7PenawaranPembelian.IdDetilPenawaranPembelian equals DbT7PenawaranPembelian.IdDetilPenawaranPembelian into gj where !gj.Any() select T7PenawaranPembelian;
            var t7PenawaranPembelians = _clsMapper.Mapper.Map<IEnumerable<DbT7PenawaranPembelian>>(queryT7);
            t7PenawaranPembelians.ToList().ForEach(fea =>
            {
                fea.IdPenawaranPembelian = IdPenawaran;
                fea.IdDetilPenawaranPembelian = IdDetailPenawaran;
            });
            _db.T7PenawaranPembelianDbSet.AddRange(t7PenawaranPembelians);
        }
    }
}

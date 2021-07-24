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

        public override Task<pesan> InsertPenawaranPembelianRepeated(InsertDataT6Requset request, ServerCallContext context)
        {
            pesan pesan;
            try
            {
                var queryT6 = from T6PenawaranPembelian in _db.T6PenawaranPembelianDbSet
                              where T6PenawaranPembelian.IdPenawaranPembelian == request.IdPenawaranPembelian
                              select T6PenawaranPembelian.IdPenawaranPembelian;

                if (!queryT6.Any())
                {
                    DbT6PenawaranPembelian t6PenawaranPembelian = new DbT6PenawaranPembelian
                    {
                        IdPenawaranPembelian = request.IdPenawaranPembelian,
                        IdJenisSupplier = request.IdJenisSupplier,
                        IdCompany_Penerima = request.IdCompanyPenerima,
                        IdSupplier = request.IdSupplier,
                        GrandTotal =(decimal) request.GrandTotal,
                        DiskonDetil = request.DiskonDetil,
                        DiskonNominal =(decimal) request.DiskonNominal,
                    };
                    _db.T6PenawaranPembelianDbSet.AddRange(t6PenawaranPembelian);
                    _db.SaveChanges();


                    var databarang = request.T7Requset;
                    foreach (var item in databarang)
                    {
                        var queryT7 = from T7PenawaranPembelian in _db.T7PenawaranPembelianDbSet
                                      where T7PenawaranPembelian.IdDetilPenawaranPembelian == item.IdDetilPenawaranPembelian select T7PenawaranPembelian.IdDetilPenawaranPembelian;

                        if (!queryT7.Any())
                        {
                            DbT7PenawaranPembelian t7PenawaranPembelian = new DbT7PenawaranPembelian
                            {
                                IdDetilPenawaranPembelian = item.IdDetilPenawaranPembelian,
                                IdPenawaranPembelian = request.IdPenawaranPembelian,
                                IdSatuan = item.IdSatuan,
                                IdDivisiBarang = item.IdDivisiBarang,
                                IdSubDivisiBarang = item.IdSubDivisiBarang,
                                IdKategoriBarang = item.IdKategoriBarang,
                                IdSubKategoriBarang = item.IdSubKategoriBarang,
                                IdBarang = item.IdBarang,
                                Harga = (Decimal)item.Harga,
                                Jumlah = (Decimal)item.Jumlah,
                                DiskonDetil = item.DiskonDetil,
                                DiskonNominal =(Decimal) item.DiskonNominal,
                                Total = item.Total
                            };
                            _db.T7PenawaranPembelianDbSet.AddRange(t7PenawaranPembelian);
                            _db.SaveChanges();
                        }
                    }
                }
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
    }
}

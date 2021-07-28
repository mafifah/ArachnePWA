﻿using Grpc.Core;
using grpcArachne.Data;
using grpcArachne.Models;
using grpcArachne.Utility;
using Microsoft.EntityFrameworkCore;
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
                        IdJenisSupplier = Convert.ToInt64(request.IdJenisSupplier),
                        IdCompany_Penerima = request.IdCompanyPenerima,
                        IdSupplier = Convert.ToInt64(request.IdSupplier),
                        GrandTotal =(decimal) request.GrandTotal,
                        Catatan = request.Catatan,
                        DiskonDetil = request.DiskonDetil,
                        DiskonNominal =(decimal) request.DiskonNominal,
                        WaktuInsert = DateTimeOffset.UtcNow.LocalDateTime
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
                                IdSatuan =Convert.ToInt64( item.IdSatuan),
                                IdDivisiBarang = Convert.ToInt64(item.IdDivisiBarang),
                                IdSubDivisiBarang = Convert.ToInt64(item.IdSubDivisiBarang),
                                IdKategoriBarang = Convert.ToInt64(item.IdKategoriBarang),
                                IdSubKategoriBarang = Convert.ToInt64(item.IdSubKategoriBarang),
                                IdBarang = Convert.ToInt64(item.IdBarang),
                                Harga = (Decimal)item.Harga,
                                Jumlah = (Decimal)item.Jumlah,
                                DiskonDetil = item.DiskonDetil,
                                DiskonNominal =(Decimal) item.DiskonNominal,
                                Total = Convert.ToInt64(item.Total),
                                CatatanPenawaran = item.CatatanPenawaran,
                                Satuan_Satuan = item.SatuanSatuan,
                                Barang_Barang = item.BarangBarang,
                                Barang_Ukuran = item.BarangUkuran,
                                Barang_Umur = item.BarangUmur,
                                SubDivisiBarang_SubDivisi = item.SubDivisiBarangSubDivisi,
                                SubKategoriBarang_SubKategori = item.SubKategoriBarangSubKategori,
                                DivisiBarang_Divisi = item.DivisiBarangDivisi,
                                KategoriBarang_Kategori = item.KategoriBarangKategori,
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

                //Metadata metadata = new Metadata { { "Error", "Error : " + ex.Message } };
                //throw new RpcException(new Status(StatusCode.Unknown, "Unknown"), metadata);

                pesan = new pesan() { Pesan = "Data Gagal terkirim ke server"  };
            }
            return Task.FromResult(pesan);
        }

        public override Task<ListTermin> GetDataTermin(TerminRequest request, ServerCallContext context)
        {
            var query = (from T0Termin in _db.T0TerminDbSet
                         select new TerminResponse
                         {
                             IdTermin = T0Termin.IdTermin,
                             Termin = T0Termin.Termin,
                         }).AsNoTracking().AsEnumerable();
            ListTermin listTermin = new ListTermin();
            listTermin.TerminResponse.AddRange(query);
            return Task.FromResult(listTermin);
        }
    }
}

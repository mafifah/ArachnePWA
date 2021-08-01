using bzrArachnePWA.Server.Data;
using bzrArachnePWA.Server.Models;
using Grpc.Core;
using grpcArachne;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace bzrArachnePWA.Server.Services
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
                        GrandTotal = (decimal)request.GrandTotal,
                        Catatan = request.Catatan,
                        Status = "Pending",
                        DiskonDetil = request.DiskonDetil,
                        DiskonNominal = (decimal)request.DiskonNominal,
                        WaktuInsert = DateTimeOffset.UtcNow.LocalDateTime
                    };
                    _db.T6PenawaranPembelianDbSet.AddRange(t6PenawaranPembelian);
                    _db.SaveChanges();


                    var databarang = request.T7Requset;
                    foreach (var item in databarang)
                    {
                        var queryT7 = from T7PenawaranPembelian in _db.T7PenawaranPembelianDbSet
                                      where T7PenawaranPembelian.IdDetilPenawaranPembelian == item.IdDetilPenawaranPembelian
                                      select T7PenawaranPembelian.IdDetilPenawaranPembelian;

                        if (!queryT7.Any())
                        {
                            if (item.IdBarang != 0)
                            {
                                DbT7PenawaranPembelian t7PenawaranPembelian = new DbT7PenawaranPembelian
                                {
                                    IdDetilPenawaranPembelian = item.IdDetilPenawaranPembelian,
                                    IdPenawaranPembelian = request.IdPenawaranPembelian,
                                    IdSatuan = Convert.ToInt64(item.IdSatuan),
                                    IdDivisiBarang = Convert.ToInt64(item.IdDivisiBarang),
                                    IdSubDivisiBarang = Convert.ToInt64(item.IdSubDivisiBarang),
                                    IdKategoriBarang = Convert.ToInt64(item.IdKategoriBarang),
                                    IdSubKategoriBarang = Convert.ToInt64(item.IdSubKategoriBarang),
                                    IdBarang = Convert.ToInt64(item.IdBarang),
                                    Harga = (Decimal)item.Harga,
                                    Jumlah = (Decimal)item.Jumlah,
                                    DiskonDetil = item.DiskonDetil,
                                    DiskonNominal = (Decimal)item.DiskonNominal,
                                    Total = Convert.ToInt64(item.Total),
                                    CatatanPenawaran = item.CatatanPenawaran,
                                    Satuan_Satuan = null,
                                    Barang_Barang = null,
                                    Barang_Ukuran = null,
                                    Barang_Umur = null,
                                    SubDivisiBarang_SubDivisi = null,
                                    SubKategoriBarang_SubKategori = null,
                                    DivisiBarang_Divisi = null,
                                    KategoriBarang_Kategori = null,
                                };
                                _db.T7PenawaranPembelianDbSet.AddRange(t7PenawaranPembelian);
                                _db.SaveChanges();
                            }
                            else
                            {
                                DbT7PenawaranPembelian t7PenawaranPembelian = new DbT7PenawaranPembelian
                                {
                                    IdDetilPenawaranPembelian = item.IdDetilPenawaranPembelian,
                                    IdPenawaranPembelian = request.IdPenawaranPembelian,
                                    IdSatuan = null,
                                    IdDivisiBarang = null,
                                    IdSubDivisiBarang = null,
                                    IdKategoriBarang = null,
                                    IdSubKategoriBarang = null,
                                    IdBarang = null,
                                    Harga = (Decimal)item.Harga,
                                    Jumlah = (Decimal)item.Jumlah,
                                    DiskonDetil = item.DiskonDetil,
                                    DiskonNominal = (Decimal)item.DiskonNominal,
                                    Total = Convert.ToInt64(item.Total),
                                    CatatanPenawaran = item.CatatanPenawaran,
                                    Satuan_Satuan = item.SatuanSatuan,
                                    Barang_Barang = item.BarangBarang,
                                    Barang_Ukuran = item.BarangUkuran,
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
                }
                pesan = new pesan() { Pesan = "Berhasil" };
            }
            catch (Exception ex)
            {

                //Metadata metadata = new Metadata { { "Error", "Error : " + ex.Message } };
                //throw new RpcException(new Status(StatusCode.Unknown, "Unknown"), metadata);

                pesan = new pesan() { Pesan = "Data Gagal terkirim ke server" };
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

        public override async Task GetDataPenawaran(PenawaranRequest request, IServerStreamWriter<PenawaranResponse> responseStream, ServerCallContext context)
        {
            var query = (from T6PenawaranPembelian in _db.T6PenawaranPembelianDbSet
                         where T6PenawaranPembelian.IdSupplier == request.IdSupplier
                         select new PenawaranResponse
                         {
                             IdPenawaranPembelian = T6PenawaranPembelian.IdPenawaranPembelian,
                             IdJenisSupplier = (long)T6PenawaranPembelian.IdJenisSupplier,
                             IdSupplier = (long)T6PenawaranPembelian.IdSupplier,
                             GrandTotal = (double)T6PenawaranPembelian.GrandTotal,
                             IdCompanyPenerima = T6PenawaranPembelian.IdCompany_Penerima,
                             DiskonDetil = T6PenawaranPembelian.DiskonDetil,
                             DiskonNominal = (double)T6PenawaranPembelian.DiskonNominal,
                             Catatan = T6PenawaranPembelian.Catatan,
                             IdTermin = T6PenawaranPembelian.IdTermin.ToString(),
                             Status = T6PenawaranPembelian.Status,
                         }).AsNoTracking().AsEnumerable();
            foreach (var item in query)
            {
                var queryDetail = (from T7PenawaranPembelian in _db.T7PenawaranPembelianDbSet
                                   where T7PenawaranPembelian.IdPenawaranPembelian == item.IdPenawaranPembelian
                                   select new DetailPenawaranResponse
                                   {
                                    IdDetilPenawaranPembelian= (long)T7PenawaranPembelian.IdDetilPenawaranPembelian,
                                    IdBarang = T7PenawaranPembelian.IdBarang.ToString(),
                                    IdSatuan = T7PenawaranPembelian.IdSatuan.ToString(),
                                    IdDivisiBarang = T7PenawaranPembelian.IdDivisiBarang.ToString(),
                                    IdSubDivisiBarang = T7PenawaranPembelian.IdSubDivisiBarang.ToString(),
                                    IdKategoriBarang = T7PenawaranPembelian.IdKategoriBarang.ToString(),
                                    IdSubKategoriBarang = T7PenawaranPembelian.IdSubKategoriBarang.ToString(),
                                    Harga = (double)T7PenawaranPembelian.Harga,
                                    Jumlah = (long)T7PenawaranPembelian.Jumlah,
                                    DiskonDetil = T7PenawaranPembelian.DiskonDetil,
                                    DiskonNominal = (long)T7PenawaranPembelian.DiskonNominal,
                                    Total = (long)T7PenawaranPembelian.Total,
                                    Catatan = T7PenawaranPembelian.CatatanPenawaran,
                                    SatuanSatuan = T7PenawaranPembelian.Satuan_Satuan,
                                    BarangBarang = T7PenawaranPembelian.Barang_Barang,
                                    BarangUkuran = T7PenawaranPembelian.Barang_Ukuran,
                                    SubDivisiBarangSubDivisi = T7PenawaranPembelian.SubDivisiBarang_SubDivisi,
                                    SubKategoriBarangSubKategori = T7PenawaranPembelian.SubKategoriBarang_SubKategori,
                                    DivisiBarangDivisi = T7PenawaranPembelian.DivisiBarang_Divisi,
                                    KategoriBarangKategori = T7PenawaranPembelian.KategoriBarang_Kategori,
                                    IdPenawaranPembelian = item.IdPenawaranPembelian,
                }).AsNoTracking().AsEnumerable();
                item.DetailPenawaranResponse.AddRange(queryDetail);
                await responseStream.WriteAsync(item);
            }
        }
    }
}

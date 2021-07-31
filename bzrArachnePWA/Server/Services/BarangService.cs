using bzrArachnePWA.Server.Data;
using bzrArachnePWA.Server.Models;
using Grpc.Core;
using grpcArachne;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bzrArachnePWA.Server.Services
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
        public override async Task GetDataBarangWithGroupBy(ListBarangRequest request, IServerStreamWriter<Barang> responseStream, ServerCallContext context)
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
                 on T2Barang.IdSubDivisiBarang equals T1SubDivisiBarang.IdSubDivisiBarang
                 join T1SubKategoriBarang in _db.T1SubKategoriBarangDbSet
                 on T2Barang.IdSubKategoriBarang equals T1SubKategoriBarang.IdSubKategoriBarang
                 select new
                 {
                     T3Satuan.IdBarang,
                     T1SubDivisiBarang.IdDivisiBarang,
                     T1SubDivisiBarang.IdSubDivisiBarang,
                     T1SubKategoriBarang.IdKategoriBarang,
                     T1SubKategoriBarang.IdSubKategoriBarang,
                     T1Supplier.IdSupplier,
                     T1Supplier.IdJenisSupplier,
                     T5CompanySatuan.IdCompany,
                     T3Satuan.IdSatuan,
                     T2Barang.Barang,
                     T3Satuan.Satuan,
                     T5StokGudang.StokBaru,
                     T5CompanySatuan.Minimum,
                     T5CompanySatuan.Maksimum,
                     T1Supplier.Nama,
                     T1Supplier.Alamat
                 } into x
                 group x by new
                 {
                     x.IdBarang,
                     x.IdDivisiBarang,
                     x.IdSubDivisiBarang,
                     x.IdKategoriBarang,
                     x.IdSubKategoriBarang,
                     x.IdSupplier,
                     x.IdCompany,
                     x.IdJenisSupplier,
                     x.IdSatuan,
                     x.Barang,
                     x.Satuan,
                     x.Minimum,
                     x.Maksimum,
                     x.Nama,
                     x.Alamat
                 } into y
                 select new Barang
                 {
                     IdBarang = (long)y.Key.IdBarang,
                     IdDivisiBarang = (long)y.Key.IdDivisiBarang,
                     IdSubDivisiBarang = (long)y.Key.IdSubDivisiBarang,
                     IdKategoriBarang = (long)y.Key.IdKategoriBarang,
                     IdSubKategoriBarang = (long)y.Key.IdSubKategoriBarang,
                     IdSupplier = (long)y.Key.IdSupplier,
                     IdCompany = y.Key.IdCompany,
                     IdJenisSupplier = (long)y.Key.IdJenisSupplier,
                     IdSatuan = (long)y.Key.IdSatuan,
                     Nama = y.Key.Barang,
                     Satuan = y.Key.Satuan,
                     Stok = (int)y.Sum(x => x.StokBaru),
                     Minimum = y.Key.Minimum,
                     Maksimum = y.Key.Maksimum,
                     NamaSupplier = y.Key.Nama,
                     AlamatSupplier = y.Key.Alamat
                 }).AsEnumerable();
                foreach (var item in qryBarang)
                {
                    await responseStream.WriteAsync(item);
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
                 join T1SubKategoriBarang in _db.T1SubKategoriBarangDbSet
                 on T2Barang.IdSubKategoriBarang equals T1SubKategoriBarang.IdSubKategoriBarang
                 where T5SupplierSatuan.IdSupplier == _idSupplier
                 select new
                 {
                     T3Satuan.IdBarang,
                     T1SubDivisiBarang.IdDivisiBarang,
                     T1SubDivisiBarang.IdSubDivisiBarang,
                     T1SubKategoriBarang.IdKategoriBarang,
                     T1SubKategoriBarang.IdSubKategoriBarang,
                     T1Supplier.IdSupplier,
                     T1Supplier.IdJenisSupplier,
                     T5CompanySatuan.IdCompany,
                     T3Satuan.IdSatuan,
                     T2Barang.Barang,
                     T3Satuan.Satuan,
                     T5StokGudang.StokBaru,
                     T5CompanySatuan.Minimum,
                     T5CompanySatuan.Maksimum,
                     T1Supplier.Nama,
                     T1Supplier.Alamat
                 } into x
                 group x by new
                 {
                     x.IdBarang,
                     x.IdDivisiBarang,
                     x.IdSubDivisiBarang,
                     x.IdKategoriBarang,
                     x.IdSubKategoriBarang,
                     x.IdSupplier,
                     x.IdCompany,
                     x.IdJenisSupplier,
                     x.IdSatuan,
                     x.Barang,
                     x.Satuan,
                     x.Minimum,
                     x.Maksimum,
                     x.Nama,
                     x.Alamat
                 } into y
                 select new Barang
                 {
                     IdBarang = (long)y.Key.IdBarang,
                     IdDivisiBarang = (long)y.Key.IdDivisiBarang,
                     IdSubDivisiBarang = (long)y.Key.IdSubDivisiBarang,
                     IdKategoriBarang = (long)y.Key.IdKategoriBarang,
                     IdSubKategoriBarang = (long)y.Key.IdSubKategoriBarang,
                     IdSupplier = (long)y.Key.IdSupplier,
                     IdCompany = y.Key.IdCompany,
                     IdJenisSupplier = (long)y.Key.IdJenisSupplier,
                     IdSatuan = (long)y.Key.IdSatuan,
                     Nama = y.Key.Barang,
                     Satuan = y.Key.Satuan,
                     Stok = (int)y.Sum(x => x.StokBaru),
                     Minimum = y.Key.Minimum,
                     Maksimum = y.Key.Maksimum,
                     NamaSupplier = y.Key.Nama,
                     AlamatSupplier = y.Key.Alamat
                 }).AsEnumerable();
                foreach (var item in qryBarang)
                {
                    await responseStream.WriteAsync(item);
                }
            }
        }
        public override async Task<Pesan> UpdateStokBarang(UpdateBarangRequest request, ServerCallContext context)
        {
            Pesan output;
            try
            {
                var qryT5StokGudang = from T5STokGudang in _db.T5StokGudangDbSet
                                      where T5STokGudang.IdSatuan == request.IdSatuan
                                      && T5STokGudang.IdGudang == request.IdGudang
                                      select T5STokGudang.IdSatuan;
                if (qryT5StokGudang.Any())
                {
                    var qry = (from T5STokGudang in _db.T5StokGudangDbSet
                               where T5STokGudang.IdSatuan == request.IdSatuan
                               && T5STokGudang.IdGudang == request.IdGudang
                               select new
                               {
                                   T5STokGudang.IdSatuan,
                                   T5STokGudang.IdGudang,
                                   T5STokGudang.StokBaru,
                                   T5STokGudang.StokBaruLokasi,
                                   T5STokGudang.StokBaruNominal,
                                   T5STokGudang.StokBekas,
                                   T5STokGudang.StokBekasLokasi,
                                   T5STokGudang.StokBekasNominal,
                                   T5STokGudang.StokRusak,
                                   T5STokGudang.StokRusakLokasi,
                                   T5STokGudang.StokRusakNominal,
                                   T5STokGudang.WaktuProses,
                                   T5STokGudang.IdOperator,
                                   T5STokGudang.Synchronise
                               }).FirstOrDefault();
                    DbT5StokGudang t5StokGudang = new DbT5StokGudang();
                    t5StokGudang.IdSatuan = request.IdSatuan;
                    t5StokGudang.IdGudang = request.IdGudang;
                    t5StokGudang.StokBaru = request.Stok;
                    t5StokGudang.StokBaruLokasi = qry.StokBaruLokasi;
                    t5StokGudang.StokBaruNominal = qry.StokBaruNominal;
                    t5StokGudang.StokRusak = qry.StokRusak;
                    t5StokGudang.StokRusakLokasi = qry.StokRusakLokasi;
                    t5StokGudang.StokRusakNominal = qry.StokRusakNominal;
                    t5StokGudang.StokBekas = qry.StokBekas;
                    t5StokGudang.StokBekasLokasi = qry.StokBekasLokasi;
                    t5StokGudang.StokBekasNominal = qry.StokBekasNominal;
                    t5StokGudang.IdOperator = qry.IdOperator;
                    t5StokGudang.Synchronise = qry.Synchronise;
                    _db.T5StokGudangDbSet.UpdateRange(t5StokGudang);
                    _db.SaveChanges();
                }
                output = new Pesan() { Message = "Data berhasil diupdate" };
            }
            catch (Exception ex)
            {
                output = new Pesan() { Message = "Data gagal diupdate" };
            }
            await Send(request.IdSatuan).ConfigureAwait(false);
            return await Task.FromResult(output);
        }

        public override async Task GetDataBarangById(BarangByIdRequest request, IServerStreamWriter<Barang> responseStream, ServerCallContext context)
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
             join T1SubKategoriBarang in _db.T1SubKategoriBarangDbSet
             on T2Barang.IdSubKategoriBarang equals T1SubKategoriBarang.IdSubKategoriBarang
             where T3Satuan.IdSatuan == Int64.Parse(request.IdSatuan)
             select new
             {
                 T3Satuan.IdBarang,
                 T1SubDivisiBarang.IdDivisiBarang,
                 T1SubDivisiBarang.IdSubDivisiBarang,
                 T1SubKategoriBarang.IdKategoriBarang,
                 T1SubKategoriBarang.IdSubKategoriBarang,
                 T1Supplier.IdSupplier,
                 T1Supplier.IdJenisSupplier,
                 T5CompanySatuan.IdCompany,
                 T3Satuan.IdSatuan,
                 T2Barang.Barang,
                 T3Satuan.Satuan,
                 T5StokGudang.StokBaru,
                 T5CompanySatuan.Minimum,
                 T5CompanySatuan.Maksimum,
                 T1Supplier.Nama,
                 T1Supplier.Alamat
             } into x
             group x by new
             {
                 x.IdBarang,
                 x.IdDivisiBarang,
                 x.IdSubDivisiBarang,
                 x.IdKategoriBarang,
                 x.IdSubKategoriBarang,
                 x.IdSupplier,
                 x.IdCompany,
                 x.IdJenisSupplier,
                 x.IdSatuan,
                 x.Barang,
                 x.Satuan,
                 x.Minimum,
                 x.Maksimum,
                 x.Nama,
                 x.Alamat
             } into y
             select new Barang
             {
                 IdBarang = (long)y.Key.IdBarang,
                 IdDivisiBarang = (long)y.Key.IdDivisiBarang,
                 IdSubDivisiBarang = (long)y.Key.IdSubDivisiBarang,
                 IdKategoriBarang = (long)y.Key.IdKategoriBarang,
                 IdSubKategoriBarang = (long)y.Key.IdSubKategoriBarang,
                 IdSupplier = (long)y.Key.IdSupplier,
                 IdCompany = y.Key.IdCompany,
                 IdJenisSupplier = (long)y.Key.IdJenisSupplier,
                 IdSatuan = (long)y.Key.IdSatuan,
                 Nama = y.Key.Barang,
                 Satuan = y.Key.Satuan,
                 Stok = (int)y.Sum(x => x.StokBaru),
                 Minimum = y.Key.Minimum,
                 Maksimum = y.Key.Maksimum,
                 NamaSupplier = y.Key.Nama,
                 AlamatSupplier = y.Key.Alamat
             }).AsEnumerable();
            foreach (var item in qryBarang)
            {
                await responseStream.WriteAsync(item);
            }
        }
        private async Task Send(long IdSatuan)
        {
            try
            {
                //var msg = "Data Updated";
                var msg = IdSatuan.ToString();
                var hubConnection = new HubConnectionBuilder().WithUrl("http://localhost:54947/broadcastHub").Build();
                await hubConnection.StartAsync();
                await hubConnection.SendAsync("sendMessage", msg);
            }
            catch (Exception e)
            {
                var ex = e.Message.ToString();
            }
        }
    }
}

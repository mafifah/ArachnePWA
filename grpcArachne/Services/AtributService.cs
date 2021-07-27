using Grpc.Core;
using grpcArachne.Data;
using grpcArachne.Utility;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grpcArachne.Services
{
    public class AtributService : AtributForm.AtributFormBase
    {
        private readonly ILogger<AtributService> _logger;
        private readonly ServerDbContext _db;
        private readonly clsMapper _clsMapper;
        public AtributService(ILogger<AtributService> logger, ServerDbContext db)
        {
            _logger = logger;
            _db = db;
            _clsMapper = new clsMapper();
        }


        public override Task<ListDivisibarang> GetDivisBarang(Empty request, ServerCallContext context)
        {
            ListDivisibarang divisibarang = new ListDivisibarang();
            var queryDivisibarang = (from T0Divisibarang in _db.T0DivisiBarangDbSet
                                     join T1SubDivisiBarang in _db.T1SubDivisiBarangDbSet on T0Divisibarang.IdDivisiBarang equals T1SubDivisiBarang.IdDivisiBarang


                                     select new DivisiBarang
                                     {
                                         IdDivisi = T0Divisibarang.IdDivisiBarang,
                                         Divisi = T0Divisibarang.Divisi,
                                         IdSubDivisi = T1SubDivisiBarang.IdSubDivisiBarang,
                                         Keterangan = T1SubDivisiBarang.Keterangan,
                                         Kode = T1SubDivisiBarang.Kode

                                     }).AsNoTracking().AsEnumerable();
            divisibarang.DivisiBarang.AddRange(queryDivisibarang);
            return Task.FromResult(divisibarang);
        }

        public override Task<ListKategoribarang> GetKategoriBarang(Empty request, ServerCallContext context)
        {
            ListKategoribarang kategoribarang = new ListKategoribarang();
            var queryDivisikategori = (from T0Kategoribarang in _db.T0KategoriBarangDbSet
                                       join T1SubKategoriBarang in _db.T1SubKategoriBarang on T0Kategoribarang.IdKategoriBarang equals T1SubKategoriBarang.IdKategoriBarang
                                       select new KategoriBarang
                                       {
                                           IdKategori = T0Kategoribarang.IdKategoriBarang,
                                           IdSubKategori = T1SubKategoriBarang.IdSubKategoriBarang,
                                           Kategori = T0Kategoribarang.Kategori,
                                           Subkategori = T1SubKategoriBarang.SubKategori

                                       }).AsNoTracking().AsEnumerable();
            kategoribarang.KategoriBarang.AddRange(queryDivisikategori);
            return Task.FromResult(kategoribarang);
        }
    }
}

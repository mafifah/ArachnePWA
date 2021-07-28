using Grpc.Core;
using grpcArachne.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grpcArachne
{
    public class AtributFormService : FormAtribut.FormAtributBase
    {
        private readonly ILogger<AtributFormService> _logger;
        private readonly ServerDbContext _db;
        public AtributFormService(ILogger<AtributFormService> logger, ServerDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public override async Task GetDivisiBarang(Empty request, IServerStreamWriter<T0DivisiBarang> responseStream, ServerCallContext context)
        {
            var qryT0DivisiBarang =
                (from T0DivisiBarang in _db.T0DivisiBarangDbSet
                 select new T0DivisiBarang
                 {
                     IdDivisi = T0DivisiBarang.IdDivisiBarang,
                     Divisi = T0DivisiBarang.Divisi
                 }).AsEnumerable();
            foreach (var item in qryT0DivisiBarang)
            {
                await responseStream.WriteAsync(item);
            }
        }

        public override async Task GetSubDivisiBarang(Empty request, IServerStreamWriter<T1SubDivisiBarang> responseStream, ServerCallContext context)
        {
            var qryT0SubDivisiBarang =
                (from T1SubDivisiBarang in _db.T1SubDivisiBarangDbSet
                 where T1SubDivisiBarang.IdSubDivisiBarang != 56001
                 select new T1SubDivisiBarang
                 {
                     IdDivisiBarang = (long)T1SubDivisiBarang.IdDivisiBarang,
                     IdSubDivisi = T1SubDivisiBarang.IdSubDivisiBarang,
                     SubDivisi = T1SubDivisiBarang.SubDivisi,
                     Keterangan = T1SubDivisiBarang.Keterangan,
                 }).AsEnumerable();
            foreach (var item in qryT0SubDivisiBarang)
            {
                await responseStream.WriteAsync(item);
            }
        }

        public override async Task GetKategoriBarang(Empty request, IServerStreamWriter<T0KategoriBarang> responseStream, ServerCallContext context)
        {
            var qryT0KategoriBarang =
                (from T0KategoriBarang in _db.T0KategoriBarangDbSet
                 select new T0KategoriBarang
                 {
                     IdKategoriBarang = T0KategoriBarang.IdKategoriBarang,
                     KategoriBarang = T0KategoriBarang.Kategori,
                 }).AsEnumerable();
            foreach (var item in qryT0KategoriBarang)
            {
                await responseStream.WriteAsync(item);
            }
        }

        public override async Task GetDataOption(Empty request, IServerStreamWriter<T9DataOption> responseStream, ServerCallContext context)
        {
            var qryT9DataOption =
                (from T9DataOption in _db.T9DataOptionDbSet
                 where T9DataOption.Entity == "Isi Atribut2 Barang"
                 select new T9DataOption
                 {
                     DataOption = T9DataOption.DataOption
                 }).AsEnumerable();
            foreach (var item in qryT9DataOption)
            {
                await responseStream.WriteAsync(item);
            }
        }
    }
}

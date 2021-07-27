using bzrArachne.Models;
using Grpc.Net.Client;
using System;
using grpcArachne;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bzrArachne.Service
{
    public class AtributService
    {
        List<M_DivisiBarang> divisiBarangs = new List<M_DivisiBarang>();
        List<M_KategoriBarang> kategoriBarangs = new List<M_KategoriBarang>();

        public async Task <List<M_DivisiBarang>> GetDivisBarang()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new AtributForm.AtributFormClient(channel);
            var request = new Empty();
            var reply = await client.GetDivisBarangAsync(request);
            divisiBarangs.Clear();
            foreach (var item in reply.DivisiBarang)
            {
               
                divisiBarangs.Add(new M_DivisiBarang
                {
                    IdDivisi = item.IdDivisi,
                    IdSubDivisi = item.IdSubDivisi,
                    Keterangan = item.Keterangan,
                    Kode = item.Kode,
                    Divisi = item.Divisi,
                });
            }
            return divisiBarangs;
        }

        public async Task<List<M_KategoriBarang>> GetkategoriBarang()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new AtributForm.AtributFormClient(channel);
            var request = new Empty();
            var reply = await client.GetKategoriBarangAsync(request);
            kategoriBarangs.Clear();
            foreach (var item in reply.KategoriBarang)
            {
                
                kategoriBarangs.Add(new M_KategoriBarang
                {
                   IdKategori = item.IdKategori,
                   IdSubKategori = item.IdSubKategori,
                   Kategori = item.Kategori,
                   SubKategori = item.Subkategori,
                });
            }
            return kategoriBarangs;
        }

    }
}

using bzrArachne.Models;
using Grpc.Net.Client;
using grpcArachne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bzrArachne.Service
{
    public class PenawaranService
    {
        public PenawaranService()
        {

        }

        public async Task<bool> InsertData
            (
                long IdPenawaranPembelian,
                long IdJenisSupplier, 
                long IdSupplier,
                long IdDetilPenawaranPembelian,
                long IdSatuan,
                long IdDivisiBarang,
                long IdSubDivisiBarang,
                long IdKategoriBarang,
                long IdSubKategoriBarang,
                long IdBarang,
                double Harga,
                double Jumlah,
                double Berat
            )
        {
            
            var channel  = GrpcChannel.ForAddress("https://localhost:5001");
            var client  = new PenawaranPembelian.PenawaranPembelianClient(channel);
            var request = new InsertDataRequset
            {
                IdJenisSupplier = IdJenisSupplier,
                IdSupplier = IdSupplier,
                IdSatuan = IdSatuan,
                IdDivisiBarang = IdDivisiBarang,
                IdSubDivisiBarang = IdSubDivisiBarang,
                IdKategoriBarang = IdKategoriBarang,
                IdSubKategoriBarang = IdSubKategoriBarang,
                IdBarang = IdBarang,
                Harga = Harga,    
                Jumlah = Jumlah,
                Berat = Berat
            };
            var reply = await client.InsertPenawaranPembelianAsync(request);

            return true;
        }
    }
}

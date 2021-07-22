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
                long IdJenisSupplier, 
                long IdSupplier, 
                string IdCompanyPenerima, 
                long IdSatuan,
                long IdDivisi,
                long IdSubDivisi,
                long IdKategori,
                long IdSubKategori,
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
                IdCompanyPenerima = IdCompanyPenerima,
                IdSatuan = IdSatuan,
                IdDivisi = IdDivisi,
                IdSubDivisi = IdSubDivisi,
                IdKategori = IdKategori,
                IdSubKategori = IdSubKategori,
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

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
        List<DataPenawaran> listBarangs = new List<DataPenawaran>();

        DataPenawaran dataPenawaran = new DataPenawaran();

        InsertDataRepeated insertDataRepeatedResponse = new InsertDataRepeated
        {
           // InsertDataRequsetRepeated = new Google.Protobuf.Collections.RepeatedField<InsertDataRequset> { }
        };
        
        public PenawaranService()
        {

        }

        public async Task<bool> InsertData
            (
                long IdPenawaranPembelian,
                long IdJenisSupplier, 
                long IdSupplier,
                DateTimeOffset Tanggal,
                long IdDetilPenawaranPembelian,
                long IdSatuan,
                long IdDivisiBarang,
                long IdSubDivisiBarang,
                long IdKategoriBarang,
                long IdSubKategoriBarang,
                long IdBarang,
                double Harga,
                double Jumlah,
                string DiskonDetil,
                double DiskonNominal,
                double Total
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
                DiskonDetil = DiskonDetil,
                DiskonNominal = DiskonNominal,
                Total = Total,
            };
            var reply = await client.InsertPenawaranPembelianAsync(request);

            return true;
        }

        public async Task<bool> InsertDataRepeated(List<DataPenawaran> listBarangs)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new PenawaranPembelian.PenawaranPembelianClient(channel);
            //var request = new InsertDataRepeated { InsertDataRequsetRepeated=listBarangs};
           // var reply = await client.InsertPenawaranPembelianRepeatedAsync(request);
            return true;
        }
    }
}

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
        public async Task<bool> InsertDataRepeated(DataPenawaran dataPenawaran)
        {
            var output = false;
            try
            {
                
                var channel = GrpcChannel.ForAddress("https://localhost:5001");
                var client = new PenawaranPembelian.PenawaranPembelianClient(channel);
                List<InsertDataT7Requset> data = new List<InsertDataT7Requset>();
                foreach(var Item in dataPenawaran.BarangPenawaran)
                {
                    data.Add(new InsertDataT7Requset {
                        IdBarang = Item.IdBarang,
                        IdDetilPenawaranPembelian = Item.IdDetilPenawaranPembelian,
                        IdSatuan = Item.IdSatuan,
                        IdDivisiBarang = Item.IdDivisiBarang,
                        IdSubDivisiBarang = Item.IdSubDivisiBarang,
                        IdKategoriBarang = Item.IdKategoriBarang,
                        IdSubKategoriBarang = Item.IdSubKategoriBarang,
                        Harga = Item.Harga,
                        Jumlah = Item.Jumlah,
                        DiskonDetil = Item.DiskonDetil.ToString(),
                        DiskonNominal = Item.DiskonNominal,
                        Total = (long)Item.Total
                    });
                }
                var request = new InsertDataT6Requset
                {
                    IdPenawaranPembelian = dataPenawaran.IdPenawaranPembelian,
                    IdJenisSupplier = dataPenawaran.IdJenisSupplier,
                    IdSupplier = dataPenawaran.IdSupplier,
                    IdCompanyPenerima = dataPenawaran.IdCompanyPenerima,
                    DiskonDetil = dataPenawaran.DiskonDetil,
                    DiskonNominal = dataPenawaran.DiskonNominal,
                    GrandTotal = dataPenawaran.GrandTotal,
                    T7Requset = {data},
                };
                var reply = await client.InsertPenawaranPembelianRepeatedAsync(request);
                output = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                output = false;
            }
            return output;
        }
    }
}

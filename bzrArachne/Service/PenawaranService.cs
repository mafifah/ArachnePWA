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

       

        public PenawaranService()
        {

        }


        public async Task<bool> InsertDataRepeated(DataPenawaran dataPenawaran)
        {
            List<DataPenawaran> T7Requset = new List<DataPenawaran>();
            InsertDataT6Requset insertDataT6 = new InsertDataT6Requset();

            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new PenawaranPembelian.PenawaranPembelianClient(channel);
            var request = new InsertDataT6Requset
            {
                IdPenawaranPembelian = dataPenawaran.IdPenawaranPembelian,
                IdJenisSupplier  = dataPenawaran.IdJenisSupplier,
                IdSupplier = dataPenawaran.IdSupplier,
                IdCompanyPenerima = dataPenawaran.IdCompanyPenerima,
                DiskonDetil = dataPenawaran.DiskonDetil,
                DiskonNominal = dataPenawaran.DiskonNominal,
                GrandTotal = dataPenawaran.GrandTotal,
              //  insertDataT6.T7Requset.AddRange(new InsertDataT6Requset (dataPenawaran.BarangPenawaran))  

            };

            return false;
        }
    }
}

using bzrArachnePWA.Client.Models;
using Grpc.Net.Client;
using Grpc.Net.Client.Web;
using grpcArachne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace bzrArachnePWA.Client.Service
{
    public class PenawaranService
    {
        List<DataPenawaran> listBarangs = new List<DataPenawaran>();
        List<DataTermin> dataTermins = new List<DataTermin>();
        DataPenawaran dataPenawaran = new DataPenawaran();
        public async Task<bool> InsertDataRepeated(DataPenawaran dataPenawaran)
            {
                var output = false;
                try
                {
                    var httpClient = new HttpClient(new GrpcWebHandler(GrpcWebMode.GrpcWeb, new HttpClientHandler()));
                    var channel = GrpcChannel.ForAddress("http://localhost:54947", new GrpcChannelOptions { HttpClient = httpClient });
                    var client = new PenawaranPembelian.PenawaranPembelianClient(channel);
                    List<InsertDataT7Requset> data = new List<InsertDataT7Requset>();
                    foreach (var Item in dataPenawaran.BarangPenawaran)
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
                            Total = (long)Item.Total,
                            CatatanPenawaran = Item.CatatanPenawaran,
                            SatuanSatuan = Item.Satuan_Satuan,
                            BarangBarang = Item.Barang_Barang,
                            BarangUkuran = Item.Barang_Ukuran,
                            BarangUmur = Item.Barang_Umur,
                            SubDivisiBarangSubDivisi = Item.SubDivisiBarang_SubDivisi,
                            SubKategoriBarangSubKategori = Item.SubKategoriBarang_SubKategori,
                            DivisiBarangDivisi = Item.DivisiBarang_Divisi,
                            KategoriBarangKategori = Item.KategoriBarang_Kategori,
                            
                        });
                    }
                    var request = new InsertDataT6Requset
                    {
                        IdPenawaranPembelian    = dataPenawaran.IdPenawaranPembelian,
                        IdJenisSupplier         = dataPenawaran.IdJenisSupplier,
                        IdSupplier              = dataPenawaran.IdSupplier,
                        IdCompanyPenerima       = dataPenawaran.IdCompanyPenerima,
                        DiskonDetil             = dataPenawaran.DiskonDetil,
                        DiskonNominal           = dataPenawaran.DiskonNominal,
                        GrandTotal              = dataPenawaran.GrandTotal,
                        T7Requset               = { data },
                    };
                    var reply = await client.InsertPenawaranPembelianRepeatedAsync(request);
                if (reply.Pesan== "Berhasil")
                {
                    output = true;
                }
                else
                {
                    output = false;
                }
            }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return output;
            }
        public async Task <List<DataTermin>>GetDataTermin()
        {
            var httpClient = new HttpClient(new GrpcWebHandler(GrpcWebMode.GrpcWeb, new HttpClientHandler()));
            var channel = GrpcChannel.ForAddress("http://localhost:54947", new GrpcChannelOptions { HttpClient = httpClient });
            var client = new PenawaranPembelian.PenawaranPembelianClient(channel);
            var request = new TerminRequest();
            var reply = await client.GetDataTerminAsync(request);
            dataTermins = new List<DataTermin>();
            foreach (var item in reply.TerminResponse)
            {
                dataTermins.Add(new DataTermin
                {
                    IdTermin = item.IdTermin,
                    Termin = item.Termin,
                });
            }
            return dataTermins;
        }
     }
} 

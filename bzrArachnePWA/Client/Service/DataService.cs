using bzrArachnePWA.Client.Models;
using Grpc.Core;
using Grpc.Net.Client;
using Grpc.Net.Client.Web;
using grpcArachne;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace bzrArachnePWA.Client.Service
{
    public class DataService
    {
        public DataUser User = new DataUser();
        public string Token;
        private readonly List<DataBarang> _dataBarang = new List<DataBarang>();
        public DataBarang _barangDipilih { get; set; }
        public void SetNullBarangDipilih() => _barangDipilih = null;
        public void SetBarangDipilih(DataBarang Item) => _barangDipilih = Item;
        public void SetBarangBaruDipilih(DataBarang ItemBaru) => _barangDipilih = ItemBaru;
        public async Task<DataUser> GetLogin(DataUser users)
        {
            var pass = users.UserPassword;
            if (pass == null)
            {
                pass = "";
            }
            try
            {
                var httpClient = new HttpClient(new GrpcWebHandler(GrpcWebMode.GrpcWeb, new HttpClientHandler()));
                var channel = GrpcChannel.ForAddress("http://localhost:54947", new GrpcChannelOptions { HttpClient = httpClient });
                var client = new LoginToken.LoginTokenClient(channel);
                var clientRequested = new LoginTokenRequest { UserName = users.UserName, UserPassword = pass };
                var reply = await client.GetLoginTokenAsync(clientRequested);
                Token = reply.Token;
                User.IdSupplier = reply.IdSupplier;
                User.Nama = reply.Nama;
                User.UserName = User.UserName;
                User.UserPassword = users.UserPassword;
                User.IdJenisSupplier = reply.IdJenisSupplier;
                User.Alamat = reply.Alamat;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return User;
        }
        public void GetLogOut()
        {
            Token = null;
            _dataBarang.Clear();
        }
        public IAsyncEnumerable<Barang> GetDataBarangWithGroupBy()
        {
            var httpClient = new HttpClient(new GrpcWebHandler(GrpcWebMode.GrpcWeb, new HttpClientHandler()));
            var channel = GrpcChannel.ForAddress("http://localhost:54947", new GrpcChannelOptions { HttpClient = httpClient });
            var client = new T1Barang.T1BarangClient(channel);
            Metadata data = new Metadata
                {
                    { "Authorization", $"Bearer {Token}" }
                };
            var request = client.GetDataBarangWithGroupBy(new ListBarangRequest { IdSupplier = User.IdSupplier }, data);
            return request.ResponseStream.ReadAllAsync();
        }
        public IAsyncEnumerable<Barang> GetDataById(string IdSatuan)
        {
            var httpClient = new HttpClient(new GrpcWebHandler(GrpcWebMode.GrpcWeb, new HttpClientHandler()));
            var channel = GrpcChannel.ForAddress("http://localhost:54947", new GrpcChannelOptions { HttpClient = httpClient });
            var client = new T1Barang.T1BarangClient(channel);
            Metadata data = new Metadata
                {
                    { "Authorization", $"Bearer {Token}" }
                };
            var request = client.GetDataBarangById(new BarangByIdRequest { IdSatuan = IdSatuan }, data);
            return request.ResponseStream.ReadAllAsync();
        }
    }
}

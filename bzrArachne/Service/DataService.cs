using bzrArachne.Models;
using Grpc.Core;
using Grpc.Net.Client;
using grpcArachne;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace bzrArachne.Service
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
                var channel = GrpcChannel.ForAddress("https://localhost:5001");
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
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new T1Barang.T1BarangClient(channel);
            Metadata data = new Metadata
                {
                    { "Authorization", $"Bearer {Token}" }
                };
            var request = client.GetDataBarangWithGroupBy(new ListBarangRequest { IdSupplier = User.IdSupplier }, data);
            return request.ResponseStream.ReadAllAsync();
        }
    }
}
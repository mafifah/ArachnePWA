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
        private readonly List<DataUser> _dataUser = new List<DataUser>();
        DataBarang t1Barang = new DataBarang();

        public DataBarang _barangDipilih { get; set; }
        public void SetBarangDipilih(DataBarang Item) => _barangDipilih = Item;
        public async Task GetBarangId()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new T1Barang.T1BarangClient(channel);
            var requested = new ListBarangIdRequest();
            var reply = await client.GetBarangIdAsync(requested);
            t1Barang = new DataBarang
            {
                IdBarang = requested.IdBarang,
                
            };
            
        }
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
                User.IdUser = reply.IdUser;
                User.IdSupplier = reply.IdSupplier;
                User.NamaLengkap = reply.NamaLengkap;
                User.NamaPanggilan = reply.NamaLengkap;
                User.UserName = User.UserName;
                User.UserPassword = users.UserPassword;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return User;
        }
        public async Task GetLogOut()
        {
            Token = null;
            _dataBarang.Clear();
        }
        public async Task<List<DataBarang>> GetDataBarang()
        {
            try
            {
                var channel = GrpcChannel.ForAddress("https://localhost:5001");
                var client = new T1Barang.T1BarangClient(channel);
                Metadata data = new Metadata
                {
                    { "Authorization", $"Bearer {Token}" }
                };
                var clientRequested = new ListBarangRequest { IdSupplier = User.IdSupplier };
                var reply = await client.GetDataBarangAsync(clientRequested, data);
                _dataBarang.Clear();
                foreach (var item in reply.Barang)
                {
                    _dataBarang.Add(new DataBarang
                    {
                        IdBarang = item.IdBarang,
                        Nama = item.Nama,
                        Satuan = item.Satuan,
                        Stok = item.Stok,
                        Minimum = item.Minimum,
                        Maksimum = item.Maksimum,
                    });
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return _dataBarang;
        }

        public IAsyncEnumerable<Barang> GetDataBarangWithStream()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new T1Barang.T1BarangClient(channel);
            Metadata data = new Metadata
                {
                    { "Authorization", $"Bearer {Token}" }
                };
            var request = client.GetDataBarangWithStream(new ListBarangRequest { IdSupplier = User.IdSupplier }, data);
            return request.ResponseStream.ReadAllAsync();
        }
    }
}

using Grpc.Core;
using Grpc.Net.Client;
using grpcArachne;
using System.Collections.Generic;

namespace bzrArachne.Service
{
    public class FormAtributService
    {
        public IAsyncEnumerable<T0DivisiBarang> GetDivisiBarang()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new FormAtribut.FormAtributClient(channel);
            var request = client.GetDivisiBarang(new Empty { });
            return request.ResponseStream.ReadAllAsync();
        }

        public IAsyncEnumerable<T1SubDivisiBarang> GetSubDivisiBarang()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new FormAtribut.FormAtributClient(channel);
            var request = client.GetSubDivisiBarang(new Empty { });
            return request.ResponseStream.ReadAllAsync();
        }

        public IAsyncEnumerable<T0KategoriBarang> GetKategoriBarang()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new FormAtribut.FormAtributClient(channel);
            var request = client.GetKategoriBarang(new Empty { });
            return request.ResponseStream.ReadAllAsync();
        }

        public IAsyncEnumerable<T9DataOption> GetUkuranBarang()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new FormAtribut.FormAtributClient(channel);
            var request = client.GetDataOption(new Empty { });
            return request.ResponseStream.ReadAllAsync();
        }
    }
}

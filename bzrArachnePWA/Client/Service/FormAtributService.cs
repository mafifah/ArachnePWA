using Grpc.Core;
using Grpc.Net.Client;
using Grpc.Net.Client.Web;
using grpcArachne;
using System.Collections.Generic;
using System.Net.Http;

namespace bzrArachnePWA.Client.Service
{
    public class FormAtributService
    {
        public IAsyncEnumerable<T0DivisiBarang> GetDivisiBarang()
        {
            var httpClient = new HttpClient(new GrpcWebHandler(GrpcWebMode.GrpcWeb, new HttpClientHandler()));
            var channel = GrpcChannel.ForAddress("http://localhost:54947", new GrpcChannelOptions { HttpClient = httpClient });
            var client = new FormAtribut.FormAtributClient(channel);
            var request = client.GetDivisiBarang(new Empty { });
            return request.ResponseStream.ReadAllAsync();
        }

        public IAsyncEnumerable<T1SubDivisiBarang> GetSubDivisiBarang()
        {
            var httpClient = new HttpClient(new GrpcWebHandler(GrpcWebMode.GrpcWeb, new HttpClientHandler()));
            var channel = GrpcChannel.ForAddress("http://localhost:54947", new GrpcChannelOptions { HttpClient = httpClient });
            var client = new FormAtribut.FormAtributClient(channel);
            var request = client.GetSubDivisiBarang(new Empty { });
            return request.ResponseStream.ReadAllAsync();
        }

        public IAsyncEnumerable<T0KategoriBarang> GetKategoriBarang()
        {
            var httpClient = new HttpClient(new GrpcWebHandler(GrpcWebMode.GrpcWeb, new HttpClientHandler()));
            var channel = GrpcChannel.ForAddress("http://localhost:54947", new GrpcChannelOptions { HttpClient = httpClient });
            var client = new FormAtribut.FormAtributClient(channel);
            var request = client.GetKategoriBarang(new Empty { });
            return request.ResponseStream.ReadAllAsync();
        }

        public IAsyncEnumerable<T9DataOption> GetUkuranBarang()
        {
            var httpClient = new HttpClient(new GrpcWebHandler(GrpcWebMode.GrpcWeb, new HttpClientHandler()));
            var channel = GrpcChannel.ForAddress("http://localhost:54947", new GrpcChannelOptions { HttpClient = httpClient });
            var client = new FormAtribut.FormAtributClient(channel);
            var request = client.GetDataOption(new Empty { });
            return request.ResponseStream.ReadAllAsync();
        }
    }
}

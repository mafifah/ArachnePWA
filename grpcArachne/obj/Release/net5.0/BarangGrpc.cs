// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Barang.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace grpcArachne {
  public static partial class T1Barang
  {
    static readonly string __ServiceName = "T1Barang";

    static readonly grpc::Marshaller<global::grpcArachne.ListBarangRequest> __Marshaller_ListBarangRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::grpcArachne.ListBarangRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::grpcArachne.Barang> __Marshaller_Barang = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::grpcArachne.Barang.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::grpcArachne.UpdateBarangRequest> __Marshaller_UpdateBarangRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::grpcArachne.UpdateBarangRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::grpcArachne.Pesan> __Marshaller_Pesan = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::grpcArachne.Pesan.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::grpcArachne.BarangByIdRequest> __Marshaller_BarangByIdRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::grpcArachne.BarangByIdRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::grpcArachne.ListBarangRequest, global::grpcArachne.Barang> __Method_GetDataBarangWithGroupBy = new grpc::Method<global::grpcArachne.ListBarangRequest, global::grpcArachne.Barang>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetDataBarangWithGroupBy",
        __Marshaller_ListBarangRequest,
        __Marshaller_Barang);

    static readonly grpc::Method<global::grpcArachne.UpdateBarangRequest, global::grpcArachne.Pesan> __Method_UpdateStokBarang = new grpc::Method<global::grpcArachne.UpdateBarangRequest, global::grpcArachne.Pesan>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateStokBarang",
        __Marshaller_UpdateBarangRequest,
        __Marshaller_Pesan);

    static readonly grpc::Method<global::grpcArachne.BarangByIdRequest, global::grpcArachne.Barang> __Method_GetDataBarangById = new grpc::Method<global::grpcArachne.BarangByIdRequest, global::grpcArachne.Barang>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetDataBarangById",
        __Marshaller_BarangByIdRequest,
        __Marshaller_Barang);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::grpcArachne.BarangReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of T1Barang</summary>
    [grpc::BindServiceMethod(typeof(T1Barang), "BindService")]
    public abstract partial class T1BarangBase
    {
      public virtual global::System.Threading.Tasks.Task GetDataBarangWithGroupBy(global::grpcArachne.ListBarangRequest request, grpc::IServerStreamWriter<global::grpcArachne.Barang> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::grpcArachne.Pesan> UpdateStokBarang(global::grpcArachne.UpdateBarangRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task GetDataBarangById(global::grpcArachne.BarangByIdRequest request, grpc::IServerStreamWriter<global::grpcArachne.Barang> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(T1BarangBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetDataBarangWithGroupBy, serviceImpl.GetDataBarangWithGroupBy)
          .AddMethod(__Method_UpdateStokBarang, serviceImpl.UpdateStokBarang)
          .AddMethod(__Method_GetDataBarangById, serviceImpl.GetDataBarangById).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, T1BarangBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetDataBarangWithGroupBy, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::grpcArachne.ListBarangRequest, global::grpcArachne.Barang>(serviceImpl.GetDataBarangWithGroupBy));
      serviceBinder.AddMethod(__Method_UpdateStokBarang, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::grpcArachne.UpdateBarangRequest, global::grpcArachne.Pesan>(serviceImpl.UpdateStokBarang));
      serviceBinder.AddMethod(__Method_GetDataBarangById, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::grpcArachne.BarangByIdRequest, global::grpcArachne.Barang>(serviceImpl.GetDataBarangById));
    }

  }
}
#endregion
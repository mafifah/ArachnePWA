// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Barang - Copy.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace grpcArachne {
  public static partial class T1Barang
  {
    static readonly string __ServiceName = "T1Barang";

    static readonly grpc::Marshaller<global::grpcArachne.ListBarangRequest> __Marshaller_ListBarangRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::grpcArachne.ListBarangRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::grpcArachne.ListBarang> __Marshaller_ListBarang = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::grpcArachne.ListBarang.Parser.ParseFrom);

    static readonly grpc::Method<global::grpcArachne.ListBarangRequest, global::grpcArachne.ListBarang> __Method_GetDataBarang = new grpc::Method<global::grpcArachne.ListBarangRequest, global::grpcArachne.ListBarang>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetDataBarang",
        __Marshaller_ListBarangRequest,
        __Marshaller_ListBarang);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::grpcArachne.BarangCopyReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of T1Barang</summary>
    [grpc::BindServiceMethod(typeof(T1Barang), "BindService")]
    public abstract partial class T1BarangBase
    {
      public virtual global::System.Threading.Tasks.Task<global::grpcArachne.ListBarang> GetDataBarang(global::grpcArachne.ListBarangRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(T1BarangBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetDataBarang, serviceImpl.GetDataBarang).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, T1BarangBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetDataBarang, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::grpcArachne.ListBarangRequest, global::grpcArachne.ListBarang>(serviceImpl.GetDataBarang));
    }

  }
}
#endregion

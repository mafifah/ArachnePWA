// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Barang - Copy.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace grpcArachne {

  /// <summary>Holder for reflection information generated from Protos/Barang - Copy.proto</summary>
  public static partial class BarangCopyReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/Barang - Copy.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BarangCopyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpQcm90b3MvQmFyYW5nIC0gQ29weS5wcm90byInChFMaXN0QmFyYW5nUmVx",
            "dWVzdBISCgpJZFN1cHBsaWVyGAEgASgDIiUKEUJhcmFuZ0J5SWRSZXF1ZXN0",
            "EhAKCElkU2F0dWFuGAEgASgJIkcKE1VwZGF0ZUJhcmFuZ1JlcXVlc3QSEAoI",
            "SWRTYXR1YW4YASABKAMSEAoISWRHdWRhbmcYAiABKAMSDAoEU3RvaxgDIAEo",
            "BSLTAgoGQmFyYW5nEhAKCElkQmFyYW5nGAEgASgDEhYKDklkRGl2aXNpQmFy",
            "YW5nGAIgASgDEhkKEUlkU3ViRGl2aXNpQmFyYW5nGAMgASgDEhgKEElkS2F0",
            "ZWdvcmlCYXJhbmcYBCABKAMSGwoTSWRTdWJLYXRlZ29yaUJhcmFuZxgFIAEo",
            "AxISCgpJZFN1cHBsaWVyGAYgASgDEhcKD0lkSmVuaXNTdXBwbGllchgHIAEo",
            "AxIQCghJZFNhdHVhbhgIIAEoAxIMCgROYW1hGAkgASgJEg4KBlNhdHVhbhgK",
            "IAEoCRIMCgRTdG9rGAsgASgFEg8KB01pbmltdW0YDCABKAMSEAoITWFrc2lt",
            "dW0YDSABKAMSEQoJSWRDb21wYW55GA4gASgJEhQKDE5hbWFTdXBwbGllchgP",
            "IAEoCRIWCg5BbGFtYXRTdXBwbGllchgQIAEoCSIYCgVQZXNhbhIPCgdNZXNz",
            "YWdlGAEgASgJMqsBCghUMUJhcmFuZxI5ChhHZXREYXRhQmFyYW5nV2l0aEdy",
            "b3VwQnkSEi5MaXN0QmFyYW5nUmVxdWVzdBoHLkJhcmFuZzABEjAKEFVwZGF0",
            "ZVN0b2tCYXJhbmcSFC5VcGRhdGVCYXJhbmdSZXF1ZXN0GgYuUGVzYW4SMgoR",
            "R2V0RGF0YUJhcmFuZ0J5SWQSEi5CYXJhbmdCeUlkUmVxdWVzdBoHLkJhcmFu",
            "ZzABQg6qAgtncnBjQXJhY2huZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::grpcArachne.ListBarangRequest), global::grpcArachne.ListBarangRequest.Parser, new[]{ "IdSupplier" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::grpcArachne.BarangByIdRequest), global::grpcArachne.BarangByIdRequest.Parser, new[]{ "IdSatuan" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::grpcArachne.UpdateBarangRequest), global::grpcArachne.UpdateBarangRequest.Parser, new[]{ "IdSatuan", "IdGudang", "Stok" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::grpcArachne.Barang), global::grpcArachne.Barang.Parser, new[]{ "IdBarang", "IdDivisiBarang", "IdSubDivisiBarang", "IdKategoriBarang", "IdSubKategoriBarang", "IdSupplier", "IdJenisSupplier", "IdSatuan", "Nama", "Satuan", "Stok", "Minimum", "Maksimum", "IdCompany", "NamaSupplier", "AlamatSupplier" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::grpcArachne.Pesan), global::grpcArachne.Pesan.Parser, new[]{ "Message" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ListBarangRequest : pb::IMessage<ListBarangRequest> {
    private static readonly pb::MessageParser<ListBarangRequest> _parser = new pb::MessageParser<ListBarangRequest>(() => new ListBarangRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListBarangRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::grpcArachne.BarangCopyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListBarangRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListBarangRequest(ListBarangRequest other) : this() {
      idSupplier_ = other.idSupplier_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListBarangRequest Clone() {
      return new ListBarangRequest(this);
    }

    /// <summary>Field number for the "IdSupplier" field.</summary>
    public const int IdSupplierFieldNumber = 1;
    private long idSupplier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long IdSupplier {
      get { return idSupplier_; }
      set {
        idSupplier_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListBarangRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListBarangRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IdSupplier != other.IdSupplier) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IdSupplier != 0L) hash ^= IdSupplier.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (IdSupplier != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(IdSupplier);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IdSupplier != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(IdSupplier);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListBarangRequest other) {
      if (other == null) {
        return;
      }
      if (other.IdSupplier != 0L) {
        IdSupplier = other.IdSupplier;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            IdSupplier = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class BarangByIdRequest : pb::IMessage<BarangByIdRequest> {
    private static readonly pb::MessageParser<BarangByIdRequest> _parser = new pb::MessageParser<BarangByIdRequest>(() => new BarangByIdRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BarangByIdRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::grpcArachne.BarangCopyReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BarangByIdRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BarangByIdRequest(BarangByIdRequest other) : this() {
      idSatuan_ = other.idSatuan_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BarangByIdRequest Clone() {
      return new BarangByIdRequest(this);
    }

    /// <summary>Field number for the "IdSatuan" field.</summary>
    public const int IdSatuanFieldNumber = 1;
    private string idSatuan_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string IdSatuan {
      get { return idSatuan_; }
      set {
        idSatuan_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BarangByIdRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BarangByIdRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IdSatuan != other.IdSatuan) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IdSatuan.Length != 0) hash ^= IdSatuan.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (IdSatuan.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(IdSatuan);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IdSatuan.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IdSatuan);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BarangByIdRequest other) {
      if (other == null) {
        return;
      }
      if (other.IdSatuan.Length != 0) {
        IdSatuan = other.IdSatuan;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            IdSatuan = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class UpdateBarangRequest : pb::IMessage<UpdateBarangRequest> {
    private static readonly pb::MessageParser<UpdateBarangRequest> _parser = new pb::MessageParser<UpdateBarangRequest>(() => new UpdateBarangRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UpdateBarangRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::grpcArachne.BarangCopyReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdateBarangRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdateBarangRequest(UpdateBarangRequest other) : this() {
      idSatuan_ = other.idSatuan_;
      idGudang_ = other.idGudang_;
      stok_ = other.stok_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdateBarangRequest Clone() {
      return new UpdateBarangRequest(this);
    }

    /// <summary>Field number for the "IdSatuan" field.</summary>
    public const int IdSatuanFieldNumber = 1;
    private long idSatuan_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long IdSatuan {
      get { return idSatuan_; }
      set {
        idSatuan_ = value;
      }
    }

    /// <summary>Field number for the "IdGudang" field.</summary>
    public const int IdGudangFieldNumber = 2;
    private long idGudang_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long IdGudang {
      get { return idGudang_; }
      set {
        idGudang_ = value;
      }
    }

    /// <summary>Field number for the "Stok" field.</summary>
    public const int StokFieldNumber = 3;
    private int stok_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Stok {
      get { return stok_; }
      set {
        stok_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UpdateBarangRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UpdateBarangRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IdSatuan != other.IdSatuan) return false;
      if (IdGudang != other.IdGudang) return false;
      if (Stok != other.Stok) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IdSatuan != 0L) hash ^= IdSatuan.GetHashCode();
      if (IdGudang != 0L) hash ^= IdGudang.GetHashCode();
      if (Stok != 0) hash ^= Stok.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (IdSatuan != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(IdSatuan);
      }
      if (IdGudang != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(IdGudang);
      }
      if (Stok != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Stok);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IdSatuan != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(IdSatuan);
      }
      if (IdGudang != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(IdGudang);
      }
      if (Stok != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Stok);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UpdateBarangRequest other) {
      if (other == null) {
        return;
      }
      if (other.IdSatuan != 0L) {
        IdSatuan = other.IdSatuan;
      }
      if (other.IdGudang != 0L) {
        IdGudang = other.IdGudang;
      }
      if (other.Stok != 0) {
        Stok = other.Stok;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            IdSatuan = input.ReadInt64();
            break;
          }
          case 16: {
            IdGudang = input.ReadInt64();
            break;
          }
          case 24: {
            Stok = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Barang : pb::IMessage<Barang> {
    private static readonly pb::MessageParser<Barang> _parser = new pb::MessageParser<Barang>(() => new Barang());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Barang> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::grpcArachne.BarangCopyReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Barang() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Barang(Barang other) : this() {
      idBarang_ = other.idBarang_;
      idDivisiBarang_ = other.idDivisiBarang_;
      idSubDivisiBarang_ = other.idSubDivisiBarang_;
      idKategoriBarang_ = other.idKategoriBarang_;
      idSubKategoriBarang_ = other.idSubKategoriBarang_;
      idSupplier_ = other.idSupplier_;
      idJenisSupplier_ = other.idJenisSupplier_;
      idSatuan_ = other.idSatuan_;
      nama_ = other.nama_;
      satuan_ = other.satuan_;
      stok_ = other.stok_;
      minimum_ = other.minimum_;
      maksimum_ = other.maksimum_;
      idCompany_ = other.idCompany_;
      namaSupplier_ = other.namaSupplier_;
      alamatSupplier_ = other.alamatSupplier_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Barang Clone() {
      return new Barang(this);
    }

    /// <summary>Field number for the "IdBarang" field.</summary>
    public const int IdBarangFieldNumber = 1;
    private long idBarang_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long IdBarang {
      get { return idBarang_; }
      set {
        idBarang_ = value;
      }
    }

    /// <summary>Field number for the "IdDivisiBarang" field.</summary>
    public const int IdDivisiBarangFieldNumber = 2;
    private long idDivisiBarang_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long IdDivisiBarang {
      get { return idDivisiBarang_; }
      set {
        idDivisiBarang_ = value;
      }
    }

    /// <summary>Field number for the "IdSubDivisiBarang" field.</summary>
    public const int IdSubDivisiBarangFieldNumber = 3;
    private long idSubDivisiBarang_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long IdSubDivisiBarang {
      get { return idSubDivisiBarang_; }
      set {
        idSubDivisiBarang_ = value;
      }
    }

    /// <summary>Field number for the "IdKategoriBarang" field.</summary>
    public const int IdKategoriBarangFieldNumber = 4;
    private long idKategoriBarang_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long IdKategoriBarang {
      get { return idKategoriBarang_; }
      set {
        idKategoriBarang_ = value;
      }
    }

    /// <summary>Field number for the "IdSubKategoriBarang" field.</summary>
    public const int IdSubKategoriBarangFieldNumber = 5;
    private long idSubKategoriBarang_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long IdSubKategoriBarang {
      get { return idSubKategoriBarang_; }
      set {
        idSubKategoriBarang_ = value;
      }
    }

    /// <summary>Field number for the "IdSupplier" field.</summary>
    public const int IdSupplierFieldNumber = 6;
    private long idSupplier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long IdSupplier {
      get { return idSupplier_; }
      set {
        idSupplier_ = value;
      }
    }

    /// <summary>Field number for the "IdJenisSupplier" field.</summary>
    public const int IdJenisSupplierFieldNumber = 7;
    private long idJenisSupplier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long IdJenisSupplier {
      get { return idJenisSupplier_; }
      set {
        idJenisSupplier_ = value;
      }
    }

    /// <summary>Field number for the "IdSatuan" field.</summary>
    public const int IdSatuanFieldNumber = 8;
    private long idSatuan_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long IdSatuan {
      get { return idSatuan_; }
      set {
        idSatuan_ = value;
      }
    }

    /// <summary>Field number for the "Nama" field.</summary>
    public const int NamaFieldNumber = 9;
    private string nama_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Nama {
      get { return nama_; }
      set {
        nama_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Satuan" field.</summary>
    public const int SatuanFieldNumber = 10;
    private string satuan_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Satuan {
      get { return satuan_; }
      set {
        satuan_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Stok" field.</summary>
    public const int StokFieldNumber = 11;
    private int stok_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Stok {
      get { return stok_; }
      set {
        stok_ = value;
      }
    }

    /// <summary>Field number for the "Minimum" field.</summary>
    public const int MinimumFieldNumber = 12;
    private long minimum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Minimum {
      get { return minimum_; }
      set {
        minimum_ = value;
      }
    }

    /// <summary>Field number for the "Maksimum" field.</summary>
    public const int MaksimumFieldNumber = 13;
    private long maksimum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Maksimum {
      get { return maksimum_; }
      set {
        maksimum_ = value;
      }
    }

    /// <summary>Field number for the "IdCompany" field.</summary>
    public const int IdCompanyFieldNumber = 14;
    private string idCompany_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string IdCompany {
      get { return idCompany_; }
      set {
        idCompany_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "NamaSupplier" field.</summary>
    public const int NamaSupplierFieldNumber = 15;
    private string namaSupplier_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NamaSupplier {
      get { return namaSupplier_; }
      set {
        namaSupplier_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "AlamatSupplier" field.</summary>
    public const int AlamatSupplierFieldNumber = 16;
    private string alamatSupplier_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AlamatSupplier {
      get { return alamatSupplier_; }
      set {
        alamatSupplier_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Barang);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Barang other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IdBarang != other.IdBarang) return false;
      if (IdDivisiBarang != other.IdDivisiBarang) return false;
      if (IdSubDivisiBarang != other.IdSubDivisiBarang) return false;
      if (IdKategoriBarang != other.IdKategoriBarang) return false;
      if (IdSubKategoriBarang != other.IdSubKategoriBarang) return false;
      if (IdSupplier != other.IdSupplier) return false;
      if (IdJenisSupplier != other.IdJenisSupplier) return false;
      if (IdSatuan != other.IdSatuan) return false;
      if (Nama != other.Nama) return false;
      if (Satuan != other.Satuan) return false;
      if (Stok != other.Stok) return false;
      if (Minimum != other.Minimum) return false;
      if (Maksimum != other.Maksimum) return false;
      if (IdCompany != other.IdCompany) return false;
      if (NamaSupplier != other.NamaSupplier) return false;
      if (AlamatSupplier != other.AlamatSupplier) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IdBarang != 0L) hash ^= IdBarang.GetHashCode();
      if (IdDivisiBarang != 0L) hash ^= IdDivisiBarang.GetHashCode();
      if (IdSubDivisiBarang != 0L) hash ^= IdSubDivisiBarang.GetHashCode();
      if (IdKategoriBarang != 0L) hash ^= IdKategoriBarang.GetHashCode();
      if (IdSubKategoriBarang != 0L) hash ^= IdSubKategoriBarang.GetHashCode();
      if (IdSupplier != 0L) hash ^= IdSupplier.GetHashCode();
      if (IdJenisSupplier != 0L) hash ^= IdJenisSupplier.GetHashCode();
      if (IdSatuan != 0L) hash ^= IdSatuan.GetHashCode();
      if (Nama.Length != 0) hash ^= Nama.GetHashCode();
      if (Satuan.Length != 0) hash ^= Satuan.GetHashCode();
      if (Stok != 0) hash ^= Stok.GetHashCode();
      if (Minimum != 0L) hash ^= Minimum.GetHashCode();
      if (Maksimum != 0L) hash ^= Maksimum.GetHashCode();
      if (IdCompany.Length != 0) hash ^= IdCompany.GetHashCode();
      if (NamaSupplier.Length != 0) hash ^= NamaSupplier.GetHashCode();
      if (AlamatSupplier.Length != 0) hash ^= AlamatSupplier.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (IdBarang != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(IdBarang);
      }
      if (IdDivisiBarang != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(IdDivisiBarang);
      }
      if (IdSubDivisiBarang != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(IdSubDivisiBarang);
      }
      if (IdKategoriBarang != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(IdKategoriBarang);
      }
      if (IdSubKategoriBarang != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(IdSubKategoriBarang);
      }
      if (IdSupplier != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(IdSupplier);
      }
      if (IdJenisSupplier != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(IdJenisSupplier);
      }
      if (IdSatuan != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(IdSatuan);
      }
      if (Nama.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Nama);
      }
      if (Satuan.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(Satuan);
      }
      if (Stok != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(Stok);
      }
      if (Minimum != 0L) {
        output.WriteRawTag(96);
        output.WriteInt64(Minimum);
      }
      if (Maksimum != 0L) {
        output.WriteRawTag(104);
        output.WriteInt64(Maksimum);
      }
      if (IdCompany.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(IdCompany);
      }
      if (NamaSupplier.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(NamaSupplier);
      }
      if (AlamatSupplier.Length != 0) {
        output.WriteRawTag(130, 1);
        output.WriteString(AlamatSupplier);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IdBarang != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(IdBarang);
      }
      if (IdDivisiBarang != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(IdDivisiBarang);
      }
      if (IdSubDivisiBarang != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(IdSubDivisiBarang);
      }
      if (IdKategoriBarang != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(IdKategoriBarang);
      }
      if (IdSubKategoriBarang != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(IdSubKategoriBarang);
      }
      if (IdSupplier != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(IdSupplier);
      }
      if (IdJenisSupplier != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(IdJenisSupplier);
      }
      if (IdSatuan != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(IdSatuan);
      }
      if (Nama.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nama);
      }
      if (Satuan.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Satuan);
      }
      if (Stok != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Stok);
      }
      if (Minimum != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Minimum);
      }
      if (Maksimum != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Maksimum);
      }
      if (IdCompany.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IdCompany);
      }
      if (NamaSupplier.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NamaSupplier);
      }
      if (AlamatSupplier.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(AlamatSupplier);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Barang other) {
      if (other == null) {
        return;
      }
      if (other.IdBarang != 0L) {
        IdBarang = other.IdBarang;
      }
      if (other.IdDivisiBarang != 0L) {
        IdDivisiBarang = other.IdDivisiBarang;
      }
      if (other.IdSubDivisiBarang != 0L) {
        IdSubDivisiBarang = other.IdSubDivisiBarang;
      }
      if (other.IdKategoriBarang != 0L) {
        IdKategoriBarang = other.IdKategoriBarang;
      }
      if (other.IdSubKategoriBarang != 0L) {
        IdSubKategoriBarang = other.IdSubKategoriBarang;
      }
      if (other.IdSupplier != 0L) {
        IdSupplier = other.IdSupplier;
      }
      if (other.IdJenisSupplier != 0L) {
        IdJenisSupplier = other.IdJenisSupplier;
      }
      if (other.IdSatuan != 0L) {
        IdSatuan = other.IdSatuan;
      }
      if (other.Nama.Length != 0) {
        Nama = other.Nama;
      }
      if (other.Satuan.Length != 0) {
        Satuan = other.Satuan;
      }
      if (other.Stok != 0) {
        Stok = other.Stok;
      }
      if (other.Minimum != 0L) {
        Minimum = other.Minimum;
      }
      if (other.Maksimum != 0L) {
        Maksimum = other.Maksimum;
      }
      if (other.IdCompany.Length != 0) {
        IdCompany = other.IdCompany;
      }
      if (other.NamaSupplier.Length != 0) {
        NamaSupplier = other.NamaSupplier;
      }
      if (other.AlamatSupplier.Length != 0) {
        AlamatSupplier = other.AlamatSupplier;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            IdBarang = input.ReadInt64();
            break;
          }
          case 16: {
            IdDivisiBarang = input.ReadInt64();
            break;
          }
          case 24: {
            IdSubDivisiBarang = input.ReadInt64();
            break;
          }
          case 32: {
            IdKategoriBarang = input.ReadInt64();
            break;
          }
          case 40: {
            IdSubKategoriBarang = input.ReadInt64();
            break;
          }
          case 48: {
            IdSupplier = input.ReadInt64();
            break;
          }
          case 56: {
            IdJenisSupplier = input.ReadInt64();
            break;
          }
          case 64: {
            IdSatuan = input.ReadInt64();
            break;
          }
          case 74: {
            Nama = input.ReadString();
            break;
          }
          case 82: {
            Satuan = input.ReadString();
            break;
          }
          case 88: {
            Stok = input.ReadInt32();
            break;
          }
          case 96: {
            Minimum = input.ReadInt64();
            break;
          }
          case 104: {
            Maksimum = input.ReadInt64();
            break;
          }
          case 114: {
            IdCompany = input.ReadString();
            break;
          }
          case 122: {
            NamaSupplier = input.ReadString();
            break;
          }
          case 130: {
            AlamatSupplier = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Pesan : pb::IMessage<Pesan> {
    private static readonly pb::MessageParser<Pesan> _parser = new pb::MessageParser<Pesan>(() => new Pesan());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Pesan> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::grpcArachne.BarangCopyReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Pesan() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Pesan(Pesan other) : this() {
      message_ = other.message_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Pesan Clone() {
      return new Pesan(this);
    }

    /// <summary>Field number for the "Message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Pesan);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Pesan other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Pesan other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

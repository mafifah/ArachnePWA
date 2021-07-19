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
            "dWVzdBISCgpJZFN1cHBsaWVyGAEgASgDIiUKCkxpc3RCYXJhbmcSFwoGQmFy",
            "YW5nGAEgAygLMgcuQmFyYW5nIo8BCgZCYXJhbmcSEAoISWRCYXJhbmcYASAB",
            "KAMSEgoKSWRTdXBwbGllchgCIAEoAxIMCgROYW1hGAMgASgJEg4KBlNhdHVh",
            "bhgEIAEoCRIQCghTdXBwbGllchgFIAEoCRIMCgRTdG9rGAYgASgFEg8KB01p",
            "bmltdW0YByABKAMSEAoITWFrc2ltdW0YCCABKAMyPAoIVDFCYXJhbmcSMAoN",
            "R2V0RGF0YUJhcmFuZxISLkxpc3RCYXJhbmdSZXF1ZXN0GgsuTGlzdEJhcmFu",
            "Z0IOqgILZ3JwY0FyYWNobmViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::grpcArachne.ListBarangRequest), global::grpcArachne.ListBarangRequest.Parser, new[]{ "IdSupplier" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::grpcArachne.ListBarang), global::grpcArachne.ListBarang.Parser, new[]{ "Barang" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::grpcArachne.Barang), global::grpcArachne.Barang.Parser, new[]{ "IdBarang", "IdSupplier", "Nama", "Satuan", "Supplier", "Stok", "Minimum", "Maksimum" }, null, null, null, null)
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

  public sealed partial class ListBarang : pb::IMessage<ListBarang> {
    private static readonly pb::MessageParser<ListBarang> _parser = new pb::MessageParser<ListBarang>(() => new ListBarang());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListBarang> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::grpcArachne.BarangCopyReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListBarang() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListBarang(ListBarang other) : this() {
      barang_ = other.barang_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListBarang Clone() {
      return new ListBarang(this);
    }

    /// <summary>Field number for the "Barang" field.</summary>
    public const int BarangFieldNumber = 1;
    private static readonly pb::FieldCodec<global::grpcArachne.Barang> _repeated_barang_codec
        = pb::FieldCodec.ForMessage(10, global::grpcArachne.Barang.Parser);
    private readonly pbc::RepeatedField<global::grpcArachne.Barang> barang_ = new pbc::RepeatedField<global::grpcArachne.Barang>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::grpcArachne.Barang> Barang {
      get { return barang_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListBarang);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListBarang other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!barang_.Equals(other.barang_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= barang_.GetHashCode();
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
      barang_.WriteTo(output, _repeated_barang_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += barang_.CalculateSize(_repeated_barang_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListBarang other) {
      if (other == null) {
        return;
      }
      barang_.Add(other.barang_);
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
            barang_.AddEntriesFrom(input, _repeated_barang_codec);
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
      get { return global::grpcArachne.BarangCopyReflection.Descriptor.MessageTypes[2]; }
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
      idSupplier_ = other.idSupplier_;
      nama_ = other.nama_;
      satuan_ = other.satuan_;
      supplier_ = other.supplier_;
      stok_ = other.stok_;
      minimum_ = other.minimum_;
      maksimum_ = other.maksimum_;
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

    /// <summary>Field number for the "IdSupplier" field.</summary>
    public const int IdSupplierFieldNumber = 2;
    private long idSupplier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long IdSupplier {
      get { return idSupplier_; }
      set {
        idSupplier_ = value;
      }
    }

    /// <summary>Field number for the "Nama" field.</summary>
    public const int NamaFieldNumber = 3;
    private string nama_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Nama {
      get { return nama_; }
      set {
        nama_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Satuan" field.</summary>
    public const int SatuanFieldNumber = 4;
    private string satuan_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Satuan {
      get { return satuan_; }
      set {
        satuan_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Supplier" field.</summary>
    public const int SupplierFieldNumber = 5;
    private string supplier_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Supplier {
      get { return supplier_; }
      set {
        supplier_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Stok" field.</summary>
    public const int StokFieldNumber = 6;
    private int stok_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Stok {
      get { return stok_; }
      set {
        stok_ = value;
      }
    }

    /// <summary>Field number for the "Minimum" field.</summary>
    public const int MinimumFieldNumber = 7;
    private long minimum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Minimum {
      get { return minimum_; }
      set {
        minimum_ = value;
      }
    }

    /// <summary>Field number for the "Maksimum" field.</summary>
    public const int MaksimumFieldNumber = 8;
    private long maksimum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Maksimum {
      get { return maksimum_; }
      set {
        maksimum_ = value;
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
      if (IdSupplier != other.IdSupplier) return false;
      if (Nama != other.Nama) return false;
      if (Satuan != other.Satuan) return false;
      if (Supplier != other.Supplier) return false;
      if (Stok != other.Stok) return false;
      if (Minimum != other.Minimum) return false;
      if (Maksimum != other.Maksimum) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IdBarang != 0L) hash ^= IdBarang.GetHashCode();
      if (IdSupplier != 0L) hash ^= IdSupplier.GetHashCode();
      if (Nama.Length != 0) hash ^= Nama.GetHashCode();
      if (Satuan.Length != 0) hash ^= Satuan.GetHashCode();
      if (Supplier.Length != 0) hash ^= Supplier.GetHashCode();
      if (Stok != 0) hash ^= Stok.GetHashCode();
      if (Minimum != 0L) hash ^= Minimum.GetHashCode();
      if (Maksimum != 0L) hash ^= Maksimum.GetHashCode();
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
      if (IdSupplier != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(IdSupplier);
      }
      if (Nama.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Nama);
      }
      if (Satuan.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Satuan);
      }
      if (Supplier.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Supplier);
      }
      if (Stok != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Stok);
      }
      if (Minimum != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(Minimum);
      }
      if (Maksimum != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(Maksimum);
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
      if (IdSupplier != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(IdSupplier);
      }
      if (Nama.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nama);
      }
      if (Satuan.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Satuan);
      }
      if (Supplier.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Supplier);
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
      if (other.IdSupplier != 0L) {
        IdSupplier = other.IdSupplier;
      }
      if (other.Nama.Length != 0) {
        Nama = other.Nama;
      }
      if (other.Satuan.Length != 0) {
        Satuan = other.Satuan;
      }
      if (other.Supplier.Length != 0) {
        Supplier = other.Supplier;
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
            IdSupplier = input.ReadInt64();
            break;
          }
          case 26: {
            Nama = input.ReadString();
            break;
          }
          case 34: {
            Satuan = input.ReadString();
            break;
          }
          case 42: {
            Supplier = input.ReadString();
            break;
          }
          case 48: {
            Stok = input.ReadInt32();
            break;
          }
          case 56: {
            Minimum = input.ReadInt64();
            break;
          }
          case 64: {
            Maksimum = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

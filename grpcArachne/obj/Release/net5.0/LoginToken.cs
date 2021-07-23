// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/LoginToken.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace grpcArachne {

  /// <summary>Holder for reflection information generated from Protos/LoginToken.proto</summary>
  public static partial class LoginTokenReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/LoginToken.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LoginTokenReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdQcm90b3MvTG9naW5Ub2tlbi5wcm90bxobZ29vZ2xlL3Byb3RvYnVmL2Vt",
            "cHR5LnByb3RvGh5nb29nbGUvcHJvdG9idWYvd3JhcHBlcnMucHJvdG8iOwoR",
            "TG9naW5Ub2tlblJlcXVlc3QSEAoIVXNlck5hbWUYASABKAkSFAoMVXNlclBh",
            "c3N3b3JkGAIgASgJIkQKEUxvZ2luVG9rZW5SZXR1cm5zEg0KBVRva2VuGAEg",
            "ASgJEhIKCklkU3VwcGxpZXIYAiABKAMSDAoETmFtYRgDIAEoCTJFCgpMb2dp",
            "blRva2VuEjcKDUdldExvZ2luVG9rZW4SEi5Mb2dpblRva2VuUmVxdWVzdBoS",
            "LkxvZ2luVG9rZW5SZXR1cm5zQg6qAgtncnBjQXJhY2huZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::grpcArachne.LoginTokenRequest), global::grpcArachne.LoginTokenRequest.Parser, new[]{ "UserName", "UserPassword" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::grpcArachne.LoginTokenReturns), global::grpcArachne.LoginTokenReturns.Parser, new[]{ "Token", "IdSupplier", "Nama" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LoginTokenRequest : pb::IMessage<LoginTokenRequest> {
    private static readonly pb::MessageParser<LoginTokenRequest> _parser = new pb::MessageParser<LoginTokenRequest>(() => new LoginTokenRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LoginTokenRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::grpcArachne.LoginTokenReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginTokenRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginTokenRequest(LoginTokenRequest other) : this() {
      userName_ = other.userName_;
      userPassword_ = other.userPassword_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginTokenRequest Clone() {
      return new LoginTokenRequest(this);
    }

    /// <summary>Field number for the "UserName" field.</summary>
    public const int UserNameFieldNumber = 1;
    private string userName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserName {
      get { return userName_; }
      set {
        userName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "UserPassword" field.</summary>
    public const int UserPasswordFieldNumber = 2;
    private string userPassword_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserPassword {
      get { return userPassword_; }
      set {
        userPassword_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LoginTokenRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LoginTokenRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserName != other.UserName) return false;
      if (UserPassword != other.UserPassword) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserName.Length != 0) hash ^= UserName.GetHashCode();
      if (UserPassword.Length != 0) hash ^= UserPassword.GetHashCode();
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
      if (UserName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserName);
      }
      if (UserPassword.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(UserPassword);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserName);
      }
      if (UserPassword.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserPassword);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LoginTokenRequest other) {
      if (other == null) {
        return;
      }
      if (other.UserName.Length != 0) {
        UserName = other.UserName;
      }
      if (other.UserPassword.Length != 0) {
        UserPassword = other.UserPassword;
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
            UserName = input.ReadString();
            break;
          }
          case 18: {
            UserPassword = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class LoginTokenReturns : pb::IMessage<LoginTokenReturns> {
    private static readonly pb::MessageParser<LoginTokenReturns> _parser = new pb::MessageParser<LoginTokenReturns>(() => new LoginTokenReturns());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LoginTokenReturns> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::grpcArachne.LoginTokenReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginTokenReturns() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginTokenReturns(LoginTokenReturns other) : this() {
      token_ = other.token_;
      idSupplier_ = other.idSupplier_;
      nama_ = other.nama_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginTokenReturns Clone() {
      return new LoginTokenReturns(this);
    }

    /// <summary>Field number for the "Token" field.</summary>
    public const int TokenFieldNumber = 1;
    private string token_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Token {
      get { return token_; }
      set {
        token_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LoginTokenReturns);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LoginTokenReturns other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Token != other.Token) return false;
      if (IdSupplier != other.IdSupplier) return false;
      if (Nama != other.Nama) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Token.Length != 0) hash ^= Token.GetHashCode();
      if (IdSupplier != 0L) hash ^= IdSupplier.GetHashCode();
      if (Nama.Length != 0) hash ^= Nama.GetHashCode();
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
      if (Token.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Token);
      }
      if (IdSupplier != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(IdSupplier);
      }
      if (Nama.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Nama);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Token.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Token);
      }
      if (IdSupplier != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(IdSupplier);
      }
      if (Nama.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nama);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LoginTokenReturns other) {
      if (other == null) {
        return;
      }
      if (other.Token.Length != 0) {
        Token = other.Token;
      }
      if (other.IdSupplier != 0L) {
        IdSupplier = other.IdSupplier;
      }
      if (other.Nama.Length != 0) {
        Nama = other.Nama;
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
            Token = input.ReadString();
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
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
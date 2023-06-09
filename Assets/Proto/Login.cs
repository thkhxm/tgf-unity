// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Users/AUSA/Documents/IdeaProject/tgf-example/login/internal/proto/login.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from Users/AUSA/Documents/IdeaProject/tgf-example/login/internal/proto/login.proto</summary>
public static partial class LoginReflection {

  #region Descriptor
  /// <summary>File descriptor for Users/AUSA/Documents/IdeaProject/tgf-example/login/internal/proto/login.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static LoginReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ck1Vc2Vycy9BVVNBL0RvY3VtZW50cy9JZGVhUHJvamVjdC90Z2YtZXhhbXBs",
          "ZS9sb2dpbi9pbnRlcm5hbC9wcm90by9sb2dpbi5wcm90byItCghMb2dpblJl",
          "cRIPCgdhY2NvdW50GAEgASgJEhAKCHBhc3N3b3JkGAIgASgJIikKCExvZ2lu",
          "UmVzEg4KBnVzZXJJZBgBIAEoCRINCgVlcnJvchgCIAEoDUIJWgcuL3BiO3Bi",
          "YgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::LoginReq), global::LoginReq.Parser, new[]{ "Account", "Password" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::LoginRes), global::LoginRes.Parser, new[]{ "UserId", "Error" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class LoginReq : pb::IMessage<LoginReq> {
  private static readonly pb::MessageParser<LoginReq> _parser = new pb::MessageParser<LoginReq>(() => new LoginReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<LoginReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::LoginReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public LoginReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public LoginReq(LoginReq other) : this() {
    account_ = other.account_;
    password_ = other.password_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public LoginReq Clone() {
    return new LoginReq(this);
  }

  /// <summary>Field number for the "account" field.</summary>
  public const int AccountFieldNumber = 1;
  private string account_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Account {
    get { return account_; }
    set {
      account_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "password" field.</summary>
  public const int PasswordFieldNumber = 2;
  private string password_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Password {
    get { return password_; }
    set {
      password_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as LoginReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(LoginReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Account != other.Account) return false;
    if (Password != other.Password) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Account.Length != 0) hash ^= Account.GetHashCode();
    if (Password.Length != 0) hash ^= Password.GetHashCode();
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
    if (Account.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Account);
    }
    if (Password.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Password);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Account.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Account);
    }
    if (Password.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Password);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(LoginReq other) {
    if (other == null) {
      return;
    }
    if (other.Account.Length != 0) {
      Account = other.Account;
    }
    if (other.Password.Length != 0) {
      Password = other.Password;
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
          Account = input.ReadString();
          break;
        }
        case 18: {
          Password = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class LoginRes : pb::IMessage<LoginRes> {
  private static readonly pb::MessageParser<LoginRes> _parser = new pb::MessageParser<LoginRes>(() => new LoginRes());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<LoginRes> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::LoginReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public LoginRes() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public LoginRes(LoginRes other) : this() {
    userId_ = other.userId_;
    error_ = other.error_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public LoginRes Clone() {
    return new LoginRes(this);
  }

  /// <summary>Field number for the "userId" field.</summary>
  public const int UserIdFieldNumber = 1;
  private string userId_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string UserId {
    get { return userId_; }
    set {
      userId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "error" field.</summary>
  public const int ErrorFieldNumber = 2;
  private uint error_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public uint Error {
    get { return error_; }
    set {
      error_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as LoginRes);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(LoginRes other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (UserId != other.UserId) return false;
    if (Error != other.Error) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (UserId.Length != 0) hash ^= UserId.GetHashCode();
    if (Error != 0) hash ^= Error.GetHashCode();
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
    if (UserId.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(UserId);
    }
    if (Error != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(Error);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (UserId.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(UserId);
    }
    if (Error != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Error);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(LoginRes other) {
    if (other == null) {
      return;
    }
    if (other.UserId.Length != 0) {
      UserId = other.UserId;
    }
    if (other.Error != 0) {
      Error = other.Error;
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
          UserId = input.ReadString();
          break;
        }
        case 16: {
          Error = input.ReadUInt32();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code

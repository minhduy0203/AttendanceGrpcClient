// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/attendance.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AttendanceGrpcServer {

  /// <summary>Holder for reflection information generated from Protos/attendance.proto</summary>
  public static partial class AttendanceReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/attendance.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AttendanceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdQcm90b3MvYXR0ZW5kYW5jZS5wcm90byJKChVBdHRlbmRhbmNlTGlzdFJl",
            "cXVlc3QSCwoDc2lkGAEgAygFEhIKCnNjaGVkdWxlSWQYAiABKAUSEAoIc3Rh",
            "dHVzZXMYAyADKAUiNgoWQXR0ZW5kYW5jZUxpc3RSZXNwb25zZRILCgNzaWQY",
            "ASADKAUSDwoHbWVzc2FnZRgCIAEoCTJQCgtBdHRlbmRhbmNlchJBCg5BdHRl",
            "bmRTdHVkZW50cxIWLkF0dGVuZGFuY2VMaXN0UmVxdWVzdBoXLkF0dGVuZGFu",
            "Y2VMaXN0UmVzcG9uc2VCF6oCFEF0dGVuZGFuY2VHcnBjU2VydmVyYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AttendanceGrpcServer.AttendanceListRequest), global::AttendanceGrpcServer.AttendanceListRequest.Parser, new[]{ "Sid", "ScheduleId", "Statuses" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::AttendanceGrpcServer.AttendanceListResponse), global::AttendanceGrpcServer.AttendanceListResponse.Parser, new[]{ "Sid", "Message" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AttendanceListRequest : pb::IMessage<AttendanceListRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AttendanceListRequest> _parser = new pb::MessageParser<AttendanceListRequest>(() => new AttendanceListRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AttendanceListRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AttendanceGrpcServer.AttendanceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AttendanceListRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AttendanceListRequest(AttendanceListRequest other) : this() {
      sid_ = other.sid_.Clone();
      scheduleId_ = other.scheduleId_;
      statuses_ = other.statuses_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AttendanceListRequest Clone() {
      return new AttendanceListRequest(this);
    }

    /// <summary>Field number for the "sid" field.</summary>
    public const int SidFieldNumber = 1;
    private static readonly pb::FieldCodec<int> _repeated_sid_codec
        = pb::FieldCodec.ForInt32(10);
    private readonly pbc::RepeatedField<int> sid_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> Sid {
      get { return sid_; }
    }

    /// <summary>Field number for the "scheduleId" field.</summary>
    public const int ScheduleIdFieldNumber = 2;
    private int scheduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ScheduleId {
      get { return scheduleId_; }
      set {
        scheduleId_ = value;
      }
    }

    /// <summary>Field number for the "statuses" field.</summary>
    public const int StatusesFieldNumber = 3;
    private static readonly pb::FieldCodec<int> _repeated_statuses_codec
        = pb::FieldCodec.ForInt32(26);
    private readonly pbc::RepeatedField<int> statuses_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> Statuses {
      get { return statuses_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AttendanceListRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AttendanceListRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!sid_.Equals(other.sid_)) return false;
      if (ScheduleId != other.ScheduleId) return false;
      if(!statuses_.Equals(other.statuses_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= sid_.GetHashCode();
      if (ScheduleId != 0) hash ^= ScheduleId.GetHashCode();
      hash ^= statuses_.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      sid_.WriteTo(output, _repeated_sid_codec);
      if (ScheduleId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ScheduleId);
      }
      statuses_.WriteTo(output, _repeated_statuses_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      sid_.WriteTo(ref output, _repeated_sid_codec);
      if (ScheduleId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ScheduleId);
      }
      statuses_.WriteTo(ref output, _repeated_statuses_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += sid_.CalculateSize(_repeated_sid_codec);
      if (ScheduleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ScheduleId);
      }
      size += statuses_.CalculateSize(_repeated_statuses_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AttendanceListRequest other) {
      if (other == null) {
        return;
      }
      sid_.Add(other.sid_);
      if (other.ScheduleId != 0) {
        ScheduleId = other.ScheduleId;
      }
      statuses_.Add(other.statuses_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10:
          case 8: {
            sid_.AddEntriesFrom(input, _repeated_sid_codec);
            break;
          }
          case 16: {
            ScheduleId = input.ReadInt32();
            break;
          }
          case 26:
          case 24: {
            statuses_.AddEntriesFrom(input, _repeated_statuses_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10:
          case 8: {
            sid_.AddEntriesFrom(ref input, _repeated_sid_codec);
            break;
          }
          case 16: {
            ScheduleId = input.ReadInt32();
            break;
          }
          case 26:
          case 24: {
            statuses_.AddEntriesFrom(ref input, _repeated_statuses_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class AttendanceListResponse : pb::IMessage<AttendanceListResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AttendanceListResponse> _parser = new pb::MessageParser<AttendanceListResponse>(() => new AttendanceListResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AttendanceListResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AttendanceGrpcServer.AttendanceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AttendanceListResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AttendanceListResponse(AttendanceListResponse other) : this() {
      sid_ = other.sid_.Clone();
      message_ = other.message_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AttendanceListResponse Clone() {
      return new AttendanceListResponse(this);
    }

    /// <summary>Field number for the "sid" field.</summary>
    public const int SidFieldNumber = 1;
    private static readonly pb::FieldCodec<int> _repeated_sid_codec
        = pb::FieldCodec.ForInt32(10);
    private readonly pbc::RepeatedField<int> sid_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> Sid {
      get { return sid_; }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 2;
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
      return Equals(other as AttendanceListResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AttendanceListResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!sid_.Equals(other.sid_)) return false;
      if (Message != other.Message) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= sid_.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      sid_.WriteTo(output, _repeated_sid_codec);
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      sid_.WriteTo(ref output, _repeated_sid_codec);
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += sid_.CalculateSize(_repeated_sid_codec);
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AttendanceListResponse other) {
      if (other == null) {
        return;
      }
      sid_.Add(other.sid_);
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10:
          case 8: {
            sid_.AddEntriesFrom(input, _repeated_sid_codec);
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10:
          case 8: {
            sid_.AddEntriesFrom(ref input, _repeated_sid_codec);
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Responses/ListGymBadgesResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/ListGymBadgesResponse.proto</summary>
  public static partial class ListGymBadgesResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/ListGymBadgesResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ListGymBadgesResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjtQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0xpc3RHeW1CYWRn",
            "ZXNSZXNwb25zZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3Bv",
            "bnNlcxorUE9HT1Byb3Rvcy9EYXRhL0JhZGdlL0F3YXJkZWRHeW1CYWRnZS5w",
            "cm90byJSChVMaXN0R3ltQmFkZ2VzUmVzcG9uc2USOQoJZ3ltX2JhZGdlGAEg",
            "AygLMiYuUE9HT1Byb3Rvcy5EYXRhLkJhZGdlLkF3YXJkZWRHeW1CYWRnZWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Badge.AwardedGymBadgeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.ListGymBadgesResponse), global::POGOProtos.Networking.Responses.ListGymBadgesResponse.Parser, new[]{ "GymBadge" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ListGymBadgesResponse : pb::IMessage<ListGymBadgesResponse> {
    private static readonly pb::MessageParser<ListGymBadgesResponse> _parser = new pb::MessageParser<ListGymBadgesResponse>(() => new ListGymBadgesResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListGymBadgesResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.ListGymBadgesResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListGymBadgesResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListGymBadgesResponse(ListGymBadgesResponse other) : this() {
      gymBadge_ = other.gymBadge_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListGymBadgesResponse Clone() {
      return new ListGymBadgesResponse(this);
    }

    /// <summary>Field number for the "gym_badge" field.</summary>
    public const int GymBadgeFieldNumber = 1;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.Badge.AwardedGymBadge> _repeated_gymBadge_codec
        = pb::FieldCodec.ForMessage(10, global::POGOProtos.Data.Badge.AwardedGymBadge.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.Badge.AwardedGymBadge> gymBadge_ = new pbc::RepeatedField<global::POGOProtos.Data.Badge.AwardedGymBadge>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.Badge.AwardedGymBadge> GymBadge {
      get { return gymBadge_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListGymBadgesResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListGymBadgesResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!gymBadge_.Equals(other.gymBadge_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= gymBadge_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      gymBadge_.WriteTo(output, _repeated_gymBadge_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += gymBadge_.CalculateSize(_repeated_gymBadge_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListGymBadgesResponse other) {
      if (other == null) {
        return;
      }
      gymBadge_.Add(other.gymBadge_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            gymBadge_.AddEntriesFrom(input, _repeated_gymBadge_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

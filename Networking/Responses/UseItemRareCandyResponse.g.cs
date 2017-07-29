// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Responses/UseItemRareCandyResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/UseItemRareCandyResponse.proto</summary>
  public static partial class UseItemRareCandyResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/UseItemRareCandyResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseItemRareCandyResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5QT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1VzZUl0ZW1SYXJl",
            "Q2FuZHlSZXNwb25zZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJl",
            "c3BvbnNlcyKWAgoYVXNlSXRlbVJhcmVDYW5keVJlc3BvbnNlElAKBnJlc3Vs",
            "dBgBIAEoDjJALlBPR09Qcm90b3MuTmV0d29ya2luZy5SZXNwb25zZXMuVXNl",
            "SXRlbVJhcmVDYW5keVJlc3BvbnNlLlJlc3VsdBISCgpwb2tlbW9uX2lkGAIg",
            "ASgGEhsKE3VwZGF0ZWRfY2FuZHlfY291bnQYAyABKAUidwoGUmVzdWx0EgkK",
            "BVVOU0VUEAASCwoHU1VDQ0VTUxABEhYKEklOVkFMSURfUE9LRU1PTl9JRBAC",
            "Eg0KCU5PX1BMQVlFUhADEhMKD1dST05HX0lURU1fVFlQRRAEEhkKFUlURU1f",
            "Tk9UX0lOX0lOVkVOVE9SWRAFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.UseItemRareCandyResponse), global::POGOProtos.Networking.Responses.UseItemRareCandyResponse.Parser, new[]{ "Result", "PokemonId", "UpdatedCandyCount" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.UseItemRareCandyResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UseItemRareCandyResponse : pb::IMessage<UseItemRareCandyResponse> {
    private static readonly pb::MessageParser<UseItemRareCandyResponse> _parser = new pb::MessageParser<UseItemRareCandyResponse>(() => new UseItemRareCandyResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UseItemRareCandyResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.UseItemRareCandyResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemRareCandyResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemRareCandyResponse(UseItemRareCandyResponse other) : this() {
      result_ = other.result_;
      pokemonId_ = other.pokemonId_;
      updatedCandyCount_ = other.updatedCandyCount_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemRareCandyResponse Clone() {
      return new UseItemRareCandyResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.UseItemRareCandyResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.UseItemRareCandyResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_id" field.</summary>
    public const int PokemonIdFieldNumber = 2;
    private ulong pokemonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong PokemonId {
      get { return pokemonId_; }
      set {
        pokemonId_ = value;
      }
    }

    /// <summary>Field number for the "updated_candy_count" field.</summary>
    public const int UpdatedCandyCountFieldNumber = 3;
    private int updatedCandyCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UpdatedCandyCount {
      get { return updatedCandyCount_; }
      set {
        updatedCandyCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UseItemRareCandyResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UseItemRareCandyResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (PokemonId != other.PokemonId) return false;
      if (UpdatedCandyCount != other.UpdatedCandyCount) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (PokemonId != 0UL) hash ^= PokemonId.GetHashCode();
      if (UpdatedCandyCount != 0) hash ^= UpdatedCandyCount.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (PokemonId != 0UL) {
        output.WriteRawTag(17);
        output.WriteFixed64(PokemonId);
      }
      if (UpdatedCandyCount != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(UpdatedCandyCount);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (PokemonId != 0UL) {
        size += 1 + 8;
      }
      if (UpdatedCandyCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UpdatedCandyCount);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UseItemRareCandyResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.PokemonId != 0UL) {
        PokemonId = other.PokemonId;
      }
      if (other.UpdatedCandyCount != 0) {
        UpdatedCandyCount = other.UpdatedCandyCount;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            result_ = (global::POGOProtos.Networking.Responses.UseItemRareCandyResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 17: {
            PokemonId = input.ReadFixed64();
            break;
          }
          case 24: {
            UpdatedCandyCount = input.ReadInt32();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the UseItemRareCandyResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("INVALID_POKEMON_ID")] InvalidPokemonId = 2,
        [pbr::OriginalName("NO_PLAYER")] NoPlayer = 3,
        [pbr::OriginalName("WRONG_ITEM_TYPE")] WrongItemType = 4,
        [pbr::OriginalName("ITEM_NOT_IN_INVENTORY")] ItemNotInInventory = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Data/Logs/RaidRewardsLogEntry.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Logs {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Logs/RaidRewardsLogEntry.proto</summary>
  public static partial class RaidRewardsLogEntryReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Logs/RaidRewardsLogEntry.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RaidRewardsLogEntryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5QT0dPUHJvdG9zL0RhdGEvTG9ncy9SYWlkUmV3YXJkc0xvZ0VudHJ5LnBy",
            "b3RvEhRQT0dPUHJvdG9zLkRhdGEuTG9ncxooUE9HT1Byb3Rvcy9JbnZlbnRv",
            "cnkvSXRlbS9JdGVtRGF0YS5wcm90byKTAgoTUmFpZFJld2FyZHNMb2dFbnRy",
            "eRJACgZyZXN1bHQYASABKA4yMC5QT0dPUHJvdG9zLkRhdGEuTG9ncy5SYWlk",
            "UmV3YXJkc0xvZ0VudHJ5LlJlc3VsdBIUCgxpc19leGNsdXNpdmUYAiABKAgS",
            "MgoFaXRlbXMYAyADKAsyIy5QT0dPUHJvdG9zLkludmVudG9yeS5JdGVtLkl0",
            "ZW1EYXRhEjwKD2RlZmF1bHRfcmV3YXJkcxgEIAMoCzIjLlBPR09Qcm90b3Mu",
            "SW52ZW50b3J5Lkl0ZW0uSXRlbURhdGESEAoIc3RhcmR1c3QYBSABKAUiIAoG",
            "UmVzdWx0EgkKBVVOU0VUEAASCwoHU1VDQ0VTUxABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Inventory.Item.ItemDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Logs.RaidRewardsLogEntry), global::POGOProtos.Data.Logs.RaidRewardsLogEntry.Parser, new[]{ "Result", "IsExclusive", "Items", "DefaultRewards", "Stardust" }, null, new[]{ typeof(global::POGOProtos.Data.Logs.RaidRewardsLogEntry.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RaidRewardsLogEntry : pb::IMessage<RaidRewardsLogEntry> {
    private static readonly pb::MessageParser<RaidRewardsLogEntry> _parser = new pb::MessageParser<RaidRewardsLogEntry>(() => new RaidRewardsLogEntry());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RaidRewardsLogEntry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Logs.RaidRewardsLogEntryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RaidRewardsLogEntry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RaidRewardsLogEntry(RaidRewardsLogEntry other) : this() {
      result_ = other.result_;
      isExclusive_ = other.isExclusive_;
      items_ = other.items_.Clone();
      defaultRewards_ = other.defaultRewards_.Clone();
      stardust_ = other.stardust_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RaidRewardsLogEntry Clone() {
      return new RaidRewardsLogEntry(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Data.Logs.RaidRewardsLogEntry.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Logs.RaidRewardsLogEntry.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "is_exclusive" field.</summary>
    public const int IsExclusiveFieldNumber = 2;
    private bool isExclusive_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsExclusive {
      get { return isExclusive_; }
      set {
        isExclusive_ = value;
      }
    }

    /// <summary>Field number for the "items" field.</summary>
    public const int ItemsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::POGOProtos.Inventory.Item.ItemData> _repeated_items_codec
        = pb::FieldCodec.ForMessage(26, global::POGOProtos.Inventory.Item.ItemData.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Inventory.Item.ItemData> items_ = new pbc::RepeatedField<global::POGOProtos.Inventory.Item.ItemData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Inventory.Item.ItemData> Items {
      get { return items_; }
    }

    /// <summary>Field number for the "default_rewards" field.</summary>
    public const int DefaultRewardsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::POGOProtos.Inventory.Item.ItemData> _repeated_defaultRewards_codec
        = pb::FieldCodec.ForMessage(34, global::POGOProtos.Inventory.Item.ItemData.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Inventory.Item.ItemData> defaultRewards_ = new pbc::RepeatedField<global::POGOProtos.Inventory.Item.ItemData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Inventory.Item.ItemData> DefaultRewards {
      get { return defaultRewards_; }
    }

    /// <summary>Field number for the "stardust" field.</summary>
    public const int StardustFieldNumber = 5;
    private int stardust_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Stardust {
      get { return stardust_; }
      set {
        stardust_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RaidRewardsLogEntry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RaidRewardsLogEntry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (IsExclusive != other.IsExclusive) return false;
      if(!items_.Equals(other.items_)) return false;
      if(!defaultRewards_.Equals(other.defaultRewards_)) return false;
      if (Stardust != other.Stardust) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (IsExclusive != false) hash ^= IsExclusive.GetHashCode();
      hash ^= items_.GetHashCode();
      hash ^= defaultRewards_.GetHashCode();
      if (Stardust != 0) hash ^= Stardust.GetHashCode();
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
      if (IsExclusive != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsExclusive);
      }
      items_.WriteTo(output, _repeated_items_codec);
      defaultRewards_.WriteTo(output, _repeated_defaultRewards_codec);
      if (Stardust != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Stardust);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (IsExclusive != false) {
        size += 1 + 1;
      }
      size += items_.CalculateSize(_repeated_items_codec);
      size += defaultRewards_.CalculateSize(_repeated_defaultRewards_codec);
      if (Stardust != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Stardust);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RaidRewardsLogEntry other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.IsExclusive != false) {
        IsExclusive = other.IsExclusive;
      }
      items_.Add(other.items_);
      defaultRewards_.Add(other.defaultRewards_);
      if (other.Stardust != 0) {
        Stardust = other.Stardust;
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
            result_ = (global::POGOProtos.Data.Logs.RaidRewardsLogEntry.Types.Result) input.ReadEnum();
            break;
          }
          case 16: {
            IsExclusive = input.ReadBool();
            break;
          }
          case 26: {
            items_.AddEntriesFrom(input, _repeated_items_codec);
            break;
          }
          case 34: {
            defaultRewards_.AddEntriesFrom(input, _repeated_defaultRewards_codec);
            break;
          }
          case 40: {
            Stardust = input.ReadInt32();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the RaidRewardsLogEntry message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code

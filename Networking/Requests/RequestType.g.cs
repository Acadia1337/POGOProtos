// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Requests/RequestType.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/RequestType.proto</summary>
  public static partial class RequestTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Requests/RequestType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RequestTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvUmVxdWVzdFR5cGUu",
            "cHJvdG8SHlBPR09Qcm90b3MuTmV0d29ya2luZy5SZXF1ZXN0cyqyEAoLUmVx",
            "dWVzdFR5cGUSEAoMTUVUSE9EX1VOU0VUEAASDgoKR0VUX1BMQVlFUhACEhEK",
            "DUdFVF9JTlZFTlRPUlkQBBIVChFET1dOTE9BRF9TRVRUSU5HUxAFEhsKF0RP",
            "V05MT0FEX0lURU1fVEVNUExBVEVTEAYSIgoeRE9XTkxPQURfUkVNT1RFX0NP",
            "TkZJR19WRVJTSU9OEAcSHgoaUkVHSVNURVJfQkFDS0dST1VORF9ERVZJQ0UQ",
            "CBIPCgtGT1JUX1NFQVJDSBBlEg0KCUVOQ09VTlRFUhBmEhEKDUNBVENIX1BP",
            "S0VNT04QZxIQCgxGT1JUX0RFVEFJTFMQaBITCg9HRVRfTUFQX09CSkVDVFMQ",
            "ahIXChNGT1JUX0RFUExPWV9QT0tFTU9OEG4SFwoTRk9SVF9SRUNBTExfUE9L",
            "RU1PThBvEhMKD1JFTEVBU0VfUE9LRU1PThBwEhMKD1VTRV9JVEVNX1BPVElP",
            "ThBxEhQKEFVTRV9JVEVNX0NBUFRVUkUQchIRCg1VU0VfSVRFTV9GTEVFEHMS",
            "EwoPVVNFX0lURU1fUkVWSVZFEHQSFgoSR0VUX1BMQVlFUl9QUk9GSUxFEHkS",
            "EgoORVZPTFZFX1BPS0VNT04QfRIUChBHRVRfSEFUQ0hFRF9FR0dTEH4SHwob",
            "RU5DT1VOVEVSX1RVVE9SSUFMX0NPTVBMRVRFEH8SFQoQTEVWRUxfVVBfUkVX",
            "QVJEUxCAARIZChRDSEVDS19BV0FSREVEX0JBREdFUxCBARIRCgxVU0VfSVRF",
            "TV9HWU0QhQESFAoPR0VUX0dZTV9ERVRBSUxTEIYBEhUKEFNUQVJUX0dZTV9C",
            "QVRUTEUQhwESDwoKQVRUQUNLX0dZTRCIARIbChZSRUNZQ0xFX0lOVkVOVE9S",
            "WV9JVEVNEIkBEhgKE0NPTExFQ1RfREFJTFlfQk9OVVMQigESFgoRVVNFX0lU",
            "RU1fWFBfQk9PU1QQiwESGwoWVVNFX0lURU1fRUdHX0lOQ1VCQVRPUhCMARIQ",
            "CgtVU0VfSU5DRU5TRRCNARIYChNHRVRfSU5DRU5TRV9QT0tFTU9OEI4BEhYK",
            "EUlOQ0VOU0VfRU5DT1VOVEVSEI8BEhYKEUFERF9GT1JUX01PRElGSUVSEJAB",
            "EhMKDkRJU0tfRU5DT1VOVEVSEJEBEiEKHENPTExFQ1RfREFJTFlfREVGRU5E",
            "RVJfQk9OVVMQkgESFAoPVVBHUkFERV9QT0tFTU9OEJMBEhkKFFNFVF9GQVZP",
            "UklURV9QT0tFTU9OEJQBEhUKEE5JQ0tOQU1FX1BPS0VNT04QlQESEAoLRVFV",
            "SVBfQkFER0UQlgESGQoUU0VUX0NPTlRBQ1RfU0VUVElOR1MQlwESFgoRU0VU",
            "X0JVRERZX1BPS0VNT04QmAESFQoQR0VUX0JVRERZX1dBTEtFRBCZARIXChJV",
            "U0VfSVRFTV9FTkNPVU5URVIQmgESDwoKR1lNX0RFUExPWRCbARIRCgxHWU1f",
            "R0VUX0lORk8QnAESFgoRR1lNX1NUQVJUX1NFU1NJT04QnQESFgoRR1lNX0JB",
            "VFRMRV9BVFRBQ0sQngESDwoKSk9JTl9MT0JCWRCfARIQCgtMRUFWRV9MT0JC",
            "WRCgARIZChRTRVRfTE9CQllfVklTSUJJTElUWRChARIWChFTRVRfTE9CQllf",
            "UE9LRU1PThCiARIVChBHRVRfUkFJRF9ERVRBSUxTEKMBEhUKEEdZTV9GRUVE",
            "X1BPS0VNT04QpAESFgoRU1RBUlRfUkFJRF9CQVRUTEUQpQESEAoLQVRUQUNL",
            "X1JBSUQQpgESFQoQR0VUX0FTU0VUX0RJR0VTVBCsAhIWChFHRVRfRE9XTkxP",
            "QURfVVJMUxCtAhITCg5DTEFJTV9DT0RFTkFNRRCTAxIPCgpTRVRfQVZBVEFS",
            "EJQDEhQKD1NFVF9QTEFZRVJfVEVBTRCVAxIbChZNQVJLX1RVVE9SSUFMX0NP",
            "TVBMRVRFEJYDEhQKD0NIRUNLX0NIQUxMRU5HRRDYBBIVChBWRVJJRllfQ0hB",
            "TExFTkdFENkEEgkKBEVDSE8QmgUSFwoSU0ZJREFfUkVHSVNUUkFUSU9OEKAG",
            "EhUKEFNGSURBX0FDVElPTl9MT0cQoQYSGAoTU0ZJREFfQ0VSVElGSUNBVElP",
            "ThCiBhIRCgxTRklEQV9VUERBVEUQowYSEQoMU0ZJREFfQUNUSU9OEKQGEhEK",
            "DFNGSURBX0RPV1NFUhClBhISCg1TRklEQV9DQVBUVVJFEKYGEh8KGkxJU1Rf",
            "QVZBVEFSX0NVU1RPTUlaQVRJT05TEKcGEh4KGVNFVF9BVkFUQVJfSVRFTV9B",
            "U19WSUVXRUQQqAYSDgoJR0VUX0lOQk9YEKkGEhQKD0xJU1RfR1lNX0JBREdF",
            "UxCrBhIaChVHRVRfR1lNX0JBREdFX0RFVEFJTFMQrAYSGQoUVVNFX0lURU1f",
            "TU9WRV9SRVJPTEwQrQYSGAoTVVNFX0lURU1fUkFSRV9DQU5EWRCuBhIbChZB",
            "V0FSRF9GUkVFX1JBSURfVElDS0VUEK8GEh8KGlJFR0lTVEVSX1BVU0hfTk9U",
            "SUZJQ0FUSU9OEIgnEiEKHFVOUkVHSVNURVJfUFVTSF9OT1RJRklDQVRJT04Q",
            "iScSHwoaVVBEQVRFX05PVElGSUNBVElPTl9TVEFUVVMQiicSJwoiT1BUX09V",
            "VF9QVVNIX05PVElGSUNBVElPTl9DQVRFR09SWRCLJxIjCh5ET1dOTE9BRF9H",
            "QU1FX01BU1RFUl9URU1QTEFURVMQjCdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Networking.Requests.RequestType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum RequestType {
    /// <summary>
    /// No implementation required
    /// </summary>
    [pbr::OriginalName("METHOD_UNSET")] MethodUnset = 0,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_PLAYER")] GetPlayer = 2,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_INVENTORY")] GetInventory = 4,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("DOWNLOAD_SETTINGS")] DownloadSettings = 5,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("DOWNLOAD_ITEM_TEMPLATES")] DownloadItemTemplates = 6,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("DOWNLOAD_REMOTE_CONFIG_VERSION")] DownloadRemoteConfigVersion = 7,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("REGISTER_BACKGROUND_DEVICE")] RegisterBackgroundDevice = 8,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("FORT_SEARCH")] FortSearch = 101,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("ENCOUNTER")] Encounter = 102,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("CATCH_POKEMON")] CatchPokemon = 103,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("FORT_DETAILS")] FortDetails = 104,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_MAP_OBJECTS")] GetMapObjects = 106,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("FORT_DEPLOY_POKEMON")] FortDeployPokemon = 110,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("FORT_RECALL_POKEMON")] FortRecallPokemon = 111,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("RELEASE_POKEMON")] ReleasePokemon = 112,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_POTION")] UseItemPotion = 113,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_CAPTURE")] UseItemCapture = 114,
    /// <summary>
    /// Can't find this one
    /// </summary>
    [pbr::OriginalName("USE_ITEM_FLEE")] UseItemFlee = 115,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_REVIVE")] UseItemRevive = 116,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_PLAYER_PROFILE")] GetPlayerProfile = 121,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("EVOLVE_POKEMON")] EvolvePokemon = 125,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_HATCHED_EGGS")] GetHatchedEggs = 126,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("ENCOUNTER_TUTORIAL_COMPLETE")] EncounterTutorialComplete = 127,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("LEVEL_UP_REWARDS")] LevelUpRewards = 128,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("CHECK_AWARDED_BADGES")] CheckAwardedBadges = 129,
    /// <summary>
    /// Removed
    /// </summary>
    [pbr::OriginalName("USE_ITEM_GYM")] UseItemGym = 133,
    /// <summary>
    /// Removed
    /// </summary>
    [pbr::OriginalName("GET_GYM_DETAILS")] GetGymDetails = 134,
    /// <summary>
    /// Removed
    /// </summary>
    [pbr::OriginalName("START_GYM_BATTLE")] StartGymBattle = 135,
    /// <summary>
    /// Removed
    /// </summary>
    [pbr::OriginalName("ATTACK_GYM")] AttackGym = 136,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("RECYCLE_INVENTORY_ITEM")] RecycleInventoryItem = 137,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("COLLECT_DAILY_BONUS")] CollectDailyBonus = 138,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_XP_BOOST")] UseItemXpBoost = 139,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_EGG_INCUBATOR")] UseItemEggIncubator = 140,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_INCENSE")] UseIncense = 141,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_INCENSE_POKEMON")] GetIncensePokemon = 142,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("INCENSE_ENCOUNTER")] IncenseEncounter = 143,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("ADD_FORT_MODIFIER")] AddFortModifier = 144,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("DISK_ENCOUNTER")] DiskEncounter = 145,
    /// <summary>
    /// Removed
    /// </summary>
    [pbr::OriginalName("COLLECT_DAILY_DEFENDER_BONUS")] CollectDailyDefenderBonus = 146,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("UPGRADE_POKEMON")] UpgradePokemon = 147,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SET_FAVORITE_POKEMON")] SetFavoritePokemon = 148,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("NICKNAME_POKEMON")] NicknamePokemon = 149,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("EQUIP_BADGE")] EquipBadge = 150,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SET_CONTACT_SETTINGS")] SetContactSettings = 151,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SET_BUDDY_POKEMON")] SetBuddyPokemon = 152,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_BUDDY_WALKED")] GetBuddyWalked = 153,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_ENCOUNTER")] UseItemEncounter = 154,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GYM_DEPLOY")] GymDeploy = 155,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GYM_GET_INFO")] GymGetInfo = 156,
    /// <summary>
    /// Not yet released.
    /// </summary>
    [pbr::OriginalName("GYM_START_SESSION")] GymStartSession = 157,
    /// <summary>
    /// Not yet released.
    /// </summary>
    [pbr::OriginalName("GYM_BATTLE_ATTACK")] GymBattleAttack = 158,
    /// <summary>
    /// Not yet released.
    /// </summary>
    [pbr::OriginalName("JOIN_LOBBY")] JoinLobby = 159,
    /// <summary>
    /// Not yet released.
    /// </summary>
    [pbr::OriginalName("LEAVE_LOBBY")] LeaveLobby = 160,
    /// <summary>
    /// Not yet released.
    /// </summary>
    [pbr::OriginalName("SET_LOBBY_VISIBILITY")] SetLobbyVisibility = 161,
    /// <summary>
    /// Not yet released.
    /// </summary>
    [pbr::OriginalName("SET_LOBBY_POKEMON")] SetLobbyPokemon = 162,
    /// <summary>
    /// Not yet released.
    /// </summary>
    [pbr::OriginalName("GET_RAID_DETAILS")] GetRaidDetails = 163,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GYM_FEED_POKEMON")] GymFeedPokemon = 164,
    /// <summary>
    /// Not yet released.
    /// </summary>
    [pbr::OriginalName("START_RAID_BATTLE")] StartRaidBattle = 165,
    /// <summary>
    /// Not yet released.
    /// </summary>
    [pbr::OriginalName("ATTACK_RAID")] AttackRaid = 166,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_ASSET_DIGEST")] GetAssetDigest = 300,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_DOWNLOAD_URLS")] GetDownloadUrls = 301,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("CLAIM_CODENAME")] ClaimCodename = 403,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SET_AVATAR")] SetAvatar = 404,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SET_PLAYER_TEAM")] SetPlayerTeam = 405,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("MARK_TUTORIAL_COMPLETE")] MarkTutorialComplete = 406,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("CHECK_CHALLENGE")] CheckChallenge = 600,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("VERIFY_CHALLENGE")] VerifyChallenge = 601,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("ECHO")] Echo = 666,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SFIDA_REGISTRATION")] SfidaRegistration = 800,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SFIDA_ACTION_LOG")] SfidaActionLog = 801,
    /// <summary>
    /// Not yet released.
    /// </summary>
    [pbr::OriginalName("SFIDA_CERTIFICATION")] SfidaCertification = 802,
    /// <summary>
    /// Not yet released.
    /// </summary>
    [pbr::OriginalName("SFIDA_UPDATE")] SfidaUpdate = 803,
    /// <summary>
    /// Not yet released.
    /// </summary>
    [pbr::OriginalName("SFIDA_ACTION")] SfidaAction = 804,
    /// <summary>
    /// Not yet released.
    /// </summary>
    [pbr::OriginalName("SFIDA_DOWSER")] SfidaDowser = 805,
    /// <summary>
    /// Not yet released.
    /// </summary>
    [pbr::OriginalName("SFIDA_CAPTURE")] SfidaCapture = 806,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("LIST_AVATAR_CUSTOMIZATIONS")] ListAvatarCustomizations = 807,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SET_AVATAR_ITEM_AS_VIEWED")] SetAvatarItemAsViewed = 808,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_INBOX")] GetInbox = 809,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("LIST_GYM_BADGES")] ListGymBadges = 811,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_GYM_BADGE_DETAILS")] GetGymBadgeDetails = 812,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_MOVE_REROLL")] UseItemMoveReroll = 813,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_RARE_CANDY")] UseItemRareCandy = 814,
    /// <summary>
    /// Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("AWARD_FREE_RAID_TICKET")] AwardFreeRaidTicket = 815,
    [pbr::OriginalName("REGISTER_PUSH_NOTIFICATION")] RegisterPushNotification = 5000,
    [pbr::OriginalName("UNREGISTER_PUSH_NOTIFICATION")] UnregisterPushNotification = 5001,
    [pbr::OriginalName("UPDATE_NOTIFICATION_STATUS")] UpdateNotificationStatus = 5002,
    [pbr::OriginalName("OPT_OUT_PUSH_NOTIFICATION_CATEGORY")] OptOutPushNotificationCategory = 5003,
    /// <summary>
    ///GET_INVENTORY = 5005;
    /// </summary>
    [pbr::OriginalName("DOWNLOAD_GAME_MASTER_TEMPLATES")] DownloadGameMasterTemplates = 5004,
  }

  #endregion

}

#endregion Designer generated code

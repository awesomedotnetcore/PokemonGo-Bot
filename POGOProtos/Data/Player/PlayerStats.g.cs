// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Data/Player/PlayerStats.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Player {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Player/PlayerStats.proto</summary>
  public static partial class PlayerStatsReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Player/PlayerStats.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerStatsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihQT0dPUHJvdG9zL0RhdGEvUGxheWVyL1BsYXllclN0YXRzLnByb3RvEhZQ",
            "T0dPUHJvdG9zLkRhdGEuUGxheWVyIp4FCgtQbGF5ZXJTdGF0cxINCgVsZXZl",
            "bBgBIAEoBRISCgpleHBlcmllbmNlGAIgASgDEhUKDXByZXZfbGV2ZWxfeHAY",
            "AyABKAMSFQoNbmV4dF9sZXZlbF94cBgEIAEoAxIRCglrbV93YWxrZWQYBSAB",
            "KAISHAoUcG9rZW1vbnNfZW5jb3VudGVyZWQYBiABKAUSHgoWdW5pcXVlX3Bv",
            "a2VkZXhfZW50cmllcxgHIAEoBRIZChFwb2tlbW9uc19jYXB0dXJlZBgIIAEo",
            "BRISCgpldm9sdXRpb25zGAkgASgFEhgKEHBva2Vfc3RvcF92aXNpdHMYCiAB",
            "KAUSGAoQcG9rZWJhbGxzX3Rocm93bhgLIAEoBRIUCgxlZ2dzX2hhdGNoZWQY",
            "DCABKAUSGwoTYmlnX21hZ2lrYXJwX2NhdWdodBgNIAEoBRIZChFiYXR0bGVf",
            "YXR0YWNrX3dvbhgOIAEoBRIbChNiYXR0bGVfYXR0YWNrX3RvdGFsGA8gASgF",
            "EhsKE2JhdHRsZV9kZWZlbmRlZF93b24YECABKAUSGwoTYmF0dGxlX3RyYWlu",
            "aW5nX3dvbhgRIAEoBRIdChViYXR0bGVfdHJhaW5pbmdfdG90YWwYEiABKAUS",
            "HQoVcHJlc3RpZ2VfcmFpc2VkX3RvdGFsGBMgASgFEh4KFnByZXN0aWdlX2Ry",
            "b3BwZWRfdG90YWwYFCABKAUSGAoQcG9rZW1vbl9kZXBsb3llZBgVIAEoBRIe",
            "ChZwb2tlbW9uX2NhdWdodF9ieV90eXBlGBYgAygFEhwKFHNtYWxsX3JhdHRh",
            "dGFfY2F1Z2h0GBcgASgFEhQKDHVzZWRfa21fcG9vbBgYIAEoARIZChFsYXN0",
            "X2ttX3JlZmlsbF9tcxgZIAEoA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Player.PlayerStats), global::POGOProtos.Data.Player.PlayerStats.Parser, new[]{ "Level", "Experience", "PrevLevelXp", "NextLevelXp", "KmWalked", "PokemonsEncountered", "UniquePokedexEntries", "PokemonsCaptured", "Evolutions", "PokeStopVisits", "PokeballsThrown", "EggsHatched", "BigMagikarpCaught", "BattleAttackWon", "BattleAttackTotal", "BattleDefendedWon", "BattleTrainingWon", "BattleTrainingTotal", "PrestigeRaisedTotal", "PrestigeDroppedTotal", "PokemonDeployed", "PokemonCaughtByType", "SmallRattataCaught", "UsedKmPool", "LastKmRefillMs" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlayerStats : pb::IMessage<PlayerStats> {
    private static readonly pb::MessageParser<PlayerStats> _parser = new pb::MessageParser<PlayerStats>(() => new PlayerStats());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PlayerStats> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Player.PlayerStatsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerStats() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerStats(PlayerStats other) : this() {
      level_ = other.level_;
      experience_ = other.experience_;
      prevLevelXp_ = other.prevLevelXp_;
      nextLevelXp_ = other.nextLevelXp_;
      kmWalked_ = other.kmWalked_;
      pokemonsEncountered_ = other.pokemonsEncountered_;
      uniquePokedexEntries_ = other.uniquePokedexEntries_;
      pokemonsCaptured_ = other.pokemonsCaptured_;
      evolutions_ = other.evolutions_;
      pokeStopVisits_ = other.pokeStopVisits_;
      pokeballsThrown_ = other.pokeballsThrown_;
      eggsHatched_ = other.eggsHatched_;
      bigMagikarpCaught_ = other.bigMagikarpCaught_;
      battleAttackWon_ = other.battleAttackWon_;
      battleAttackTotal_ = other.battleAttackTotal_;
      battleDefendedWon_ = other.battleDefendedWon_;
      battleTrainingWon_ = other.battleTrainingWon_;
      battleTrainingTotal_ = other.battleTrainingTotal_;
      prestigeRaisedTotal_ = other.prestigeRaisedTotal_;
      prestigeDroppedTotal_ = other.prestigeDroppedTotal_;
      pokemonDeployed_ = other.pokemonDeployed_;
      pokemonCaughtByType_ = other.pokemonCaughtByType_.Clone();
      smallRattataCaught_ = other.smallRattataCaught_;
      usedKmPool_ = other.usedKmPool_;
      lastKmRefillMs_ = other.lastKmRefillMs_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerStats Clone() {
      return new PlayerStats(this);
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 1;
    private int level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "experience" field.</summary>
    public const int ExperienceFieldNumber = 2;
    private long experience_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Experience {
      get { return experience_; }
      set {
        experience_ = value;
      }
    }

    /// <summary>Field number for the "prev_level_xp" field.</summary>
    public const int PrevLevelXpFieldNumber = 3;
    private long prevLevelXp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long PrevLevelXp {
      get { return prevLevelXp_; }
      set {
        prevLevelXp_ = value;
      }
    }

    /// <summary>Field number for the "next_level_xp" field.</summary>
    public const int NextLevelXpFieldNumber = 4;
    private long nextLevelXp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long NextLevelXp {
      get { return nextLevelXp_; }
      set {
        nextLevelXp_ = value;
      }
    }

    /// <summary>Field number for the "km_walked" field.</summary>
    public const int KmWalkedFieldNumber = 5;
    private float kmWalked_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float KmWalked {
      get { return kmWalked_; }
      set {
        kmWalked_ = value;
      }
    }

    /// <summary>Field number for the "pokemons_encountered" field.</summary>
    public const int PokemonsEncounteredFieldNumber = 6;
    private int pokemonsEncountered_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PokemonsEncountered {
      get { return pokemonsEncountered_; }
      set {
        pokemonsEncountered_ = value;
      }
    }

    /// <summary>Field number for the "unique_pokedex_entries" field.</summary>
    public const int UniquePokedexEntriesFieldNumber = 7;
    private int uniquePokedexEntries_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UniquePokedexEntries {
      get { return uniquePokedexEntries_; }
      set {
        uniquePokedexEntries_ = value;
      }
    }

    /// <summary>Field number for the "pokemons_captured" field.</summary>
    public const int PokemonsCapturedFieldNumber = 8;
    private int pokemonsCaptured_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PokemonsCaptured {
      get { return pokemonsCaptured_; }
      set {
        pokemonsCaptured_ = value;
      }
    }

    /// <summary>Field number for the "evolutions" field.</summary>
    public const int EvolutionsFieldNumber = 9;
    private int evolutions_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Evolutions {
      get { return evolutions_; }
      set {
        evolutions_ = value;
      }
    }

    /// <summary>Field number for the "poke_stop_visits" field.</summary>
    public const int PokeStopVisitsFieldNumber = 10;
    private int pokeStopVisits_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PokeStopVisits {
      get { return pokeStopVisits_; }
      set {
        pokeStopVisits_ = value;
      }
    }

    /// <summary>Field number for the "pokeballs_thrown" field.</summary>
    public const int PokeballsThrownFieldNumber = 11;
    private int pokeballsThrown_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PokeballsThrown {
      get { return pokeballsThrown_; }
      set {
        pokeballsThrown_ = value;
      }
    }

    /// <summary>Field number for the "eggs_hatched" field.</summary>
    public const int EggsHatchedFieldNumber = 12;
    private int eggsHatched_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int EggsHatched {
      get { return eggsHatched_; }
      set {
        eggsHatched_ = value;
      }
    }

    /// <summary>Field number for the "big_magikarp_caught" field.</summary>
    public const int BigMagikarpCaughtFieldNumber = 13;
    private int bigMagikarpCaught_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BigMagikarpCaught {
      get { return bigMagikarpCaught_; }
      set {
        bigMagikarpCaught_ = value;
      }
    }

    /// <summary>Field number for the "battle_attack_won" field.</summary>
    public const int BattleAttackWonFieldNumber = 14;
    private int battleAttackWon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BattleAttackWon {
      get { return battleAttackWon_; }
      set {
        battleAttackWon_ = value;
      }
    }

    /// <summary>Field number for the "battle_attack_total" field.</summary>
    public const int BattleAttackTotalFieldNumber = 15;
    private int battleAttackTotal_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BattleAttackTotal {
      get { return battleAttackTotal_; }
      set {
        battleAttackTotal_ = value;
      }
    }

    /// <summary>Field number for the "battle_defended_won" field.</summary>
    public const int BattleDefendedWonFieldNumber = 16;
    private int battleDefendedWon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BattleDefendedWon {
      get { return battleDefendedWon_; }
      set {
        battleDefendedWon_ = value;
      }
    }

    /// <summary>Field number for the "battle_training_won" field.</summary>
    public const int BattleTrainingWonFieldNumber = 17;
    private int battleTrainingWon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BattleTrainingWon {
      get { return battleTrainingWon_; }
      set {
        battleTrainingWon_ = value;
      }
    }

    /// <summary>Field number for the "battle_training_total" field.</summary>
    public const int BattleTrainingTotalFieldNumber = 18;
    private int battleTrainingTotal_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BattleTrainingTotal {
      get { return battleTrainingTotal_; }
      set {
        battleTrainingTotal_ = value;
      }
    }

    /// <summary>Field number for the "prestige_raised_total" field.</summary>
    public const int PrestigeRaisedTotalFieldNumber = 19;
    private int prestigeRaisedTotal_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PrestigeRaisedTotal {
      get { return prestigeRaisedTotal_; }
      set {
        prestigeRaisedTotal_ = value;
      }
    }

    /// <summary>Field number for the "prestige_dropped_total" field.</summary>
    public const int PrestigeDroppedTotalFieldNumber = 20;
    private int prestigeDroppedTotal_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PrestigeDroppedTotal {
      get { return prestigeDroppedTotal_; }
      set {
        prestigeDroppedTotal_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_deployed" field.</summary>
    public const int PokemonDeployedFieldNumber = 21;
    private int pokemonDeployed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PokemonDeployed {
      get { return pokemonDeployed_; }
      set {
        pokemonDeployed_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_caught_by_type" field.</summary>
    public const int PokemonCaughtByTypeFieldNumber = 22;
    private static readonly pb::FieldCodec<int> _repeated_pokemonCaughtByType_codec
        = pb::FieldCodec.ForInt32(178);
    private readonly pbc::RepeatedField<int> pokemonCaughtByType_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> PokemonCaughtByType {
      get { return pokemonCaughtByType_; }
    }

    /// <summary>Field number for the "small_rattata_caught" field.</summary>
    public const int SmallRattataCaughtFieldNumber = 23;
    private int smallRattataCaught_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int SmallRattataCaught {
      get { return smallRattataCaught_; }
      set {
        smallRattataCaught_ = value;
      }
    }

    /// <summary>Field number for the "used_km_pool" field.</summary>
    public const int UsedKmPoolFieldNumber = 24;
    private double usedKmPool_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double UsedKmPool {
      get { return usedKmPool_; }
      set {
        usedKmPool_ = value;
      }
    }

    /// <summary>Field number for the "last_km_refill_ms" field.</summary>
    public const int LastKmRefillMsFieldNumber = 25;
    private long lastKmRefillMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long LastKmRefillMs {
      get { return lastKmRefillMs_; }
      set {
        lastKmRefillMs_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PlayerStats);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PlayerStats other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Level != other.Level) return false;
      if (Experience != other.Experience) return false;
      if (PrevLevelXp != other.PrevLevelXp) return false;
      if (NextLevelXp != other.NextLevelXp) return false;
      if (KmWalked != other.KmWalked) return false;
      if (PokemonsEncountered != other.PokemonsEncountered) return false;
      if (UniquePokedexEntries != other.UniquePokedexEntries) return false;
      if (PokemonsCaptured != other.PokemonsCaptured) return false;
      if (Evolutions != other.Evolutions) return false;
      if (PokeStopVisits != other.PokeStopVisits) return false;
      if (PokeballsThrown != other.PokeballsThrown) return false;
      if (EggsHatched != other.EggsHatched) return false;
      if (BigMagikarpCaught != other.BigMagikarpCaught) return false;
      if (BattleAttackWon != other.BattleAttackWon) return false;
      if (BattleAttackTotal != other.BattleAttackTotal) return false;
      if (BattleDefendedWon != other.BattleDefendedWon) return false;
      if (BattleTrainingWon != other.BattleTrainingWon) return false;
      if (BattleTrainingTotal != other.BattleTrainingTotal) return false;
      if (PrestigeRaisedTotal != other.PrestigeRaisedTotal) return false;
      if (PrestigeDroppedTotal != other.PrestigeDroppedTotal) return false;
      if (PokemonDeployed != other.PokemonDeployed) return false;
      if(!pokemonCaughtByType_.Equals(other.pokemonCaughtByType_)) return false;
      if (SmallRattataCaught != other.SmallRattataCaught) return false;
      if (UsedKmPool != other.UsedKmPool) return false;
      if (LastKmRefillMs != other.LastKmRefillMs) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Level != 0) hash ^= Level.GetHashCode();
      if (Experience != 0L) hash ^= Experience.GetHashCode();
      if (PrevLevelXp != 0L) hash ^= PrevLevelXp.GetHashCode();
      if (NextLevelXp != 0L) hash ^= NextLevelXp.GetHashCode();
      if (KmWalked != 0F) hash ^= KmWalked.GetHashCode();
      if (PokemonsEncountered != 0) hash ^= PokemonsEncountered.GetHashCode();
      if (UniquePokedexEntries != 0) hash ^= UniquePokedexEntries.GetHashCode();
      if (PokemonsCaptured != 0) hash ^= PokemonsCaptured.GetHashCode();
      if (Evolutions != 0) hash ^= Evolutions.GetHashCode();
      if (PokeStopVisits != 0) hash ^= PokeStopVisits.GetHashCode();
      if (PokeballsThrown != 0) hash ^= PokeballsThrown.GetHashCode();
      if (EggsHatched != 0) hash ^= EggsHatched.GetHashCode();
      if (BigMagikarpCaught != 0) hash ^= BigMagikarpCaught.GetHashCode();
      if (BattleAttackWon != 0) hash ^= BattleAttackWon.GetHashCode();
      if (BattleAttackTotal != 0) hash ^= BattleAttackTotal.GetHashCode();
      if (BattleDefendedWon != 0) hash ^= BattleDefendedWon.GetHashCode();
      if (BattleTrainingWon != 0) hash ^= BattleTrainingWon.GetHashCode();
      if (BattleTrainingTotal != 0) hash ^= BattleTrainingTotal.GetHashCode();
      if (PrestigeRaisedTotal != 0) hash ^= PrestigeRaisedTotal.GetHashCode();
      if (PrestigeDroppedTotal != 0) hash ^= PrestigeDroppedTotal.GetHashCode();
      if (PokemonDeployed != 0) hash ^= PokemonDeployed.GetHashCode();
      hash ^= pokemonCaughtByType_.GetHashCode();
      if (SmallRattataCaught != 0) hash ^= SmallRattataCaught.GetHashCode();
      if (UsedKmPool != 0D) hash ^= UsedKmPool.GetHashCode();
      if (LastKmRefillMs != 0L) hash ^= LastKmRefillMs.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Level != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Level);
      }
      if (Experience != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Experience);
      }
      if (PrevLevelXp != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(PrevLevelXp);
      }
      if (NextLevelXp != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(NextLevelXp);
      }
      if (KmWalked != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(KmWalked);
      }
      if (PokemonsEncountered != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(PokemonsEncountered);
      }
      if (UniquePokedexEntries != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(UniquePokedexEntries);
      }
      if (PokemonsCaptured != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(PokemonsCaptured);
      }
      if (Evolutions != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Evolutions);
      }
      if (PokeStopVisits != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(PokeStopVisits);
      }
      if (PokeballsThrown != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(PokeballsThrown);
      }
      if (EggsHatched != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(EggsHatched);
      }
      if (BigMagikarpCaught != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(BigMagikarpCaught);
      }
      if (BattleAttackWon != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(BattleAttackWon);
      }
      if (BattleAttackTotal != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(BattleAttackTotal);
      }
      if (BattleDefendedWon != 0) {
        output.WriteRawTag(128, 1);
        output.WriteInt32(BattleDefendedWon);
      }
      if (BattleTrainingWon != 0) {
        output.WriteRawTag(136, 1);
        output.WriteInt32(BattleTrainingWon);
      }
      if (BattleTrainingTotal != 0) {
        output.WriteRawTag(144, 1);
        output.WriteInt32(BattleTrainingTotal);
      }
      if (PrestigeRaisedTotal != 0) {
        output.WriteRawTag(152, 1);
        output.WriteInt32(PrestigeRaisedTotal);
      }
      if (PrestigeDroppedTotal != 0) {
        output.WriteRawTag(160, 1);
        output.WriteInt32(PrestigeDroppedTotal);
      }
      if (PokemonDeployed != 0) {
        output.WriteRawTag(168, 1);
        output.WriteInt32(PokemonDeployed);
      }
      pokemonCaughtByType_.WriteTo(output, _repeated_pokemonCaughtByType_codec);
      if (SmallRattataCaught != 0) {
        output.WriteRawTag(184, 1);
        output.WriteInt32(SmallRattataCaught);
      }
      if (UsedKmPool != 0D) {
        output.WriteRawTag(193, 1);
        output.WriteDouble(UsedKmPool);
      }
      if (LastKmRefillMs != 0L) {
        output.WriteRawTag(200, 1);
        output.WriteInt64(LastKmRefillMs);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
      }
      if (Experience != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Experience);
      }
      if (PrevLevelXp != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(PrevLevelXp);
      }
      if (NextLevelXp != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(NextLevelXp);
      }
      if (KmWalked != 0F) {
        size += 1 + 4;
      }
      if (PokemonsEncountered != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PokemonsEncountered);
      }
      if (UniquePokedexEntries != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UniquePokedexEntries);
      }
      if (PokemonsCaptured != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PokemonsCaptured);
      }
      if (Evolutions != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Evolutions);
      }
      if (PokeStopVisits != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PokeStopVisits);
      }
      if (PokeballsThrown != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PokeballsThrown);
      }
      if (EggsHatched != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EggsHatched);
      }
      if (BigMagikarpCaught != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BigMagikarpCaught);
      }
      if (BattleAttackWon != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BattleAttackWon);
      }
      if (BattleAttackTotal != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BattleAttackTotal);
      }
      if (BattleDefendedWon != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(BattleDefendedWon);
      }
      if (BattleTrainingWon != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(BattleTrainingWon);
      }
      if (BattleTrainingTotal != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(BattleTrainingTotal);
      }
      if (PrestigeRaisedTotal != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(PrestigeRaisedTotal);
      }
      if (PrestigeDroppedTotal != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(PrestigeDroppedTotal);
      }
      if (PokemonDeployed != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(PokemonDeployed);
      }
      size += pokemonCaughtByType_.CalculateSize(_repeated_pokemonCaughtByType_codec);
      if (SmallRattataCaught != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(SmallRattataCaught);
      }
      if (UsedKmPool != 0D) {
        size += 2 + 8;
      }
      if (LastKmRefillMs != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(LastKmRefillMs);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PlayerStats other) {
      if (other == null) {
        return;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.Experience != 0L) {
        Experience = other.Experience;
      }
      if (other.PrevLevelXp != 0L) {
        PrevLevelXp = other.PrevLevelXp;
      }
      if (other.NextLevelXp != 0L) {
        NextLevelXp = other.NextLevelXp;
      }
      if (other.KmWalked != 0F) {
        KmWalked = other.KmWalked;
      }
      if (other.PokemonsEncountered != 0) {
        PokemonsEncountered = other.PokemonsEncountered;
      }
      if (other.UniquePokedexEntries != 0) {
        UniquePokedexEntries = other.UniquePokedexEntries;
      }
      if (other.PokemonsCaptured != 0) {
        PokemonsCaptured = other.PokemonsCaptured;
      }
      if (other.Evolutions != 0) {
        Evolutions = other.Evolutions;
      }
      if (other.PokeStopVisits != 0) {
        PokeStopVisits = other.PokeStopVisits;
      }
      if (other.PokeballsThrown != 0) {
        PokeballsThrown = other.PokeballsThrown;
      }
      if (other.EggsHatched != 0) {
        EggsHatched = other.EggsHatched;
      }
      if (other.BigMagikarpCaught != 0) {
        BigMagikarpCaught = other.BigMagikarpCaught;
      }
      if (other.BattleAttackWon != 0) {
        BattleAttackWon = other.BattleAttackWon;
      }
      if (other.BattleAttackTotal != 0) {
        BattleAttackTotal = other.BattleAttackTotal;
      }
      if (other.BattleDefendedWon != 0) {
        BattleDefendedWon = other.BattleDefendedWon;
      }
      if (other.BattleTrainingWon != 0) {
        BattleTrainingWon = other.BattleTrainingWon;
      }
      if (other.BattleTrainingTotal != 0) {
        BattleTrainingTotal = other.BattleTrainingTotal;
      }
      if (other.PrestigeRaisedTotal != 0) {
        PrestigeRaisedTotal = other.PrestigeRaisedTotal;
      }
      if (other.PrestigeDroppedTotal != 0) {
        PrestigeDroppedTotal = other.PrestigeDroppedTotal;
      }
      if (other.PokemonDeployed != 0) {
        PokemonDeployed = other.PokemonDeployed;
      }
      pokemonCaughtByType_.Add(other.pokemonCaughtByType_);
      if (other.SmallRattataCaught != 0) {
        SmallRattataCaught = other.SmallRattataCaught;
      }
      if (other.UsedKmPool != 0D) {
        UsedKmPool = other.UsedKmPool;
      }
      if (other.LastKmRefillMs != 0L) {
        LastKmRefillMs = other.LastKmRefillMs;
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
            Level = input.ReadInt32();
            break;
          }
          case 16: {
            Experience = input.ReadInt64();
            break;
          }
          case 24: {
            PrevLevelXp = input.ReadInt64();
            break;
          }
          case 32: {
            NextLevelXp = input.ReadInt64();
            break;
          }
          case 45: {
            KmWalked = input.ReadFloat();
            break;
          }
          case 48: {
            PokemonsEncountered = input.ReadInt32();
            break;
          }
          case 56: {
            UniquePokedexEntries = input.ReadInt32();
            break;
          }
          case 64: {
            PokemonsCaptured = input.ReadInt32();
            break;
          }
          case 72: {
            Evolutions = input.ReadInt32();
            break;
          }
          case 80: {
            PokeStopVisits = input.ReadInt32();
            break;
          }
          case 88: {
            PokeballsThrown = input.ReadInt32();
            break;
          }
          case 96: {
            EggsHatched = input.ReadInt32();
            break;
          }
          case 104: {
            BigMagikarpCaught = input.ReadInt32();
            break;
          }
          case 112: {
            BattleAttackWon = input.ReadInt32();
            break;
          }
          case 120: {
            BattleAttackTotal = input.ReadInt32();
            break;
          }
          case 128: {
            BattleDefendedWon = input.ReadInt32();
            break;
          }
          case 136: {
            BattleTrainingWon = input.ReadInt32();
            break;
          }
          case 144: {
            BattleTrainingTotal = input.ReadInt32();
            break;
          }
          case 152: {
            PrestigeRaisedTotal = input.ReadInt32();
            break;
          }
          case 160: {
            PrestigeDroppedTotal = input.ReadInt32();
            break;
          }
          case 168: {
            PokemonDeployed = input.ReadInt32();
            break;
          }
          case 178:
          case 176: {
            pokemonCaughtByType_.AddEntriesFrom(input, _repeated_pokemonCaughtByType_codec);
            break;
          }
          case 184: {
            SmallRattataCaught = input.ReadInt32();
            break;
          }
          case 193: {
            UsedKmPool = input.ReadDouble();
            break;
          }
          case 200: {
            LastKmRefillMs = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
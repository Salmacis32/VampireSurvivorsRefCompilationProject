/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence;
using Coherence.Toolkit;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Stage;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Items
{
	public class TreasureChest : NetworkPickup // TypeDefIndex: 16092
	{
		// Fields
		[Sync]
		public byte[] SerializedTreasure; // 0x170
		private Treasure _treasure; // 0x178
		private bool _hasArcana; // 0x180
		private bool _hasEvo; // 0x181
		private bool _hasRandoms; // 0x182
		private bool _hasSpecial; // 0x183
		private static bool _globalTakeAssigned; // 0x00
	
		// Properties
		public bool HasArcana { get => default; set {} } // 0x0000000186EE6450-0x0000000186EE6460 0x0000000186EE6460-0x0000000186EE6470
		protected override bool UsesOrderedCommand { get => default; } // 0x0000000181958370-0x0000000181958380 
		public Treasure TreasureData { get => default; } // 0x0000000182917A20-0x0000000182917A30 
		public bool HasSpecial { get => default; } // 0x0000000186EE6470-0x0000000186EE6480 
		public int blessedTimes { get; set; } // 0x0000000182766980-0x0000000182766990 0x0000000182766990-0x00000001827669A0
	
		// Constructors
		public TreasureChest() {} // 0x0000000186EB9C10-0x0000000186EB9C20
	
		// Methods
		protected override void Awake() {} // 0x0000000186EE6480-0x0000000186EE64C0
		public void SetData(VampireSurvivors.Data.ItemType itemType, Treasure treasure) {} // 0x0000000186EE64C0-0x0000000186EE67A0
		private void UpdateSerializedTreasureData() {} // 0x0000000186EE67A0-0x0000000186EE6890
		public void SetArcana(bool hasArcana) {} // 0x0000000186EE6890-0x0000000186EE6900
		public void SetWithEvo() {} // 0x0000000186EE6900-0x0000000186EE6A00
		public void SetDarkVFX(bool hasRandoms) {} // 0x0000000186EE6A00-0x0000000186EE6A60
		public void SetSpecial() {} // 0x0000000186EE6A60-0x0000000186EE6AB0
		public override void InternalUpdate() {} // 0x0000000186EE6AB0-0x0000000186EE6C40
		[Command(defaultRouting = MessageTarget.AuthorityOnly)]
		public void RequestTreasureTake(CoherenceSync openingPlayer) {} // 0x0000000186EE6C40-0x0000000186EE7210
		[Command]
		public void PerformTreasureTake(long startingSimFrame, CoherenceSync openingPlayer, CoherenceSync winningPlayer, byte[] serializedPrizePairs, byte[] serializedWeaponPrizes, int coins, bool quickTreasureAnim, byte[] serializedTreasure) {} // 0x0000000186EE7210-0x0000000186EE7770
		public override void GetOnlineTaken() {} // 0x0000000186EE7770-0x0000000186EE7920
		public override void GetTaken() {} // 0x0000000186EE7920-0x0000000186EE7A80
		private void SpawnSpecial() {} // 0x0000000180B15170-0x0000000180B15180
		public void RemoveCursor() {} // 0x0000000186EE7A80-0x0000000186EE7B40
		public override void Despawn() {} // 0x0000000186EE7B40-0x0000000186EE7C10
		public override void Bless(float value, HitVfxType hitVFXType = HitVfxType.Prism /* Metadata: 0x01977B44 */) {} // 0x0000000186EE7C10-0x0000000186EE7EC0
		[Command]
		public void DoBless(int changedIndex) {} // 0x0000000186EE7EC0-0x0000000186EE8020
		private void AdjustTreasureLevelFromArcana() {} // 0x0000000186EE8020-0x0000000186EE80C0
		private void AddDefaultCursor() {} // 0x0000000186EE80C0-0x0000000186EE8370
		private void AddArcanaCursor() {} // 0x0000000186EE8370-0x0000000186EE8680
		protected override void TrackItemPickup(bool trackRunPickup = true /* Metadata: 0x01977B45 */) {} // 0x0000000186EE8680-0x0000000186EE8830
		private void CheckMinMaxStageValues() {} // 0x0000000186EE8830-0x0000000186EE8A50
	}
}

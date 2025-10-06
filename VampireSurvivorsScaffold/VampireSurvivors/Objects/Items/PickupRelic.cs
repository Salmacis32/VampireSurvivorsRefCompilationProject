/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using DG.Tweening;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Items;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Items
{
	public class PickupRelic : PickupGuarded // TypeDefIndex: 16058
	{
		// Fields
		private PhaserSprite _shadow; // 0x1D0
		private PhaserSprite _glow; // 0x1D8
		private VampireSurvivors.Data.ItemType _itemType; // 0x1E0
		private ItemData _itemData; // 0x1E8
		private float _colorValue; // 0x1F0
		private MultiTargetTween _floatTween; // 0x1F8
		private MultiTargetTween _shadowTween; // 0x200
		private Tween _glowTween; // 0x208
		private Action<float> _onPickedUpCallback; // 0x210
	
		// Properties
		[OnValueSynced("OnRelicTypeSetRemotely")]
		[Sync]
		public int SyncedRelicType { get => default; set {} } // 0x0000000184F61C80-0x0000000184F61C90 0x0000000184F61C90-0x0000000184F61CA0
		protected override bool UsesOrderedCommand { get => default; } // 0x0000000181958370-0x0000000181958380 
		public VampireSurvivors.Data.ItemType ItemType { get => default; } // 0x0000000184F61C80-0x0000000184F61C90 
		public PhaserSprite Shadow { get => default; } // 0x0000000182766C90-0x0000000182766CA0 
		public PhaserSprite Glow { get => default; } // 0x0000000182766D00-0x0000000182766D10 
		public Action<float> OnPickedUpCallback { get => default; set {} } // 0x0000000185FA1D70-0x0000000185FA1D80 0x0000000186753380-0x00000001867533E0
	
		// Constructors
		public PickupRelic() {} // 0x0000000186EB9040-0x0000000186EB9050
	
		// Methods
		protected override void Awake() {} // 0x0000000186ED43E0-0x0000000186ED4470
		protected override void OnDestroy() {} // 0x0000000186ED4470-0x0000000186ED4670
		public override void SetData(VampireSurvivors.Data.ItemType itemType) {} // 0x0000000186ED4670-0x0000000186ED4AA0
		public override void InternalUpdate() {} // 0x0000000186ED4AA0-0x0000000186ED4DF0
		public void SetItemType(VampireSurvivors.Data.ItemType itemType) {} // 0x0000000186ED4DF0-0x0000000186ED4F70
		public override void UpdateDepth() {} // 0x0000000186ED4F70-0x0000000186ED5020
		public override void Despawn() {} // 0x0000000186ED5020-0x0000000186ED50F0
		public override void GetTaken() {} // 0x0000000186ED50F0-0x0000000186ED51D0
		protected void OnRelicTypeSetRemotely(int oldType, int newType) {} // 0x0000000186ED51D0-0x0000000186ED51E0
		private void ProcessNewItemType() {} // 0x0000000186ED51E0-0x0000000186ED5350
		protected override void OnRecycle() {} // 0x0000000186ED5350-0x0000000186ED58D0
		private void UpdateGlowColor() {} // 0x0000000186ED58D0-0x0000000186ED5B90
		private void DisposeTweens() {} // 0x0000000186ED5B90-0x0000000186ED5CB0
		public void StopFloatTween() {} // 0x0000000186ED5CB0-0x0000000186ED5D30
		public void StartFloatTween() {} // 0x0000000186ED5D30-0x0000000186ED5F70
		public void SetVfxVisible(bool visible) {} // 0x0000000186ED5F70-0x0000000186ED5FF0
		protected override void TrackItemPickup(bool trackRunPickup = true /* Metadata: 0x01977A04 */) {} // 0x0000000186ED5FF0-0x0000000186ED6050
		public void SpawnCursor() {} // 0x0000000186ED6050-0x0000000186ED6360
		public void HideCursor() {} // 0x0000000186ED6360-0x0000000186ED6420
	}
}

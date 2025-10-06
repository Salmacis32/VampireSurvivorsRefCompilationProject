/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Items
{
	public class PickupWeapon : PickupGuarded // TypeDefIndex: 16060
	{
		// Fields
		private PhaserSprite _shadow; // 0x1D0
		private PhaserSprite _glow; // 0x1D8
		private WeaponType _weaponType; // 0x1E0
		private WeaponData _weaponData; // 0x1E8
		private LevelUpFactory _levelUpFactory; // 0x1F0
		private float _colorValue; // 0x1F8
		private bool _triggerOnGet; // 0x1FC
		private bool _despawnOnUnavailable; // 0x1FD
		private Tween _floatTween; // 0x200
		private Tween _shadowTween; // 0x208
		private Tween _glowTween; // 0x210
		private Sprite _sprite; // 0x218
		private VampireSurvivors.Objects.Characters.CharacterController _markedForSpecificCharacter; // 0x220
	
		// Properties
		public WeaponType WeaponType { get => default; } // 0x0000000184F61C80-0x0000000184F61C90 
		[OnValueSynced("OnWeaponUpdatedRemotely")]
		[Sync]
		public int SyncedWeaponType { get => default; set {} } // 0x0000000184F61C80-0x0000000184F61C90 0x0000000184F61C90-0x0000000184F61CA0
		[Sync]
		public bool DespawnOnUnavailable { get => default; set {} } // 0x0000000186ED90C0-0x0000000186ED90D0 0x0000000186ED90D0-0x0000000186ED90E0
		[Sync]
		public CoherenceSync MarkedForSpecificCharacter { get => default; set {} } // 0x0000000186ED90E0-0x0000000186ED91E0 0x0000000186ED91E0-0x0000000186ED93B0
		protected override bool UsesOrderedCommand { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public PickupWeapon() {} // 0x0000000186EDC1C0-0x0000000186EDC1D0
	
		// Methods
		[Inject]
		private void Construct(LevelUpFactory levelUpFactory) {} // 0x0000000186747280-0x00000001867472E0
		protected override void Awake() {} // 0x0000000186ED93B0-0x0000000186ED93F0
		protected override void OnDisable() {} // 0x0000000186ED93F0-0x0000000186ED94B0
		public override void GetOnlineTaken() {} // 0x0000000186ED94B0-0x0000000186ED94E0
		public void MarkForSpecificCharacter(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x0000000185562B70-0x0000000185562BD0
		public override void SetData(VampireSurvivors.Data.ItemType itemType) {} // 0x0000000186ED94E0-0x0000000186ED9B50
		public void SetWeaponType(WeaponType weaponType) {} // 0x0000000186ED9B50-0x0000000186ED9DD0
		public override void InternalUpdate() {} // 0x0000000186ED9DD0-0x0000000186EDA070
		public override void UpdateDepth() {} // 0x0000000180B15170-0x0000000180B15180
		public void TriggerOnGet() {} // 0x0000000186EDA070-0x0000000186EDA0A0
		public void StopFloat() {} // 0x0000000186EDA0A0-0x0000000186EDA0C0
		public void ResumeFloat() {} // 0x0000000186EDA0C0-0x0000000186EDA570
		public void SetVfxVisible(bool visible) {} // 0x0000000186ED5F70-0x0000000186ED5FF0
		private void OnWeaponUpdatedRemotely(int old, int newValue) {} // 0x0000000186EDA570-0x0000000186EDA580
		public override void Despawn() {} // 0x0000000186EDA580-0x0000000186EDA690
		protected override void OnRecycle() {} // 0x0000000186EDA690-0x0000000186EDADE0
		public override void GetTaken() {} // 0x0000000186EDADE0-0x0000000186EDAF50
		private bool ShouldAbortTake() => default; // 0x0000000186EDAF50-0x0000000186EDB4F0
		private void SetWeaponDataUnlocked(WeaponType weaponType) {} // 0x0000000186EDB4F0-0x0000000186EDB740
		private void UpdateColor() {} // 0x0000000186EDB740-0x0000000186EDBA00
		private void DisposeTweens() {} // 0x0000000186EDBA00-0x0000000186EDBB30
		private void CheckIfRemovedFromWeaponStore() {} // 0x0000000186EDBB30-0x0000000186EDBD00
		private void SpawnCursor() {} // 0x0000000186EDBD00-0x0000000186EDC0D0
		private void RemoveCursor() {} // 0x0000000186EDC0D0-0x0000000186EDC1A0
		protected override void ToggleCursors(UISignals.ToggleGuidesSignal sig) {} // 0x0000000186EDC1A0-0x0000000186EDC1C0
	}
}

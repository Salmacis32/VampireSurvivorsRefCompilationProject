/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Stages;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Props
{
	public class TP_PropDoor : Destructible // TypeDefIndex: 15378
	{
		// Fields
		private bool _hasFired; // 0xF8
		private MultiTargetTween _alphaTween; // 0x100
		private TPBiomeType BiomeType; // 0x108
		private VampireSurvivors.Data.ItemType linkedRelicType; // 0x10C
		private int doorType; // 0x110
	
		// Properties
		[Sync]
		public int LinkedRelicType { get => default; set {} } // 0x0000000185DD4EA0-0x0000000185DD4EB0 0x0000000186BA91F0-0x0000000186BA9200
		[OnValueSynced("OnDoorTypeChanged")]
		[Sync]
		public int DoorType { get => default; set {} } // 0x0000000184E07690-0x0000000184E076A0 0x0000000184E076A0-0x0000000184E076B0
	
		// Constructors
		public TP_PropDoor() {} // 0x00000001869ECEE0-0x00000001869ECF40
	
		// Methods
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019775FD */, float damageKb = 1f /* Metadata: 0x019775FE */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01977602 */, bool hasKb = true /* Metadata: 0x01977603 */) {} // 0x0000000180B15170-0x0000000180B15180
		protected virtual void OnRecycle() {} // 0x0000000180B15170-0x0000000180B15180
		public void SetRelicFromBiomeType(TPBiomeType biomeType) {} // 0x0000000186BA9200-0x0000000186BA9290
		public void SetType(int type) {} // 0x0000000186BA9290-0x0000000186BA9620
		protected override void SetupAnimations() {} // 0x0000000186B9B5A0-0x0000000186B9B5C0
		public override void Init(PropType destructibleType) {} // 0x0000000186BA9620-0x0000000186BA9740
		public override void Despawn() {} // 0x0000000186BA9740-0x0000000186BA9750
		public void ManualUpdate() {} // 0x0000000186BA9750-0x0000000186BA9E00
		protected override void OnUpdate() {} // 0x0000000186BA9E00-0x0000000186BA9E20
		protected void OnTriggeredByPlayer() {} // 0x0000000186BA9E20-0x0000000186BAA190
		public override bool DoesAllowVenting() => default; // 0x0000000180B15290-0x0000000180B152A0
		private void OnDoorTypeChanged(int old, int newDoor) {} // 0x0000000186BAA190-0x0000000186BAA1A0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Loot;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Props
{
	public class Prop_FB_Capsule : Destructible // TypeDefIndex: 15377
	{
		// Fields
		private float2 _startingPosition; // 0xF8
		private float _repeats; // 0x100
		private float _repeated; // 0x104
		private float _life; // 0x108
		private float _travelDuration; // 0x10C
		private bool _hasFired; // 0x110
		private static WeightedStore WEIGHTEDSTORE; // 0x00
		private float StartingX; // 0x114
		private float FinishingXOffset; // 0x118
		private float OffsetFromPlayerY; // 0x11C
		private float WaveMaxHeight; // 0x120
		private float _oscillations; // 0x124
		private float _accumulatedTime; // 0x128
	
		// Constructors
		public Prop_FB_Capsule() {} // 0x0000000186BA8FC0-0x0000000186BA9050
	
		// Methods
		public override void Init(PropType destructibleType) {} // 0x0000000186BA81B0-0x0000000186BA8510
		protected override bool CanEmitLight() => default; // 0x0000000180B15290-0x0000000180B152A0
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019775F6 */, float damageKb = 1f /* Metadata: 0x019775F7 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x019775FB */, bool hasKb = true /* Metadata: 0x019775FC */) {} // 0x0000000186BA8510-0x0000000186BA8690
		protected override void SetupAnimations() {} // 0x0000000186BA8690-0x0000000186BA8790
		protected override void OnDestroyed() {} // 0x0000000186BA8790-0x0000000186BA87E0
		protected void CustomLoot() {} // 0x0000000186BA87E0-0x0000000186BA8C50
		private void UpdatePosition() {} // 0x0000000186BA8C50-0x0000000186BA8D60
		protected override void OnUpdate() {} // 0x0000000186BA8D60-0x0000000186BA8FC0
	}
}

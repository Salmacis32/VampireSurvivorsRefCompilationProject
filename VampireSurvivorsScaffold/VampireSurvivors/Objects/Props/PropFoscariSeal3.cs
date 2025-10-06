/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using DG.Tweening.Core;
using VampireSurvivors.App.Objects;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Props
{
	public class PropFoscariSeal3 : Destructible // TypeDefIndex: 15372
	{
		// Fields
		private bool _alreadyDestroyed; // 0xF8
		private MultiTargetTween _floatTween; // 0x100
		private MapToken _mapToken; // 0x108
	
		// Properties
		public Action DestroyedCallback { get; set; } // 0x0000000182A45AF0-0x0000000182A45B00 0x0000000184BB6350-0x0000000184BB63B0
	
		// Constructors
		public PropFoscariSeal3() {} // 0x00000001869ECEE0-0x00000001869ECF40
	
		// Methods
		public override void Awake() {} // 0x0000000186BA0B80-0x0000000186BA0BA0
		public override void Init(PropType destructibleType) {} // 0x0000000186BA2A20-0x0000000186BA3070
		protected override void OnUpdate() {} // 0x0000000180B15170-0x0000000180B15180
		public override void GetDamaged(float value, HitVfxType showHitVFX, float knockbackMul, WeaponType damageType, bool hasKnockback = true /* Metadata: 0x019775DF */) {} // 0x0000000186BA3070-0x0000000186BA3440
		[Command]
		public void DestroySeal(long startingSimFrame) {} // 0x0000000186BA3440-0x0000000186BA3520
		public override void Despawn() {} // 0x0000000186B9E840-0x0000000186B9E850
		protected override void OnDestroyed() {} // 0x0000000186BA3520-0x0000000186BA3FE0
		private void SaveProgress() {} // 0x0000000186BA3FE0-0x0000000186BA4040
		protected void ShakeEarth() {} // 0x0000000186BA4040-0x0000000186BA4050
		private void ScreenShake(int repeats = 6 /* Metadata: 0x019775E0 */) {} // 0x0000000186BA4050-0x0000000186BA4370
	}
}

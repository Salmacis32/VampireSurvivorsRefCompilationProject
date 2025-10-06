/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using VampireSurvivors.App.Objects;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Props
{
	public class PropFoscariSeal2 : Destructible // TypeDefIndex: 15370
	{
		// Fields
		private bool _alreadyDestroyed; // 0xF8
		private MultiTargetTween _floatTween; // 0x100
		private MapToken _mapToken; // 0x108
	
		// Properties
		public Action DestroyedCallback { get; set; } // 0x0000000182A45AF0-0x0000000182A45B00 0x0000000184BB6350-0x0000000184BB63B0
	
		// Constructors
		public PropFoscariSeal2() {} // 0x00000001869ECEE0-0x00000001869ECF40
	
		// Methods
		public override void Awake() {} // 0x0000000186BA0B80-0x0000000186BA0BA0
		public override void Init(PropType destructibleType) {} // 0x0000000186BA0BA0-0x0000000186BA11D0
		public override void GetDamaged(float value, HitVfxType showHitVFX, float knockbackMul, WeaponType damageType, bool hasKnockback = true /* Metadata: 0x019775DD */) {} // 0x0000000186BA11D0-0x0000000186BA1580
		[Command]
		public void DestroySeal(long startingSimFrame) {} // 0x0000000186BA1580-0x0000000186BA1660
		public override void Despawn() {} // 0x0000000186B9E840-0x0000000186B9E850
		private void KillIt() {} // 0x0000000186AE61E0-0x0000000186AE6200
		protected override void OnDestroyed() {} // 0x0000000186BA1660-0x0000000186BA2190
		private void SaveProgress() {} // 0x0000000186BA2190-0x0000000186BA21F0
		private void ScreenShake(int repeats = 6 /* Metadata: 0x019775DE */) {} // 0x0000000186BA21F0-0x0000000186BA2510
	}
}

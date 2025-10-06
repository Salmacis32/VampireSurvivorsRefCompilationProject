/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Weapons;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Props
{
	public class Prop_AnimatedExplosive_Tohil : Destructible // TypeDefIndex: 15376
	{
		// Fields
		private float TreasureChance; // 0xF8
		private float GraceTimes; // 0xFC
		private float MaxGrace; // 0x100
		public int BreakAnimationFramesNumber; // 0x104
		private VampireSurvivors.Objects.Stage _stage; // 0x108
		private bool _hasFired; // 0x110
		private bool hasAnimations; // 0x111
	
		// Properties
		public virtual WeaponType MyWeaponType { get => default; } // 0x0000000181B59210-0x0000000181B59220 
	
		// Constructors
		public Prop_AnimatedExplosive_Tohil() {} // 0x0000000186BA80F0-0x0000000186BA8170
	
		// Methods
		[Inject]
		private void Construct(VampireSurvivors.Objects.Stage stage) {} // 0x0000000182766880-0x00000001827668E0
		public void InternalUpdate() {} // 0x0000000186BA5C20-0x0000000186BA5C50
		public void UpdateDepth() {} // 0x0000000186BA5C20-0x0000000186BA5C50
		public override void Init(PropType destructibleType) {} // 0x0000000186BA6980-0x0000000186BA6A00
		protected override void SetupAnimations() {} // 0x0000000186BA6A00-0x0000000186BA6C00
		protected override void OnDestroyed() {} // 0x0000000186BA6C00-0x0000000186BA7150
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019775EF */, float damageKb = 1f /* Metadata: 0x019775F0 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x019775F4 */, bool hasKb = true /* Metadata: 0x019775F5 */) {} // 0x0000000186BA7150-0x0000000186BA7410
		protected override void RestoreTint() {} // 0x0000000186BA7410-0x0000000186BA74C0
		public virtual void AfterDestroyed() {} // 0x0000000186BA74C0-0x0000000186BA75E0
		private void SpawnTreasure() {} // 0x0000000186BA75E0-0x0000000186BA80F0
	}
}

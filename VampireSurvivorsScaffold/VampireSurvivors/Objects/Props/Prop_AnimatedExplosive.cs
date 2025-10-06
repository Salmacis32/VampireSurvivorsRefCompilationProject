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
	public class Prop_AnimatedExplosive : Destructible // TypeDefIndex: 15375
	{
		// Fields
		public WeaponType MyWeaponType; // 0xF8
		public int BreakAnimationFramesNumber; // 0xFC
		private VampireSurvivors.Objects.Stage _stage; // 0x100
		private bool _hasFired; // 0x108
		private bool hasAnimations; // 0x109
	
		// Constructors
		public Prop_AnimatedExplosive() {} // 0x0000000186BA67C0-0x0000000186BA6830
	
		// Methods
		[Inject]
		private void Construct(VampireSurvivors.Objects.Stage stage) {} // 0x0000000184B1D430-0x0000000184B1D490
		public void InternalUpdate() {} // 0x0000000186BA5C20-0x0000000186BA5C50
		public void UpdateDepth() {} // 0x0000000186BA5C20-0x0000000186BA5C50
		public override void Init(PropType destructibleType) {} // 0x0000000186BA5C50-0x0000000186BA5D70
		protected override bool CanEmitLight() => default; // 0x0000000186BA5D70-0x0000000186BA5D80
		protected override void SetupAnimations() {} // 0x0000000186BA5D80-0x0000000186BA5F90
		protected override void OnDestroyed() {} // 0x0000000186BA5F90-0x0000000186BA6450
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019775E8 */, float damageKb = 1f /* Metadata: 0x019775E9 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x019775ED */, bool hasKb = true /* Metadata: 0x019775EE */) {} // 0x0000000186BA6450-0x0000000186BA6710
		protected override void RestoreTint() {} // 0x0000000186BA6710-0x0000000186BA67C0
	}
}

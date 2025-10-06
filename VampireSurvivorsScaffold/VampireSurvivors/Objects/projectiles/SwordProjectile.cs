/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class SwordProjectile : Projectile // TypeDefIndex: 15437
	{
		// Fields
		private MultiTargetTween _tween; // 0xD0
		private MultiTargetTween _tween2; // 0xD8
		private float _previousArea; // 0xE0
		private float _detuneMul; // 0xE4
	
		// Constructors
		public SwordProjectile() {} // 0x0000000186BFC170-0x0000000186BFC1C0
	
		// Methods
		protected override void Awake() {} // 0x0000000186BFB780-0x0000000186BFB820
		public void SetDetune(float value = 0f /* Metadata: 0x0197761B */) {} // 0x0000000185138430-0x0000000185138440
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BFB820-0x0000000186BFC170
	}
}

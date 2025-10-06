/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Ice0_Projectile : Projectile // TypeDefIndex: 15590
	{
		// Fields
		private List<string> _frames; // 0xD0
		private MultiTargetTween _scaleTween; // 0xD8
		private MultiTargetTween _scaleTween2; // 0xE0
	
		// Constructors
		public TP_Ice0_Projectile() {} // 0x0000000186CC9400-0x0000000186CC96B0
	
		// Methods
		protected override void Awake() {} // 0x0000000186CC8C50-0x0000000186CC8E70
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CC8E70-0x0000000186CC9390
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186CC9390-0x0000000186CC9400
		public override void Despawn() {} // 0x0000000186CB94E0-0x0000000186CB9520
	}
}

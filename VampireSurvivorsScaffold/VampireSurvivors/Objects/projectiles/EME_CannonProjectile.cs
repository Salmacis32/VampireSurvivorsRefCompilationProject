/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_CannonProjectile : Projectile // TypeDefIndex: 15753
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD0
		private MultiTargetTween _scaleTween; // 0xD8
		private bool _hasExploded; // 0xE0
	
		// Constructors
		public EME_CannonProjectile() {} // 0x0000000186D772B0-0x0000000186D77300
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D768A0-0x0000000186D77150
		public override void Despawn() {} // 0x0000000186D77150-0x0000000186D771A0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186D771A0-0x0000000186D772B0
	}
}

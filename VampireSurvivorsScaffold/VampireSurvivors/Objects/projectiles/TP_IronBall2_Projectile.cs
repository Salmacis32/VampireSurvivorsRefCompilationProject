/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_IronBall2_Projectile : TP_IronBall_Projectile // TypeDefIndex: 15598
	{
		// Fields
		private bool _initPfx; // 0xF8
		private ParticleSystem _pfxEmitter; // 0x100
		private VampireSurvivors.Framework.TimerSystem.Timer _pfxTimer; // 0x108
	
		// Constructors
		public TP_IronBall2_Projectile() {} // 0x0000000186CD4460-0x0000000186CD44B0
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CD3510-0x0000000186CD3540
		public override void OnHittingScreenBottom() {} // 0x0000000186CD3540-0x0000000186CD35E0
		private void InitPfx() {} // 0x0000000186CD35E0-0x0000000186CD4090
		private void PlayHitPfx() {} // 0x0000000186CD4090-0x0000000186CD4400
		public override void Despawn() {} // 0x0000000186CD4400-0x0000000186CD4460
	}
}

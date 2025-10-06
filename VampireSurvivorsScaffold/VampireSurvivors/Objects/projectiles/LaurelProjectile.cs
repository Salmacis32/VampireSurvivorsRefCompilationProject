/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class LaurelProjectile : Projectile // TypeDefIndex: 15912
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD0
		private const float Radius = 16f; // Metadata: 0x0197794A
		private MultiTargetTween _imageTween2; // 0xD8
	
		// Constructors
		public LaurelProjectile() {} // 0x0000000186E3CCB0-0x0000000186E3CD00
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E3C4D0-0x0000000186E3CA00
		public override void InternalUpdate() {} // 0x0000000186E3CA00-0x0000000186E3CC70
		public override void Despawn() {} // 0x0000000186E3CC70-0x0000000186E3CCB0
	}
}

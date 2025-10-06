/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class GattiScuffleProjectile : Projectile // TypeDefIndex: 15885
	{
		// Fields
		private ParticleEmitterManager _pfxEmitterManager; // 0xD0
		private ParticleSystem _pfxEmitter1; // 0xD8
		private ParticleSystem _pfxEmitter2; // 0xE0
		private Circle _explosionCircle; // 0xE8
		private int _exploRadius; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xF8
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x100
		private GattiWeapon _trueWeapon; // 0x108
	
		// Constructors
		public GattiScuffleProjectile() {} // 0x0000000186E24F10-0x0000000186E24F70
	
		// Methods
		protected override void Awake() {} // 0x0000000186E234F0-0x0000000186E24710
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E24710-0x0000000186E24E70
		public override void InternalUpdate() {} // 0x0000000186E24E70-0x0000000186E24EC0
		public override void Despawn() {} // 0x0000000186E24EC0-0x0000000186E24F10
	}
}

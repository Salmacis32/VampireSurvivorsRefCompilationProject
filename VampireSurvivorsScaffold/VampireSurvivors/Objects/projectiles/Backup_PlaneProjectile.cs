/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class Backup_PlaneProjectile : Projectile // TypeDefIndex: 15456
	{
		// Fields
		private float2 _targetPosition; // 0xD0
		private float _timeSinceChangedTarget; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer _timerEvent; // 0xE0
		public BulletPool bulletPool; // 0xE8
		[NonSerialized]
		public float planeAngleOffset; // 0xF0
	
		// Constructors
		public Backup_PlaneProjectile() {} // 0x0000000186C12EC0-0x0000000186C12F20
	
		// Methods
		protected override void Awake() {} // 0x0000000186C124B0-0x0000000186C12550
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C12550-0x0000000186C12830
		public override void InternalUpdate() {} // 0x0000000186C12830-0x0000000186C12AB0
		private void RefreshTarget() {} // 0x0000000186C12AB0-0x0000000186C12C40
		private void fireBullet() {} // 0x0000000186C12C40-0x0000000186C12E70
		public override void Despawn() {} // 0x0000000186C12E70-0x0000000186C12EC0
	}
}

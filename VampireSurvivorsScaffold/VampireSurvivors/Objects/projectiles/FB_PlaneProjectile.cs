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
	public class FB_PlaneProjectile : Projectile // TypeDefIndex: 15478
	{
		// Fields
		[NonSerialized]
		public VampireSurvivors.Framework.TimerSystem.Timer timerEvent; // 0xD0
		[NonSerialized]
		public float angleOffset; // 0xD8
		private float _targetAngle; // 0xDC
		public float _dist; // 0xE0
		public float _width; // 0xE4
		public float2 drift; // 0xE8
		public VampireSurvivors.Framework.TimerSystem.Timer driftTimer; // 0xF0
	
		// Constructors
		public FB_PlaneProjectile() {} // 0x0000000186C28480-0x0000000186C28500
	
		// Methods
		protected override void Awake() {} // 0x0000000186C27EA0-0x0000000186C27F40
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C27F40-0x0000000186C28150
		public override void InternalUpdate() {} // 0x0000000186C28150-0x0000000186C28430
		public override void Despawn() {} // 0x0000000186C28430-0x0000000186C28480
	}
}

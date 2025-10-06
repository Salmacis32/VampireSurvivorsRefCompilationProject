/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_KatanaProjectile_Gravedigger : Projectile // TypeDefIndex: 15780
	{
		// Fields
		[SerializeField]
		private ParticleSystem _ParticleVFX; // 0xD0
		private const float VFXScale = 1f; // Metadata: 0x0197783E
		private const float VFXDuration = 1700f; // Metadata: 0x01977842
		private const float MaxAreaLimit = 2.5f; // Metadata: 0x01977846
		private float2 _bodySize; // 0xD8
		private float2 _bodyOffset; // 0xE0
		private bool _cachedFlipX; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _bodyTimer; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _rockTimer; // 0xF8
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x100
	
		// Constructors
		public EME_KatanaProjectile_Gravedigger() {} // 0x0000000186D8AC40-0x0000000186D8AC90
	
		// Methods
		protected override void Awake() {} // 0x0000000186D89F80-0x0000000186D8A080
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D8A080-0x0000000186D8A6C0
		public override void InternalUpdate() {} // 0x0000000186D8A6C0-0x0000000186D8A6D0
		private void UpdateBody() {} // 0x0000000186D8A6D0-0x0000000186D8A880
		public void FireRocks() {} // 0x0000000186D8A880-0x0000000186D8AA40
		private void PlaySfx() {} // 0x0000000186D8AA40-0x0000000186D8AB10
		public override void Despawn() {} // 0x0000000186D8AB10-0x0000000186D8AC40
	}
}

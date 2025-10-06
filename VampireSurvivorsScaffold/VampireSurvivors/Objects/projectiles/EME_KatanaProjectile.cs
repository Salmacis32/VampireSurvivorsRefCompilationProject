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
	public class EME_KatanaProjectile : Projectile // TypeDefIndex: 15779
	{
		// Fields
		[SerializeField]
		private ParticleSystem _SlashVFX; // 0xD0
		private const float XOffset = 0.24f; // Metadata: 0x01977826
		private const float XRepeatOffset = 0.08f; // Metadata: 0x0197782A
		private const float YOffset = 0.16f; // Metadata: 0x0197782E
		private const float VFXScale = 0.4f; // Metadata: 0x01977832
		private const float VFXDuration = 640f; // Metadata: 0x01977836
		private const float BodyDuration = 420f; // Metadata: 0x0197783A
		private float2 _bodySize; // 0xD8
		private float2 _bodyOffset; // 0xE0
		private float2 _offsetFromPlayer; // 0xE8
		private bool _cachedFlipX; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _bodyTimer; // 0xF8
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x100
	
		// Constructors
		public EME_KatanaProjectile() {} // 0x0000000186D89E90-0x0000000186D89EE0
	
		// Methods
		protected override void Awake() {} // 0x0000000186BB4A00-0x0000000186BB4A10
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D89170-0x0000000186D898C0
		public override void InternalUpdate() {} // 0x0000000186D898C0-0x0000000186D89A80
		private void UpdatePosition() {} // 0x0000000186D89A80-0x0000000186D89AE0
		private void InitBody() {} // 0x0000000186D89AE0-0x0000000186D89C00
		private void UpdateBody() {} // 0x0000000186D89C00-0x0000000186D89D70
		public override void Despawn() {} // 0x0000000186D89D70-0x0000000186D89E90
	}
}

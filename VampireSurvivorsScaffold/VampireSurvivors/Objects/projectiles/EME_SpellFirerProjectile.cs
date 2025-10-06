/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_SpellFirerProjectile : Projectile // TypeDefIndex: 15846
	{
		// Fields
		private MultiTargetTween _tween; // 0xD0
		private MultiTargetTween _tween2; // 0xD8
		private EME_RapierWeapon _trueWeapon; // 0xE0
		private ParticleSystem _pfxEmitter; // 0xE8
		private ParticleSystem _pfxEmitter2; // 0xF0
		private ParticleSystem _pfxEmitter3; // 0xF8
		private bool _initialisedParticles; // 0x100
		[SerializeField]
		private MeshRenderer _Model1; // 0x108
		[SerializeField]
		private MeshRenderer _Model2; // 0x110
		[SerializeField]
		private MeshRenderer _Model3; // 0x118
		private static readonly int _ScrollSpeedX; // 0x00
		private static readonly int _ScrollSpeedY; // 0x04
		private static readonly int _AlphaMul; // 0x08
		private VampireSurvivors.Framework.TimerSystem.Timer _DespawnTimer; // 0x120
		private PhaserSprite _displayImage; // 0x128
		private Transform _M1CachedT; // 0x130
		private Transform _M2CachedT; // 0x138
		private Transform _M3CachedT; // 0x140
	
		// Constructors
		public EME_SpellFirerProjectile() {} // 0x0000000186DEAF70-0x0000000186DEAFC0
		static EME_SpellFirerProjectile() {} // 0x0000000186DEAFC0-0x0000000186DEB080
	
		// Methods
		protected override void Awake() {} // 0x0000000186D1D3F0-0x0000000186D1D420
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DE9960-0x0000000186DEA850
		private void OnRecycle() {} // 0x0000000186DEA850-0x0000000186DEAD00
		private void FadeOut(float fadeDuration) {} // 0x0000000186DEAD00-0x0000000186DEAEE0
		public override void Despawn() {} // 0x0000000186DEAEE0-0x0000000186DEAF70
	}
}

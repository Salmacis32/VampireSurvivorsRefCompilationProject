/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_AxeProjectile_HellsFury : Projectile // TypeDefIndex: 15744
	{
		// Fields
		private MultiTargetTween _tween; // 0xD0
		private MultiTargetTween _tween2; // 0xD8
		private EME_RapierWeapon _trueWeapon; // 0xE0
		private ParticleEmitterManager _pfxEmitterManager; // 0xE8
		private ParticleSystem _pfxEmitter; // 0xF0
		[SerializeField]
		private ParticleSystem punchVFX; // 0xF8
		[SerializeField]
		private MeshRenderer _Quad1; // 0x100
		[SerializeField]
		private MeshRenderer _Quad2; // 0x108
		private static readonly int _ScrollSpeedX; // 0x00
		private static readonly int _ScrollSpeedY; // 0x04
		private static readonly int _AlphaMul; // 0x08
		private VampireSurvivors.Framework.TimerSystem.Timer _DespawnTimer; // 0x110
		private PhaserSprite _displayImage; // 0x118
		private float _offsetX; // 0x120
		private MultiTargetTween slashTween; // 0x128
		private MultiTargetTween modelTween1; // 0x130
		private MultiTargetTween modelTween2; // 0x138
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x140
		private int _strikeTimes; // 0x148
	
		// Constructors
		public EME_AxeProjectile_HellsFury() {} // 0x0000000186D695E0-0x0000000186D69630
		static EME_AxeProjectile_HellsFury() {} // 0x0000000186D69630-0x0000000186D696F0
	
		// Methods
		private void LateUpdate() {} // 0x0000000186D67B70-0x0000000186D67C70
		protected override void Awake() {} // 0x0000000186D67C70-0x0000000186D67EA0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D67EA0-0x0000000186D68A90
		private void Activate() {} // 0x0000000186D68A90-0x0000000186D69280
		public void StartDespawn() {} // 0x0000000186D69280-0x0000000186D69550
		public override void Despawn() {} // 0x0000000186D69550-0x0000000186D695E0
	}
}

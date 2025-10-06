/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class SpellstromWeapon : Weapon // TypeDefIndex: 16181
	{
		// Fields
		private ParticleEmitterManager _pfxManager; // 0x158
		private ParticleSystem _emitter1; // 0x160
		private ParticleSystem _emitter2; // 0x168
		private Circle _emitZone; // 0x170
		private GravityWell _well1; // 0x178
		private GravityWell _well2; // 0x180
		private float _angleValue; // 0x188
		private ParticleEmitterManager _fixedCircleManager; // 0x190
		private ParticleSystem _fixedCircleEmitter; // 0x198
		private Circle _circleEmitZone; // 0x1A0
		private SpellstringWeapon _weaponString; // 0x1A8
		private SpellstreamWeapon _weaponStream; // 0x1B0
		private SpellstrikeWeapon _weaponStrike; // 0x1B8
		private MultiTargetTween _singularityTween; // 0x1C0
		private float _singularityTime; // 0x1C8
		private bool _doingSingularity; // 0x1CC
		private MultiTargetTween _restoreTween; // 0x1D0
		private float _singularityTimes; // 0x1D8
		private bool _skipEmitUpdate; // 0x1DC
		private bool _hasBullets; // 0x1DD
		private MultiTargetTween _singularityExplosionTween; // 0x1E0
		private MultiTargetTween _screenShakeTween; // 0x1E8
		private SpellstromProjectile _bulletA; // 0x1F0
		private SpellstromProjectile _bulletB; // 0x1F8
		private bool _totalDamageCalculated; // 0x200
		[NonSerialized]
		public float Radius; // 0x204
		[NonSerialized]
		public float SingularityExplosionValue; // 0x208
	
		// Constructors
		public SpellstromWeapon() {} // 0x0000000186F48F50-0x0000000186F48FA0
	
		// Methods
		protected override void Awake() {} // 0x0000000186F42C40-0x0000000186F43F50
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F43F50-0x0000000186F448A0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BB0 */) {} // 0x0000000180B15170-0x0000000180B15180
		public override float CalculateTotalDamage() => default; // 0x0000000186F448A0-0x0000000186F44920
		public override void InternalUpdate() {} // 0x0000000186F44920-0x0000000186F454C0
		public override void Cleanup() {} // 0x0000000186F454C0-0x0000000186F457A0
		protected virtual float SingularityPower() => default; // 0x0000000186F457A0-0x0000000186F458E0
		protected virtual float SingularityDelay() => default; // 0x0000000186F458E0-0x0000000186F45950
		private void InitBullets() {} // 0x0000000186F45950-0x0000000186F45F20
		private void DoSingularity() {} // 0x0000000186F45F20-0x0000000186F469F0
		private void ExplodeSingularity() {} // 0x0000000186F469F0-0x0000000186F47310
		protected override void OnStart() {} // 0x0000000186F47310-0x0000000186F48100
		private void ScreenShake() {} // 0x0000000186F48100-0x0000000186F48690
		public override void SetVisible(bool visible) {} // 0x0000000186F48690-0x0000000186F48F50
	}
}

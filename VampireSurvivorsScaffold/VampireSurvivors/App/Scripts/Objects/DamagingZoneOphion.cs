/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Objects
{
	public class DamagingZoneOphion : ArcadeSprite // TypeDefIndex: 18654
	{
		// Fields
		private DamagingZonePool_Ophion _pool; // 0x58
		private PhaserSprite _groundFx; // 0x60
		private PhaserSprite _snakeSprite; // 0x68
		private Circle _collider; // 0x70
		private float _damage; // 0x78
		private float _duration; // 0x7C
		private float _hitDelay; // 0x80
		private bool _hasInit; // 0x84
		private bool _activateDamage; // 0x85
		private bool _hasHit; // 0x86
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x88
		private VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0x90
		private MultiTargetTween _snakeTween; // 0x98
		private MultiTargetTween _displayScaleTween; // 0xA0
		private MultiTargetTween _displayScaleTween2; // 0xA8
		private MultiTargetTween _implosionTween; // 0xB0
		private MultiTargetTween _explosionTween; // 0xB8
		private const float EXPLO_1_DURATION = 500f; // Metadata: 0x0197AF32
		private const float EXPLO_2_DURATION = 100f; // Metadata: 0x0197AF36
		private const float EXPLO_3_DURATION = 200f; // Metadata: 0x0197AF3A
	
		// Constructors
		public DamagingZoneOphion() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		protected override void OnUpdate() {} // 0x000000018680C7E0-0x000000018680CB10
		public void Init(DamagingZonePool_Ophion pool) {} // 0x000000018680CB10-0x000000018680D0E0
		public void OnRecycle() {} // 0x000000018680D0E0-0x000000018680D6B0
		public void SetExplosionSize(float x, float y, float radius) {} // 0x000000018680D6B0-0x000000018680D7C0
		public void SetExplosionDamage(float damage, float duration, float hitDelay) {} // 0x000000018680D7C0-0x000000018680D7E0
		public void Despawn() {} // 0x000000018680D7E0-0x000000018680D9B0
		private void Explode() {} // 0x000000018680D9B0-0x000000018680E180
		private void Implode() {} // 0x000000018680E180-0x000000018680E430
		private void Explode2() {} // 0x000000018680E430-0x000000018680EAD0
	}
}

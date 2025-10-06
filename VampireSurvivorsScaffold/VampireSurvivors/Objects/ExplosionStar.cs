/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using QFSW.MOP2;
using UnityEngine;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public class ExplosionStar : PoolableMonoBehaviour // TypeDefIndex: 15087
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _GroundFx; // 0x30
		[SerializeField]
		private SpriteRenderer _WarningSprite; // 0x38
		[SerializeField]
		private SpriteRenderer _StarSprite; // 0x40
		[SerializeField]
		private SpriteRenderer _GroundWarning; // 0x48
		[SerializeField]
		private TrailRenderer _Trail; // 0x50
		private GameSessionData _gameSessionData; // 0x58
		private PlayerOptions _playerOptions; // 0x60
		private SpriteAnimation _starsSpriteAnim; // 0x68
		private Camera _camera; // 0x70
		private Circle _circleArea; // 0x78
		private ParticleEmitterManager _particlesManager; // 0x80
		private ParticleSystem _starsPfx; // 0x88
		private ParticleSystem _cloudPfx; // 0x90
		private GravityWell _gravityWell; // 0x98
		private DG.Tweening.Sequence _warningTween; // 0xA0
		private DG.Tweening.Sequence _groundWarningTween; // 0xA8
		private Tween _arcAngleTween; // 0xB0
		private Tween _scaleTween; // 0xB8
		private VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0xC0
		private Color _color; // 0xC8
		private bool _hasHit; // 0xD8
		private bool _exploding; // 0xD9
		private float _arcAngle; // 0xDC
		private float _arcRadius; // 0xE0
	
		// Properties
		private float Damage { get; set; } // 0x0000000181945E20-0x0000000181945E30 0x0000000185138430-0x0000000185138440
		private float Radius { get; set; } // 0x00000001866FAF70-0x00000001866FAF80 0x00000001867530E0-0x00000001867530F0
	
		// Constructors
		public ExplosionStar() {} // 0x00000001869F5DA0-0x00000001869F5E10
	
		// Methods
		[Inject]
		private void Construct(GameSessionData gameSessionData, PlayerOptions playerOptions) {} // 0x00000001865DF3C0-0x00000001865DF470
		private new void Awake() {} // 0x00000001869F6500-0x00000001869F6690
		private void OnDrawGizmosSelected() {} // 0x00000001869EFCE0-0x00000001869EFDD0
		public void Init(float damage, float radius) {} // 0x00000001869F6690-0x00000001869F7C70
		public void InternalUpdate() {} // 0x00000001869F37C0-0x00000001869F3970
		public void SetDepthPlease(float depth) {} // 0x00000001869F7C70-0x00000001869F7D20
		private void Explode() {} // 0x00000001869F7D20-0x00000001869F8480
		private void TriggerDespawnTimer() {} // 0x00000001869F8480-0x00000001869F87A0
		private void Despawn() {} // 0x00000001869F87A0-0x00000001869F88F0
		private void AssignRandomColor() {} // 0x00000001869F88F0-0x00000001869F8AB0
		private void TrailUpdate() {} // 0x00000001869F4760-0x00000001869F4A20
		private void GenerateParticleSystems() {} // 0x00000001869F8AB0-0x00000001869F9C70
		private void InitGravityWell() {} // 0x00000001869F5C80-0x00000001869F5CB0
		private void ReleaseGravityWell() {} // 0x00000001869F9C70-0x00000001869F9D60
	}
}

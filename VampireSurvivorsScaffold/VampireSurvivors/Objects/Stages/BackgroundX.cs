/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Graphics.RenderPass;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Characters.Enemies;
using VampireSurvivors.Objects.Items;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	[UsedImplicitly]
	public class BackgroundX : BackgroundManager // TypeDefIndex: 15325
	{
		// Fields
		private float _wind; // 0x80
		private float _fireTimer; // 0x84
		private bool _hasRosaryBeenTriggered; // 0x88
		private bool _saveOption; // 0x89
		private FishEyeRenderFeature _fishEyeRenderFeature; // 0x90
		private ShootingEyesManager _shootingEyesManager; // 0x98
		private Pickup _rosary; // 0xA0
		private Transform _spritesRootTransform; // 0xA8
		private TileSprite _skyBlue; // 0xB0
		private TileSprite _cloudsBlue; // 0xB8
		private TileSprite _cloudsWhite; // 0xC0
		private TileSprite _cloudsAddBlue; // 0xC8
		private TileSprite _cloudsAddRed; // 0xD0
		private TileSprite _cloudsRed; // 0xD8
		private TileSprite _skyRed; // 0xE0
		private SpriteRenderer _whiteFader; // 0xE8
		private SpriteRenderer _shootingRay; // 0xF0
		private SpriteRenderer _shootingRing; // 0xF8
		private ParticleEmitterManager _particleEmitterManager; // 0x100
		private ParticleEmitterManager _particleEmitterManagerRed; // 0x108
		private ParticleSystem _pfxEmitterRed1; // 0x110
		private ParticleSystem _pfxEmitterRed2; // 0x118
		private ParticleEmitterManager _particleEmitterManagerRedBelow; // 0x120
		private ParticleSystem _pfxEmitterBelow1; // 0x128
		private ParticleSystem _pfxEmitterBelow2; // 0x130
		private EnemyMaddener _enemyMaddener; // 0x138
		private VampireSurvivors.Framework.TimerSystem.Timer _tweenExplosionsTimer; // 0x140
		private int _tweenExplosionsTimerRepeatCount; // 0x148
		private Tween _tweenExplosions; // 0x150
		private List<VampireSurvivors.Framework.TimerSystem.Timer> _timers; // 0x158
		private VampireSurvivors.Framework.TimerSystem.Timer _checkRosaryTimer; // 0x160
		private int _checkRosaryTimerRepeatCount; // 0x168
		private DG.Tweening.Sequence _permanentVfxTween; // 0x170
		private static readonly int Intensity; // 0x00
		private static readonly int Radius; // 0x04
		private static readonly int Mode; // 0x08
		private static readonly int TexSize; // 0x0C
		private static readonly int Center; // 0x10
	
		// Constructors
		public BackgroundX() {} // 0x0000000186B7C940-0x0000000186B7CA10
		static BackgroundX() {} // 0x0000000186B7CA10-0x0000000186B7CB30
	
		// Methods
		public override void Awake() {} // 0x0000000186B6FEF0-0x0000000186B6FF10
		protected override void OnUpdate() {} // 0x0000000186B6FF10-0x0000000186B70A20
		protected override void OnDestroy() {} // 0x0000000186B70A20-0x0000000186B70E70
		public override void CustomPreload(Action onComplete) {} // 0x0000000186B70E70-0x0000000186B71010
		public override void Create() {} // 0x0000000186B71010-0x0000000186B71FE0
		private void OnRemoteItemInstantiated(Pickup item) {} // 0x0000000186B71FE0-0x0000000186B72060
		private void OnRemoteEnemySpawned(EnemyController enemy) {} // 0x0000000186B72060-0x0000000186B72240
		public override void Cleanup() {} // 0x0000000186B72240-0x0000000186B724C0
		public override void RosaryTriggered() {} // 0x0000000186B724C0-0x0000000186B725C0
		[IteratorStateMachine(typeof(_InitFishEye_d__47))]
		private IEnumerator InitFishEye() => default; // 0x0000000186B725C0-0x0000000186B72660
		private void TweenFishEye(TweenCallback callback) {} // 0x0000000186B72660-0x0000000186B72D50
		private void InitShootingEyesManager() {} // 0x0000000186B72D50-0x0000000186B72E30
		private void GenerateSprites() {} // 0x0000000186B72E30-0x0000000186B74410
		private void AddYellowParticles() {} // 0x0000000186B74410-0x0000000186B74520
		private void OnYellowRelicFound(PickupRelic found) {} // 0x0000000186B74520-0x0000000186B75850
		private void AddRedParticles() {} // 0x0000000186B75850-0x0000000186B76DF0
		private void AddRedParticlesBelow() {} // 0x0000000186B76DF0-0x0000000186B78390
		private void AddRosary() {} // 0x0000000186B78390-0x0000000186B784E0
		private bool RemoveEggs() => default; // 0x0000000186B784E0-0x0000000186B78580
		private void RemovePowers() {} // 0x0000000186B78580-0x0000000186B79900
		private void SetupCharacterAnimation(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x0000000186B79900-0x0000000186B79B40
		private void UpdatePlayerOptions() {} // 0x0000000186B79B40-0x0000000186B79D90
		private void SetupTimers() {} // 0x0000000186B79D90-0x0000000186B7A710
		private void ToggleBlue(bool visible) {} // 0x0000000186B7A710-0x0000000186B7A7B0
		private void ToggleRed(bool visible) {} // 0x0000000186B7A7B0-0x0000000186B7A850
		private void ToggleAlias() {} // 0x0000000186B7A850-0x0000000186B7AB30
		private void RemoveTimer() {} // 0x0000000186B7AB30-0x0000000186B7AC40
		private void ShootVfx() {} // 0x0000000186B7AC40-0x0000000186B7B390
		private void ShootEyes(int times, float delay, float radiusMul) {} // 0x0000000186B7B390-0x0000000186B7B570
		private void PermanentVfx() {} // 0x0000000186B7B570-0x0000000186B7BB60
		private void CheckDistanceFromRosary() {} // 0x0000000186B7BB60-0x0000000186B7BF30
		private void StopAllTimers() {} // 0x0000000186B7BF30-0x0000000186B7C3A0
		private void StopRedEmitters() {} // 0x0000000186B7C3A0-0x0000000186B7C6D0
		private void MoveStoppedParticles(ParticleSystem ps) {} // 0x0000000186B7C6D0-0x0000000186B7C940
	}
}

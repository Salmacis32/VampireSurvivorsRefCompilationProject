/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class GlassFandango2Weapon : GlassFandangoWeapon // TypeDefIndex: 16694
	{
		// Fields
		[SerializeField]
		private Transform _Sky; // 0x180
		[SerializeField]
		private MeshRenderer _SkyMesh; // 0x188
		[SerializeField]
		private float StaggerA; // 0x190
		[SerializeField]
		private float StaggerB; // 0x194
		[SerializeField]
		private float StaggerC; // 0x198
		[SerializeField]
		private SfxType HitSound; // 0x19C
		private ParticleEmitterManager _zodiacBlurEmitterManager; // 0x1A0
		private ParticleSystem _zodiacBlurEmitter; // 0x1A8
		private bool _initialisedZodiacParticles; // 0x1B0
		private static readonly int _ScrollSpeedX; // 0x00
		private static readonly int _ScrollSpeedY; // 0x04
		private static readonly int _AlphaMul; // 0x08
		private List<PhaserSprite> _doilies; // 0x1B8
		private bool _isStarryHeavenRunning; // 0x1C0
		private bool _isStarryHeavenStopping; // 0x1C1
		private float _StarryExecutionDelta; // 0x1C4
		private readonly float _StarryExecutionTime; // 0x1C8
		private VampireSurvivors.Framework.TimerSystem.Timer _restartTimer; // 0x1D0
		private PhaserSprite _sprZodiac; // 0x1D8
		private MultiTargetTween _tween2; // 0x1E0
		private Circle _pfxCircle; // 0x1E8
		private bool _playSoundsDuringUpdate; // 0x1F0
		private ParticleSystem _zodiacBlurEmitterLarge; // 0x1F8
		private ParticleSystem _zodiacBlurEmitterBack; // 0x200
		private float _detuneValue; // 0x208
		private float _defaultSkyScale; // 0x20C
		private PhaserSprite _darkBackground; // 0x210
		private MultiTargetTween _tween1; // 0x218
		private BulletPool _tvExplosionPool; // 0x220
		private bool _generatedPools; // 0x228
		private float _StarryFiringDelta; // 0x22C
		private float _StarryFiringDelay; // 0x230
	
		// Properties
		public BulletPool TVExplosionPool { get => default; } // 0x0000000186753440-0x0000000186753450 
	
		// Constructors
		public GlassFandango2Weapon() {} // 0x0000000187085CD0-0x0000000187085D70
		static GlassFandango2Weapon() {} // 0x0000000187085D70-0x0000000187085E30
	
		// Methods
		public override float PSpeed() => default; // 0x0000000186F2B9B0-0x0000000186F2B9E0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000187080750-0x00000001870808E0
		protected override void OnStart() {} // 0x00000001870808E0-0x0000000187080910
		public void MakeEmitters() {} // 0x0000000187080910-0x0000000187082550
		public void MakeProjectiles() {} // 0x0000000187082550-0x0000000187082760
		public void ButtonStartStarryHeavens() {} // 0x0000000187082760-0x0000000187082770
		public void FireSpecialProjectiles() {} // 0x0000000187082770-0x0000000187082980
		public void StartStarryHeavens() {} // 0x0000000187082980-0x0000000187082FE0
		private void exe_CameraZoom() {} // 0x0000000187082FE0-0x00000001870830A0
		private void exe_FadeInSky() {} // 0x00000001870830A0-0x00000001870835C0
		private void exe_SlowDownSky() {} // 0x00000001870835C0-0x00000001870837E0
		private void exe_BringInBlurryZodiac() {} // 0x00000001870837E0-0x0000000187083BE0
		private void exe_BringInZodiac() {} // 0x0000000187083BE0-0x0000000187084040
		private void exe_StartParticles() {} // 0x0000000187084040-0x0000000187084590
		public void StopStarryHeaven() {} // 0x0000000187084590-0x0000000187084940
		public void ClearFlags() {} // 0x0000000187084940-0x0000000187084960
		public override void InternalUpdate() {} // 0x0000000187084960-0x0000000187084B00
		protected override void OnPause() {} // 0x0000000187084B00-0x0000000187084BD0
		protected override void OnResume() {} // 0x0000000187084BD0-0x0000000187084CB0
		private void MakeSprites() {} // 0x0000000187084CB0-0x00000001870856D0
		public override void Cleanup() {} // 0x00000001870856D0-0x0000000187085CD0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	[UsedImplicitly]
	public class Background4 : BackgroundManager // TypeDefIndex: 15211
	{
		// Fields
		private bool _hasSpawnedGuards; // 0x80
		private bool _stopp; // 0x81
		private bool _passed; // 0x82
		private BgmType _saveBgm; // 0x84
		private VampireSurvivors.Framework.TimerSystem.Timer _firstEvent; // 0x88
		private VampireSurvivors.Framework.TimerSystem.Timer _recurringEvent; // 0x90
		private MultiTargetTween _randomazzoTween; // 0x98
		private Transform _spritesRootTransform; // 0xA0
		private readonly List<SpriteRenderer> _allSprites; // 0xA8
		private SpriteRenderer _sBackground; // 0xB0
		private SpriteRenderer _sStars2; // 0xB8
		private SpriteRenderer _sStars1; // 0xC0
		private SpriteRenderer _sPeaks; // 0xC8
		private SpriteRenderer _sMount2; // 0xD0
		private SpriteRenderer _sMist3; // 0xD8
		private SpriteRenderer _sMount1; // 0xE0
		private SpriteRenderer _sFlash; // 0xE8
		private SpriteRenderer _sMist2; // 0xF0
		private SpriteRenderer _sHills; // 0xF8
		private SpriteRenderer _sMist1; // 0x100
		private SpriteRenderer _sForest; // 0x108
		private SpriteRenderer _sDarkness; // 0x110
		private PhaserSprite _sFog; // 0x118
		private PhaserSprite _sFogExtraA; // 0x120
		private PhaserSprite _sFogExtraB; // 0x128
		private ParticleEmitterManager _particleEmitterManager; // 0x130
		private ParticleSystem _pfxEmitter; // 0x138
		private GravityWell _well; // 0x140
		private List<RuneStripVfx> _runeStrips; // 0x148
		private List<RuneStripVfx2> _runeStrips2; // 0x150
		private const int SortingOrderBackmost = -32768; // Metadata: 0x0197745E
		private const float TowerTop = 122.88f; // Metadata: 0x01977462
		private const float Bot = -245.76f; // Metadata: 0x01977466
		private const float Bott = -491.52f; // Metadata: 0x0197746A
	
		// Constructors
		public Background4() {} // 0x0000000186AA1670-0x0000000186AA1880
	
		// Methods
		protected override void OnUpdate() {} // 0x0000000186A99AA0-0x0000000186A9A1D0
		public override void OnInitCompleted() {} // 0x0000000186A9A1D0-0x0000000186A9A2C0
		protected override void OnDestroy() {} // 0x0000000186A9A2C0-0x0000000186A9A440
		public override void CustomPreload(Action onComplete) {} // 0x0000000186A9A440-0x0000000186A9A5E0
		public override void Create() {} // 0x0000000186A9A5E0-0x0000000186A9A610
		public override void Cleanup() {} // 0x0000000186A9A610-0x0000000186A9A680
		private void PlayFlash() {} // 0x0000000186A9A680-0x0000000186A9B9F0
		private void StopRune2() {} // 0x0000000186A9B9F0-0x0000000186A9C040
		private void FixY(SpriteRenderer spriteRenderer, float min, float max, float prop) {} // 0x0000000186A9C040-0x0000000186A9C360
		private void CheckPlayerVsBot(float prop) {} // 0x0000000186A9C360-0x0000000186A9D2A0
		private void CheckPlayerVsTop() {} // 0x0000000186A9D2A0-0x0000000186A9D7C0
		private void GenerateObjects() {} // 0x0000000186A9D7C0-0x0000000186AA01B0
		private void GenerateTrappedSorceress() {} // 0x0000000186AA01B0-0x0000000186AA0590
		private void OnRemoteEnemySpawned(EnemyController enemy) {} // 0x0000000186AA0590-0x0000000186AA0840
		private void GenerateBridgeBoss() {} // 0x0000000186AA0840-0x0000000186AA08D0
		private void GenerateParticleSystems() {} // 0x0000000186AA08D0-0x0000000186AA1670
	}
}

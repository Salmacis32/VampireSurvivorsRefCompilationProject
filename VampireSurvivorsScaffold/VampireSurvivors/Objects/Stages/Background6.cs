/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DG.Tweening.Core;
using UnityEngine;
using UnityEngine.Video;
using VampireSurvivors.App.Objects;
using VampireSurvivors.App.Tools;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Characters.Enemies;
using VampireSurvivors.Objects.Items;
using VampireSurvivors.Objects.Pickups;
using VampireSurvivors.Objects.VFX.Shatter;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class Background6 : BackgroundManager // TypeDefIndex: 15235
	{
		// Fields
		private DirecterManager _directerManager; // 0x80
		private GameObject _fakePlayerUiLevelUpPrefab; // 0x88
		private bool _hasMirror; // 0x90
		private bool _hasTrumpet; // 0x91
		private bool _hasJubilee; // 0x92
		private bool _canContinueStageZoom; // 0x93
		private float _colorBgValue; // 0x94
		private Transform _spritesRootTransform; // 0x98
		private PhaserSprite _snap; // 0xA0
		private SpriteAnimation _snapAnimation; // 0xA8
		private PhaserSprite _sSunCircle; // 0xB0
		private PhaserSprite _sMoonCircle; // 0xB8
		private PhaserSprite _sWorldCircle; // 0xC0
		private PhaserSprite _sCentralCircle; // 0xC8
		private PhaserSprite _sunCircle; // 0xD0
		private PhaserSprite _moonCircle; // 0xD8
		private PhaserSprite _worldCircle; // 0xE0
		private PhaserSprite _centralCircle; // 0xE8
		private PhaserSprite _colorBg; // 0xF0
		private List<PhaserSprite> _windows; // 0xF8
		private FakeTilingBackground _tilingBg; // 0x100
		private MultiTargetTween _sunCircleTween; // 0x108
		private MultiTargetTween _moonCircleTween; // 0x110
		private MultiTargetTween _worldCircleTween; // 0x118
		private MultiTargetTween _stageZoomTween; // 0x120
		private VampireSurvivors.Framework.TimerSystem.Timer _colorBgTimer; // 0x128
		private ParticleEmitterManager _pfxEmitter; // 0x130
		private ParticleSystem _pfxFire1; // 0x138
		private ParticleSystem _pfxFire2; // 0x140
		private ParticleSystem _pfxFireRed1; // 0x148
		private ParticleSystem _pfxFireRed2; // 0x150
		private ShatterVFX _shatterVfx; // 0x158
		private Texture2D _capturedScreenshot; // 0x160
		private bool _hasCaptureScreenshot; // 0x168
		private SpriteRenderer _shatterVfxRenderer; // 0x170
		private float _shatterGlobalScale; // 0x178
		private Tween[] _shatterMoveTweens; // 0x180
		private Tween[] _shatterAngleTweens; // 0x188
		private Tween[] _shatterAlphaTweens; // 0x190
		private Pickup _pickupDirecter; // 0x198
		private EnemyDirecter _directer; // 0x1A0
		private int _stageKeyIndex; // 0x1A8
		private List<string> _stageKeys; // 0x1B0
		public float _OriginalZoom; // 0x1B8
		public float _OriginalUIZoom; // 0x1BC
		private RectTransform _mainUIView; // 0x1C0
		private GameObject _videoPlayerPrefab; // 0x1C8
		private Dictionary<string, VideoClip> _videoClips; // 0x1D0
		private List<string> _videoKeys; // 0x1D8
		private List<float> _videoStarts; // 0x1E0
		private List<float> _videoEnds; // 0x1E8
		private List<int> _videoBlinks; // 0x1F0
		private List<VideoPlayerHelper> _videoPlayerHelpers; // 0x1F8
		private VideoPlaybackManager _videoPlaybackManager; // 0x200
	
		// Properties
		public EnemyDirecter Directer { get => default; } // 0x0000000181971880-0x0000000181971890 
		public ParticleSystem PfxFire1 { get => default; } // 0x0000000184F612E0-0x0000000184F612F0 
		public ParticleSystem PfxFire2 { get => default; } // 0x0000000184F612F0-0x0000000184F61300 
		private DirecterManager DirecterMan { get => default; } // 0x00000001819A0370-0x00000001819A0380 
	
		// Constructors
		public Background6() {} // 0x0000000186AC2F80-0x0000000186AC3C20
	
		// Methods
		protected override void OnDestroy() {} // 0x0000000186AB2C20-0x0000000186AB30D0
		protected override void OnUpdate() {} // 0x0000000186AB30D0-0x0000000186AB36F0
		public DirecterManager GetDirecterManager() => default; // 0x00000001819A0370-0x00000001819A0380
		public override void Create() {} // 0x0000000186AB36F0-0x0000000186AB4990
		private void OnRemoteItemInstantiated(Pickup item) {} // 0x0000000186AB4990-0x0000000186AB4BA0
		private void OnRemoteEnemySpawned(EnemyController enemy) {} // 0x0000000186AB4BA0-0x0000000186AB4DD0
		public void SwapDirecters() {} // 0x0000000186AB4DD0-0x0000000186AB5040
		public void OnPhase1() {} // 0x0000000186AB5040-0x0000000186AB5120
		public void OnPhase2() {} // 0x0000000186AB5120-0x0000000186AB5200
		public void OnPhase3() {} // 0x0000000186AB5200-0x0000000186AB52E0
		public void OnPhase4() {} // 0x0000000186AB52E0-0x0000000186AB53C0
		public void OnPhase5() {} // 0x0000000186AB53C0-0x0000000186AB54A0
		public void RemoveCircles() {} // 0x0000000186AB54A0-0x0000000186AB5BF0
		public void RemoveTileset() {} // 0x0000000186AB5BF0-0x0000000186AB6090
		public void RemoveWalls() {} // 0x0000000186AB6090-0x0000000186AB62E0
		public void ZoomOverStages() {} // 0x0000000186AB62E0-0x0000000186AB67F0
		public void TurnBgToFire() {} // 0x0000000186AB67F0-0x0000000186AB6940
		public void StartColorChangingBackground() {} // 0x0000000186AB6940-0x0000000186AB7020
		[IteratorStateMachine(typeof(_EnterPhase5PostShatterAnimation_d__80))]
		public IEnumerator EnterPhase5PostShatterAnimation() => default; // 0x0000000186AB7020-0x0000000186AB70C0
		public void BlockInput() {} // 0x0000000186AB70C0-0x0000000186AB7180
		public void ShatterImage() {} // 0x0000000186AB7180-0x0000000186AB7230
		public void OpenWindows() {} // 0x0000000186AB7230-0x0000000186AB7370
		public void StartZoomingOut() {} // 0x0000000186AB7370-0x0000000186AB7FE0
		public void RemoveColorBg() {} // 0x0000000186AB7FE0-0x0000000186AB8280
		public void AddLevelUpBars() {} // 0x0000000186AB8280-0x0000000186AB83C0
		public void StartGifts() {} // 0x0000000186AB83C0-0x0000000186AB8860
		public void MakeThrowingHands() {} // 0x0000000186AB8860-0x0000000186AB9660
		public void PlayVideos() {} // 0x0000000186AB9660-0x0000000186AB9BA0
		private void GenerateSprites() {} // 0x0000000186AB9BA0-0x0000000186ABA2C0
		private void GenerateFakeTilingBackground() {} // 0x0000000186ABA2C0-0x0000000186ABA510
		private void RemovePowerUps() {} // 0x0000000186ABA510-0x0000000186ABADA0
		private void RemovePowers(List<string> frames) {} // 0x0000000186ABADA0-0x0000000186ABB920
		private void SnapEggs() {} // 0x0000000186ABB920-0x0000000186ABBB40
		private void MakeCircles() {} // 0x0000000186ABBB40-0x0000000186ABCB20
		private void MakeFireEmitters() {} // 0x0000000186ABCB20-0x0000000186ABEB50
		private void MakeWindows() {} // 0x0000000186ABEB50-0x0000000186ABF330
		private void MakeDirector() {} // 0x0000000186ABF330-0x0000000186ABF410
		private void InitShatterVfx() {} // 0x0000000186ABF410-0x0000000186ABF950
		[IteratorStateMachine(typeof(_ShatterImageRoutine_d__100))]
		private IEnumerator ShatterImageRoutine() => default; // 0x0000000186ABF950-0x0000000186ABF9F0
		private void Shatter() {} // 0x0000000186ABF9F0-0x0000000186AC09D0
		private void KillShatterTweens() {} // 0x0000000186AC09D0-0x0000000186AC0AC0
		private static void KillTween(Tween[] tweens) {} // 0x0000000186AC0AC0-0x0000000186AC0B20
		private void SpawnFakePlayerUILevelUp(float xPos, float yPos) {} // 0x0000000186AC0B20-0x0000000186AC0D70
		private void SendGem(bool isCluster, bool isRandomColor) {} // 0x0000000186AC0D70-0x0000000186AC1910
		private void SendCoins(bool isRandomType) {} // 0x0000000186AC1910-0x0000000186AC2240
		private void CacheVideoHelpers() {} // 0x0000000186AC2240-0x0000000186AC2620
		private void CleanupVideoPlaybackManager() {} // 0x0000000186AC2620-0x0000000186AC2640
		private void PlayVideosAt(int index, List<Vector2> positions, float scale = 0.75f /* Metadata: 0x0197746E */) {} // 0x0000000186AC2640-0x0000000186AC2F80
	}
}

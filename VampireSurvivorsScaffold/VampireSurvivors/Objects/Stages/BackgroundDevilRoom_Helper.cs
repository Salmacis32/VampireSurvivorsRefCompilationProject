/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DarkTonic.MasterAudio;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class BackgroundDevilRoom_Helper // TypeDefIndex: 15269
	{
		// Fields
		public BackgroundDevilRoom backgroundManager; // 0x10
		public PhaserScene scene; // 0x18
		public ParticleSystem TopEmitter; // 0x20
		public ParticleSystem BottomEmitter; // 0x28
		public ParticleSystem SkullsEmitter; // 0x30
		public PhaserSprite _darkBackground; // 0x38
		public PhaserSprite _lightBackground; // 0x40
		public MultiTargetTween _tween1; // 0x48
		public MultiTargetTween _tween2; // 0x50
		public Light2D _globalLight; // 0x58
		private float _currentCameraAngleZ; // 0x60
		private DG.Tweening.Sequence _pulseLightSeq; // 0x68
		private TweenerCore<float, float, FloatOptions> _darkToLightTween; // 0x70
		private List<SpriteRenderer> _backgroundClouds; // 0x78
		private List<MultiTargetTween> _movingBgTweens; // 0x80
		private Transform _spritesRootTransform; // 0x88
		private PlaySoundResult _geiger1AL; // 0x90
		private PlaySoundResult _geiger2AR; // 0x98
		private PlaySoundResult _geiger3BL; // 0xA0
		private PlaySoundResult _geiger4BR; // 0xA8
		public PhaserSprite _centralSprite; // 0xB0
		private MultiTargetTween _eyeTween; // 0xB8
		private float IntroDurationMS; // 0xC0
		private float LoopDurationMS; // 0xC4
		private List<string> _eyeFrames; // 0xC8
		private List<string> _eyeFrames2; // 0xD0
		private VampireSurvivors.Framework.TimerSystem.Timer bloodEmitterTimer; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer _musicIntroTimedEvent; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _musicLoopEvent; // 0xE8
		private TweenerCore<Vector3, Vector3, VectorOptions> _eyeScaleTween; // 0xF0
		private Light2D _redLight; // 0xF8
		private int _wallEyesCounter; // 0x100
		private List<PhaserSprite> _eyeWallSprites; // 0x108
		private int _backgroundEyesCounter; // 0x110
		private List<PhaserSprite> _eyeSprites; // 0x118
		private float _geigerTime; // 0x120
		private bool _isPlayingGeigerNoise; // 0x124
		private bool _bgEnabled; // 0x125
	
		// Constructors
		public BackgroundDevilRoom_Helper() {} // Dummy constructor
		public BackgroundDevilRoom_Helper(PhaserScene _scene, BackgroundDevilRoom _backgroundManager) {} // 0x0000000186B16A40-0x0000000186B17180
	
		// Methods
		public void MakeRedLight() {} // 0x0000000186B17180-0x0000000186B17410
		public void DarkToLight(float value = 1f /* Metadata: 0x0197748A */) {} // 0x0000000186B17410-0x0000000186B17580
		public void StartMusic() {} // 0x0000000186B17580-0x0000000186B17800
		private void RegisterMusicLoopEvents() {} // 0x0000000186B17800-0x0000000186B18B10
		public void RedLightSwoop(int index = 0 /* Metadata: 0x0197748E */) {} // 0x0000000186B18B10-0x0000000186B18D30
		public void WallEyes(int index = 0 /* Metadata: 0x0197748F */, int amount = 1 /* Metadata: 0x01977490 */) {} // 0x0000000186B18D30-0x0000000186B19180
		public void BackgroundEyes(int index = 0 /* Metadata: 0x01977491 */, int amount = 1 /* Metadata: 0x01977492 */) {} // 0x0000000186B19180-0x0000000186B195B0
		public void PulseLight(float value = 1f /* Metadata: 0x01977493 */) {} // 0x0000000186B195B0-0x0000000186B19840
		public void PulseBlood(float value = 1f /* Metadata: 0x01977497 */) {} // 0x0000000186B19840-0x0000000186B19980
		public void StartBlood(float value = 1f /* Metadata: 0x0197749B */) {} // 0x0000000186B19980-0x0000000186B199F0
		public void TiltCamera() {} // 0x0000000186B199F0-0x0000000186B19B30
		public void ResetCameraRotation() {} // 0x0000000186B19B30-0x0000000186B19D40
		public void PulseBackground() {} // 0x0000000186B19D40-0x0000000186B1A120
		public void MakeEmitters() {} // 0x0000000186B1A120-0x0000000186B1BED0
		public void MakeBackgrounds() {} // 0x0000000186B1BED0-0x0000000186B1CF70
		public void TweenEye(PhaserSprite sprite) {} // 0x0000000186B1CF70-0x0000000186B1D530
		public void AddRotatingBackground() {} // 0x0000000186B1D530-0x0000000186B1E190
		private void ReTween(SpriteRenderer s, int i) {} // 0x0000000186B1E190-0x0000000186B1E500
		public void StartGeigerNoise() {} // 0x0000000186B1E500-0x0000000186B1E9A0
		public void StopGeigerNoise() {} // 0x0000000186B1E9A0-0x0000000186B1ED50
		public void Update() {} // 0x0000000186B1ED50-0x0000000186B1F800
		public void DisableMovingBackground() {} // 0x0000000186B1F800-0x0000000186B1FA50
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Tilemaps;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class BackgroundSpace : BackgroundManager // TypeDefIndex: 15302
	{
		// Fields
		private TileSprite _stars2; // 0x80
		private TileSprite _starsA; // 0x88
		private TileSprite _starsB; // 0x90
		private TileSprite _starsC; // 0x98
		private TileSprite _starsD; // 0xA0
		private float _yMul; // 0xA8
		private BgmType _saveBgm; // 0xAC
		private BgmModType _saveBgmMod; // 0xB0
		private float _speedFactor; // 0xB4
		private int alphaMinuteStart; // 0xB8
		private List<Tilemap> stageTilemaps; // 0xC0
		private bool _spawnBraveStory; // 0xC8
		private bool _checkHeartDistance; // 0xC9
		private float2 relicPosition; // 0xCC
		private float2 _center; // 0xD4
		protected PhaserSprite _zodiacSprite; // 0xE0
		private MultiTargetTween _tween1; // 0xE8
		private MultiTargetTween _tween2; // 0xF0
		private MultiTargetTween _tween3; // 0xF8
		private float _value; // 0x100
		private Pickup _spawnedBraveStoryRelic; // 0x108
		private ParticleSystem _pfxSnowEmitter; // 0x110
		private ParticleEmitterManager _pfxManager; // 0x118
		private List<MultiTargetTween> spaceTweens; // 0x120
		private bool _spaceTweensActive; // 0x128
		private Circle _heartCircle; // 0x130
		private PhaserSprite _heartSprite; // 0x138
	
		// Constructors
		public BackgroundSpace() {} // 0x0000000186B5A560-0x0000000186B5A660
	
		// Methods
		public override void Create() {} // 0x0000000186B56380-0x0000000186B57850
		public override void OnInitCompleted() {} // 0x0000000186B57850-0x0000000186B58120
		private void GetCenter() {} // 0x0000000186B58120-0x0000000186B582A0
		protected override void OnUpdate() {} // 0x0000000186B582A0-0x0000000186B58BF0
		public override void CheckMinute(int minute) {} // 0x0000000186B58BF0-0x0000000186B59530
		public void StartSpaceTweens() {} // 0x0000000186B59530-0x0000000186B59C90
		public override void Cleanup() {} // 0x0000000186B59C90-0x0000000186B59D90
		public override void EnableMovingBackground() {} // 0x0000000186B59D90-0x0000000186B5A0D0
		public override void DisableMovingBackground() {} // 0x0000000186B5A0D0-0x0000000186B5A560
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Signals;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class BackgroundCoop : BackgroundManager // TypeDefIndex: 15261
	{
		// Fields
		public int zoneNum; // 0x80
		private VampireSurvivors.Framework.TimerSystem.Timer _gaeaEventTimer; // 0x88
		private bool _activated; // 0x90
		private bool _hasSpeedUpClock; // 0x91
		private BgmType _saveBgm; // 0x94
		private BgmModType _saveBgmMod; // 0x98
		private List<PhaserSprite> _barriers; // 0xA0
		private List<PhaserSprite> _brokenBarriers; // 0xA8
		private bool _firstEnemyKilled; // 0xB0
		private Bounds _pickupSafeAreaBounds; // 0xB4
		private PhaserSprite _AGaeaSprite; // 0xD0
		private PhaserSprite _eyeSpriteL; // 0xD8
		private PhaserSprite _eyeSpriteR; // 0xE0
		private MultiTargetTween faceTween; // 0xE8
		private MultiTargetTween fadeOutTween; // 0xF0
		private float _colorValue; // 0xF8
		private PhaserSprite _backgroundTile; // 0x100
		private bool _changeBGColor; // 0x108
		private bool _gaeaEventStarted; // 0x109
	
		// Properties
		public override bool SpawnEnemiesOnStart { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	
		// Constructors
		public BackgroundCoop() {} // 0x0000000186B0EA70-0x0000000186B0EA80
	
		// Methods
		public override void Create() {} // 0x0000000186B09F90-0x0000000186B0A860
		private void OnEnemyRemovedFromStage(GameplaySignals.RemoveEnemyFromStageSignal obj) {} // 0x0000000186B0A860-0x0000000186B0AA40
		public void SetFirstEnmemyKilled() {} // 0x00000001849DC700-0x00000001849DC710
		private void CreateBarriers() {} // 0x0000000186B0AA40-0x0000000186B0B000
		public override void OnInitCompleted() {} // 0x0000000186B0B000-0x0000000186B0B390
		public override bool HasExtraSafeXYLogic() => default; // 0x0000000181958370-0x0000000181958380
		public override float2 ExtraSafeXY(float2 position, float2 playerPosition) => default; // 0x0000000186B0B390-0x0000000186B0B530
		public override void CheckMinute(int minute) {} // 0x0000000186B0B530-0x0000000186B0B540
		public void ChangeZone(int zone) {} // 0x0000000186B0B540-0x0000000186B0BE80
		protected override void OnUpdate() {} // 0x0000000186B0BE80-0x0000000186B0BEE0
		public override void Cleanup() {} // 0x0000000186B0BEE0-0x0000000186B0BF90
		private void Activate() {} // 0x0000000186B0BF90-0x0000000186B0C430
		private void ChangeBGMRate(float value) {} // 0x0000000186B0C430-0x0000000186B0C500
		protected override void OnDestroy() {} // 0x0000000186B0C500-0x0000000186B0C5D0
		private void InitBackground() {} // 0x0000000186B0C5D0-0x0000000186B0CA30
		private void GaeaEventUpdate() {} // 0x0000000186B0CA30-0x0000000186B0CC40
		private void CheckForGaeaEvent() {} // 0x0000000186B0CC40-0x0000000186B0CDE0
		public void StartGaeaEvent() {} // 0x0000000186B0CDE0-0x0000000186B0E110
		private void StartFinalSequence() {} // 0x0000000186B0E110-0x0000000186B0E960
		private void OnDrawGizmos() {} // 0x0000000186B0E960-0x0000000186B0EA70
	}
}

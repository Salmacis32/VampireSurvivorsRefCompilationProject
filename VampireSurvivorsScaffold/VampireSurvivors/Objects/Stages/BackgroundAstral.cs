/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using SuperTiled2Unity;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Items;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class BackgroundAstral : BackgroundManager // TypeDefIndex: 15242
	{
		// Fields
		private StageEventTrisectionManager _trisection; // 0x80
		private TileSprite _stars2; // 0x88
		private PhaserSprite _carpet; // 0x90
		private PhaserSprite _hand; // 0x98
		private PhaserSprite _pizzaASprite; // 0xA0
		private Circle _pizzaA; // 0xA8
		private float _yMul; // 0xB0
		private float _startingX; // 0xB4
		private float _startingY; // 0xB8
		private float _distanceFromStartingY; // 0xBC
		private float _red; // 0xC0
		private float _blue; // 0xC4
		private int[] _cachedPlayerCharm; // 0xC8
		private bool _stopPlayerMovement; // 0xD0
		private bool _isPlayingIntroSequence; // 0xD1
		private bool _isEventTrisectionEnabled; // 0xD2
		private bool _isOnBeatComplete; // 0xD3
		private bool _canPizza; // 0xD4
		private BgmType _saveBgm; // 0xD8
		private BgmModType _saveBgmMod; // 0xDC
		private VampireSurvivors.Framework.TimerSystem.Timer _initialTimeout; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _flipInterval; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _flipClearTimeout; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _mainInterval; // 0xF8
		private float _speedFactor; // 0x100
		private List<PhaserSprite> _portraits; // 0x108
		private List<MultiTargetTween> _portraitsTweens; // 0x110
		private List<string> _portraitFrames; // 0x118
		private PickupTeleporter secretDoor; // 0x120
		private BgmType _secretEventSaveBgm; // 0x128
		private PickupCoffin secretCoffin; // 0x130
		private const float BGMDuration = 83650f; // Metadata: 0x01977472
		private const float InitialTimeoutDuration = 34000f; // Metadata: 0x01977476
		private const float FlipIntervalDuration = 800f; // Metadata: 0x0197747A
		private const float FlipClearTimeoutDuration = 75000f; // Metadata: 0x0197747E
	
		// Constructors
		public BackgroundAstral() {} // 0x0000000186ACFE00-0x0000000186AD06C0
	
		// Methods
		private void OnDrawGizmos() {} // 0x0000000186AC82E0-0x0000000186AC8380
		protected override void OnDestroy() {} // 0x0000000186AC8380-0x0000000186AC8500
		public override void Create() {} // 0x0000000186AC8500-0x0000000186AC9520
		private void OnRemoteItemInstantiated(Pickup obj) {} // 0x0000000186AC9520-0x0000000186AC96E0
		public override void OnInitCompleted() {} // 0x0000000186AC96E0-0x0000000186AC9EF0
		protected override void OnUpdate() {} // 0x0000000186AC9EF0-0x0000000186ACA7F0
		public override void CheckHalfMinute() {} // 0x0000000186ACA7F0-0x0000000186ACA8C0
		public override void CheckMinute(int minute) {} // 0x0000000186ACA8C0-0x0000000186ACA8E0
		public override void Cleanup() {} // 0x0000000186ACA8E0-0x0000000186ACA9E0
		private void FirstTimeSetup() {} // 0x0000000186ACA9E0-0x0000000186ACB0A0
		private void MakeSpinningPortraits() {} // 0x0000000186ACB0A0-0x0000000186ACB980
		private void StartIntroSequence() {} // 0x0000000186ACB980-0x0000000186ACC250
		private void EnterHand() {} // 0x0000000186ACC250-0x0000000186ACC9E0
		private void FadeInTileset() {} // 0x0000000186ACC9E0-0x0000000186ACCAD0
		private bool IsIntroSequence() => default; // 0x0000000186ACCAD0-0x0000000186ACCCC0
		private void StartFlipBeats() {} // 0x0000000186ACCCC0-0x0000000186ACCE80
		private void StartBeatsLoop() {} // 0x0000000186ACCE80-0x0000000186ACCF70
		private void OnBeat() {} // 0x0000000186ACCF70-0x0000000186ACD280
		private void StopBeat() {} // 0x0000000186ACD280-0x0000000186ACD2E0
		private Color GetColor(float alpha) => default; // 0x0000000186ACD2E0-0x0000000186ACD3A0
		public float2 MakeDoor46Event(float2 previousDestination, PickupTeleporter sourceTeleporter) => default; // 0x0000000186ACD3A0-0x0000000186ACE030
		public override void CustomPreload(Action onComplete) {} // 0x0000000186ACE030-0x0000000186ACE520
		public void OnSecretFinished() {} // 0x0000000186ACE520-0x0000000186ACE950
		public void OnReturnStarted(VampireSurvivors.Objects.Characters.CharacterController playerTeleported) {} // 0x0000000186ACE950-0x0000000186ACECE0
		private void MakePizza() {} // 0x0000000186ACECE0-0x0000000186ACF2D0
		private void CheckPizzas() {} // 0x0000000186ACF2D0-0x0000000186ACF4D0
		private void AnimPizza() {} // 0x0000000186ACF4D0-0x0000000186ACF7F0
		private void RestorePlayersCharmStat() {} // 0x0000000186ACF7F0-0x0000000186ACF960
		public override void EnableMovingBackground() {} // 0x0000000186ACF960-0x0000000186ACFBC0
		public override void DisableMovingBackground() {} // 0x0000000186ACFBC0-0x0000000186ACFE00
	}
}

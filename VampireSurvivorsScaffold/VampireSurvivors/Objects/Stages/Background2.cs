/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using SuperTiled2Unity;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Characters.Enemies;
using VampireSurvivors.Objects.Items;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	[UsedImplicitly]
	public class Background2 : BackgroundManager // TypeDefIndex: 15208
	{
		// Fields
		private bool _triggerCheck; // 0x80
		private bool _hasSpawnedTrickster; // 0x81
		private bool _hasDefeatedTrickster; // 0x82
		private bool _saveDmg; // 0x83
		private bool _canInteractWithPiano; // 0x84
		private BgmType? _saveBgm; // 0x88
		private BgmModType? _saveBgmMod; // 0x90
		private EnemyTrickster _enemyTrickster; // 0x98
		private VampireSurvivors.Framework.TimerSystem.Timer _pianoInteractionTimer; // 0xA0
		private VampireSurvivors.Framework.TimerSystem.Timer _undeadsTimer; // 0xA8
		private int _undeadsTimerLoopCount; // 0xB0
		private PhaserSprite _sDarkness; // 0xB8
		private PhaserSprite _sDarknessExtraA; // 0xC0
		private PhaserSprite _sDarknessExtraB; // 0xC8
		private SuperObject _piano; // 0xD0
		private SuperObject _coffin; // 0xD8
		private Vector2 _pianoPos; // 0xE0
		private Vector2 _coffinPos; // 0xE8
		private float _pianoOffset; // 0xF0
		private float _displayHeight; // 0xF4
		private float _displayWidth; // 0xF8
		private bool _pianoDone; // 0xFC
		private PickupCoffinEmpty _rightCoffin; // 0x100
		private readonly bool _quickDebug; // 0x108
	
		// Constructors
		public Background2() {} // 0x0000000186A98280-0x0000000186A982A0
	
		// Methods
		protected override void OnUpdate() {} // 0x0000000186A95130-0x0000000186A955E0
		public override void Create() {} // 0x0000000186A955E0-0x0000000186A96190
		public void BigPianoIn(VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x0000000186A96190-0x0000000186A96330
		public void BigPianoOut() {} // 0x0000000186A96330-0x0000000186A96450
		public void BigSpoop() {} // 0x0000000186A96450-0x0000000186A96CC0
		public override void Cleanup() {} // 0x0000000186A96CC0-0x0000000186A970C0
		public override void CustomPreload(Action onComplete) {} // 0x0000000186A970C0-0x0000000186A973A0
		private void MakeCoffins() {} // 0x0000000186A973A0-0x0000000186A977F0
		private void OnRightCoffinOpened() {} // 0x0000000186A977F0-0x0000000186A97950
		private void ProcessRightCoffinOpened() {} // 0x0000000186A97950-0x0000000186A97DB0
		private void RevealTrickster() {} // 0x0000000186A97DB0-0x0000000186A98070
		private void HandleTricksterDefeat() {} // 0x0000000186A98070-0x0000000186A98250
		private void SetupDarkness() {} // 0x0000000186A98250-0x0000000186A98280
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DG.Tweening.Core;
using JetBrains.Annotations;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Characters.Enemies;
using VampireSurvivors.Objects.Items;
using VampireSurvivors.Objects.Pickups;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	[UsedImplicitly]
	public class Background5 : BackgroundManager // TypeDefIndex: 15219
	{
		// Fields
		private float _wind; // 0x80
		[HideInInspector]
		public float _TintHelp; // 0x84
		private float _minuteValueMillis; // 0x88
		private bool _hasKilledTheFinalBoss; // 0x8C
		private bool _hasTerraceBeenOpened; // 0x8D
		private Pickup _coffin; // 0x90
		private BgmType _savedBgm; // 0x98
		private EnemyTheEnder _ender; // 0xA0
		private EnemyDrownerNormal _drowner; // 0xA8
		private EnemyStalkerNormal _stalker; // 0xB0
		private EnemyStalkerNormal _trickster; // 0xB8
		private EnemyMaddenerNormal _maddener; // 0xC0
		private Transform _spritesRootTransform; // 0xC8
		private SpriteRenderer _snap; // 0xD0
		private SpriteAnimation _snapAnimation; // 0xD8
		private TileSprite _skyBlue; // 0xE0
		private TileSprite _skyRed; // 0xE8
		private GameObject _cloudsParent; // 0xF0
		private TileSprite _cloudsBlue; // 0xF8
		private TileSprite _cloudsWhite; // 0x100
		private TileSprite _cloudsAddBlue; // 0x108
		private TileSprite _cloudsAddRed; // 0x110
		private TileSprite _cloudsRed; // 0x118
		private SpriteRenderer _whiteFader; // 0x120
		private SpriteRenderer _shootingRay; // 0x128
		private SpriteRenderer _shootingRing; // 0x130
		private TileSprite _floorLights; // 0x138
		private TileSprite _skyLights; // 0x140
		private SpriteRenderer _purpleOverlay; // 0x148
		private SpriteRenderer _purpleOverlayAdd; // 0x150
		private List<SpriteRenderer> _purpleClouds; // 0x158
		private List<MultiTargetTween> _movingBgTweens; // 0x160
		private MultiTargetTween _floorLightsTween; // 0x168
		private MultiTargetTween _skyLightsTween; // 0x170
		private List<EquipmentInfo> _playerEquipment; // 0x178
		private bool _useReaperMinuteCheck; // 0x180
		private Pickup _cosmoPavone; // 0x188
	
		// Properties
		protected virtual bool AlwaysSpawnEnder { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected virtual bool DropGospel { get => default; } // 0x0000000181958370-0x0000000181958380 
		protected virtual float EnderShieldTime { get => default; } // 0x0000000186AA1EB0-0x0000000186AA1EC0 
		public WindowWeapon WindowWeapon { get; set; } // 0x0000000182766A50-0x0000000182766A60 0x0000000185132550-0x00000001851325B0
	
		// Constructors
		public Background5() {} // 0x0000000186AAF680-0x0000000186AAF8A0
	
		// Methods
		protected override void OnDestroy() {} // 0x0000000186AA1EC0-0x0000000186AA25F0
		protected override void OnUpdate() {} // 0x0000000186AA25F0-0x0000000186AA3200
		public override void Create() {} // 0x0000000186AA3200-0x0000000186AA4060
		private void OnRemoteItemInstantiated(Pickup item) {} // 0x0000000186AA4060-0x0000000186AA4150
		private void OnMaddenerSpawned(GameObject enemy) {} // 0x0000000186AA4150-0x0000000186AA42C0
		private void OnRemoteEnemySpawned(EnemyController enemy) {} // 0x0000000186AA42C0-0x0000000186AA43B0
		public override void Cleanup() {} // 0x0000000186AA43B0-0x0000000186AA4480
		public override void DisableMovingBackground() {} // 0x0000000186AA4480-0x0000000186AA4910
		public override void EnableMovingBackground() {} // 0x0000000186AA4910-0x0000000186AA4DA0
		private void GenerateSprites() {} // 0x0000000186AA4DA0-0x0000000186AA6B00
		private void SetupCoffinTrigger() {} // 0x0000000186AA6B00-0x0000000186AA6C50
		private void SetupCosmoTrigger() {} // 0x0000000186AA6C50-0x0000000186AA7000
		private bool UpdateEnemyAndBossData() => default; // 0x0000000186AA7000-0x0000000186AA7440
		private void SetDefaultEnemyAndBossData() {} // 0x0000000186AA7440-0x0000000186AA76A0
		public override void CheckMinute(int minute) {} // 0x0000000186AA76A0-0x0000000186AA7D40
		private void OnTricksterSpawned(GameObject enemyTrickster) {} // 0x0000000186AA7D40-0x0000000186AA7DF0
		private void OnStalkerSpawned(GameObject enemyStalker) {} // 0x0000000186AA7DF0-0x0000000186AA7EB0
		private void OnDrownerSpawned(GameObject enemy) {} // 0x0000000186AA7EB0-0x0000000186AA7F70
		private void SnapEggs() {} // 0x0000000186AA7F70-0x0000000186AA81A0
		private void SnapYellows() {} // 0x0000000186AA81A0-0x0000000186AA8820
		public void PerformSnapYellows(PickupWeapon gRing, PickupWeapon sRing, PickupWeapon lMeta, PickupWeapon rMeta, VampireSurvivors.Objects.Characters.CharacterController player, Weapon cs, Weapon ic) {} // 0x0000000186AA8820-0x0000000186AA8D60
		private void TryRemoveStagePickup(Pickup pickup) {} // 0x0000000186AA8D60-0x0000000186AA8E20
		private void RemovePowers(List<string> frames) {} // 0x0000000186AA8E20-0x0000000186AA99A0
		private void EnterTheBossi() {} // 0x0000000186AA99A0-0x0000000186AAA180
		private void RemoveWalls() {} // 0x0000000186AAA180-0x0000000186AAA4D0
		private void FadeOutSky() {} // 0x0000000186AAA4D0-0x0000000186AAAD30
		private void OnEnderSpawned(GameObject enemyEnder) {} // 0x0000000186AAAD30-0x0000000186AAAFD0
		private void PowerOfFriendshipGoPlanet() {} // 0x0000000186AAAFD0-0x0000000186AABE50
		private void StaggerMoveReaper(int index, SpriteRenderer reaper) {} // 0x0000000186AABE50-0x0000000186AAC110
		private void EnterPurpleSky() {} // 0x0000000186AAC110-0x0000000186AAD3E0
		private void FadeOutPurpleSky() {} // 0x0000000186AAD3E0-0x0000000186AADB00
		private void ShowPurpleOverlays() {} // 0x0000000186AADB00-0x0000000186AAE040
		private void FadeToMad() {} // 0x0000000186AAE040-0x0000000186AAE350
		private void RevertMad() {} // 0x0000000186AAE350-0x0000000186AAE5A0
		private void ToggleBlue(bool visible) {} // 0x0000000186AAE5A0-0x0000000186AAE6C0
		private void ToggleRed(bool visible) {} // 0x0000000186AAE6C0-0x0000000186AAE7E0
		private void ToggleAlias(bool toggle) {} // 0x0000000186AAE7E0-0x0000000186AAEB00
		public void OpenTerrace() {} // 0x0000000186AAEB00-0x0000000186AAF680
	}
}

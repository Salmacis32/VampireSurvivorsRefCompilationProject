/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using DG.Tweening;
using I2.Loc;
using Rewired;
using SuperTiled2Unity;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Tilemaps;
using VampireSurvivors.App.Objects;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Characters;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Characters.Enemies;
using VampireSurvivors.Objects.Items;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class DraculaCutscene : GameMonoBehaviour // TypeDefIndex: 13961
	{
		// Fields
		[SerializeField]
		protected TPCutsceneDialogueUI _CutsceneDialogueUIPrefab; // 0x28
		[SerializeField]
		protected ArcadeSprite _DraculaSprite; // 0x30
		[Header("Character Positions")]
		[SerializeField]
		private Vector2 _DebugTeleportPosition; // 0x38
		[SerializeField]
		private Vector2 _WaitPosition; // 0x40
		[SerializeField]
		private float _SpreadPerPlayerInCoOp; // 0x48
		[SerializeField]
		private int _CharacterWalkTimeInMilliseconds; // 0x4C
		[SerializeField]
		protected Vector2 _DeathSpawnPosition; // 0x50
		[Header("Camera")]
		[SerializeField]
		private Transform _CameraTargetTransform; // 0x58
		[SerializeField]
		private float _CameraTransitionDuration; // 0x60
		[SerializeField]
		private bool _DoCameraZoom; // 0x64
		[SerializeField]
		private float _CameraZoomScreenSize; // 0x68
		[SerializeField]
		private float _CameraZoomScreenSizePortrait; // 0x6C
		[SerializeField]
		private float _CameraZoomInDuration; // 0x70
		[SerializeField]
		private float _CameraZoomOutDuration; // 0x74
		[Header("Dialogue")]
		[SerializeField]
		protected TPCutsceneDialogue[] _CutsceneDialogue; // 0x78
		[SerializeField]
		protected TPCutsceneDialogue[] _AfterCoffinCutsceneDialogue; // 0x80
		[Header("Wine Glass Throw")]
		[SerializeField]
		protected DraculaCutsceneWineGlass _WineGlass; // 0x88
		[SerializeField]
		private Vector2 _ThrowStartPosition; // 0x90
		[SerializeField]
		private Vector2 _ThrowEndPosition; // 0x98
		[SerializeField]
		private int _ThrowWineGlassDialogueIndex; // 0xA0
		[SerializeField]
		private float _ThrowWineGlassDelay; // 0xA4
		[Header("Coffin Teleport")]
		[SerializeField]
		private DraculaCutsceneTeleport _TeleportEffect; // 0xA8
		[SerializeField]
		private ArcadeSprite _DirecterHand; // 0xB0
		[SerializeField]
		private Vector2 _CoffinPosition; // 0xB8
		[SerializeField]
		private float _DelayBeforePlayingDirecterSnap; // 0xC0
		[Header("Death Transition")]
		[SerializeField]
		private float _BackgroundTileLerpOutDuration; // 0xC4
		[SerializeField]
		private float _ScreenShakeMagnitude; // 0xC8
		[SerializeField]
		private float _ScreenShakeDuration; // 0xCC
		[SerializeField]
		protected int _ScreenShakeRepeats; // 0xD0
		[Header("Other")]
		[SerializeField]
		private bool _showLetterBox; // 0xD4
		protected Player _player; // 0xD8
		protected TPCutsceneDialogueUI _cutsceneDialogueUI; // 0xE0
		protected List<VampireSurvivors.Objects.Characters.CharacterController> _characterControllers; // 0xE8
		protected Tilemap _backgroundTilemap; // 0xF0
		private Coroutine _cutsceneCoroutine; // 0xF8
		protected Coroutine _cameraZoomCoroutine; // 0x100
		private Rectangle _platformingArea; // 0x108
		private Rectangle _cutsceneArea; // 0x110
		private Rect? _originalHardBounds; // 0x118
		private Rectangle _platformingHardBounds; // 0x130
		private Rectangle _cutsceneHardBounds; // 0x138
		private Rectangle _cutsceneCameraLimits; // 0x140
		private float _preZoomCameraSize; // 0x148
		protected bool _isAnyCharacterRichter; // 0x14C
		private bool _coffinSpawnTeleportComplete; // 0x14D
		private bool _backgroundRemoveComplete; // 0x14E
		protected CutsceneState _currentCutsceneState; // 0x150
		protected MapToken _mapToken; // 0x158
		private bool _deathCutsceneTriggered; // 0x160
		protected PickupCoffin _draculaCoffin; // 0x168
		private const string WalkAnimName = "walk"; // Metadata: 0x01976BD3
		protected const string MeleeAnimName = "meleeA"; // Metadata: 0x01976BD8
		protected CoherenceSync _sync; // 0x170
		private bool _changingState; // 0x178
		private const string PlatformingAreaBoundsName = "CutscenePlatformingZone"; // Metadata: 0x01976BDF
		private const string CutsceneAreaBoundsName = "Cutscene"; // Metadata: 0x01976BF7
		private const string CutsceneCameraLimitsName = "CutsceneCameraLimits"; // Metadata: 0x01976C00
		private const string DraculaIdleAnimationName = "idle"; // Metadata: 0x01976C15
		private const string EnemiesMTextureName = "enemiesM"; // Metadata: 0x01976C1A
		private const string HandSnapAnimPrefix = "hand_snap_"; // Metadata: 0x01976C23
		private const string SnapDoAnimName = "snap"; // Metadata: 0x01976C2E
		private const string SnapStartAnimName = "snap_start"; // Metadata: 0x01976C33
	
		// Properties
		private float CameraZoomScreenSize { get => default; } // 0x0000000186971370-0x00000001869713D0 
	
		// Nested types
		protected enum CutsceneState // TypeDefIndex: 13942
		{
			Inactive = 0,
			EnteredPlatformingArea = 1,
			DraculaAndRichterDialogue = 2,
			CoffinSpawned = 3,
			DeathDialogue = 4,
			TransitionToDeathFight = 5,
			CutsceneOver = 6
		}
	
		public enum DialogueCharacter // TypeDefIndex: 13943
		{
			None = 0,
			Richter = 1,
			Dracula = 2,
			Death = 3
		}
	
		[Serializable]
		public struct TPCutsceneDialogue // TypeDefIndex: 13944
		{
			// Fields
			public DialogueCharacter Character; // 0x00
			public LocalizedString DialogueLocKey; // 0x08
	
			// Properties
			public float EnglishShowTime { [IsReadOnly] get; private set; } // 0x0000000181967D10-0x0000000181967D20 0x0000000184C5EF70-0x0000000184C5EF80
			public int EnglishCharacterCount { [IsReadOnly] get; private set; } // 0x0000000181E0A5A0-0x0000000181E0A5B0 0x0000000181E0A5B0-0x0000000181E0A5C0
	
			// Methods
			public void SetEnglishTextValues(float englishShowTime, int englishCharacterCount) {} // 0x0000000186976F30-0x0000000186976F40
		}
	
		// Constructors
		public DraculaCutscene() {} // 0x0000000186976A50-0x0000000186976B10
	
		// Methods
		protected virtual void Start() {} // 0x00000001869713D0-0x0000000186971DE0
		protected override void OnUpdate() {} // 0x0000000186971DE0-0x0000000186971FF0
		protected override void OnDestroy() {} // 0x00000001827DC690-0x00000001827DC730
		private bool CheckAllPlayersInRectangle(Rectangle rectangle) => default; // 0x0000000186971FF0-0x00000001869721E0
		protected void SetupCutsceneAreas() {} // 0x00000001869721E0-0x0000000186972500
		[Command]
		public void OnEnterPlatformingArea() {} // 0x0000000186972500-0x00000001869729A0
		[Command]
		public void OnEnterCutsceneArea() {} // 0x00000001869729A0-0x0000000186972AE0
		protected void DisableAllInput() {} // 0x0000000186972AE0-0x0000000186972C80
		protected void EnableAllInput() {} // 0x0000000186972C80-0x0000000186972E20
		private void BeginCutscene() {} // 0x0000000186972E20-0x00000001869734F0
		protected void InitDracula() {} // 0x00000001869734F0-0x0000000186973910
		protected void InitDirecterHand() {} // 0x0000000186973910-0x0000000186973BA0
		private void PlayDirecterSnap(Action onSnap = null) {} // 0x0000000186973BA0-0x0000000186973DA0
		[IteratorStateMachine(typeof(_CameraZoom_d__80))]
		private IEnumerator CameraZoom(float startSize, float endSize, float duration) => default; // 0x0000000186973DA0-0x0000000186973E20
		[IteratorStateMachine(typeof(_RevealDeath_d__81))]
		protected IEnumerator RevealDeath() => default; // 0x0000000186973E20-0x0000000186973EC0
		private void DisableGameplayOnEnterPlatformingArea() {} // 0x0000000186973EC0-0x0000000186974250
		[IteratorStateMachine(typeof(_TweenCharactersToWaitPosition_d__83))]
		private IEnumerator TweenCharactersToWaitPosition() => default; // 0x0000000186974250-0x00000001869742F0
		private void AddMoveToPositionTween(VampireSurvivors.Objects.Characters.CharacterController character, float halfSpread, int positionIndex, TweenCallback onComplete) {} // 0x00000001869742F0-0x0000000186974770
		protected void EnableMovementAfterCutscene() {} // 0x0000000186974770-0x00000001869749A0
		private void LockPlayerMovementToCameraBounds() {} // 0x00000001869749A0-0x0000000186974D20
		private void LockPlayerMovementToPlatformingAreaBounds() {} // 0x0000000186974D20-0x0000000186974ED0
		[IteratorStateMachine(typeof(_PlayCutscene_d__88))]
		private IEnumerator PlayCutscene() => default; // 0x0000000186974ED0-0x0000000186974F70
		private void OnTeleportFromThroneComplete() {} // 0x0000000186974F70-0x0000000186975060
		[IteratorStateMachine(typeof(_PlayDeathDialogueCutscene_d__90))]
		protected virtual IEnumerator PlayDeathDialogueCutscene() => default; // 0x0000000186975060-0x0000000186975100
		[IteratorStateMachine(typeof(_TransitionToDeathFight_d__91))]
		private IEnumerator TransitionToDeathFight(Enemy_TP_Death deathEnemy) => default; // 0x0000000186975100-0x0000000186975200
		private void SpawnDraculaCoffin() {} // 0x0000000186975200-0x00000001869757F0
		private void OnCharacterFoundScreenClosed() {} // 0x00000001869757F0-0x0000000186975880
		private void MakeAllBackgroundsInvisible() {} // 0x0000000186975880-0x0000000186975B20
		protected void RemoveBackground() {} // 0x0000000186975B20-0x0000000186975E00
		[IteratorStateMachine(typeof(_ScaleOutTile_d__96))]
		private IEnumerator ScaleOutTile(Vector3 cameraPosition, Vector3Int cellPosition, int relativeXCoordinate, int relativeYCoordinate) => default; // 0x0000000186975E00-0x0000000186975EF0
		protected void RemoveWalls() {} // 0x0000000186975EF0-0x00000001869761B0
		[IteratorStateMachine(typeof(_PlayDeathScream_d__98))]
		protected IEnumerator PlayDeathScream(Enemy_TP_Death death) => default; // 0x00000001869761B0-0x00000001869762B0
		private void PlayDeathScreamAudio() {} // 0x00000001869762B0-0x00000001869764A0
		[IteratorStateMachine(typeof(_WaitForSecondsPausable_d__100))]
		private IEnumerator WaitForSecondsPausable(float seconds) => default; // 0x00000001869764A0-0x00000001869764F0
		protected void DeathScreenShake(int repeats) {} // 0x00000001869764F0-0x0000000186976970
		protected float2 ConvertLocalV3ToWorldFloat2(Vector3 vector3) => default; // 0x0000000186976970-0x0000000186976A50
	}
}

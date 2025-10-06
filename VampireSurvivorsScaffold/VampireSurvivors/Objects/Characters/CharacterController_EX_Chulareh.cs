/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Items;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterController_EX_Chulareh : CharacterController // TypeDefIndex: 16985
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _DiceSprite; // 0x3F0
		[SerializeField]
		private SpriteRenderer _ScreenFillRenderer; // 0x3F8
		[SerializeField]
		private Transform _CameraTarget; // 0x400
		private List<DiceResult> _nonLuckyDiceResults; // 0x408
		private const float LuckyMoveBonus = 0.77f; // Metadata: 0x01977F95
		private const float LuckyLuckBonus = 7.77f; // Metadata: 0x01977F99
		private const float UnluckyLuckMalus = -7.77f; // Metadata: 0x01977F9D
		private const float UnluckyCurseBonus = 0.77f; // Metadata: 0x01977FA1
		private const float LuckyDiceRollBaseChance = 0.16666667f; // Metadata: 0x01977FA5
		private const float LuckyDiceEffectDuration = 30000f; // Metadata: 0x01977FA9
		private const float UnluckyDiceEffectDuration = 10000f; // Metadata: 0x01977FAD
		private const float DiceRollInterval = 30000f; // Metadata: 0x01977FB1
		private string _characterTexture; // 0x410
		private SpriteAnimation _diceRollAnim; // 0x418
		private DiceResult _diceResult; // 0x420
		private SpecialState _specialState; // 0x424
		private int _diceRollCounter; // 0x428
		private int _queuedDiceRolls; // 0x42C
		private bool _diceRollInProgress; // 0x430
		private bool _luckyCameraZoomTriggered; // 0x431
		private bool _unluckyCameraZoomTriggered; // 0x432
		private VampireSurvivors.Framework.TimerSystem.Timer _diceRollTimer; // 0x438
		private VampireSurvivors.Framework.TimerSystem.Timer _diceEffectTimer; // 0x440
		private VampireSurvivors.Framework.TimerSystem.Timer _cameraTimer; // 0x448
		private VampireSurvivors.Framework.TimerSystem.Timer _eventTimer; // 0x450
		private MultiTargetTween _diceTween; // 0x458
		private ParticleEmitterManager _pfxManager; // 0x460
		private ParticleSystem _luckyPfx; // 0x468
		private ParticleSystem _unluckyPfx; // 0x470
		private List<Transform> _originalCameraTargets; // 0x478
		private float _orthographicSize; // 0x480
	
		// Properties
		private bool IsLucky { get => default; } // 0x00000001871320B0-0x00000001871320C0 
		private bool IsUnlucky { get => default; } // 0x00000001871320C0-0x00000001871320D0 
		public override float LootMult_Rerollo { get => default; } // 0x000000018652E810-0x000000018652E820 
	
		// Nested types
		private enum DiceResult // TypeDefIndex: 16981
		{
			NoEffect = 0,
			UnluckyOne = 1,
			Two = 2,
			Three = 3,
			Four = 4,
			Five = 5,
			LuckySix = 6
		}
	
		private enum SpecialState // TypeDefIndex: 16982
		{
			None = 0,
			Lucky = 1,
			Unlucky = 2
		}
	
		// Constructors
		public CharacterController_EX_Chulareh() {} // 0x0000000187138E20-0x0000000187139130
	
		// Methods
		public override float PLuck() => default; // 0x00000001871320D0-0x00000001871322B0
		public override float PMoveSpeed() => default; // 0x00000001871322B0-0x0000000187132430
		public override float PCurse() => default; // 0x0000000187132430-0x0000000187132600
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977F92 */) {} // 0x0000000187132600-0x0000000187132CD0
		protected override void InternalUpdate() {} // 0x0000000187132CD0-0x0000000187132DF0
		private void CheckForQueuedDiceRolls() {} // 0x0000000187132DF0-0x0000000187132E10
		public override void OnPickupCollected(Pickup pickup) {} // 0x0000000187132E10-0x0000000187132E50
		private void WaitForNextDiceRoll(float delay) {} // 0x0000000187132E50-0x0000000187132F70
		private void DoDiceRoll() {} // 0x0000000187132F70-0x0000000187133130
		[Command]
		public void SetDiceResult(int result) {} // 0x0000000187133130-0x0000000187133140
		private void DoDiceRollAnim() {} // 0x0000000187133140-0x0000000187133620
		private DiceResult GetDiceResult() => default; // 0x0000000187133620-0x00000001871339B0
		private bool IsDiceResult2345() => default; // 0x00000001871339B0-0x00000001871339E0
		private void SetDiceSpriteForRoll() {} // 0x00000001871339E0-0x00000001871342A0
		private void DoDiceRollOutcome() {} // 0x00000001871342A0-0x0000000187134610
		private void GetNormalOutcome() {} // 0x0000000187134610-0x0000000187134710
		private void GetLucky() {} // 0x0000000187134710-0x0000000187134840
		private void GetUnlucky() {} // 0x0000000187134840-0x0000000187134970
		private void ActivateLuckyBonus() {} // 0x0000000187134970-0x0000000187134E50
		private void DeactivateLuckyBonus() {} // 0x0000000187134E50-0x0000000187134E60
		private void ActivateUnluckyBonus() {} // 0x0000000187134E60-0x0000000187135370
		private void DeactivateUnluckyBonus(bool playSfx = true /* Metadata: 0x01977F93 */) {} // 0x0000000187135370-0x0000000187135440
		private void DoShootingStars() {} // 0x0000000187135440-0x00000001871356B0
		private void AddPermanentLuckBonus(float bonus) {} // 0x00000001871356B0-0x0000000187135910
		private void DisplayOverheadIcon(string frameOverride = null, string textOverride = null, Vector2? offsetOverride = default) {} // 0x0000000187135910-0x0000000187135BE0
		private void DoDiceFadeOutSequence() {} // 0x0000000187135BE0-0x0000000187135EE0
		private void GenerateLuckyParticleSystem() {} // 0x0000000187135EE0-0x0000000187136A30
		private void GenerateUnluckyParticleSystem() {} // 0x0000000187136A30-0x0000000187137580
		private void UpdateParticles() {} // 0x0000000187137580-0x0000000187137680
		private void PlayDiceShakeSfx(bool play = true /* Metadata: 0x01977F94 */) {} // 0x0000000187137680-0x00000001871377D0
		private void PlayNormalEffectSfx() {} // 0x00000001871377D0-0x00000001871378A0
		private void PlayLuckySfx() {} // 0x00000001871378A0-0x0000000187137A30
		private void PlayUnluckySfx() {} // 0x0000000187137A30-0x0000000187137B60
		private void PlayLaughSfx() {} // 0x0000000187137B60-0x0000000187137C30
		private void ZoomInOnDice() {} // 0x0000000187137C30-0x0000000187138130
		private void SetupScreenFill() {} // 0x0000000187138130-0x0000000187138670
		public void ZoomOutFromDice() {} // 0x0000000187138670-0x0000000187138800
		private void DoQuickScreenFill() {} // 0x0000000187138800-0x0000000187138920
		public override bool OnTreasureCollected(TreasureChest treasure) => default; // 0x0000000187138920-0x0000000187138AA0
		public override void Despawn() {} // 0x0000000187138AA0-0x0000000187138B30
		private void DebugDoDiceRoll() {} // 0x0000000187138B30-0x0000000187138B40
		private void DebugGetLucky() {} // 0x0000000187138B40-0x0000000187138B80
		private void DebugGetUnlucky() {} // 0x0000000187138B80-0x0000000187138BC0
		private void DebugGetNormalOutcome() {} // 0x0000000187138BC0-0x0000000187138DF0
		private void DebugRemoveCurrentDiceEffect() {} // 0x0000000187138DF0-0x0000000187138E20
	}
}

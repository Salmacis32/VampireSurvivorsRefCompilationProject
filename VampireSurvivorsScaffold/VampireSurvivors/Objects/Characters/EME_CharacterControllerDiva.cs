/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Characters;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class EME_CharacterControllerDiva : EME_CharacterControllerShowstopper // TypeDefIndex: 17140
	{
		// Fields
		private float _glPower; // 0x428
		private float _glArea; // 0x42C
		private float _glSpeed; // 0x430
		private float _glDuration; // 0x434
		private float _glCooldown; // 0x438
		private float _glRecovery; // 0x43C
		private float _timeSinceLastAltWalk; // 0x440
		private float _timeUntilNextAltWalk; // 0x444
		private float _minTimeBetweenAltWalk; // 0x448
		private float _maxTimeBetweenAltWalk; // 0x44C
		private SpriteAnimation _scatteredPetalsSlashUp; // 0x450
		private SpriteAnimation _scatteredPetalsMidAir; // 0x458
		private SpriteAnimation _scatteredPetalsSlashDown; // 0x460
		private SpriteAnimation _scatteredPetalsLand; // 0x468
		private SpriteAnimation _scatteredPetalsGroundedSlash; // 0x470
		private bool _isUsingDivaKatanaSkin; // 0x478
		private const string WalkAnimName = "walk"; // Metadata: 0x0197802A
		private const string AltWalk1AnimName = "EME_divano5_hop"; // Metadata: 0x0197802F
		private const string AltWalk2AnimName = "EME_divano5_splits"; // Metadata: 0x0197803F
		private const string UpSlashAnimName = "EME_divano5_scatteredpetals_upwardslash"; // Metadata: 0x01978052
		private const string MidAirAnimName = "EME_divano5_scatteredpetals_midairpose"; // Metadata: 0x0197807A
		private const string DownSlashName = "EME_divano5_scatteredpetals_downwardslash"; // Metadata: 0x019780A1
		private const string LandAnimName = "EME_divano5_scatteredpetals_land"; // Metadata: 0x019780CB
		private const string GroundSlashAnimName = "EME_divano5_sword"; // Metadata: 0x019780EC
		private bool CanFly; // 0x479
		private bool HasHiddenRave; // 0x47A
		private bool HasTechniqueBonuses; // 0x47B
		private bool HasBallisticMissile; // 0x47C
		private bool HasBigMissile; // 0x47D
		private List<WeaponType> missiles; // 0x480
		private Weapon _HiddenWeapon; // 0x488
		[SerializeField]
		private int _scatteredPetalsFps; // 0x490
		private int _walkFps; // 0x494
		private int _altWalkFps; // 0x498
		private float RingLevelUpEveyXLevels; // 0x49C
		[SerializeField]
		private Image _ChargeBar; // 0x4A0
		[SerializeField]
		private Image _ChargeBarFill; // 0x4A8
		private bool _isCharging; // 0x4B0
		private float _chargeTime; // 0x4B4
		private float _maxChargeTimeMS; // 0x4B8
		private float _defaultChargeTimeMS; // 0x4BC
		private Color ChargeColor; // 0x4C0
		private Color ReadyColor; // 0x4D0
		private VampireSurvivors.Framework.TimerSystem.Timer nextTriggeredSkillTimer; // 0x4E0
	
		// Constructors
		public EME_CharacterControllerDiva() {} // 0x0000000187184A60-0x0000000187184D00
	
		// Methods
		public override float PPower() => default; // 0x00000001871813B0-0x00000001871814B0
		public override float PArea() => default; // 0x00000001871814B0-0x00000001871815B0
		public override float PSpeed() => default; // 0x00000001871815B0-0x00000001871816B0
		public override float PDuration() => default; // 0x00000001871816B0-0x00000001871817B0
		public override float PCooldown() => default; // 0x00000001871817B0-0x00000001871818B0
		public override float PRegen() => default; // 0x00000001871818B0-0x00000001871819B0
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01978029 */) {} // 0x00000001871819B0-0x00000001871820E0
		public override bool ShouldCollideWithWalls() => default; // 0x00000001871820E0-0x00000001871820F0
		private void LateUpdate() {} // 0x00000001871820F0-0x0000000187182200
		public override void LevelUp() {} // 0x0000000187182200-0x0000000187182780
		public void EnterScatteredPetalsStage(ScatteredPetalsStage stage) {} // 0x0000000187182780-0x0000000187182960
		private void AddScatteredPetalsAnimStage(string animName, string textureName, int frameCount) {} // 0x0000000187182960-0x0000000187182BA0
		private void AddCustomWalkAnim(string animName, string textureName, List<int> frameOrder, int fps) {} // 0x0000000187182BA0-0x0000000187182C90
		private List<string> SpecifyOrderAnimFrameList(string animName, List<int> frameOrder) => default; // 0x0000000187182C90-0x0000000187182E80
		private void AltWalkUpdate() {} // 0x0000000187182E80-0x0000000187183030
		private void DoAltWalk1() {} // 0x0000000187183030-0x00000001871830B0
		private void DoAltWalk2() {} // 0x00000001871830B0-0x0000000187183130
		public void ReturnToNormalWalkAnim() {} // 0x0000000187183130-0x00000001871831C0
		private List<string> MakeAnimFrameList(string animName, int frameCount) => default; // 0x00000001871831C0-0x0000000187183350
		public override void AfterFullInitialization() {} // 0x0000000187183350-0x0000000187183440
		private void HideCharge() {} // 0x0000000187183440-0x00000001871835E0
		private void ShowCharge() {} // 0x00000001871835E0-0x0000000187183780
		private void HighlightCharge() {} // 0x0000000187183780-0x0000000187183920
		protected override void OnUpdate() {} // 0x0000000187183920-0x0000000187184070
		private void TriggerChargeSkill() {} // 0x0000000187184070-0x0000000187184640
		public void SetMechaDamageEmitter() {} // 0x0000000187184640-0x0000000187184A60
	}
}

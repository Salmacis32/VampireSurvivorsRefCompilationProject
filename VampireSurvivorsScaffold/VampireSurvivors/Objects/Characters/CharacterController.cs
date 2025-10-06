/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using Newtonsoft.Json.Linq;
using Rewired;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Characters;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.NumberTypes;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Algorithm;
using VampireSurvivors.Objects.Items;
using VampireSurvivors.Objects.Pickups;
using VampireSurvivors.Objects.Weapons;
using VampireSurvivors.UI.Player;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	[DefaultExecutionOrder(850)]
	public class CharacterController : ArcadeSprite, IDamageable // TypeDefIndex: 16929
	{
		// Fields
		[Sync]
		public Vector2 CurrentDefaultMapPosition; // 0x58
		[SerializeField]
		protected int _PlayerIndex; // 0x64
		[SerializeField]
		protected SpriteRenderer _CharacterRenderer; // 0x68
		[SerializeField]
		private SpriteRenderer _DeathNoHurtRenderer; // 0x70
		protected SignalBus _signalBus; // 0x78
		protected PlayerOptions _playerOptions; // 0x80
		protected GameManager _gameManager; // 0x88
		private CharacterController_Support _classSupport; // 0x90
		private bool _sentRevivalCommand; // 0x98
		private Player _player; // 0xA0
		protected CoherenceSync _coherenceSync; // 0xA8
		private Unity.Mathematics.Random? _randomEnemyPickerRng; // 0xB0
		private Transform _cachedTransform; // 0xB8
		private CharacterWeaponsManager _weaponsManager; // 0xC0
		private CharacterAccessoriesManager _accessoriesManager; // 0xC8
		protected SpriteAnimation _spriteAnimation; // 0xD0
		protected ParticleSystem _damageVfx; // 0xD8
		private SpriteTrail _spriteTrail; // 0xE0
		private HealthBar _healthBar; // 0xE8
		private CharacterLightManager _characterLightManager; // 0xF0
		protected CharAnimationType _currentAnimation; // 0xF8
		private DataManager _dataManager; // 0x100
		protected JObject _currentJsonData; // 0x108
		protected CharacterData _currentCharacterData; // 0x110
		protected CharacterData _currentSkinData; // 0x118
		protected CharacterData _levelZeroCharacterData; // 0x120
		private List<WeaponType> _weaponSelection; // 0x128
		protected WeaponType _startingWeaponType; // 0x130
		protected VampireSurvivors.Data.CharacterType _characterType; // 0x134
		protected SkinType _skinType; // 0x138
		protected VampireSurvivors.Framework.TimerSystem.Timer _regenTimer; // 0x140
		protected VampireSurvivors.Framework.TimerSystem.Timer _blinkTimeoutTimer; // 0x148
		protected VampireSurvivors.Framework.TimerSystem.Timer _freezeWeaponsTimer; // 0x150
		protected bool _receivingDamage; // 0x158
		protected bool _playDamageSFX; // 0x159
		private float _invincibilityTimer; // 0x15C
		protected bool _hasWalkingAnimation; // 0x160
		protected bool _hasIdleAnimation; // 0x161
		protected MultiTargetTween _wiggleTween; // 0x168
		protected Vector2 _currentDirection; // 0x170
		private Vector2 _currentDirectionRaw; // 0x178
		private Vector2 _lastMovementDirection; // 0x180
		private bool _actionButtonPressed; // 0x188
		protected MaterialPropertyBlock _propBlock; // 0x190
		private ArcadeBodyBounds _worldBoxCollider; // 0x198
		private ArcadeBodyBounds _coopMovementBoxCollider; // 0x1A0
		private ModifierStats _onEveryLevelUp; // 0x1A8
		protected MeleeAttack _meleeAnim; // 0x1B0
		protected MeleeAttack _meleeAnim2; // 0x1B8
		protected MeleeAttack _rangedAnim; // 0x1C0
		protected MeleeAttack _magicAnim; // 0x1C8
		protected MeleeAttack _specialAnim; // 0x1D0
		protected MeleeAttack _idleAnim; // 0x1D8
		private bool _followPlayerOne; // 0x1E0
		private float _defaultSpriteWidth; // 0x1E4
		protected SpriteRenderer _customDamageOverlayRenderer; // 0x1E8
		private bool _useWorldSpaceMovementLimits; // 0x1F0
		private WorldSpaceLimits _worldSpaceMovementLimits; // 0x1F4
		protected PlayerModifierStats _playerStats; // 0x218
		private float _slowMultiplier; // 0x220
		private bool _isSlow; // 0x224
		private float _currentHp; // 0x228
		private int _level; // 0x22C
		private float _walked; // 0x230
		private Vector2 _lastFacingDirection; // 0x234
		private float _xp; // 0x23C
		private bool _isAnimForced; // 0x240
		private bool _canFlip; // 0x241
		private bool _isFlipped; // 0x242
		private float _shieldInvulTime; // 0x244
		private MagnetZone _magnet; // 0x248
		private SineBonus _sineSpeed; // 0x250
		private SineBonus _sineCooldown; // 0x258
		private SineBonus _sineArea; // 0x260
		private SineBonus _sineDuration; // 0x268
		private SineBonus _sineMight; // 0x270
		private float _slowTime; // 0x278
		private float _gFeverMul; // 0x27C
		private Action<float, float> _onHpRecoveryCallback; // 0x280
		private bool _isInFinalStage; // 0x288
		private bool _isDead; // 0x289
		protected bool _isInvul; // 0x28A
		protected bool _isSendingDeath; // 0x28B
		protected bool _isInitialized; // 0x28C
		private bool _isLastBreathEnabled; // 0x28D
		private bool _hasLastBreath; // 0x28E
		private Action _onLastBreath; // 0x290
		private bool _isCriticalHPEnabled; // 0x298
		private bool _hasAnyCriticalHPSkill; // 0x299
		private Action _onCriticalHP; // 0x2A0
		private float _criticalHPTreshold; // 0x2A8
		private bool _hasThorns; // 0x2AC
		private int _maxWeaponCount; // 0x2B0
		private int _maxAccessoryCount; // 0x2B4
		private int _maxWeaponBonus; // 0x2B8
		private int _maxAccessoryBonus; // 0x2BC
		private MultiplayerRevivalUI _multiplayerRevivalUI; // 0x2C0
		private SpriteRenderer _multiplayerIndicator; // 0x2C8
		private SpriteOutlinerControl _multiplayerOutliner; // 0x2D0
		private SpriteRenderer _outlineReferenceRenderer; // 0x2D8
		private bool _usingCustomRendererForOutline; // 0x2E0
		protected float _multiplayerRevivalProportion; // 0x2E4
		private int _revivalJuiceThisFrame; // 0x2E8
		private VampireSurvivors.Framework.TimerSystem.Timer _multiplayerChompTimer; // 0x2F0
		private VampireSurvivors.Framework.TimerSystem.Timer _multiplayerIndicatorTimer; // 0x2F8
		private float _debuffSlow; // 0x300
		private VampireSurvivors.Framework.TimerSystem.Timer _multiplayerDecompositionTimer; // 0x308
		private Transform _multiplayerCameraTargetTransform; // 0x310
		private VampireSurvivors.Framework.TimerSystem.Timer _deathConsequenceTimer; // 0x318
		private VampireSurvivors.Framework.TimerSystem.Timer _multiplayerReviveShake1; // 0x320
		private VampireSurvivors.Framework.TimerSystem.Timer _multiplayerReviveShake2; // 0x328
		private bool _multiplayerRevivalAllowed; // 0x330
		private PetManager _petManager; // 0x338
		protected CharacterADControl _deficiencyControl; // 0x340
		private PickupMode _pickupMode; // 0x348
		private bool _permanentInvulnerability; // 0x34C
		private bool _blockInput; // 0x34D
		public float MoveSpeedMultiplier; // 0x350
		public float ArmorManualIncrease; // 0x354
		public List<WeaponType> GlimmeredTechniques; // 0x358
		public float SvMult_AnyRare; // 0x360
		public float SvMult_Foil; // 0x364
		public float SvMult_Gala; // 0x368
		public float SvMult_Poly; // 0x36C
		public float SvMult_Holo; // 0x370
		public float SvMult_Inve; // 0x374
		public float SvMult_Base; // 0x378
		public CharacterSkillCardsManager CharacterSkillCardsManager; // 0x380
		public float TempCurse; // 0x38C
		[Sync]
		public bool IsFollowerSharingPassives; // 0x397
		[Sync]
		public bool IsFollowerReactingToArcanas; // 0x398
		[NonSerialized]
		public float RapidFire_Life; // 0x3B4
		[NonSerialized]
		public float Barrier_Number; // 0x3B8
		private PhaserSprite BarrierSprite; // 0x3C0
		public bool HasFourthLevelUpOption; // 0x3C8
		public List<Weapon> HeldShieldSlots; // 0x3D0
		public SfxType DamageSound; // 0x3D8
		public float DamageVolume; // 0x3DC
		public float DamageBaseDetune; // 0x3E0
		private bool _hasForcedSortingOrder; // 0x3E4
		private int _forcedSortingOrder; // 0x3E8
	
		// Properties
		[Sync]
		public int SyncedCharacterType { get => default; set {} } // 0x00000001857F9420-0x00000001857F9430 0x00000001867532B0-0x00000001867532C0
		[Sync]
		public int SyncedSkinType { get => default; set {} } // 0x0000000182944690-0x00000001829446A0 0x0000000186560990-0x00000001865609A0
		[Sync]
		public bool IsFlipped { get => default; set {} } // 0x00000001870EE260-0x00000001870EE270 0x00000001870EE270-0x00000001870EE280
		[Sync]
		public float CurrentHp { get => default; set {} } // 0x00000001870EE280-0x00000001870EE290 0x00000001870EE290-0x00000001870EE2A0
		[Sync]
		public uint RandomEnemyPickerSeed { get; set; } // 0x00000001819A0200-0x00000001819A0210 0x0000000181C2C000-0x0000000181C2C010
		[Sync(DefaultSyncMode = SyncMode.CreationOnly)]
		public bool ShowHealthBar { get => default; set {} } // 0x00000001870EE2A0-0x00000001870EE3B0 0x00000001870EE3B0-0x00000001870EE4C0
		[Sync(DefaultSyncMode = SyncMode.CreationOnly)]
		public float HealthBarScale { get => default; set {} } // 0x00000001870EE4C0-0x00000001870EE660 0x00000001870EE660-0x00000001870EE790
		public Unity.Mathematics.Random? RandomEnemyPickerGenerator { get => default; } // 0x00000001819A0190-0x00000001819A01A0 
		public bool IsDead { get => default; set {} } // 0x00000001870EE790-0x00000001870EE7B0 0x00000001870EE7B0-0x00000001870EE7C0
		[OnValueSynced("OnPermanentInvulnerabilityUpdated")]
		[Sync(DefaultSyncMode = SyncMode.CreationOnly)]
		public bool PermanentInvulnerability { get => default; set {} } // 0x00000001870EE7C0-0x00000001870EE7D0 0x00000001870EE7D0-0x00000001870EE7E0
		[Sync(DefaultSyncMode = SyncMode.CreationOnly)]
		public bool TrackedByCamera { get; set; } // 0x00000001870EE7E0-0x00000001870EE7F0 0x00000001870EE7F0-0x00000001870EE800
		public bool IsCoffinVisible { get => default; } // 0x00000001870EE800-0x00000001870EE830 
		public virtual float LootMult_Rosary { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
		public virtual float LootMult_Orologion { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
		public virtual float LootMult_Rerollo { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
		public float SkillCards_Mult { get; set; } // 0x00000001870EE830-0x00000001870EE840 0x00000001870EE840-0x00000001870EE850
		public int Level { get => default; set {} } // 0x00000001865DBF40-0x00000001865DC450 0x00000001870EE910-0x00000001870EE920
		public int MaxWeaponCount { get => default; set {} } // 0x00000001870EE920-0x00000001870EE930 0x00000001870EE930-0x00000001870EE940
		public int MaxAccessoryCount { get => default; } // 0x00000001870EE940-0x00000001870EE950 
		public int MaxWeaponBonus { get => default; set {} } // 0x00000001870EE950-0x00000001870EE960 0x00000001870EE960-0x00000001870EE970
		public int MaxAccessoryBonus { get => default; set {} } // 0x0000000186753A00-0x0000000186753A10 0x0000000186753A10-0x0000000186753A20
		public float DefaultSpriteWidth { get => default; } // 0x00000001870EE970-0x00000001870EE980 
		public PlayerModifierStats PlayerStats { get => default; } // 0x00000001865DBE50-0x00000001865DBE60 
		public CoherenceSync Sync { get => default; } // 0x00000001819716D0-0x00000001819716E0 
		public PetManager PetManager { get => default; } // 0x00000001870EE980-0x00000001870EEC30 
		public CharacterADControl DeficiencyControl { get => default; } // 0x00000001870EEC30-0x00000001870EEC40 
		public PickupMode PickupMode { get => default; set {} } // 0x0000000185EAA040-0x0000000185EAA050 0x0000000185EAA050-0x0000000185EAA060
		[Sync(DefaultSyncMode = SyncMode.CreationOnly)]
		public int SyncedPickupMode { get => default; set {} } // 0x0000000185EAA040-0x0000000185EAA050 0x0000000185EAA050-0x0000000185EAA060
		[Sync(DefaultSyncMode = SyncMode.CreationOnly)]
		public uint FollowerLevelUpShuffleSeed { get; set; } // 0x00000001870EEC40-0x00000001870EEC50 0x00000001870EEC50-0x00000001870EEC60
		public bool AlwaysCoinBag { get; set; } // 0x00000001870EEC60-0x00000001870EEC70 0x00000001870EEC70-0x00000001870EEC80
		public bool AlwaysRoast { get; set; } // 0x00000001870EEC80-0x00000001870EEC90 0x00000001870EEC90-0x00000001870EECA0
		public bool AlwaysRandomLimitBreak { get; set; } // 0x00000001870EECA0-0x00000001870EECB0 0x00000001870EECB0-0x00000001870EECC0
		public ModifierStats OnEveryLevelUp { get => default; } // 0x0000000185FA2680-0x0000000185FA2690 
		public Transform CachedTransform { get => default; } // 0x00000001819A01A0-0x00000001819A01B0 
		private Vector2 CurrentPos { get => default; } // 0x00000001870EECC0-0x00000001870EED90 
		public Vector2 Velocity { get => default; } // 0x00000001870EED90-0x00000001870EEE70 
		public Vector2 ScaledVelocity { get => default; } // 0x00000001870EEE70-0x00000001870EEF40 
		public float2 ExternalVelocity { get; set; } // 0x00000001870EEF40-0x00000001870EEF60 0x00000001870EEF60-0x00000001870EEF70
		public float FrameWalk { get => default; } // 0x00000001870EEF70-0x00000001870EF010 
		public float Walked { get => default; set {} } // 0x00000001870EF010-0x00000001870EF020 0x00000001870EF020-0x00000001870EF030
		public bool IsDisconnectedFromOnlinePlay { get => default; } // 0x00000001870EF030-0x00000001870EF0E0 
		private float Speed { get => default; } // 0x00000001870EF0E0-0x00000001870EF180 
		public Vector2 LastFacingDirection { get => default; private set {} } // 0x00000001870EF180-0x00000001870EF1A0 0x00000001870EF1A0-0x00000001870EF1B0
		public bool ActionButtonPressed { get => default; } // 0x00000001827669D0-0x00000001827669E0 
		public Vector2 CurrentDirection { get => default; set {} } // 0x00000001870EF1B0-0x00000001870EF1D0 0x00000001870EF1D0-0x00000001870EF1E0
		[OnValueSynced("OnMovDirectionUpdated")]
		[Sync]
		public Vector2 CurrentDirectionRaw { get => default; set {} } // 0x00000001870EF1E0-0x00000001870EF200 0x00000001870EF200-0x00000001870EF210
		public Vector2 LastMovementDirection { get => default; } // 0x0000000186FB0D80-0x0000000186FB0DA0 
		public SpriteTrail rtGhosts { get => default; } // 0x000000018282D820-0x000000018282D830 
		[OnValueSynced("OnXpUpdated")]
		[Sync]
		public float Xp { get => default; set {} } // 0x00000001870EF210-0x00000001870EF220 0x00000001870EF220-0x00000001870EF230
		public bool IsAnimForced { get => default; set {} } // 0x00000001870EF230-0x00000001870EF240 0x00000001870EF240-0x00000001870EF250
		public bool CanFlip { get => default; set {} } // 0x00000001870EF250-0x00000001870EF260 0x00000001870EF260-0x00000001870EF270
		public Player PlayerInput { get => default; } // 0x00000001819A0250-0x00000001819A0260 
		public List<WeaponType> weaponSelection { get => default; set {} } // 0x0000000182937BD0-0x0000000182937BE0 0x0000000182A45B30-0x0000000182A45B90
		public WeaponType StartingWeaponType { get => default; } // 0x0000000184756700-0x0000000184756710 
		public CharacterWeaponsManager WeaponsManager { get => default; } // 0x00000001819A0460-0x00000001819A0470 
		public CharacterAccessoriesManager AccessoriesManager { get => default; } // 0x00000001827666D0-0x00000001827666E0 
		public CharacterData CurrentCharacterData { get => default; } // 0x0000000182A45AF0-0x0000000182A45B00 
		public CharacterData CurrentSkinData { get => default; } // 0x00000001829475E0-0x00000001829475F0 
		public VampireSurvivors.Data.CharacterType CharacterType { get => default; } // 0x00000001857F9420-0x00000001857F9430 
		public float MultiplayerRevivalProportion { get => default; } // 0x00000001870EF280-0x00000001870EF290 
		public bool MultiplayerRevivalAllowed { get => default; } // 0x0000000185FB6E40-0x0000000185FB6E50 
		[Sync(DefaultSyncMode = SyncMode.CreationOnly)]
		public bool CountsAsMainCharacterForRevivals { get; set; } // 0x00000001870EF290-0x00000001870EF2A0 0x00000001870EF2A0-0x00000001870EF2B0
		public Transform CameraTarget { get => default; } // 0x00000001870EF2B0-0x00000001870EF5B0 
		public bool IsLastBreathEnabled { get => default; set {} } // 0x00000001867538A0-0x00000001867538B0 0x00000001867538B0-0x00000001867538C0
		public bool HasLastBreath { get => default; set {} } // 0x00000001867538C0-0x00000001867538D0 0x00000001867538D0-0x00000001867538E0
		public Action OnLastBreath { get => default; set {} } // 0x00000001870EF5B0-0x00000001870EF5C0 0x00000001870EF5C0-0x00000001870EF620
		public bool HasAnyCriticalHPSkill { get => default; set {} } // 0x00000001870EF620-0x00000001870EF630 0x00000001870EF630-0x00000001870EF640
		public bool IsCriticalHPEnabled { get => default; set {} } // 0x00000001870EF640-0x00000001870EF650 0x00000001870EF650-0x00000001870EF660
		public Action OnCriticalHP { get => default; set {} } // 0x0000000185EAA030-0x0000000185EAA040 0x0000000186AB2660-0x0000000186AB26C0
		public float ShieldInvulTime { get => default; set {} } // 0x00000001870EF660-0x00000001870EF670 0x00000001870EF670-0x00000001870EF680
		public float CurrentInvincibilityTimer { get => default; } // 0x0000000182917660-0x0000000182917670 
		public virtual bool HasThorns { get => default; set {} } // 0x00000001870EF680-0x00000001870EF690 0x00000001870EF690-0x00000001870EF6A0
		public MagnetZone Magnet { get => default; set {} } // 0x00000001870EF730-0x00000001870EF740 0x00000001870EF740-0x00000001870EF7A0
		public SineBonus SineSpeed { get => default; set {} } // 0x00000001867535F0-0x0000000186753600 0x0000000186753600-0x0000000186753660
		public SineBonus SineCooldown { get => default; set {} } // 0x00000001840DCD50-0x00000001840DCD60 0x00000001840DCD60-0x00000001840DCDC0
		public SineBonus SineArea { get => default; set {} } // 0x00000001840BCE80-0x00000001840BCE90 0x00000001840BCE90-0x00000001840BCEF0
		public SineBonus SineDuration { get => default; set {} } // 0x00000001840BCEF0-0x00000001840BCF00 0x00000001840BCF00-0x00000001840BCF60
		public SineBonus SineMight { get => default; set {} } // 0x0000000186A130F0-0x0000000186A13100 0x0000000186A13100-0x0000000186A13160
		public float SlowTime { get => default; set {} } // 0x00000001870EF7A0-0x00000001870EF7B0 0x00000001870EF7B0-0x00000001870EF7C0
		public float gFeverMul { get => default; set {} } // 0x00000001870EF7C0-0x00000001870EF7D0 0x00000001870EF7D0-0x00000001870EF7E0
		public float SilentCooldown { get; set; } // 0x00000001870EF7E0-0x00000001870EF7F0 0x00000001870EF7F0-0x00000001870EF800
		public float SilentMight { get; set; } // 0x00000001870EF800-0x00000001870EF810 0x00000001870EF810-0x00000001870EF820
		public SpriteAnimation SpriteAnimation { get => default; } // 0x000000018291BA90-0x000000018291BAA0 
		public SpriteAnimation Anims { get => default; } // 0x000000018291BA90-0x000000018291BAA0 
		public PlayerOptions PlayerOptions { get => default; } // 0x00000001819A0370-0x00000001819A0380 
		public Action<float, float> OnHpRecoveryCallback { get => default; set {} } // 0x00000001869A0820-0x00000001869A0830 0x00000001870EF820-0x00000001870EF880
		public ArcadeBodyBounds WorldBoxCollider { get => default; } // 0x0000000186747020-0x0000000186747030 
		public int Depth { get => default; } // 0x00000001870EF880-0x00000001870EF920 
		public HealthBar HealthBar { get => default; } // 0x0000000182766DD0-0x0000000182766DE0 
		public bool IsInFinalStage { get => default; set {} } // 0x0000000185FA3660-0x0000000185FA3670 0x00000001870EF920-0x00000001870EF930
		public bool IsPlatformMovementActive { get; set; } // 0x0000000185FB7830-0x0000000185FB7840 0x00000001870EF930-0x00000001870EF940
		public ParticleSystem DamageBloodVfx { get => default; } // 0x0000000182A45A70-0x0000000182A45A80 
		public virtual bool DrainWeaponsImmunity { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		public virtual int GlimmerComboModifier { get => default; } // 0x0000000180B15D70-0x0000000180B15D80 
		public virtual bool NeedsCart { get => default; } // 0x0000000181958370-0x0000000181958380 
		public bool IsInvul { get => default; set {} } // 0x00000001870EFC60-0x00000001870EFC70 0x00000001870EFC70-0x00000001870EFF00
		public float NormalizedHp { get => default; } // 0x00000001870EFF00-0x00000001870EFF70 
		[Sync(DefaultSyncMode = SyncMode.CreationOnly)]
		public bool IsFollower { get => default; set {} } // 0x00000001870EFF70-0x00000001870EFF80 0x00000001870EFF80-0x00000001870EFF90
		[Sync(DefaultSyncMode = SyncMode.CreationOnly)]
		public CoherenceSync FollowedCharacter { get => default; set {} } // 0x00000001870EFF90-0x00000001870F00A0 0x00000001870F00A0-0x00000001870F0230
		[Sync(DefaultSyncMode = SyncMode.CreationOnly)]
		public int FollowerLevelUpType { get => default; set {} } // 0x00000001870F0230-0x00000001870F0250 0x00000001870F0250-0x00000001870F02A0
		public bool IsMainCharacterFollower { get => default; } // 0x00000001870F02A0-0x00000001870F02D0 
		public bool IsMinorFollower { get => default; } // 0x00000001870F02D0-0x00000001870F0300 
		public bool SkipsArcanaEffects { get => default; } // 0x00000001870F02D0-0x00000001870F0300 
		public virtual bool RespectAnimationXPivots { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		public float DebuffSlowAmount { get => default; set {} } // 0x0000000185FB6920-0x0000000185FB6930 0x00000001870F0300-0x00000001870F0310
		public virtual float BloodlineDamage { get => default; } // 0x00000001870F7720-0x00000001870F77B0 
		public virtual float BloodlineArmorValue { get => default; } // 0x00000001870F77B0-0x00000001870F7840 
		public virtual float2 GetVectorWhipOffset { get => default; } // 0x00000001870FACD0-0x00000001870FAD90 
		public virtual float GetSpriteWhipOffset { get => default; } // 0x00000001870FAD90-0x00000001870FAE70 
	
		// Nested types
		private struct EdgeDistances // TypeDefIndex: 16916
		{
			// Fields
			public float xToRightUnbound; // 0x00
			public float xToLeftUnbound; // 0x04
			public float yToTopUnbound; // 0x08
			public float yToBottomUnbound; // 0x0C
		}
	
		private struct WorldSpaceLimits // TypeDefIndex: 16917
		{
			// Fields
			public float? Left; // 0x00
			public float? Right; // 0x08
			public float? Top; // 0x10
			public float? Bottom; // 0x18
		}
	
		// Constructors
		public CharacterController() {} // 0x00000001871050B0-0x00000001871055C0
	
		// Methods
		public void AddSkillCard(CharacterSkillCard_Base card) {} // 0x00000001870EE850-0x00000001870EE910
		public virtual void OnSkillCardAdded(CharacterSkillCard_Base card) {} // 0x0000000180B15170-0x0000000180B15180
		public void SetStartingWeaponFromWeaponSelector(WeaponType weaponType) {} // 0x00000001870EF270-0x00000001870EF280
		public virtual float GetThornDamage(EnemyController enemy) => default; // 0x00000001870EF6A0-0x00000001870EF730
		public virtual WeaponType GetFourthLevelUpOption() => default; // 0x0000000180B15D70-0x0000000180B15D80
		public bool HasSeraphicCry(out SantaJavelin2Weapon seraphicCry) {
			seraphicCry = default;
			return default;
		} // 0x00000001870EF940-0x00000001870EFC40
		public bool IsInvulnerabilityWindowActive() => default; // 0x00000001870EFC40-0x00000001870EFC60
		[Inject]
		private void Construct(SignalBus signalBus, DataManager dataManager, PlayerOptions playerOptions, GameManager gameManager) {} // 0x00000001870F0310-0x00000001870F0480
		private new void Awake() {} // 0x00000001870F0480-0x00000001870F0FC0
		private bool ShouldStopAtScreenEdge() => default; // 0x00000001870F0FC0-0x00000001870F1290
		protected override void OnUpdate() {} // 0x00000001870F1290-0x00000001870F1B80
		public void UpdateBoxCollider() {} // 0x00000001870F1B80-0x00000001870F1E50
		private EdgeDistances GetDistancesToScreenEdges() => default; // 0x00000001870F1E50-0x00000001870F20E0
		public void SetWorldSpaceMovementLimitsActive(bool limitsActive) {} // 0x00000001870F20E0-0x00000001870F20F0
		public void SetWorldSpaceMovementLimits(float? left, float? right, float? top, float? bottom) {} // 0x00000001870F20F0-0x00000001870F2120
		public void ClearWorldSpaceMovementLimits() {} // 0x00000001870F2120-0x00000001870F2140
		private void LimitMovementInsideWorldSpaceLimits(ref Vector2 movement) {} // 0x00000001870F2140-0x00000001870F23A0
		private void DoOnlineOrLocalRevival(bool instantRevival) {} // 0x00000001870F23A0-0x00000001870F2530
		[Command]
		public void TriggerOnlineRevival(long startingSimFrame, bool instantRevival) {} // 0x00000001870F2530-0x00000001870F2780
		private void DoMultiplayerRevival(bool instantRevival) {} // 0x00000001870F2780-0x00000001870F2C80
		public virtual void DoPostRevivalActions(CharacterController revived, bool instantRevival = false /* Metadata: 0x01977EEB */) {} // 0x0000000180B15170-0x0000000180B15180
		private void TurnIntoMultiplayerGhost() {} // 0x00000001870F2C80-0x00000001870F2E00
		public void ForceHideOutline() {} // 0x00000001870F2E00-0x00000001870F2E40
		private void EnsureOnScreen() {} // 0x00000001870F2E40-0x00000001870F3020
		public void HandleLateUpdate() {} // 0x00000001870F3020-0x00000001870F35D0
		private Vector3 ContainCharacterInHardBounds(Vector3 pos) => default; // 0x00000001870F35D0-0x00000001870F3790
		public bool IsWithinBounds(ArcadeBodyBounds bounds) => default; // 0x00000001870F3790-0x00000001870F3800
		public void RefreshMultiplayerOutline() {} // 0x00000001870F3800-0x00000001870F3890
		protected override void OnDisable() {} // 0x00000001870F3890-0x00000001870F3A80
		public void InitCharacter(VampireSurvivors.Data.CharacterType characterType, int playerIndex, bool asRemote, bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977EEC */) {} // 0x00000001870F3A80-0x00000001870F48F0
		[IteratorStateMachine(typeof(_AddCursor_d__447))]
		private IEnumerator AddCursor() => default; // 0x00000001870F48F0-0x00000001870F4990
		public void UpdateMaxWeaponCount() {} // 0x00000001870F4990-0x00000001870F4A30
		public virtual void AfterFullInitialization() {} // 0x00000001870F4A30-0x00000001870F4B80
		public virtual void OnWeaponMadeLevelOne(WeaponType type) {} // 0x0000000180B15170-0x0000000180B15180
		public virtual void OnQuit() {} // 0x00000001870F4B80-0x00000001870F4C10
		public virtual void OnGlimmeredTechniqueFired() {} // 0x0000000180B15170-0x0000000180B15180
		public virtual void OnGlimmeredTechniqueLearned(WeaponType glimmerType) {} // 0x00000001870F4C10-0x00000001870F4CC0
		public void ForceSetPosition(Vector2 newPosition) {} // 0x0000000186D54370-0x0000000186D54390
		public float GetMultipliedHPRecoveryValue(float value) => default; // 0x00000001870F4CC0-0x00000001870F4DC0
		public virtual void RecoverHp(float value, bool showRecovery = false /* Metadata: 0x01977EED */, bool mulByRegen = false /* Metadata: 0x01977EEE */) {} // 0x00000001870F4DC0-0x00000001870F51A0
		public virtual void SetBloodColor(uint colorValue) {} // 0x00000001870F51A0-0x00000001870F52C0
		protected virtual void _hpFullyRecovered(float recovered) {} // 0x00000001870F52C0-0x00000001870F52D0
		public void EnableDestroyDestructiblesOnTouch() {} // 0x00000001870F52D0-0x00000001870F5420
		public virtual void LevelUp() {} // 0x00000001870F5420-0x00000001870F5720
		public virtual void OnLevelUpFollowers() {} // 0x00000001870F5720-0x00000001870F5A70
		public virtual void OnLevelUpCompleted() {} // 0x00000001870F5A70-0x00000001870F5A90
		public virtual void OnLevelUpSkipped() {} // 0x00000001870F5A90-0x00000001870F5B60
		public virtual void Revive(float percentage = 1f /* Metadata: 0x01977EEF */, bool instantRevival = false /* Metadata: 0x01977EF3 */) {} // 0x00000001870F5B60-0x00000001870F5E50
		[Command]
		public void OnlineRevival(long startingSimFrame, float percentage) {} // 0x00000001870F5E50-0x00000001870F5FB0
		private void PerformRevival(float percentage) {} // 0x00000001870F5FB0-0x00000001870F69C0
		private void CancelDeathConsequencesTimer() {} // 0x00000001870F69C0-0x00000001870F69E0
		public void AddXp(float value, XPMultiplierMode multiplierMode = XPMultiplierMode.Normal /* Metadata: 0x01977EF4 */) {} // 0x00000001870F69E0-0x00000001870F6AF0
		public void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01977EF5 */, float damageKnockBack = 1f /* Metadata: 0x01977EF6 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01977EFA */, bool hasKb = true /* Metadata: 0x01977EFB */) {} // 0x00000001870F6AF0-0x00000001870F6B10
		public void OnGetDamaged(HitVfxType hitVfxType, bool hasKb = true /* Metadata: 0x01977EFC */) {} // 0x00000001870F6B10-0x00000001870F6B70
		public bool IsUnitDead() => default; // 0x00000001870EE790-0x00000001870EE7B0
		public float CurrentHealth() => default; // 0x00000001870EE280-0x00000001870EE290
		public GameObject GetGameObject() => default; // 0x0000000182774DD0-0x0000000182774DE0
		public void SetMaxHistory(int max) {} // 0x00000001870F6B70-0x00000001870F6BC0
		public void DisableMultiplayerRevival() {} // 0x00000001870F6BC0-0x00000001870F6C20
		public bool WouldWeaponSynergise(WeaponType type) => default; // 0x00000001870F6C20-0x00000001870F7210
		public void GiveMaxedWeaponToPlayer(WeaponType weaponType, int minusMaxLevel = 0 /* Metadata: 0x01977EFD */) {} // 0x00000001870F7210-0x00000001870F7340
		public void InitCharacterSpotlight() {} // 0x00000001870F7340-0x00000001870F7480
		public float2 ApplyRacingOffset(CharacterVehicleType characterVehicleType) => default; // 0x00000001870F7480-0x00000001870F76B0
		public virtual float PInvulTime() => default; // 0x00000001870F76B0-0x00000001870F76E0
		public virtual float PShieldTime() => default; // 0x00000001870F76E0-0x00000001870F7720
		public virtual float PArmor() => default; // 0x00000001870F7840-0x00000001870F78C0
		public virtual float PCurse() => default; // 0x00000001870F78C0-0x00000001870F7A20
		public virtual float PGrowth() => default; // 0x00000001870F7A20-0x00000001870F7B80
		public virtual float PLuck() => default; // 0x00000001870F7B80-0x00000001870F7CE0
		public virtual float PGreed() => default; // 0x00000001870F7CE0-0x00000001870F7E40
		public virtual float PSpeed() => default; // 0x00000001870F7E40-0x00000001870F7EB0
		public virtual float PDuration() => default; // 0x00000001870F7EB0-0x00000001870F7F20
		public virtual float PAreaFinal(float preClampMultiplier = 1f /* Metadata: 0x01977EFE */) => default; // 0x00000001870F7F20-0x00000001870F7FC0
		public virtual float PArea() => default; // 0x00000001870F7FC0-0x00000001870F8030
		public virtual float PRegen() => default; // 0x00000001870F8030-0x00000001870F80A0
		public virtual float MaxHp() => default; // 0x00000001870F80A0-0x00000001870F8110
		public virtual float PMoveSpeed() => default; // 0x00000001870F8110-0x00000001870F8220
		public virtual float PCooldownFinal(float cap = 0.1f /* Metadata: 0x01977F02 */) => default; // 0x00000001870F8220-0x00000001870F82D0
		public virtual float PCooldown() => default; // 0x00000001870F82D0-0x00000001870F8340
		public virtual float PAmount() => default; // 0x00000001870F8340-0x00000001870F83B0
		public virtual EggDouble PRevivals() => default; // 0x00000001870F83B0-0x00000001870F83E0
		public float PPowerFinal() => default; // 0x00000001870F83E0-0x00000001870F8470
		public float PPowerWithoutSilentMight() => default; // 0x00000001870F8470-0x00000001870F84E0
		public virtual float PPower() => default; // 0x00000001870F84E0-0x00000001870F8550
		public void AddTemporaryBonus(Action start, Action end, float duration) {} // 0x00000001870F8550-0x00000001870F85C0
		[Command]
		public void ReportBody(long startingSimFrame, CoherenceSync player) {} // 0x00000001870F85C0-0x00000001870F8770
		public void PerformReportBody(CharacterController player) {} // 0x00000001870F8770-0x00000001870F88D0
		[Command]
		public void FireSireWeapon(bool skipTriggers) {} // 0x00000001870F88D0-0x00000001870F8A30
		[Command]
		public void FirePentagramWeapon(bool eraseItems, bool skipTriggers) {} // 0x00000001870F8A30-0x00000001870F8BA0
		[Command]
		public void FireBattiliaWeapon() {} // 0x00000001870F8BA0-0x00000001870F8CF0
		[Command]
		public void FireVenusCrescentWeapon(bool skipTriggers) {} // 0x0000000180B15170-0x0000000180B15180
		[Command]
		public void EmergencyMeeting(long startingSimFrame, byte[] serializedEnemyTypes, int voteTarget) {} // 0x00000001870F8CF0-0x00000001870F8FF0
		public void SendApplyWeaponLevelUp(WeaponType weapon) {} // 0x00000001870F8FF0-0x00000001870F9140
		[Command]
		public void OnlineApplyWeaponLevelUp(long startingSimFrame, int weaponType) {} // 0x00000001870F9140-0x00000001870F92A0
		public void SendAddAttribute(WeaponType weaponType, float value) {} // 0x00000001870F92A0-0x00000001870F9450
		[Command]
		public void AddAttributeOnline(long startingSimFrame, int weaponType, float value) {} // 0x00000001870F9450-0x00000001870F95C0
		public void AddAttribute(WeaponType weaponType, float value) {} // 0x00000001870F95C0-0x00000001870F9AB0
		private void ApplyWeaponLevelUp(WeaponType weapon) {} // 0x00000001870F9AB0-0x00000001870F9D00
		public void QueueWeaponSelectionSelector(WeaponType weapon, string selectionType) {} // 0x00000001870F9D00-0x00000001870F9EA0
		[Command]
		public void QueueWeaponSelectionOnline(long startingSimFrame, int weaponType, string selectionType) {} // 0x00000001870F9EA0-0x00000001870FA060
		[IteratorStateMachine(typeof(_QueueWeaponSelectionInternal_d__521))]
		private IEnumerator QueueWeaponSelectionInternal(WeaponType type, string selectionType) => default; // 0x00000001870FA060-0x00000001870FA170
		public void SendSetGlimmerNextFireForWeapon(WeaponType weapon) {} // 0x00000001870FA170-0x00000001870FA280
		[Command]
		public void SetGlimmerNextFireForWeapon(long frame, int weaponType) {} // 0x00000001870FA280-0x00000001870FA530
		protected void Pushback(GameObject value, float duration) {} // 0x0000000180B15170-0x0000000180B15180
		public void SetHealth(float health) {} // 0x00000001870FA530-0x00000001870FA590
		public void Kill() {} // 0x00000001870FA590-0x00000001870FA5A0
		public void Resurrect() {} // 0x00000001870FA5A0-0x00000001870FA5B0
		public void Die() {} // 0x00000001870FA5B0-0x00000001870FA6D0
		public void DisableIfFollower() {} // 0x00000001870FA6D0-0x00000001870FA7A0
		public void EnableIfFollower() {} // 0x00000001870FA7A0-0x00000001870FA820
		public void Debug_ToggleInvulnerability() {} // 0x00000001870FA820-0x00000001870FA920
		public void FreezePlayer(bool freeze) {} // 0x00000001870FA920-0x00000001870FAAD0
		public void SetPermanentInvulnerability(bool on) {} // 0x00000001870FAAD0-0x00000001870FABE0
		protected void OnPermanentInvulnerabilityUpdated(bool old, bool newValue) {} // 0x00000001870FABE0-0x00000001870FABF0
		public void SetInvulForMilliSeconds(float duration) {} // 0x00000001870FABF0-0x00000001870FAC30
		public void SetInvulForMilliSecondsNonCumulative(float duration) {} // 0x00000001870FAC30-0x00000001870FAC70
		public void SetInvulForMilliSecondsNonCumulativeIncludeParma(float duration) {} // 0x00000001870FAC70-0x00000001870FACD0
		public bool TryGettingChomped() => default; // 0x00000001870FAE70-0x00000001870FB090
		public void RemoveInvul() {} // 0x00000001870FB090-0x00000001870FB0A0
		public void TriggerGetDamagedByOwnWeapon(float damageAmount) {} // 0x00000001870FB0A0-0x00000001870FB200
		[Command]
		public virtual void GetDamagedByOwnWeapon(float damageAmount) {} // 0x00000001870FB200-0x00000001870FB610
		public virtual bool GetDamaged(float damageAmount) => default; // 0x00000001870FB610-0x00000001870FBB80
		private void TakeDamage(float damageAmount) {} // 0x00000001870FBB80-0x00000001870FC180
		[Command]
		public void OnHpReachedZeroOnline() {} // 0x00000001870FC180-0x00000001870FC1A0
		private void OnHpReachedZero(float damageAmount = 0f /* Metadata: 0x01977F06 */) {} // 0x00000001870FC1A0-0x00000001870FC370
		public virtual void OnGetDamaged(string hexColor = "#ff0000" /* Metadata: 0x01977F0A */, float vulnerabilityDelay = 120f /* Metadata: 0x01977F12 */, bool playDamageFx = true /* Metadata: 0x01977F16 */, bool playWeaponDamageFx = false /* Metadata: 0x01977F17 */) {} // 0x00000001870FC370-0x00000001870FC3A0
		public void OnGetDamaged(string hexColor, float vulnerabilityDelay, bool playDamageFx, bool playWeaponDamageFx, bool ignoreInvulnerabilityForRestoringTint) {} // 0x00000001870FC3A0-0x00000001870FCA30
		public virtual void RestoreTint() {} // 0x00000001870FCA30-0x00000001870FCCE0
		public void ActivateSineSpeedBonus(SineBonusData data) {} // 0x00000001870FCCE0-0x00000001870FCDA0
		public void ActivateSineDurationBonus(SineBonusData data) {} // 0x00000001870FCDA0-0x00000001870FCE60
		public void ActivateSineMightBonus(SineBonusData data) {} // 0x00000001870FCE60-0x00000001870FCF20
		public void ActivateSineAreaBonus(SineBonusData data) {} // 0x00000001870FCF20-0x00000001870FCFE0
		public void ActivateSineCooldownBonus(SineBonusData data) {} // 0x00000001870FCFE0-0x00000001870FD0A0
		public virtual void GetTreasureModifier() {} // 0x0000000180B15170-0x0000000180B15180
		protected void OnXpUpdated(float oldXp, float newXp) {} // 0x00000001870FD0A0-0x00000001870FD180
		protected void OnMovDirectionUpdated(Vector2 oldLastMovDir, Vector2 newLastMovDir) {} // 0x00000001870FD180-0x00000001870FD190
		private void SetupInput() {} // 0x00000001870FD190-0x00000001870FD2B0
		protected virtual void OnStop() {} // 0x00000001870FD2B0-0x00000001870FD360
		public virtual void OnWeaponFired(Weapon weapon) {} // 0x00000001870FD360-0x00000001870FD420
		private void SetupDamageVfx() {} // 0x00000001870FD420-0x00000001870FDEC0
		private void HandlePlayerInput() {} // 0x00000001870FDEC0-0x00000001870FE070
		private void ProcessRawDirection() {} // 0x00000001870FE070-0x00000001870FE190
		protected virtual Vector2 ProcessMovementVector(Vector2 v) => default; // 0x00000001826F2060-0x00000001826F2070
		private void Regenerate() {} // 0x00000001870FE190-0x00000001870FE200
		private void SetDamageFxColor() {} // 0x00000001870FE200-0x00000001870FE300
		private void InitDeathNoHurtRenderer() {} // 0x00000001870FE300-0x00000001870FE4E0
		protected virtual bool OnCharacterOverlapsDestructible_Destroy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870FE4E0-0x00000001870FE660
		protected virtual void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977F18 */) {} // 0x00000001870FE660-0x00000001870FF060
		public void UpdateMagnet() {} // 0x00000001870FF060-0x00000001870FF090
		protected virtual void AddAttackAnimations() {} // 0x00000001870FF090-0x00000001870FFBB0
		private void OnMeleeAComplete() {} // 0x00000001870FFBB0-0x00000001870FFC60
		public virtual void OnMeleeAttackAnim() {} // 0x00000001870FFC60-0x00000001870FFCF0
		protected void OnRangedAComplete() {} // 0x00000001870FFCF0-0x00000001870FFD90
		public virtual void OnRangedAttackAnim() {} // 0x00000001870FFD90-0x00000001870FFE20
		private void OnMagicAComplete() {} // 0x00000001870FFE20-0x00000001870FFEC0
		public virtual void OnMagicAttackAnim() {} // 0x00000001870FFEC0-0x00000001870FFF50
		public virtual void ClearFromSpecialAnims() {} // 0x0000000180B15170-0x0000000180B15180
		public virtual void OnAttackAnim(Weapon.FiringAnimation firingAnimation) {} // 0x0000000180B15170-0x0000000180B15180
		private void GetCharacterDataForCurrentLevel(int level) {} // 0x00000001870FFF50-0x0000000187100360
		public void ShowMultiplayerIndicator() {} // 0x0000000187100360-0x0000000187100910
		protected void SetCustomOutlineReferenceRenderer(SpriteRenderer referenceRenderer) {} // 0x0000000187100910-0x0000000187100A50
		protected void SetOutlineOffsetNegative() {} // 0x0000000187100A50-0x0000000187100A70
		protected virtual void SetCharacterSprite() {} // 0x0000000187100A70-0x0000000187100B30
		private void SetSpriteForSkin(CharacterData skinData) {} // 0x0000000187100B30-0x0000000187100F50
		private CharacterData SetSkin(SkinType skinType, CharacterData skinData) => default; // 0x0000000187100F50-0x0000000187101250
		protected virtual void SetupAnimation() {} // 0x0000000187101250-0x00000001871014C0
		public Color GetCoopColour() => default; // 0x00000001871014C0-0x0000000187101650
		protected virtual void InternalUpdate() {} // 0x0000000187101650-0x0000000187101A10
		public void SetSortgingOrder(bool value, int order = 0 /* Metadata: 0x01977F19 */) {} // 0x0000000187101A10-0x0000000187101A20
		public virtual void PlayWalkingAnimations() {} // 0x0000000187101A20-0x0000000187101BB0
		private void SetHealthToMax() {} // 0x0000000187101BB0-0x0000000187101BE0
		public virtual void OnDeath() {} // 0x0000000187101BE0-0x0000000187102800
		protected virtual void ScheduleDeathConsequences() {} // 0x0000000187102800-0x0000000187102C10
		public virtual void Despawn() {} // 0x0000000180B15170-0x0000000180B15180
		public void GiveReward(Action<Pickup> onRewardGiven = null) {} // 0x0000000180B15170-0x0000000180B15180
		protected void StopParticleFX() {} // 0x0000000187102C10-0x0000000187102C40
		protected void PlayDamageParticleFX() {} // 0x0000000187102C40-0x0000000187102D80
		public virtual bool ShouldCollideWithWalls() => default; // 0x0000000181958370-0x0000000181958380
		private void EditorLogPlayerStats() {} // 0x0000000180B15170-0x0000000180B15180
		public List<Vector2> GetHeadOffsets() => default; // 0x0000000187102D80-0x0000000187102E80
		public void ApplySkinModifiers() {} // 0x0000000187102E80-0x0000000187103F80
		public void AddSkinWeapons() {} // 0x0000000187103F80-0x0000000187104460
		public void ResetStats() {} // 0x0000000187104460-0x00000001871044E0
		public void PlayerStatsUpgrade(ModifierStats other, bool multiplicativeMaxHp = false /* Metadata: 0x01977F1A */) {} // 0x00000001871044E0-0x00000001871046C0
		public void AddValueToAttribute(CharacterController character, WeaponType weaponType, float value) {} // 0x00000001871046C0-0x0000000187104AA0
		public void AddActiveRapidFire(float cooldownChange, float speedChange, float duration) {} // 0x0000000187104AA0-0x0000000187104AD0
		public void AddActiveHeartRefresh(float statChange1, float statChange2, float duration) {} // 0x0000000187104AD0-0x0000000187104B00
		public void AddActiveKarmaCoin() {} // 0x0000000187104B00-0x0000000187104B20
		public void AddActiveMirrorOfTruth(float statChange1, float statChange2, float duration) {} // 0x0000000187104B20-0x0000000187104B50
		public virtual void SetExtraVisualsVisible(bool show) {} // 0x0000000180B15170-0x0000000180B15180
		public void SetMovementAI(AIType aiType, CharacterController followedCharacter = null) {} // 0x0000000187104B50-0x0000000187104EB0
		public virtual bool DoesWantPickup(Pickup pickup) => default; // 0x0000000187104EB0-0x00000001871050B0
		public virtual void OnPickupCollected(Pickup pickup) {} // 0x0000000180B15170-0x0000000180B15180
		public virtual bool OnTreasureCollected(TreasureChest treasure) => default; // 0x0000000180B15290-0x0000000180B152A0
		protected void SetCustomDamageOverlayRenderer(SpriteRenderer renderer) {} // 0x0000000186747210-0x0000000186747270
	}
}

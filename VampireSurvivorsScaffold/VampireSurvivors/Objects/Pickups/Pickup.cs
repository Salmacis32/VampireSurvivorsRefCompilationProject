/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Pickups
{
	public class Pickup : BasePoolableSpriteBehaviour, IDamageable // TypeDefIndex: 16012
	{
		// Fields
		protected SignalBus _signalBus; // 0x60
		protected PlayerOptions _playerOptions; // 0x68
		protected DataManager _dataManager; // 0x70
		protected GameSessionData _gameSessionData; // 0x78
		protected GameManager _gameManager; // 0x80
		protected SpriteRenderer _itemRenderer; // 0x88
		public SpriteAnimation _spriteAnimation; // 0x90
		protected Camera _mainCamera; // 0x98
		private Vector2 _currentDirection; // 0xA0
		private const float Radius = 10f; // Metadata: 0x019779E7
		private const float DefaultSpeed = 250f; // Metadata: 0x019779EB
		protected VampireSurvivors.Objects.Characters.CharacterController _targetPlayer; // 0xA8
		private static int _fps; // 0x00
		private static double _frameTime; // 0x08
		private double _frameTimeMS; // 0xB0
		private double _elapsed; // 0xB8
		protected string _frameName; // 0xC0
		protected string _textureName; // 0xC8
		protected bool _ShowAboveAll; // 0xD0
		protected bool _doOnlineDespawn; // 0xD1
		public bool HasMapTokenData; // 0xD2
		public string MapTokenFrameName; // 0xD8
		public string MapTokenTexture; // 0xE0
		public float Time; // 0x104
		private MultiTargetTween _vacuumTween; // 0x110
		private bool _goToPlayer; // 0x120
		private bool _disableDespawn; // 0x121
	
		// Properties
		[Sync]
		public int SyncedPickupType { get => default; set {} } // 0x00000001827FCB90-0x00000001827FCBA0 0x00000001837263E0-0x00000001837263F0
		[Sync]
		public bool IsStagePickup { get; set; } // 0x00000001828C4B40-0x00000001828C4B50 0x00000001828C4B50-0x00000001828C4B60
		[OnValueSynced("OnSpriteChanged")]
		[Sync]
		public string SpriteName { get; set; } // 0x00000001819716C0-0x00000001819716D0 0x0000000180B3E860-0x0000000180B3E8C0
		public VampireSurvivors.Data.ItemType PickupType { get; protected set; } // 0x00000001827FCB90-0x00000001827FCBA0 0x00000001837263E0-0x00000001837263F0
		[Sync]
		public float Value { get; set; } // 0x00000001827FCBA0-0x00000001827FCBB0 0x000000018675D370-0x000000018675D380
		public float ResRosary { get; set; } // 0x0000000182808640-0x0000000182808650 0x0000000186CBBE50-0x0000000186CBBE60
		public float? LoopedSpawnX { get; set; } // 0x0000000182766870-0x0000000182766880 0x0000000182A45AE0-0x0000000182A45AF0
		public float Speed { get; set; } // 0x0000000182908210-0x0000000182908220 0x000000018474DB80-0x000000018474DB90
		public float FeverMS { get; set; } // 0x0000000186758A10-0x0000000186758A20 0x0000000186758A20-0x0000000186758A30
		public bool GoToPlayer { get => default; set {} } // 0x0000000182917530-0x0000000182917540 0x0000000186EB3610-0x0000000186EB36D0
		[Sync]
		public bool IgnoreMadGroove { get; set; } // 0x00000001867531F0-0x0000000186753200 0x0000000186753200-0x0000000186753210
		[Sync]
		public bool DisableGet { get; set; } // 0x0000000186753210-0x0000000186753220 0x0000000186753220-0x0000000186753230
		public Action<Pickup> PickupCallback { get; set; } // 0x0000000182937BD0-0x0000000182937BE0 0x0000000182A45B30-0x0000000182A45B90
		public int Depth { get => default; } // 0x0000000186EB36D0-0x0000000186EB3770 
		public bool IsStationary { get; set; } // 0x0000000184F6FBA0-0x0000000184F6FBB0 0x00000001857FE930-0x00000001857FE940
		public bool IgnoreForcedMovement { get; set; } // 0x0000000186753290-0x00000001867532A0 0x00000001867532A0-0x00000001867532B0
		public bool DespawnInteadOfResetPosition { get; set; } // 0x0000000186EB3770-0x0000000186EB3780 0x0000000186EB3780-0x0000000186EB3790
		public bool AutoSafeXY { get; set; } // 0x0000000186EB3790-0x0000000186EB37A0 0x0000000186EB37A0-0x0000000186EB37B0
		public VampireSurvivors.Objects.Characters.CharacterController TargetPlayer { get => default; set {} } // 0x00000001819716D0-0x00000001819716E0 0x00000001819716E0-0x0000000181971740
		public bool DoOnlineDespawn { get => default; } // 0x00000001829082A0-0x00000001829082B0 
	
		// Constructors
		public Pickup() {} // 0x0000000186EB6240-0x0000000186EB6370
		static Pickup() {} // 0x0000000186EB6370-0x0000000186EB64A0
	
		// Methods
		public virtual bool CanCharacterCollectPickup(VampireSurvivors.Data.CharacterType characterType) => default; // 0x0000000181958370-0x0000000181958380
		[Inject]
		private void Construct(SignalBus signalBus, PlayerOptions playerOptions, DataManager dataManager, GameSessionData gameSessionData, GameManager gameManager) {} // 0x0000000186EB37B0-0x0000000186EB3960
		protected virtual new void Awake() {} // 0x0000000186EB3960-0x0000000186EB39D0
		protected virtual void Start() {} // 0x0000000186EB39D0-0x0000000186EB3CE0
		protected override void OnDestroy() {} // 0x0000000186EB3CE0-0x0000000186EB3E70
		public virtual void SetData(VampireSurvivors.Data.ItemType itemType) {} // 0x0000000186EB3E70-0x0000000186EB42A0
		public virtual void InternalUpdate() {} // 0x0000000186EB42A0-0x0000000186EB4520
		public virtual void UpdateDepth() {} // 0x0000000186EB4520-0x0000000186EB4560
		public virtual bool Vacuum(VampireSurvivors.Objects.Characters.CharacterController player) => default; // 0x0000000186EB4560-0x0000000186EB48F0
		public virtual void Despawn() {} // 0x0000000186EB48F0-0x0000000186EB49F0
		public void SetFrame(string spriteName) {} // 0x0000000186EB49F0-0x0000000186EB4AE0
		public virtual void GetTaken() {} // 0x0000000186EB4AE0-0x0000000186EB4C20
		public void ForceDisableDespawn() {} // 0x0000000186EB4C20-0x0000000186EB4C30
		public virtual void DisposeAsTaken() {} // 0x0000000186EB4C30-0x0000000186EB4D60
		public void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019779DD */, float damageKb = 1f /* Metadata: 0x019779DE */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x019779E2 */, bool hasKb = true /* Metadata: 0x019779E3 */) {} // 0x0000000180B15170-0x0000000180B15180
		public void OnGetDamaged(HitVfxType hitVfxType, bool hasKb = true /* Metadata: 0x019779E4 */) {} // 0x0000000180B15170-0x0000000180B15180
		public bool IsUnitDead() => default; // 0x0000000180B15290-0x0000000180B152A0
		public float MaxHp() => default; // 0x0000000186EB4D60-0x0000000186EB4D70
		public float CurrentHealth() => default; // 0x0000000186EB4D60-0x0000000186EB4D70
		public GameObject GetGameObject() => default; // 0x0000000182774DD0-0x0000000182774DE0
		public void GoToLowestHealthPlayer() {} // 0x0000000186EB4D70-0x0000000186EB50C0
		protected void RemovePhysics() {} // 0x0000000186EB50C0-0x0000000186EB5260
		protected void OnSpriteChanged(string oldSprite, string newSprite) {} // 0x0000000186EB5260-0x0000000186EB5280
		private void InitRenderer() {} // 0x0000000186EB5280-0x0000000186EB5580
		protected void InitPhysics() {} // 0x0000000186EB5580-0x0000000186EB5640
		protected virtual void SetHasSeenItem() {} // 0x0000000186EB5640-0x0000000186EB5660
		protected virtual void SetHasSeenItem(VampireSurvivors.Data.ItemType itemType) {} // 0x0000000186EB5660-0x0000000186EB5730
		protected virtual void AddToRunPickups() {} // 0x0000000186EB5730-0x0000000186EB57E0
		protected virtual void AddToRunPickups(VampireSurvivors.Data.ItemType itemType) {} // 0x0000000186EB57E0-0x0000000186EB58A0
		protected float2 SafeXY() => default; // 0x0000000186EB58A0-0x0000000186EB5BA0
		protected float2 SafeXYWrapped() => default; // 0x0000000186EB5BA0-0x0000000186EB5EA0
		protected virtual void GoToThePlayer() {} // 0x0000000186EB5EA0-0x0000000186EB6100
		protected virtual void TrackItemPickup(bool trackRunPickup = true /* Metadata: 0x019779E5 */) {} // 0x0000000186EB6100-0x0000000186EB6160
		protected virtual void ToggleCursors(UISignals.ToggleGuidesSignal sig) {} // 0x0000000180B15170-0x0000000180B15180
		public virtual void Bless(float value, HitVfxType hitVFXType = HitVfxType.Prism /* Metadata: 0x019779E6 */) {} // 0x0000000186EB6160-0x0000000186EB6240
		public void GiveReward(Action<Pickup> onRewardGiven = null) {} // 0x0000000180B15170-0x0000000180B15180
	}
}

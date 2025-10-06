/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence;
using Coherence.Toolkit;
using SuperTiled2Unity;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Props;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Loot;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pickups;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public class Destructible : BasePoolableSpriteBehaviour, IDamageable // TypeDefIndex: 15076
	{
		// Fields
		[Sync]
		public uint _deathSeed; // 0x60
		protected SpriteRenderer _destructibleRenderer; // 0x68
		protected SpriteAnimation _spriteAnimation; // 0x70
		private DataManager _dataManager; // 0x78
		protected PlayerOptions _playerOptions; // 0x80
		private LootManager _lootManager; // 0x88
		private GameManager _gameManager; // 0x90
		protected GameSessionData _gameSessionData; // 0x98
		protected PropData _propData; // 0xA0
		private MaterialPropertyBlock _propBlock; // 0xA8
		protected Camera _mainCamera; // 0xB0
		protected PropType _destructibleType; // 0xB8
		protected float _hp; // 0xBC
		private float _maxHp; // 0xC0
		protected VampireSurvivors.Framework.TimerSystem.Timer _blinkTimer; // 0xC8
		private bool _receivingDamage; // 0xD0
		private bool _isCullable; // 0xD1
		private bool _isTeleportOnCull; // 0xD2
		protected bool _isDead; // 0xD3
		public float _blessedLevel; // 0xD4
		protected Light2D _light; // 0xE0
		protected CoherenceSync _coherenceSync; // 0xE8
		private Unity.Mathematics.Random _deathRng; // 0xF0
	
		// Properties
		[Sync]
		public int PropType { get => default; set {} } // 0x0000000182937930-0x0000000182937940 0x00000001865B30C0-0x00000001865B30D0
		public bool IsStationary { get; set; } // 0x0000000182816BD0-0x0000000182816BE0 0x0000000182816BE0-0x0000000182816BF0
		public PropType DestructibleType { get => default; } // 0x0000000182937930-0x0000000182937940 
		public bool IgnoreForcedMovement { get; set; } // 0x0000000184EB8710-0x0000000184EB8720 0x0000000184EB8720-0x0000000184EB8730
	
		// Constructors
		public Destructible() {} // 0x00000001869ECEE0-0x00000001869ECF40
	
		// Methods
		[Inject]
		private void Construct(DataManager dataManager, PlayerOptions playerOptions, LootManager lootManager, GameManager gameManager, GameSessionData gameSessionData) {} // 0x00000001869EA260-0x00000001869EA430
		public virtual new void Awake() {} // 0x00000001869EA430-0x00000001869EA880
		protected override void OnEnable() {} // 0x00000001869EA880-0x00000001869EA900
		public virtual void OnDestructibleSpawned(SuperObject tiledScriptObject) {} // 0x0000000180B15170-0x0000000180B15180
		protected override void OnUpdate() {} // 0x00000001869EA900-0x00000001869EAA20
		public virtual void Init(PropType destructibleType) {} // 0x00000001869EAA20-0x00000001869EB270
		public void UpdateLightPosition() {} // 0x00000001869EB270-0x00000001869EB4F0
		protected virtual bool CanEmitLight() => default; // 0x0000000181958370-0x0000000181958380
		public virtual void Despawn() {} // 0x00000001869EB4F0-0x00000001869EB810
		protected void Pushback(GameObject value, float duration) {} // 0x0000000180B15170-0x0000000180B15180
		public void RemoteDestroy() {} // 0x00000001869EB810-0x00000001869EB860
		public virtual void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019772E1 */, float damageKb = 1f /* Metadata: 0x019772E2 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x019772E6 */, bool hasKb = true /* Metadata: 0x019772E7 */) {} // 0x00000001869EB860-0x00000001869EB9B0
		[Command(defaultRouting = MessageTarget.AuthorityOnly)]
		public void DestroyDestructible() {} // 0x00000001869EB9B0-0x00000001869EBA00
		public void OnGetDamaged(HitVfxType hitVfxType, bool hasKb = true /* Metadata: 0x019772E8 */) {} // 0x00000001869EBA00-0x00000001869EBBE0
		public bool IsUnitDead() => default; // 0x00000001869EBBE0-0x00000001869EBBF0
		public float MaxHp() => default; // 0x0000000183725DA0-0x0000000183725DB0
		public float CurrentHealth() => default; // 0x000000018293AC00-0x000000018293AC10
		public GameObject GetGameObject() => default; // 0x0000000182774DD0-0x0000000182774DE0
		protected virtual void SetupAnimations() {} // 0x00000001869EBBF0-0x00000001869EBCF0
		protected virtual void OnDestroyed() {} // 0x00000001869EBCF0-0x00000001869EC790
		public void GiveReward(Action<Pickup> onRewardGiven = null) {} // 0x00000001869EC790-0x00000001869ECC40
		private void HandleArcanas() {} // 0x00000001869ECC40-0x00000001869ECE00
		protected virtual void RestoreTint() {} // 0x00000001869ECE00-0x00000001869ECEE0
		public virtual bool DoesAllowVenting() => default; // 0x0000000181958370-0x0000000181958380
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Serialization;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Items;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class Enemy_TP_GateBoss : EnemyController // TypeDefIndex: 17259
	{
		// Fields
		[Header("Gate Boss")]
		[SerializeField]
		public VampireSurvivors.Data.ItemType RelicToDrop; // 0x270
		[SerializeField]
		public WeaponType WeaponToDrop; // 0x274
		[SerializeField]
		public VampireSurvivors.Data.ItemType AlternativePrize; // 0x278
		[SerializeField]
		public bool HasRelic; // 0x27C
		[SerializeField]
		public bool HasTreasureChest; // 0x27D
		[SerializeField]
		public List<float> TreasureChances; // 0x280
		[SerializeField]
		public VampireSurvivors.Data.ItemType RequiresItem; // 0x288
		[SerializeField]
		public List<PrizeType?> TreasurePrizeTypes; // 0x290
		[FormerlySerializedAs("damageZone")]
		[Header("Damage Zone")]
		[SerializeField]
		private DamagingZonePrefab damagingZone; // 0x298
		private float _damageZoneRespawnTimer; // 0x2A0
		public bool DoWiggle; // 0x2A4
		private SpriteRenderer _ringSprite; // 0x2A8
		private float _shieldDamage; // 0x2B0
		private int _deathScreamTimerLoopCount; // 0x2B4
		private bool _hasShield; // 0x2B8
		private bool _hasRunDeathLogic; // 0x2B9
		private bool _hasRunOneHKOLogic; // 0x2BA
		private VampireSurvivors.Framework.TimerSystem.Timer _shieldTimer; // 0x2C0
		private VampireSurvivors.Framework.TimerSystem.Timer _aiTimer; // 0x2C8
		private VampireSurvivors.Framework.TimerSystem.Timer _deathScreamTimer; // 0x2D0
		protected bool _isRunningDeathAnimation; // 0x2D8
		private SpriteRenderer _posterSprite; // 0x2E0
		private SpriteMask _posterMask; // 0x2E8
		private MultiTargetTween screamTween; // 0x2F0
		protected MultiTargetTween scaleTween; // 0x2F8
		private VampireSurvivors.Framework.TimerSystem.Timer deathTimer1; // 0x300
		private VampireSurvivors.Framework.TimerSystem.Timer deathTimer2; // 0x308
		private VampireSurvivors.Framework.TimerSystem.Timer exploTimer1; // 0x310
		private VampireSurvivors.Framework.TimerSystem.Timer exploTimer2; // 0x318
		private VampireSurvivors.Framework.TimerSystem.Timer animTimer; // 0x320
		private VampireSurvivors.Framework.TimerSystem.Timer relicDropTimer; // 0x328
		private Tween posterTween; // 0x330
		private bool _hasDroppedTreasure; // 0x338
		private Tween _onEnterTween; // 0x340
		private SpriteRenderer _enterSprite; // 0x348
		private SpriteRenderer _enterSprite2; // 0x350
		private MultiTargetTween _alphaTween; // 0x358
		private MultiTargetTween _rotTween; // 0x360
		private ParticleSystem _deathVfxParticleSystem1; // 0x368
		private ParticleSystem _deathVfxParticleSystem2; // 0x370
		protected uint _damagingZoneSeed; // 0x378
		[SerializeField]
		public WeaponType OHKOWeaponType; // 0x390
		[SerializeField]
		public SecretType OHKOSecretUnlock; // 0x394
		[SerializeField]
		public VampireSurvivors.Data.CharacterType OHKOCharacterUnlock; // 0x398
		[SerializeField]
		public VampireSurvivors.Data.CharacterType Assassin; // 0x39C
		[SerializeField]
		public SecretType AssassinSecretUnlock; // 0x3A0
		[SerializeField]
		public VampireSurvivors.Data.CharacterType AssassinCharacterUnlock; // 0x3A4
	
		// Properties
		public Action OnDefeat { get; set; } // 0x000000018721D300-0x000000018721D310 0x000000018721D310-0x000000018721D370
		public virtual bool DropRelic { get; set; } // 0x000000018721D370-0x000000018721D380 0x000000018721D380-0x000000018721D390
		public virtual float ShieldTime { get; set; } // 0x000000018721D390-0x000000018721D3A0 0x000000018721D3A0-0x000000018721D3B0
		[Sync(DefaultSyncMode = SyncMode.CreationOnly)]
		public uint DamagingZoneSeed { get => default; set {} } // 0x0000000185FB7660-0x0000000185FB7670 0x000000018721D3B0-0x000000018721D3C0
	
		// Constructors
		public Enemy_TP_GateBoss() {} // 0x0000000187222600-0x0000000187222B50
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x000000018721D3C0-0x000000018721E970
		private void OnRemoteItemInstantiated(Pickup pickup) {} // 0x000000018721E970-0x000000018721EC20
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x0197831E */, float damageKb = 1f /* Metadata: 0x0197831F */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01978323 */, bool hasKb = true /* Metadata: 0x01978324 */) {} // 0x000000018721EC20-0x000000018721F080
		public virtual void CheckAssassin() {} // 0x000000018721F080-0x000000018721F480
		public virtual void OnOHKO() {} // 0x000000018721F480-0x000000018721F5D0
		[Command]
		public void OneHitKoOnline(long startingClientFrame) {} // 0x000000018721F5D0-0x000000018721F6B0
		private void OneHitKoLogic() {} // 0x000000018721F6B0-0x000000018721F9C0
		public override void Disappear() {} // 0x000000018721F9C0-0x000000018721FA10
		protected override void Die() {} // 0x000000018721F9C0-0x000000018721FA10
		private void KillGateBoss() {} // 0x000000018721FA10-0x000000018721FB10
		[Command]
		public void DeathTrigger() {} // 0x000000018721FB10-0x000000018721FB30
		protected virtual void DeathLogic() {} // 0x000000018721FB30-0x000000018721FB70
		protected virtual void CustomDeathLogic() {} // 0x000000018721FB70-0x000000018721FE10
		private void OnWeaponSpawned(Pickup p) {} // 0x000000018721FE10-0x000000018721FF80
		private void OnRelicSpawned(PickupRelic p) {} // 0x000000018721FF80-0x00000001872202B0
		private void DropTreasure() {} // 0x00000001872202B0-0x0000000187220530
		private void PlayPosterAnimation(Transform t) {} // 0x0000000187220530-0x0000000187220BD0
		protected void DeathScream() {} // 0x0000000187220BD0-0x0000000187221000
		protected override void OnUpdate() {} // 0x0000000187221000-0x00000001872212B0
		protected virtual void DoDeathAnimation() {} // 0x00000001872212B0-0x0000000187222530
		public override void Despawn() {} // 0x0000000187222530-0x0000000187222600
	}
}

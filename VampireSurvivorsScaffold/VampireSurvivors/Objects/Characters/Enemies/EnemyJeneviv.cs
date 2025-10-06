/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using DG.Tweening;
using DG.Tweening.Core;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyJeneviv : EnemyController // TypeDefIndex: 17335
	{
		// Fields
		private DiContainer _diContainer; // 0x270
		private float _totalTime; // 0x278
		private float _scitheTime; // 0x27C
		private float _shieldDamage; // 0x280
		private float _activationDistance; // 0x284
		private bool _hasShield; // 0x288
		private bool _isInvul; // 0x289
		private bool _painInTheAss; // 0x28A
		private bool _isActivated; // 0x28B
		private bool _specialDeath; // 0x28C
		private VampireSurvivors.Framework.TimerSystem.Timer _shieldTimer; // 0x290
		private VampireSurvivors.Framework.TimerSystem.Timer _summonSnakesEvent; // 0x298
		private VampireSurvivors.Framework.TimerSystem.Timer _damagingZonesEvent; // 0x2A0
		private DamagingZonePool_Ophion _damagingZonePool; // 0x2A8
		private PhaserSprite _ringSprite; // 0x2B0
		private PhaserSprite _breakFreeSprite; // 0x2B8
		private PhaserSprite _worldEaterImage; // 0x2C0
		private PhaserSprite _faderImage; // 0x2C8
		private MultiTargetTween _worldEaterTween1; // 0x2D0
		private MultiTargetTween _worldEaterTween2; // 0x2D8
		private MultiTargetTween _worldEaterTween3; // 0x2E0
		private List<EquipmentInfo> _playerEquipment; // 0x2E8
		private List<PhaserSprite> _rays; // 0x2F0
		private const float SHIELD_TIME = 45000f; // Metadata: 0x0197845B
	
		// Properties
		public Action OnActivated { get; set; } // 0x0000000186753C10-0x0000000186753C20 0x0000000186753C20-0x0000000186753C80
		public Action OnDefeat { get; set; } // 0x000000018726E490-0x000000018726E4A0 0x000000018726E4A0-0x000000018726E500
	
		// Constructors
		public EnemyJeneviv() {} // 0x0000000187274CD0-0x0000000187274E80
	
		// Methods
		protected override void FakeConstruct() {} // 0x000000018726E500-0x000000018726E5B0
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x000000018726E5B0-0x000000018726EEC0
		public void RestoreShield() {} // 0x000000018726EEC0-0x000000018726EFF0
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978453 */, float damageKb = 1f /* Metadata: 0x01978454 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01978458 */, bool hasKb = true /* Metadata: 0x01978459 */) {} // 0x000000018726EFF0-0x000000018726F3C0
		[Command]
		public void OnlineDeath() {} // 0x0000000186DDED80-0x0000000186DDEDA0
		protected override void OnUpdate() {} // 0x000000018726F3C0-0x000000018726F920
		public override void Disappear() {} // 0x0000000180B15170-0x0000000180B15180
		public void SealInStone() {} // 0x000000018726F920-0x00000001872700E0
		public void BreakFree1() {} // 0x00000001872700E0-0x00000001872701F0
		public void StartMoving() {} // 0x00000001872701F0-0x00000001872702E0
		public void BreakFree2() {} // 0x00000001872702E0-0x00000001872703B0
		public void ChargeWorldEater() {} // 0x00000001872703B0-0x0000000187270B60
		public void CastWorldEater() {} // 0x0000000187270B60-0x00000001872710D0
		public void StartVerySmartAI() {} // 0x00000001872710D0-0x0000000187271390
		public void ScreenShake(int repeats = 6 /* Metadata: 0x0197845A */) {} // 0x0000000187271390-0x0000000187271870
		private void TestSpecialDeath() {} // 0x0000000187271870-0x0000000187271890
		private void ActivatedByDistance() {} // 0x0000000187271890-0x0000000187271920
		protected override void Die() {} // 0x0000000187271920-0x00000001872721C0
		private void RemovePlayerWeapons() {} // 0x00000001872721C0-0x0000000187272270
		protected void DeathScream() {} // 0x0000000187272270-0x0000000187272640
		private void SpecialDeathAnimation() {} // 0x0000000187272640-0x0000000187272690
		private void PlayWorldEater() {} // 0x0000000187272690-0x0000000187272DC0
		private void StealHearts() {} // 0x0000000187272DC0-0x0000000187273420
		private void FakeRecover() {} // 0x0000000187273420-0x0000000187273560
		private void DevourEleanor() {} // 0x0000000187273560-0x00000001872746F0
		private void SummonSnakes(int generic, int exploding) {} // 0x00000001872746F0-0x0000000187274A50
		private void FireOphion(float delay, float radius, int times) {} // 0x0000000187274A50-0x0000000187274C70
		[Command]
		public void SpawnDamagingPool(float x, float y) {} // 0x0000000187274C70-0x0000000187274CD0
	}
}

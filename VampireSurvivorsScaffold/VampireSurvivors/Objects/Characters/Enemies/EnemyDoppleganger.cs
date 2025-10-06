/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Projectiles;
using VampireSurvivors.Objects.Stages;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyDoppleganger : EnemyController // TypeDefIndex: 17230
	{
		// Fields
		public EnemyProjectile _knifePrefab; // 0x270
		public EnemyProjectile _runetracerPrefab; // 0x278
		private List<EnemyWeapon> _weapons; // 0x280
		private VampireSurvivors.Objects.Characters.CharacterController _targetCharacter; // 0x288
		private float _weaponUsageCooldown; // 0x290
		private float _reloadSpeed; // 0x294
		private VampireSurvivors.Objects.Characters.CharacterController _characterToCopy; // 0x298
		private bool _hasStartedDeathAnimation; // 0x2A0
		private DopplegangerGate _parentGate; // 0x2A8
		private PlatformZoneMovement.JumpInfo _jumpInfo; // 0x2B0
		private float _jumpTimer; // 0x2B8
	
		// Properties
		[Sync]
		public float WeaponUsageCooldown { get => default; set {} } // 0x0000000186A13330-0x0000000186A13340 0x0000000186A13340-0x0000000186A13350
		[Sync]
		public float ReloadSpeed { get => default; set {} } // 0x00000001871F4FC0-0x00000001871F4FD0 0x00000001871F4FD0-0x00000001871F4FE0
		[Sync]
		public CoherenceSync CharacterToCopy { get => default; set {} } // 0x00000001871F4FE0-0x00000001871F50E0 0x00000001871F50E0-0x00000001871F52B0
		[Sync]
		public Vector2 SpritePosition { get => default; set {} } // 0x0000000186D54340-0x0000000186D54370 0x0000000186D54370-0x0000000186D54390
		[Sync]
		public Vector2 CurrentDirectionSynced { get => default; set {} } // 0x00000001871F52B0-0x00000001871F52D0 0x00000001871F52D0-0x00000001871F52E0
	
		// Constructors
		public EnemyDoppleganger() {} // 0x00000001871F7080-0x00000001871F70D0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001871F52E0-0x00000001871F5310
		private void SetTargetToNearestCharacter() {} // 0x00000001871F5310-0x00000001871F5530
		public void SetupDoppleganger(VampireSurvivors.Objects.Characters.CharacterController toCopy, float reloadSpeed, DopplegangerGate gate) {} // 0x00000001871F5530-0x00000001871F5610
		public void SetupRemoteDoppleganger(DopplegangerGate gate) {} // 0x00000001871F5610-0x00000001871F5630
		private void SetupDoppleganger(VampireSurvivors.Objects.Characters.CharacterController toCopy, DopplegangerGate gate) {} // 0x00000001871F5630-0x00000001871F5F60
		protected override void OnUpdate() {} // 0x00000001871F5F60-0x00000001871F6560
		private void ResetJumpTimer() {} // 0x00000001871F6560-0x00000001871F65D0
		private void HandleWeapons() {} // 0x00000001871F65D0-0x00000001871F6730
		public override void Disappear() {} // 0x00000001871ECB40-0x00000001871ECB50
		protected override void Die() {} // 0x00000001871ECB40-0x00000001871ECB50
		private void DoDeathAnimation() {} // 0x00000001871F6730-0x00000001871F6E60
		private void DeathAnimationFinished() {} // 0x00000001871F6E60-0x00000001871F7080
	}
}

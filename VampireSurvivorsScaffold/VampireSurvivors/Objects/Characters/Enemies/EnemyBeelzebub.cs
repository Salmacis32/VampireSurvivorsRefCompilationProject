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
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyBeelzebub : EnemyController // TypeDefIndex: 17221
	{
		// Fields
		private List<EnemyBeelzebubSection> _sections; // 0x270
		private EnemyBeelzebubSection _head; // 0x278
		private EnemyBeelzebubSection _leftArm; // 0x280
		private EnemyBeelzebubSection _leftHand; // 0x288
		private EnemyBeelzebubSection _rightArm; // 0x290
		private EnemyBeelzebubSection _rightHand; // 0x298
		private EnemyBeelzebubSection _leftThigh; // 0x2A0
		private EnemyBeelzebubSection _leftLeg; // 0x2A8
		private EnemyBeelzebubSection _rightThigh; // 0x2B0
		private EnemyBeelzebubSection _rightLeg; // 0x2B8
		private EnemyBeelzebubSection _belly; // 0x2C0
		private List<EnemyBeelzebubBee> _beeList; // 0x2C8
		private float _beeTimer; // 0x2D0
		private PhaserSprite[] _torsoChains; // 0x2D8
		private bool _isRunningDeathAnimation; // 0x2E0
	
		// Properties
		public List<EnemyBeelzebubSection> Sections { get => default; } // 0x0000000186A130F0-0x0000000186A13100 
		[Sync]
		public GameObject Head { get => default; set {} } // 0x00000001871E7050-0x00000001871E7150 0x00000001871E7150-0x00000001871E7320
		[Sync]
		public GameObject LeftArm { get => default; set {} } // 0x00000001871E7320-0x00000001871E7420 0x00000001871E7420-0x00000001871E75F0
		[Sync]
		public GameObject LeftHand { get => default; set {} } // 0x00000001871E75F0-0x00000001871E76F0 0x00000001871E76F0-0x00000001871E78C0
		[Sync]
		public GameObject RightArm { get => default; set {} } // 0x00000001871E78C0-0x00000001871E79C0 0x00000001871E79C0-0x00000001871E7B90
		[Sync]
		public GameObject RightHand { get => default; set {} } // 0x00000001871E7B90-0x00000001871E7C90 0x00000001871E7C90-0x00000001871E7E60
		[Sync]
		public GameObject LeftThigh { get => default; set {} } // 0x00000001871E7E60-0x00000001871E7F60 0x00000001871E7F60-0x00000001871E8130
		[Sync]
		public GameObject LeftLeg { get => default; set {} } // 0x00000001871E8130-0x00000001871E8230 0x00000001871E8230-0x00000001871E8400
		[Sync]
		public GameObject RightThigh { get => default; set {} } // 0x00000001871E8400-0x00000001871E8500 0x00000001871E8500-0x00000001871E86D0
		[Sync]
		public GameObject RightLeg { get => default; set {} } // 0x00000001871E86D0-0x00000001871E87D0 0x00000001871E87D0-0x00000001871E89A0
		[Sync]
		public GameObject Belly { get => default; set {} } // 0x00000001871E89A0-0x00000001871E8AA0 0x00000001871E8AA0-0x00000001871E8C70
	
		// Constructors
		public EnemyBeelzebub() {} // 0x00000001871EF960-0x00000001871EF9B0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001871E8C70-0x00000001871E90D0
		private void SpawnBodyParts() {} // 0x00000001871E90D0-0x00000001871EA410
		private void UpdateBodyParts() {} // 0x00000001871EA410-0x00000001871ECB40
		public override void Disappear() {} // 0x00000001871ECB40-0x00000001871ECB50
		protected override void Die() {} // 0x00000001871ECB40-0x00000001871ECB50
		public override void Despawn() {} // 0x00000001871ECB50-0x00000001871ED070
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019782CC */, float damageKb = 1f /* Metadata: 0x019782CD */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x019782D1 */, bool hasKb = true /* Metadata: 0x019782D2 */) {} // 0x00000001871ED070-0x00000001871ED290
		protected override void OnUpdate() {} // 0x00000001871ED290-0x00000001871ED9F0
		private void DoDeathAnimation() {} // 0x00000001871ED9F0-0x00000001871EF210
		private void DropReward() {} // 0x00000001871EF210-0x00000001871EF960
	}
}

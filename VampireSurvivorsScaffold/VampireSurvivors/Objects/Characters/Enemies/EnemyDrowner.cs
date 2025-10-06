/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyDrowner : EnemyController // TypeDefIndex: 17310
	{
		// Fields
		private VampireSurvivors.Objects.Stage _stage; // 0x270
		private bool _hasLostTreasure; // 0x278
		private bool _dismissed; // 0x279
		private bool _invul; // 0x27A
		private bool _isFresh; // 0x27B
		private bool _done; // 0x27C
		private EnemyBulletW _bullet; // 0x280
		private GameObject _spritte; // 0x288
		private ParticleSystem _pfxEmitter; // 0x290
		public bool _FromTrisection; // 0x298
	
		// Properties
		public bool Dismissed { get => default; set {} } // 0x0000000187259D20-0x0000000187259D30 0x0000000187259D30-0x0000000187259D40
	
		// Constructors
		public EnemyDrowner() {} // 0x000000018725CE30-0x000000018725CE90
	
		// Methods
		protected override void FakeConstruct() {} // 0x000000018725A620-0x000000018725A6D0
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x000000018725A6D0-0x000000018725AA00
		public void Dismiss() {} // 0x000000018725AA00-0x000000018725AAA0
		public override void Disappear() {} // 0x000000018725AAA0-0x000000018725ACA0
		protected override void OnUpdate() {} // 0x000000018725ACA0-0x000000018725ACB0
		public override void Despawn() {} // 0x000000018725ACB0-0x000000018725AE50
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978429 */, float damageKb = 1f /* Metadata: 0x0197842A */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x0197842E */, bool hasKb = true /* Metadata: 0x0197842F */) {} // 0x000000018725AE50-0x000000018725B200
		private void SpawnBullet() {} // 0x000000018725B200-0x000000018725B3A0
		private void SpawnSpritte() {} // 0x000000018725B3A0-0x000000018725B740
		private void HandleDrownerUpdate() {} // 0x000000018725B740-0x000000018725C280
		private float Approach(float start, float end, float shift) => default; // 0x00000001869DF580-0x00000001869DF5A0
		private void GenerateParticleSystems() {} // 0x000000018725C280-0x000000018725CE30
	}
}

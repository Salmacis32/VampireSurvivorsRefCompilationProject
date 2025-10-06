/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class EnemyTaka : EnemyController // TypeDefIndex: 17194
	{
		// Fields
		private EnemyWeakPoint _weakPoint; // 0x270
		private VampireSurvivors.Framework.TimerSystem.Timer _bundleSpawnTimer; // 0x278
		private VampireSurvivors.Framework.TimerSystem.Timer _swarmSpawnTimer; // 0x280
		private VampireSurvivors.Framework.TimerSystem.Timer _bulletSpawnTimer; // 0x288
		private List<Sprite> _explosionFrames; // 0x290
		private List<PhaserSprite> _explosionSprites; // 0x298
		private List<PhaserSprite> _readyExplosionSprites; // 0x2A0
		private bool _isExploding; // 0x2A8
		private float _explosionTimer; // 0x2AC
	
		// Constructors
		public EnemyTaka() {} // 0x00000001871D8BD0-0x00000001871D8D40
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001871D6950-0x00000001871D6D80
		private void AddExplosionEffect(float2 position) {} // 0x00000001871D6D80-0x00000001871D7230
		protected override void OnUpdate() {} // 0x00000001871D7230-0x00000001871D7810
		private void StartExploding() {} // 0x00000001871D7810-0x00000001871D7A70
		private void LateUpdate() {} // 0x00000001871D7A70-0x00000001871D7B50
		protected override void OnDestroy() {} // 0x00000001871D7B50-0x00000001871D7B70
		protected override void Die() {} // 0x00000001871D7B70-0x00000001871D7C90
		[Command]
		public void StartExplodingOnline() {} // 0x00000001871D7C90-0x00000001871D7CA0
		public override void Despawn() {} // 0x00000001871D7CA0-0x00000001871D7CC0
		private void Clearup() {} // 0x00000001871D7CC0-0x00000001871D7D40
		private void CancelAttacks() {} // 0x00000001871D7D40-0x00000001871D7EC0
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x0197818C */, float damageKb = 1f /* Metadata: 0x0197818D */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01978191 */, bool hasKb = true /* Metadata: 0x01978192 */) {} // 0x00000001871D7EC0-0x00000001871D8030
		private void FireBullet() {} // 0x00000001871D8030-0x00000001871D8160
		private void FireBundle() {} // 0x00000001871D8160-0x00000001871D8370
		private void HandleBundle(EnemyController enemy) {} // 0x00000001871D8370-0x00000001871D8AA0
		[Command]
		public void OnBundleSpawned(CoherenceSync bundle) {} // 0x00000001871D8AA0-0x00000001871D8B10
		private void FireSwarm() {} // 0x00000001871D8B10-0x00000001871D8BD0
	}
}

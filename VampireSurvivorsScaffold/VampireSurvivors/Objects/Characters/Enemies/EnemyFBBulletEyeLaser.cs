/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyFBBulletEyeLaser : EnemyController // TypeDefIndex: 17211
	{
		// Fields
		private float _lifetime; // 0x270
		private const float DurationMillis = 5500f; // Metadata: 0x019782BD
		private bool _isDespawning; // 0x274
		private Tween _onEnterTween; // 0x278
		private Tween _scaleTween; // 0x280
		private Tween _onLifetimeTween; // 0x288
		private float _directionTimer; // 0x290
	
		// Constructors
		public EnemyFBBulletEyeLaser() {} // 0x00000001871E5150-0x00000001871E51B0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001871E4010-0x00000001871E4560
		public override void Disappear() {} // 0x00000001871E4560-0x00000001871E45E0
		protected override void OnUpdate() {} // 0x00000001871E45E0-0x00000001871E4CD0
		public override void Despawn() {} // 0x00000001871E4CD0-0x00000001871E4DB0
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019782B6 */, float damageKb = 1f /* Metadata: 0x019782B7 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x019782BB */, bool hasKb = true /* Metadata: 0x019782BC */) {} // 0x0000000180B15170-0x0000000180B15180
		public override void OnPlayerOverlap(CharacterController player) {} // 0x00000001871E4DB0-0x00000001871E4E30
		private void DeathTween() {} // 0x00000001871E4E30-0x00000001871E50E0
		protected override void Die() {} // 0x00000001871E50E0-0x00000001871E5150
	}
}

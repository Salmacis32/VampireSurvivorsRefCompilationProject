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
	public class EnemyFBBullet : EnemyController // TypeDefIndex: 17210
	{
		// Fields
		private float _originalScale; // 0x270
		private float _lifetime; // 0x274
		private const float DurationMillis = 5500f; // Metadata: 0x019782B2
		private bool _isDespawning; // 0x278
		private Tween _onEnterTween; // 0x280
		private Tween _scaleTween; // 0x288
		private Tween _onLifetimeTween; // 0x290
	
		// Constructors
		public EnemyFBBullet() {} // 0x00000001871E3F00-0x00000001871E3F60
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001871E3450-0x00000001871E39F0
		public override void Disappear() {} // 0x00000001871E39F0-0x00000001871E3A70
		protected override void UpdateDepth() {} // 0x0000000180B15170-0x0000000180B15180
		public override void Despawn() {} // 0x00000001871E3A70-0x00000001871E3B10
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019782AB */, float damageKb = 1f /* Metadata: 0x019782AC */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x019782B0 */, bool hasKb = true /* Metadata: 0x019782B1 */) {} // 0x00000001871E3B10-0x00000001871E3B50
		public override void OnPlayerOverlap(CharacterController player) {} // 0x00000001871E3B50-0x00000001871E3BD0
		private void DeathTween() {} // 0x00000001871E3BD0-0x00000001871E3E90
		protected override void Die() {} // 0x00000001871E3E90-0x00000001871E3F00
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Unity.Mathematics;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyFBBulletFireball : EnemyController // TypeDefIndex: 17212
	{
		// Fields
		private float _lifetime; // 0x270
		private const float DurationMillis = 5500f; // Metadata: 0x019782C8
		private bool _isDespawning; // 0x274
		private Tween _onEnterTween; // 0x278
		private Tween _scaleTween; // 0x280
		private Tween _onLifetimeTween; // 0x288
		private float2 _fixedVelocity; // 0x290
	
		// Constructors
		public EnemyFBBulletFireball() {} // 0x00000001871E5C60-0x00000001871E5CC0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001871E51D0-0x00000001871E56C0
		public void SetFixedVelocity(float2 velocity) {} // 0x00000001871E56C0-0x00000001871E56D0
		public override void Disappear() {} // 0x00000001871E56D0-0x00000001871E5750
		protected override void OnUpdate() {} // 0x00000001871E5750-0x00000001871E57A0
		public override void Despawn() {} // 0x00000001871E57A0-0x00000001871E5880
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019782C1 */, float damageKb = 1f /* Metadata: 0x019782C2 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x019782C6 */, bool hasKb = true /* Metadata: 0x019782C7 */) {} // 0x0000000180B15170-0x0000000180B15180
		public override void OnPlayerOverlap(CharacterController player) {} // 0x00000001871E5880-0x00000001871E5900
		private void DeathTween() {} // 0x00000001871E5900-0x00000001871E5BF0
		protected override void Die() {} // 0x00000001871E5BF0-0x00000001871E5C60
	}
}

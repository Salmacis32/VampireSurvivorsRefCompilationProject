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
	public class EnemyBullet1 : EnemyController // TypeDefIndex: 17277
	{
		// Fields
		private float _originalScale; // 0x270
		private float _lifetime; // 0x274
		private const float DurationMillis = 5500f; // Metadata: 0x0197835F
		private bool _isDespawning; // 0x278
		private Tween _onEnterTween; // 0x280
		private Tween _scaleTween; // 0x288
		private Tween _onLifetimeTween; // 0x290
	
		// Constructors
		public EnemyBullet1() {} // 0x000000018722E9B0-0x000000018722EA10
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x000000018722DF80-0x000000018722E520
		public override void Disappear() {} // 0x000000018722E520-0x000000018722E5B0
		public override void Despawn() {} // 0x000000018722E5B0-0x000000018722E650
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978358 */, float damageKb = 1f /* Metadata: 0x01978359 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x0197835D */, bool hasKb = true /* Metadata: 0x0197835E */) {} // 0x00000001871E3B10-0x00000001871E3B50
		public override void OnPlayerOverlap(CharacterController player) {} // 0x000000018722E650-0x000000018722E680
		private void DeathTween() {} // 0x000000018722E680-0x000000018722E940
		protected override void Die() {} // 0x000000018722E940-0x000000018722E9B0
	}
}

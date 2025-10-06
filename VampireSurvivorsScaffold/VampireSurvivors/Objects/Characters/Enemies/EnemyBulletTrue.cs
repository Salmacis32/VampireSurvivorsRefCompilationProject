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
	public class EnemyBulletTrue : EnemyController // TypeDefIndex: 17278
	{
		// Fields
		private float _lifetime; // 0x270
		private float _myAngle; // 0x274
		private bool _isDespawning; // 0x278
		private Tween _onEnterTween; // 0x280
		private Tween _scaleTween; // 0x288
		private Tween _onLifetimeTween; // 0x290
		private const float DurationMillis = 5500f; // Metadata: 0x0197836A
	
		// Constructors
		public EnemyBulletTrue() {} // 0x000000018722F640-0x000000018722F6A0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x000000018722EB10-0x000000018722F040
		public override void Disappear() {} // 0x000000018722F040-0x000000018722F0D0
		public override void Despawn() {} // 0x000000018722F0D0-0x000000018722F170
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978363 */, float damageKb = 1f /* Metadata: 0x01978364 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01978368 */, bool hasKb = true /* Metadata: 0x01978369 */) {} // 0x0000000180B15170-0x0000000180B15180
		public override void OnPlayerOverlap(CharacterController player) {} // 0x000000018722E650-0x000000018722E680
		protected override void OnUpdate() {} // 0x000000018722F170-0x000000018722F310
		protected override void ProcessWiggle() {} // 0x0000000180B15170-0x0000000180B15180
		private void DeathTween() {} // 0x000000018722F310-0x000000018722F5D0
		protected override void Die() {} // 0x000000018722F5D0-0x000000018722F640
	}
}

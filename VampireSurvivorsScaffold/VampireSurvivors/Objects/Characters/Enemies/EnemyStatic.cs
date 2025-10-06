/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyStatic : EnemyController // TypeDefIndex: 17402
	{
		// Fields
		private MultiTargetTween _onEnterTween; // 0x270
		private float _randomDepthOffset; // 0x278
		private int _prevDepth; // 0x27C
	
		// Constructors
		public EnemyStatic() {} // 0x00000001872A7860-0x00000001872A78C0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872A6EC0-0x00000001872A73C0
		protected override void OnUpdate() {} // 0x00000001872A73C0-0x00000001872A7410
		protected override void UpdateDepth() {} // 0x00000001872A7410-0x00000001872A74A0
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978519 */, float damageKb = 1f /* Metadata: 0x0197851A */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x0197851E */, bool hasKb = true /* Metadata: 0x0197851F */) {} // 0x00000001872A74A0-0x00000001872A77C0
		public override void Despawn() {} // 0x00000001872A77C0-0x00000001872A77F0
		protected override void Die() {} // 0x00000001872A77F0-0x00000001872A7830
		protected override void OnDestroy() {} // 0x00000001872A7830-0x00000001872A7860
	}
}

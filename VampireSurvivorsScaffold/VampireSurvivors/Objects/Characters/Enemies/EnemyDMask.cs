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
	public class EnemyDMask : EnemyController // TypeDefIndex: 17309
	{
		// Fields
		private MultiTargetTween _onEnterTween; // 0x270
		protected bool _isInvul; // 0x278
		private bool _canBreak; // 0x279
		private bool _alreadyBroken; // 0x27A
	
		// Properties
		public bool CanBreak { get => default; set {} } // 0x0000000187259D20-0x0000000187259D30 0x0000000187259D30-0x0000000187259D40
	
		// Constructors
		public EnemyDMask() {} // 0x000000018725A5D0-0x000000018725A620
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187259D40-0x000000018725A060
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978422 */, float damageKb = 1f /* Metadata: 0x01978423 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01978427 */, bool hasKb = true /* Metadata: 0x01978428 */) {} // 0x000000018725A060-0x000000018725A0F0
		public void DisappearMask() {} // 0x00000001872182C0-0x00000001872182D0
		private void BreakMask() {} // 0x000000018725A0F0-0x000000018725A3D0
		public override void Disappear() {} // 0x0000000180B15170-0x0000000180B15180
		public override void Despawn() {} // 0x000000018725A3D0-0x000000018725A400
		public void ScriptedDisappear() {} // 0x00000001872182C0-0x00000001872182D0
		public void BreakOnNextAttack(bool value) {} // 0x0000000187259D30-0x0000000187259D40
		protected override void OnUpdate() {} // 0x000000018725A400-0x000000018725A510
		protected override void UpdateDepth() {} // 0x000000018725A510-0x000000018725A5D0
		protected override void Die() {} // 0x0000000180B15170-0x0000000180B15180
	}
}

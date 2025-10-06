/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemySkelangue : EnemyController // TypeDefIndex: 17382
	{
		// Fields
		private int _lives; // 0x270
		private const string UndieAnimName = "Undie"; // Metadata: 0x019784F0
		private List<Sprite> _frames; // 0x278
	
		// Constructors
		public EnemySkelangue() {} // 0x0000000187299640-0x00000001872996A0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187298D90-0x0000000187299150
		public override void Disappear() {} // 0x0000000187299150-0x00000001872991B0
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019784E9 */, float damageKb = 1f /* Metadata: 0x019784EA */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x019784EE */, bool hasKb = true /* Metadata: 0x019784EF */) {} // 0x00000001872991B0-0x00000001872991F0
		protected override void OnDeathAnimationComplete() {} // 0x00000001872991F0-0x0000000187299460
		private void OnUndieAnimComplete() {} // 0x0000000187299460-0x00000001872995C0
		public override void Despawn() {} // 0x00000001872995C0-0x0000000187299640
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyLegionSection : EnemyController // TypeDefIndex: 17239
	{
		// Fields
		private EnemyLegion _parentBoss; // 0x270
		private int2 _direction; // 0x278
		private bool _isFalling; // 0x280
		private float _fallTimer; // 0x284
	
		// Constructors
		public EnemyLegionSection() {} // 0x0000000187201DE0-0x0000000187201E30
	
		// Methods
		[Command]
		public void OnlineSetupSection(CoherenceSync boss, Vector2 direction) {} // 0x0000000187200D80-0x0000000187200E10
		public void SetupLegionSection(EnemyLegion parentBoss, int2 direction) {} // 0x0000000187200E10-0x00000001872012B0
		public void SetOutlineColour(Color c) {} // 0x00000001872012B0-0x0000000187201330
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019782EB */, float damageKb = 1f /* Metadata: 0x019782EC */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x019782F0 */, bool hasKb = true /* Metadata: 0x019782F1 */) {} // 0x0000000187201330-0x00000001872016E0
		public bool IsMiddleSection() => default; // 0x00000001872016E0-0x0000000187201700
		public override void Disappear() {} // 0x0000000187201700-0x0000000187201810
		protected override void Die() {} // 0x0000000187201810-0x0000000187201920
		protected override void OnUpdate() {} // 0x0000000187201920-0x0000000187201B40
		public void UpdateSection() {} // 0x0000000187201B40-0x0000000187201DE0
	}
}

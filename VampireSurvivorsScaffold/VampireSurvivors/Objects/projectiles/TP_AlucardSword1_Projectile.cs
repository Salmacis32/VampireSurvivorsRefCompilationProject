/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_AlucardSword1_Projectile : Projectile // TypeDefIndex: 15499
	{
		// Fields
		private SpriteAnimation _anim; // 0xD0
		private bool _cachedFlipX; // 0xD8
		private const int AnimFPS = 50; // Metadata: 0x0197764A
		private const float XOffset = 0.14f; // Metadata: 0x0197764B
		private const float XRepeatOffset = 0.16f; // Metadata: 0x0197764F
		private const float YOffset = 0.26f; // Metadata: 0x01977653
	
		// Constructors
		public TP_AlucardSword1_Projectile() {} // 0x0000000186C60D50-0x0000000186C60DA0
	
		// Methods
		protected override void Awake() {} // 0x0000000186C605D0-0x0000000186C60800
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C60800-0x0000000186C60D40
		public override void InternalUpdate() {} // 0x0000000180B15170-0x0000000180B15180
		public override void Despawn() {} // 0x0000000186C60D40-0x0000000186C60D50
		protected virtual void OnAnimAttackComplete() {} // 0x0000000186BB8730-0x0000000186BB8750
	}
}

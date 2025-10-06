/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_WhipCore1_Weapon : Weapon // TypeDefIndex: 16511
	{
		// Fields
		protected WeaponType _weaponNodeType; // 0x158
		protected BulletPool _nodePool; // 0x160
		protected int _fireCounter; // 0x168
		protected int _specialCounter; // 0x16C
		protected int _subWeaponCounter; // 0x170
	
		// Constructors
		public TP_WhipCore1_Weapon() {} // 0x0000000186FFCCE0-0x0000000186FFCD50
	
		// Methods
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977D1C */) {} // 0x0000000186FFC760-0x0000000186FFC8F0
		public virtual void OnSpecialCounter(bool skipTriggers = false /* Metadata: 0x01977D1D */) {} // 0x0000000180B15170-0x0000000180B15180
		public virtual void OnSubWeaponCounter(bool skipTriggers = false /* Metadata: 0x01977D1E */) {} // 0x0000000180B15170-0x0000000180B15180
		public Projectile CreateNodeProjectile(float2 pos, int enemiesHit = 0 /* Metadata: 0x01977D1F */, int damage = 1 /* Metadata: 0x01977D20 */, float area = 1f /* Metadata: 0x01977D21 */) => default; // 0x0000000186FFC8F0-0x0000000186FFCC60
		protected override void OnDestroy() {} // 0x0000000186FFCC60-0x0000000186FFCCE0
		public override void Cleanup() {} // 0x0000000186FD74D0-0x0000000186FD7500
	}
}

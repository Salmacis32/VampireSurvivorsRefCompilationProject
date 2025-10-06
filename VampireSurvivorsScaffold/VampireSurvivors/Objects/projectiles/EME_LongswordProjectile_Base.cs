/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_LongswordProjectile_Base : Projectile // TypeDefIndex: 15796
	{
		// Fields
		protected float Radius; // 0xD0
		private PhaserSprite _animatedSprite; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0xE0
		private MultiTargetTween _fadeOutTween; // 0xE8
	
		// Constructors
		public EME_LongswordProjectile_Base() {} // 0x0000000186DBC920-0x0000000186DBC980
	
		// Methods
		protected override void Awake() {} // 0x0000000186DBB280-0x0000000186DBB760
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DBB760-0x0000000186DBB960
		private void SetupMechanics() {} // 0x0000000186DBB960-0x0000000186DBBC10
		private void SetupVisuals() {} // 0x0000000186DBBC10-0x0000000186DBBCB0
		public override void InternalUpdate() {} // 0x0000000186DBBCB0-0x0000000186DBBCC0
		private void UpdatePositionAndScale() {} // 0x0000000186DBBCC0-0x0000000186DBC870
		public override void Despawn() {} // 0x0000000186DBC870-0x0000000186DBC920
	}
}

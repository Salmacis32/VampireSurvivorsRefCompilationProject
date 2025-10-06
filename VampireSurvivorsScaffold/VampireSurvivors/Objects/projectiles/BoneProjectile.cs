/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class BoneProjectile : Projectile // TypeDefIndex: 15398
	{
		// Fields
		private Tween _angleTween; // 0xD0
		private Tween _scaleTween; // 0xD8
		private float _saveVelX; // 0xE0
		private float _saveVelY; // 0xE4
		private VampireSurvivors.Framework.TimerSystem.Timer _bounceTimer; // 0xE8
		private bool _canBounce; // 0xF0
		[NonSerialized]
		public float _physBounce; // 0xF4
		[NonSerialized]
		public bool _accelOnBounce; // 0xF8
	
		// Constructors
		public BoneProjectile() {} // 0x0000000186BBBCD0-0x0000000186BBBD30
	
		// Methods
		protected override void Awake() {} // 0x0000000186BBABC0-0x0000000186BBACE0
		protected override void OnDestroy() {} // 0x0000000186BBACE0-0x0000000186BBAD80
		public void BounceMore() {} // 0x0000000186BBAD80-0x0000000186BBADC0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BBADC0-0x0000000186BBB720
		public override void InternalUpdate() {} // 0x0000000186BBB720-0x0000000186BBB780
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186BBB780-0x0000000186BBB9F0
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186BBB9F0-0x0000000186BBBAD0
		private void Bounce(Body bdy, bool up, bool down, bool left, bool right) {} // 0x0000000186BBBAD0-0x0000000186BBBB60
		public override void Despawn() {} // 0x0000000186BBBB60-0x0000000186BBBCD0
	}
}

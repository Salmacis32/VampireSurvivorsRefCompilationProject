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
	public class EME_WaveProjectile : Projectile // TypeDefIndex: 15847
	{
		// Fields
		private Tween _scaleTween; // 0xD0
		private float _saveVelX; // 0xD8
		private float _saveVelY; // 0xDC
		private VampireSurvivors.Framework.TimerSystem.Timer _bounceTimer; // 0xE0
		private bool _canBounce; // 0xE8
	
		// Constructors
		public EME_WaveProjectile() {} // 0x0000000186DEBE80-0x0000000186DEBED0
	
		// Methods
		protected override void Awake() {} // 0x0000000186DEB370-0x0000000186DEB490
		protected override void OnDestroy() {} // 0x0000000186DEB490-0x0000000186DEB510
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DEB510-0x0000000186DEBAF0
		public override void InternalUpdate() {} // 0x0000000186DEBAF0-0x0000000186DEBB50
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186DEBB50-0x0000000186DEBD60
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186DEBD60-0x0000000186DEBE00
		private void Bounce(Body bdy, bool up, bool down, bool left, bool right) {} // 0x0000000180B15170-0x0000000180B15180
		public override void Despawn() {} // 0x0000000186DEBE00-0x0000000186DEBE80
	}
}

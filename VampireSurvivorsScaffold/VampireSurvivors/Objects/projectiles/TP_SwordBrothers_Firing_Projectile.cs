/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_SwordBrothers_Firing_Projectile : Projectile // TypeDefIndex: 15696
	{
		// Fields
		private MultiTargetTween _alphaTween; // 0xD0
		private bool lockOnOwner; // 0xD8
		private PhaserSprite _displaySprite; // 0xE0
	
		// Constructors
		public TP_SwordBrothers_Firing_Projectile() {} // 0x0000000186D3A3A0-0x0000000186D3A400
	
		// Methods
		protected override void Awake() {} // 0x0000000186D39AB0-0x0000000186D39E40
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D39E40-0x0000000186D39FE0
		public override void InternalUpdate() {} // 0x0000000186D39FE0-0x0000000186D3A050
		public void SetSwordAngle(float angleValue) {} // 0x0000000186D3A050-0x0000000186D3A090
		public void ShootOff() {} // 0x0000000186D3A090-0x0000000186D3A350
		public override void Despawn() {} // 0x0000000186D3A350-0x0000000186D3A3A0
	}
}

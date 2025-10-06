/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class FlashArrowWeapon : Weapon, IMillionaire // TypeDefIndex: 16162
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _rangedAnimEvent; // 0x158
	
		// Constructors
		public FlashArrowWeapon() {} // 0x0000000186F33F50-0x0000000186F33FA0
	
		// Methods
		public override float PPower() => default; // 0x0000000186F333E0-0x0000000186F33480
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F33480-0x0000000186F334B0
		protected override void OnStart() {} // 0x0000000186F334B0-0x0000000186F334D0
		public void PlayNextRangedAnim() {} // 0x0000000186F334D0-0x0000000186F33610
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977B9B */) {} // 0x0000000186F33610-0x0000000186F33730
		public void Millionaire(float x, float y, float angle, int times = 4 /* Metadata: 0x01977B9C */) {} // 0x0000000180B15170-0x0000000180B15180
		public override void CheckArcanas() {} // 0x0000000186F33730-0x0000000186F33A30
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F33A30-0x0000000186F33A80
		public override void Cleanup() {} // 0x0000000186F33A80-0x0000000186F33AB0
		public void FireVolley(Vector2 pos, int _amount, Transform target = null) {} // 0x0000000186F33AB0-0x0000000186F33F50
	}
}

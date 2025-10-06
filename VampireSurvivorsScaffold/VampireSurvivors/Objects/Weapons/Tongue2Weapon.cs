/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class Tongue2Weapon : TongueWeapon // TypeDefIndex: 16216
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _assassinationSprite; // 0x178
		[SerializeField]
		private SpriteAnimation _assassinationAnim; // 0x180
		private VampireSurvivors.Framework.TimerSystem.Timer _specialAttackTimer; // 0x188
		private float _lastSpecialDelay; // 0x190
		private float _specialDelay; // 0x194
		protected SfxType[] s_sounds; // 0x198
	
		// Constructors
		public Tongue2Weapon() {} // 0x0000000186F68E00-0x0000000186F68EE0
	
		// Methods
		protected override void Awake() {} // 0x0000000186F66DD0-0x0000000186F66E80
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F66E80-0x0000000186F67430
		private void OnSlashAnimComplete() {} // 0x0000000186F67430-0x0000000186F674A0
		private float GetSpecialDelay() => default; // 0x0000000186F674A0-0x0000000186F674F0
		private void ResetSpecialAttackTimer() {} // 0x0000000186F674F0-0x0000000186F67650
		private EnemyController GetMostDistantStrongestEnemy() => default; // 0x0000000186F67650-0x0000000186F67B30
		private void DoSpecialAttack() {} // 0x0000000186F67B30-0x0000000186F68330
		protected void Assassinate(EnemyController target, float previousTargetScale) {} // 0x0000000186F68330-0x0000000186F68870
		protected override bool CanLickBackwards() => default; // 0x0000000181958370-0x0000000181958380
		protected override bool SupportCounterWeapon() => default; // 0x0000000181958370-0x0000000181958380
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F68870-0x0000000186F68AF0
		public override void CheckArcanas() {} // 0x0000000186F68AF0-0x0000000186F68E00
	}
}

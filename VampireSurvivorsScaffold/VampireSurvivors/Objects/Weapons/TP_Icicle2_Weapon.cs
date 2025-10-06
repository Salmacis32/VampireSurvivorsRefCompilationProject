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
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Icicle2_Weapon : Weapon // TypeDefIndex: 16406
	{
		// Fields
		[SerializeField]
		private Projectile _LaunchProjectilePrefab; // 0x158
		[SerializeField]
		private Projectile _RuneProjectilePrefab; // 0x160
		[SerializeField]
		private Transform _RuneContainer; // 0x168
		private VampireSurvivors.Framework.TimerSystem.Timer _runeTimer; // 0x188
	
		// Properties
		public float ProjScale { get => default; } // 0x0000000186FD1900-0x0000000186FD1930 
		public Transform RuneContainer { get => default; } // 0x00000001829176E0-0x00000001829176F0 
		private float RuneZRotSpeed { get => default; } // 0x0000000186FD1930-0x0000000186FD1970 
		public int NumRunes { get; private set; } // 0x00000001827669C0-0x00000001827669D0 0x0000000186EDD140-0x0000000186EDD150
		public BulletPool LaunchProjectilePool { get; private set; } // 0x0000000182917A20-0x0000000182917A30 0x0000000185637EC0-0x0000000185637F20
		public BulletPool RuneProjectilePool { get; private set; } // 0x00000001826DB9D0-0x00000001826DB9E0 0x00000001826DB9E0-0x00000001826DBA40
	
		// Constructors
		public TP_Icicle2_Weapon() {} // 0x0000000186FD3050-0x0000000186FD30A0
	
		// Methods
		protected override void Awake() {} // 0x0000000186FD1970-0x0000000186FD1990
		protected override void OnStart() {} // 0x0000000186FD1990-0x0000000186FD1F00
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FD1F00-0x0000000186FD2020
		private void StartRuneTimer() {} // 0x0000000186FD2020-0x0000000186FD2130
		public override float PArea() => default; // 0x0000000186FD2130-0x0000000186FD2190
		public override float SecondaryPPower() => default; // 0x0000000186FD2190-0x0000000186FD21D0
		public override float SecondaryPAmount() => default; // 0x0000000186FD21D0-0x0000000186FD2230
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target, BulletPool pool = null) => default; // 0x0000000186FD2230-0x0000000186FD2370
		public override void InternalUpdate() {} // 0x0000000186FD2370-0x0000000186FD2390
		private void UpdateRuneContainer() {} // 0x0000000186FD2390-0x0000000186FD2570
		private void UpdateRuneAmount() {} // 0x0000000186FD2570-0x0000000186FD2DF0
		public override void CheckArcanas() {} // 0x0000000186FD2DF0-0x0000000186FD2F60
		public override void SetVisible(bool visible) {} // 0x0000000186FD2F60-0x0000000186FD3020
		public override void Cleanup() {} // 0x0000000186FD3020-0x0000000186FD3050
	}
}

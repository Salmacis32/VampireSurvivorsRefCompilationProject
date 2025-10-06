/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_ClockTower_Weapon : Weapon // TypeDefIndex: 16289
	{
		// Fields
		private TP_Gear_Weapon _weaponGears; // 0x158
		private TP_Pendulum_Weapon _weaponPendulum; // 0x160
		private TP_Elevator_Weapon _weaponElevator; // 0x168
		private TP_Heads_Weapon _weaponHeads; // 0x170
		private bool _totalDamageCalculated; // 0x178
		private MultiTargetTween _screenShakeTween; // 0x180
	
		// Constructors
		public TP_ClockTower_Weapon() {} // 0x0000000186F910B0-0x0000000186F91100
	
		// Methods
		protected override void Awake() {} // 0x0000000186F8F2B0-0x0000000186F8F680
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F8F680-0x0000000186F90EC0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C2F */) {} // 0x0000000180B15170-0x0000000180B15180
		public override float CalculateTotalDamage() => default; // 0x0000000186F90EC0-0x0000000186F90F50
		public override void Cleanup() {} // 0x0000000186F90F50-0x0000000186F91000
		public override void SetVisible(bool visible) {} // 0x0000000186F91000-0x0000000186F910B0
	}
}

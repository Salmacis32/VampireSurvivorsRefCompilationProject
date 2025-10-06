/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class Silf3Weapon : SilfWeapon // TypeDefIndex: 16771
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _TargetZone2; // 0x1F8
		protected Circle _damageZone2; // 0x200
		protected WeaponType _counterWeaponType1; // 0x208
		protected WeaponType _counterWeaponType2; // 0x20C
		protected Weapon _counterWeapon1; // 0x210
		protected Weapon _counterWeapon2; // 0x218
	
		// Constructors
		public Silf3Weapon() {} // 0x00000001870B5430-0x00000001870B54A0
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x00000001870B3DE0-0x00000001870B4040
		public override void InternalUpdate() {} // 0x00000001870B4040-0x00000001870B43D0
		public override void CheckArcanas() {} // 0x00000001870B43D0-0x00000001870B4970
		public override bool LevelUp() => default; // 0x00000001870B4970-0x00000001870B4C20
		public override bool ApplyLimitBreak(WeightedLimitBreak weightedLimitBreak) => default; // 0x00000001870B4C20-0x00000001870B4ED0
		public override void SetVisible(bool visible) {} // 0x00000001870B4ED0-0x00000001870B5000
		protected override void AddTargets() {} // 0x00000001870B5000-0x00000001870B51C0
		protected override void BlockFire() {} // 0x00000001870B51C0-0x00000001870B5360
		protected override void UnblockFire() {} // 0x00000001870B5360-0x00000001870B5430
	}
}

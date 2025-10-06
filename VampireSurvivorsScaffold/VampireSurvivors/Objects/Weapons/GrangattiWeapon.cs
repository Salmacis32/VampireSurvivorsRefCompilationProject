/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class GrangattiWeapon : Weapon // TypeDefIndex: 16697
	{
		// Fields
		private List<float> _RANDOMS; // 0x158
		private int _randomIndex; // 0x160
		private int _plusMinusIndex; // 0x164
		private List<float> _PLUSMINUS; // 0x168
		private double _chanceBonus; // 0x170
		private int _success; // 0x178
		private int _fail; // 0x17C
		private static VampireSurvivors.Data.ItemType[] _gold; // 0x00
		private static VampireSurvivors.Data.ItemType[] _edible; // 0x08
		private static VampireSurvivors.Data.ItemType[] _ignore; // 0x10
		protected WeaponType _counterWeaponType; // 0x180
		protected Weapon _counterWeapon; // 0x188
		public double goldChance; // 0x190
	
		// Constructors
		public GrangattiWeapon() {} // 0x0000000187089220-0x00000001870892A0
		static GrangattiWeapon() {} // 0x00000001870892A0-0x00000001870894E0
	
		// Methods
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000187086F70-0x0000000187087270
		public override void CheckArcanas() {} // 0x0000000187087270-0x0000000187087AB0
		public override bool LevelUp() => default; // 0x0000000187087AB0-0x0000000187087BD0
		public override bool ApplyLimitBreak(WeightedLimitBreak weightedLimitBreak) => default; // 0x0000000187087BD0-0x0000000187087CF0
		public float GetRandom() => default; // 0x0000000187087CF0-0x0000000187087D90
		public float GetPlusMinus() => default; // 0x0000000187087D90-0x0000000187087E30
		protected override void OnStart() {} // 0x0000000187087E30-0x0000000187088210
		public bool OnBulletOverlapsPickup(CallbackContext context, ArcadeColliderType left, ArcadeColliderType right) => default; // 0x0000000187088210-0x0000000187088660
		public bool OnBulletOverlapsEnemyNoKB(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000187088660-0x0000000187088840
		public bool TurnToGold(ArcadeSprite target, bool certain = false /* Metadata: 0x01977DDE */) => default; // 0x0000000187088840-0x0000000187088B10
		protected override void MakeLevelOne() {} // 0x0000000187088B10-0x0000000187089220
	}
}

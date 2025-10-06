/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Loot;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pickups;
using VampireSurvivors.Objects.VFX;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	public class ArcanaManager_Support // TypeDefIndex: 17446
	{
		// Fields
		private const float goldenRatio = 1.618034f; // Metadata: 0x019785AE
		private static int _foodSfxIndex; // 0x00
		private static float[] _foodDetunes; // 0x08
		private List<float> _sapphireMistChances; // 0x10
		private int _sapphireMistIndex; // 0x18
		private float _sapphireMistBaseChance; // 0x1C
		private float _baseCandyboxChance; // 0x28
		private float _foundCandyboxes; // 0x2C
		private float _baseArmadioChance; // 0x30
		private float _foundArmadios; // 0x34
		private List<float> _hailFromFutureChances; // 0x38
		private int _hailFromFutureIndex; // 0x40
		private Dictionary<WeaponType, List<float>> _breadBonusList; // 0x48
		private Dictionary<WeaponType, int> _bonusTimes; // 0x50
		private VampireSurvivors.Framework.TimerSystem.Timer _food_sequentialTimer; // 0x58
		private float _food_angleInc; // 0x60
		private float _food_angleMul; // 0x64
		private float _food_BonusTimer; // 0x68
		private float _food_BonusDelay; // 0x6C
		private List<VampireSurvivors.Objects.Characters.CharacterController> _food_CharacterBonuses; // 0x70
	
		// Properties
		public WeightedStore HailFromTheFutureWeightedStore { get; set; } // 0x0000000180B15530-0x0000000180B15540 0x0000000180B1C120-0x0000000180B1C180
	
		// Constructors
		public ArcanaManager_Support() {} // 0x00000001872CD140-0x00000001872CE800
		static ArcanaManager_Support() {} // 0x00000001872CE800-0x00000001872CE900
	
		// Methods
		private static float GetDetune() => default; // 0x00000001872CB200-0x00000001872CB2B0
		public void Initialize() {} // 0x00000001872CB2B0-0x00000001872CB3F0
		public void MakeHailFromTheFutureWeightedStore(bool force = false /* Metadata: 0x019785AD */) {} // 0x00000001872CB3F0-0x00000001872CB530
		public bool IsSapphireMistSuccessful(VampireSurvivors.Objects.Characters.CharacterController character) => default; // 0x00000001872CB530-0x00000001872CB600
		public void SendHailFromTheFutureGift(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x00000001872CB600-0x00000001872CBE80
		public void SendGift(Vector2 startPosition, Vector2 endPosition, VampireSurvivors.Data.ItemType itemType, WeaponType weaponType) {} // 0x00000001872CBE80-0x00000001872CC480
		private void OnGiftLanded(SpinningIcosahedron gift, VampireSurvivors.Data.ItemType itemToSpawn, WeaponType weaponType, float x, float y) {} // 0x00000001872CC480-0x00000001872CC880
		public void OnFoodPickedUp(VampireSurvivors.Objects.Characters.CharacterController character, VampireSurvivors.Data.ItemType itemType, float value) {} // 0x00000001872CC880-0x00000001872CCAC0
		public void Update() {} // 0x00000001872CCAC0-0x00000001872CD140
		private void AddAttribute(VampireSurvivors.Objects.Characters.CharacterController character, WeaponType weaponType, float value) {} // 0x0000000186EDFD60-0x0000000186EE01C0
	}
}

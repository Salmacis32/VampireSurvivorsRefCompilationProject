/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterControllerGazebo : CharacterController // TypeDefIndex: 16936
	{
		// Fields
		private float OverhealTriggerValue; // 0x3F0
		private VampireSurvivors.Framework.TimerSystem.Timer _overHealTimer; // 0x3F8
		private List<WeaponBonusPair> _earlyBonusList; // 0x400
		private List<WeaponBonusPair> _crapBonusList; // 0x408
		private List<WeaponBonusPair> _obtainedBonusList; // 0x410
		private int maxBonusTimes; // 0x418
		private float cachedSize; // 0x41C
		private VampireSurvivors.Framework.TimerSystem.Timer _food_sequentialTimer; // 0x420
		private float _food_BonusTimer; // 0x428
		private float _food_BonusDelay; // 0x42C
	
		// Constructors
		public CharacterControllerGazebo() {} // 0x000000018710DD50-0x000000018710DF20
	
		// Methods
		public override void AfterFullInitialization() {} // 0x000000018710C160-0x000000018710D3D0
		protected override void OnUpdate() {} // 0x000000018710D3D0-0x000000018710D720
		private void ApplyBonus(WeaponType weapon, float value, float bonusSize) {} // 0x000000018710D720-0x000000018710D980
		[Command]
		public void AddAttributeOnline(int weaponType, float value, float bonusSize) {} // 0x000000018710D980-0x000000018710D990
		private void InitBonuses(WeaponType weaponType, float bonusValue, int times, List<WeaponBonusPair> _list) {} // 0x000000018710D990-0x000000018710DA80
		private void CharacterHealed(float value, float rawValue) {} // 0x000000018710DA80-0x000000018710DBC0
		public bool CheckAchievementStats() => default; // 0x000000018710DBC0-0x000000018710DC20
		private void AddBonusToQueue() {} // 0x000000018710DC20-0x000000018710DD50
		private void AddAttribute(CharacterController character, WeaponType weaponType, float value) {} // 0x0000000186EDFD60-0x0000000186EE01C0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class FB_Bill : CharacterController_FirstBlood // TypeDefIndex: 17015
	{
		// Fields
		private int enemyKilledCounter; // 0x410
		private float mightCounter; // 0x414
		private float speedCounter; // 0x418
		private float speedAdded; // 0x41C
		private float maxSpeed; // 0x420
	
		// Constructors
		public FB_Bill() {} // 0x000000018714A370-0x000000018714A3A0
	
		// Methods
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977FCA */) {} // 0x0000000187149E40-0x0000000187149EF0
		public override void OnQuit() {} // 0x0000000187149EF0-0x0000000187149FA0
		public void OnEnemyKilled() {} // 0x0000000187149FA0-0x000000018714A0B0
		private void HandleEquipment(WeaponType weaponType, float value, float delay = 0f /* Metadata: 0x01977FCB */) {} // 0x000000018714A0B0-0x000000018714A370
	}
}

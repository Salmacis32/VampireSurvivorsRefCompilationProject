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
	public class FB_Lance : CharacterController_FirstBlood // TypeDefIndex: 17020
	{
		// Fields
		private int enemyKilledCounter; // 0x410
		private float cooldownCounter; // 0x414
		private float speedCounter; // 0x418
		private float cooldownAdded; // 0x41C
		private float speedAdded; // 0x420
		private float maxCooldown; // 0x424
		private float maxSpeed; // 0x428
	
		// Constructors
		public FB_Lance() {} // 0x000000018714B390-0x000000018714B3C0
	
		// Methods
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977FD0 */) {} // 0x000000018714AE10-0x000000018714AEC0
		public override void OnQuit() {} // 0x000000018714AEC0-0x000000018714AF70
		public void OnEnemyKilled() {} // 0x000000018714AF70-0x000000018714B0D0
		private void HandleEquipment(WeaponType weaponType, float value, float delay = 0f /* Metadata: 0x01977FD1 */) {} // 0x000000018714B0D0-0x000000018714B390
	}
}

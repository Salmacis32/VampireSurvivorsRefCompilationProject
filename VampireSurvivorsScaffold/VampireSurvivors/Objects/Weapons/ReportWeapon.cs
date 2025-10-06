/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class ReportWeapon : Weapon // TypeDefIndex: 16205
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _reportImage; // 0x158
		[SerializeField]
		private GameObject _deadBodyDisplay; // 0x160
		[SerializeField]
		private SpriteRenderer _deadCharacterSprite; // 0x168
		[SerializeField]
		private SpriteRenderer _deadCharacterShadowSprite; // 0x170
		private List<VampireSurvivors.Objects.Characters.CharacterController> _reportedPlayers; // 0x178
		private bool _isSendingBodyReport; // 0x180
	
		// Constructors
		public ReportWeapon() {} // 0x0000000186F5E710-0x0000000186F5E800
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F5D7F0-0x0000000186F5D850
		public override void InternalUpdate() {} // 0x0000000186F5D850-0x0000000186F5DDE0
		public void ReportBody(VampireSurvivors.Objects.Characters.CharacterController character = null) {} // 0x0000000186F5DDE0-0x0000000186F5DEC0
		private void PerformReport(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x0000000186F5DEC0-0x0000000186F5E5E0
		private void Unfreeze() {} // 0x0000000186F5E5E0-0x0000000186F5E710
	}
}

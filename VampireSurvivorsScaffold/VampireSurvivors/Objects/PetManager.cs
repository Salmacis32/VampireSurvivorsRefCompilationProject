/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public class PetManager : GameMonoBehaviour // TypeDefIndex: 15083
	{
		// Fields
		private List<PetInstance> _pets; // 0x28
		private VampireSurvivors.Objects.Characters.CharacterController _owner; // 0x30
	
		// Constructors
		public PetManager() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		public void Init(VampireSurvivors.Objects.Characters.CharacterController owner) {} // 0x00000001869EF730-0x00000001869EF850
		public PetInstance AddPet(Equipment baseEquipment, Equipment hiddenWeapon, SpriteRenderer petSprite, float petOffset) => default; // 0x00000001869EF850-0x00000001869EFB20
		public List<PetInstance> GetPets() => default; // 0x0000000180B15540-0x0000000180B15550
		protected override void OnUpdate() {} // 0x00000001869EFB20-0x00000001869EFC70
	}
}

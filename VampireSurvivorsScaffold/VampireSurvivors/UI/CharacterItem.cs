/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Characters;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class CharacterItem // TypeDefIndex: 14720
	{
		// Fields
		private PlayerOptions _playerOptions; // 0x10
		private VampireSurvivors.Data.CharacterType _characterType; // 0x18
		private CharacterData _characterData; // 0x20
		private UIUnlockStates _unlockState; // 0x28
		private Dictionary<SkinType, SkinItem> _skinItems; // 0x30
	
		// Properties
		public UIUnlockStates UnlockState { get => default; } // 0x0000000181FFD1B0-0x0000000181FFD1C0 
		public VampireSurvivors.Data.CharacterType CharacterType { get => default; } // 0x00000001819457C0-0x00000001819457D0 
		public CharacterData CharacterData { get => default; } // 0x0000000180B15530-0x0000000180B15540 
	
		// Constructors
		public CharacterItem() {} // Dummy constructor
		public CharacterItem(PlayerOptions playerOptions, VampireSurvivors.Data.CharacterType characterType, CharacterData characterData) {} // 0x000000018684EE10-0x000000018684F290
	
		// Methods
		public void RefreshUnlockState() {} // 0x000000018684F290-0x000000018684F5D0
		public SkinItem GetCurrentSkinItem() => default; // 0x000000018684F5D0-0x000000018684F680
		public Dictionary<SkinType, SkinItem> GetSkinItems() => default; // 0x0000000180B15550-0x0000000180B15560
		public bool CanSeeSecrets() => default; // 0x000000018684F680-0x000000018684F740
		public bool IsCharacterAlwaysHidden() => default; // 0x000000018684F740-0x000000018684F760
		public bool IsCharacterSecret() => default; // 0x000000018684F760-0x000000018684F780
		public bool IsCharacterHidden() => default; // 0x000000018684F780-0x000000018684F7A0
		public bool IsCharacterBought() => default; // 0x000000018684F7A0-0x000000018684F980
		public bool IsCharacterCoffinOpen() => default; // 0x000000018684F980-0x000000018684FB20
		public bool IsCharacterUnlocked() => default; // 0x000000018684FB20-0x000000018684FD00
		public bool HasCharacterRequirements() => default; // 0x000000018684FD00-0x000000018684FDC0
		public bool HasCharacterRequirementsOrUnlock() => default; // 0x000000018684FDC0-0x000000018684FEB0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Characters;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class SkinItem // TypeDefIndex: 14979
	{
		// Fields
		private PlayerOptions _playerOptions; // 0x10
		private VampireSurvivors.Data.CharacterType _characterType; // 0x18
		private CharacterData _characterData; // 0x20
		private SkinType _skinType; // 0x28
		private Skin _skinData; // 0x30
		private UIUnlockStates _unlockState; // 0x38
	
		// Properties
		public UIUnlockStates UnlockState { get => default; } // 0x0000000181E091A0-0x0000000181E091B0 
		public VampireSurvivors.Data.CharacterType CharacterType { get => default; } // 0x00000001819457C0-0x00000001819457D0 
		public CharacterData CharacterData { get => default; } // 0x0000000180B15530-0x0000000180B15540 
		public SkinType SkinType { get => default; } // 0x0000000181FFD1B0-0x0000000181FFD1C0 
		public Skin SkinData { get => default; } // 0x0000000180B15550-0x0000000180B15560 
	
		// Constructors
		public SkinItem() {} // Dummy constructor
		public SkinItem(PlayerOptions playerOptions, VampireSurvivors.Data.CharacterType characterType, CharacterData characterData, SkinType skinType, Skin skinData) {} // 0x00000001869694E0-0x0000000186969600
	
		// Methods
		public void RefreshUnlockState() {} // 0x0000000186969600-0x00000001869697D0
		public bool CanSeeSecrets() => default; // 0x000000018684F680-0x000000018684F740
		public bool IsSkinAlwaysHidden() => default; // 0x00000001869697D0-0x00000001869697F0
		public bool IsSkinSecret() => default; // 0x00000001869697F0-0x0000000186969810
		public bool IsSkinHidden() => default; // 0x0000000186969810-0x0000000186969830
		public bool IsSkinBought() => default; // 0x0000000186969830-0x0000000186969890
		public bool IsSkinCoffinOpen() => default; // 0x0000000186969890-0x00000001869698F0
		public bool IsSkinUnlocked() => default; // 0x00000001869698F0-0x00000001869699E0
	}
}

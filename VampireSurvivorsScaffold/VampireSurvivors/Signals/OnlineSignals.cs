/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Signals
{
	public static class OnlineSignals // TypeDefIndex: 14393
	{
		// Nested types
		public struct OnlineLevelUpReRollRequested // TypeDefIndex: 14356
		{
		}
	
		public struct OnlineLevelUpReRoll // TypeDefIndex: 14357
		{
			// Fields
			public List<WeaponType> ChosenWeapons; // 0x00
		}
	
		public struct RequestOnlineLevelUpPass // TypeDefIndex: 14358
		{
		}
	
		public struct OnlineLevelUpPass // TypeDefIndex: 14359
		{
			// Fields
			public bool ShowStats; // 0x00
		}
	
		public struct OnlineLevelUpSkip // TypeDefIndex: 14360
		{
		}
	
		public struct OnlineLevelUpWithItem // TypeDefIndex: 14361
		{
			// Fields
			public VampireSurvivors.Data.ItemType ItemType; // 0x00
			public CharacterController ReceivingCharacter; // 0x08
		}
	
		public struct OnlineLevelUpWithFriendshipAmulet // TypeDefIndex: 14362
		{
		}
	
		public struct OnlineLevelUpWithLimitBreak // TypeDefIndex: 14363
		{
			// Fields
			public int ChosenLimitBreakIndex; // 0x00
			public bool AlwaysRandomLimitBreak; // 0x04
			public CharacterController ReceivingCharacter; // 0x08
		}
	
		public struct OnlinePurchase // TypeDefIndex: 14364
		{
			// Fields
			public WeaponType Weapon; // 0x00
			public VampireSurvivors.Data.ItemType Item; // 0x04
			public int Index; // 0x08
			public int Price; // 0x0C
			public CharacterController PurchasingPlayer; // 0x10
		}
	
		public struct OnlineCloseItemFoundPage // TypeDefIndex: 14365
		{
			// Fields
			public bool Discard; // 0x00
		}
	
		public struct OnlineSelectedArcana // TypeDefIndex: 14366
		{
			// Fields
			public int Arcana; // 0x00
		}
	
		public struct OnlineSelectedCharacterCard // TypeDefIndex: 14367
		{
			// Fields
			public int Arcana; // 0x00
			public int Edition; // 0x04
			public int SubCardType; // 0x08
		}
	
		public struct OnlineReRolledArcanas // TypeDefIndex: 14368
		{
		}
	
		public struct OnlineReRolledCharacterCards // TypeDefIndex: 14369
		{
		}
	
		public struct OnlineBoosterSurvarots // TypeDefIndex: 14370
		{
		}
	
		public struct OnlineSkipTreasureAnim // TypeDefIndex: 14371
		{
		}
	
		public struct SelectCandyBoxWeapon // TypeDefIndex: 14372
		{
			// Fields
			public WeaponType Weapon; // 0x00
		}
	
		public struct SelectTPWeapon // TypeDefIndex: 14373
		{
			// Fields
			public WeaponType Weapon; // 0x00
		}
	
		public struct SkipTpWeapon // TypeDefIndex: 14374
		{
		}
	
		public struct SkipCandyBox // TypeDefIndex: 14375
		{
		}
	
		public struct SelectLevelUpBonus // TypeDefIndex: 14376
		{
			// Fields
			public PowerUpType LevelUpBonus; // 0x00
		}
	
		public struct SkipLevelBonus // TypeDefIndex: 14377
		{
		}
	
		public struct SuccessfulPianoSignal // TypeDefIndex: 14378
		{
		}
	
		public struct ExitPianoSignal // TypeDefIndex: 14379
		{
		}
	
		public struct RightCoffinOpened // TypeDefIndex: 14380
		{
		}
	
		public struct TouchedPianoKeySignal // TypeDefIndex: 14381
		{
			// Fields
			public int Key; // 0x00
		}
	
		public struct RevealCharacter // TypeDefIndex: 14382
		{
		}
	
		public struct CollectCharacter // TypeDefIndex: 14383
		{
		}
	
		public struct DirecterTooEasy // TypeDefIndex: 14384
		{
		}
	
		public struct DirecterTooHard // TypeDefIndex: 14385
		{
		}
	
		public struct DirecterOkayButton // TypeDefIndex: 14386
		{
		}
	
		public struct OnDirecterStageSwitch // TypeDefIndex: 14387
		{
			// Fields
			public int Stage; // 0x00
		}
	
		public struct CharacterDisconnected // TypeDefIndex: 14388
		{
			// Fields
			public CharacterController DisconnectedPlayer; // 0x00
		}
	
		public struct ForceCloseUi // TypeDefIndex: 14389
		{
		}
	
		public struct ArcanaModeTransition // TypeDefIndex: 14390
		{
		}
	
		public struct MadMoonSpin // TypeDefIndex: 14391
		{
			// Fields
			public string result; // 0x00
		}
	
		public struct WestwoodsSpin // TypeDefIndex: 14392
		{
			// Fields
			public int _seed; // 0x00
		}
	}
}

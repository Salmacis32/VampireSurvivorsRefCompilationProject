/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Connection;
using UnityEngine;
using UnityEngine.Serialization;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Signals
{
	public static class GameplaySignals // TypeDefIndex: 14355
	{
		// Nested types
		public struct InitializeGameSessionSignal // TypeDefIndex: 14302
		{
		}
	
		public struct PreInitializeGameSessionSignal // TypeDefIndex: 14303
		{
		}
	
		public struct GameSessionInitializedSignal // TypeDefIndex: 14304
		{
		}
	
		public struct ResetGameSessionSignal // TypeDefIndex: 14305
		{
		}
	
		public struct TimeStopSignal // TypeDefIndex: 14306
		{
			// Fields
			public bool IgnoreMovementFreezeFromTimeStop; // 0x00
			public bool SkipStandardVFX; // 0x01
		}
	
		public struct ChangeSpectateSignal // TypeDefIndex: 14307
		{
		}
	
		public struct SummonWhiteHandSignal // TypeDefIndex: 14308
		{
		}
	
		public struct GamePausedSignal // TypeDefIndex: 14309
		{
			// Fields
			public VampireSurvivors.Objects.Characters.CharacterController pausingPlayer; // 0x00
		}
	
		public struct ReturnToAppSignal // TypeDefIndex: 14310
		{
		}
	
		public struct ConnectionErrorSignal // TypeDefIndex: 14311
		{
			// Fields
			public ConnectionException ConnectionException; // 0x00
		}
	
		public struct CharacterDiedSignal // TypeDefIndex: 14312
		{
			// Fields
			public bool GoStraightToRecapPage; // 0x00
		}
	
		public struct CharacterXpChangedSignal // TypeDefIndex: 14313
		{
			// Fields
			public float CurrentXp; // 0x00
			public float MaxXp; // 0x04
		}
	
		public struct CharacterLostShieldSignal // TypeDefIndex: 14314
		{
			// Fields
			public float DamageAmount; // 0x00
			public VampireSurvivors.Objects.Characters.CharacterController Character; // 0x08
		}
	
		public struct CharacterReceivedDamageSignal // TypeDefIndex: 14315
		{
			// Fields
			public VampireSurvivors.Objects.Characters.CharacterController Character; // 0x00
		}
	
		public struct SetCharacterInvincibilityForMillisSignal // TypeDefIndex: 14316
		{
			// Fields
			public float DurationMillis; // 0x00
		}
	
		public struct SetCharacterInvincibilityForMillisNonCumulativeSignal // TypeDefIndex: 14317
		{
			// Fields
			public float DurationMillis; // 0x00
		}
	
		public struct AddWeaponToCharacterSignal // TypeDefIndex: 14318
		{
			// Fields
			public VampireSurvivors.Objects.Characters.CharacterController Character; // 0x00
			public WeaponType Weapon; // 0x08
		}
	
		public struct AddSkillToCharacterSignal // TypeDefIndex: 14319
		{
			// Fields
			public VampireSurvivors.Objects.Characters.CharacterController Character; // 0x00
		}
	
		public struct WeaponAddedToCharacterSignal // TypeDefIndex: 14320
		{
			// Fields
			public VampireSurvivors.Objects.Characters.CharacterController Character; // 0x00
			public WeaponType Weapon; // 0x08
			public WeaponData Data; // 0x10
		}
	
		public struct RemoveWeaponFromCharacterSignal // TypeDefIndex: 14321
		{
			// Fields
			public VampireSurvivors.Objects.Characters.CharacterController Character; // 0x00
			public WeaponType Weapon; // 0x08
			public bool RemoveFromAnotherCharacterIfNotFound; // 0x0C
		}
	
		public struct WeaponRemovedFromCharacterSignal // TypeDefIndex: 14322
		{
			// Fields
			public VampireSurvivors.Objects.Characters.CharacterController Character; // 0x00
			public WeaponType Weapon; // 0x08
		}
	
		public struct AddHiddenWeaponToCharacterSignal // TypeDefIndex: 14323
		{
			// Fields
			public VampireSurvivors.Objects.Characters.CharacterController Character; // 0x00
			public WeaponType Weapon; // 0x08
		}
	
		public struct HiddenWeaponAddedToCharacterSignal // TypeDefIndex: 14324
		{
			// Fields
			public VampireSurvivors.Objects.Characters.CharacterController Character; // 0x00
			public WeaponType Weapon; // 0x08
		}
	
		public struct RemoveHiddenWeaponFromCharacterSignal // TypeDefIndex: 14325
		{
			// Fields
			public VampireSurvivors.Objects.Characters.CharacterController Character; // 0x00
			public WeaponType Weapon; // 0x08
		}
	
		public struct HiddenWeaponRemovedFromCharacterSignal // TypeDefIndex: 14326
		{
			// Fields
			public VampireSurvivors.Objects.Characters.CharacterController Character; // 0x00
			public WeaponType Weapon; // 0x08
		}
	
		public struct AddAccessoryToCharacterSignal // TypeDefIndex: 14327
		{
			// Fields
			public VampireSurvivors.Objects.Characters.CharacterController Character; // 0x00
			public WeaponType Accessory; // 0x08
		}
	
		public struct WeaponLevelledUpSignal // TypeDefIndex: 14328
		{
			// Fields
			public WeaponType Weapon; // 0x00
			public int NewLevel; // 0x04
		}
	
		public struct AccessoryAddedToCharacterSignal // TypeDefIndex: 14329
		{
			// Fields
			public VampireSurvivors.Objects.Characters.CharacterController Character; // 0x00
			public WeaponType Accessory; // 0x08
			public WeaponData Data; // 0x10
		}
	
		public struct RemoveAccessoryFromCharacterSignal // TypeDefIndex: 14330
		{
			// Fields
			public WeaponType Accessory; // 0x00
		}
	
		public struct AccessoryRemovedFromCharacterSignal // TypeDefIndex: 14331
		{
			// Fields
			public VampireSurvivors.Objects.Characters.CharacterController Character; // 0x00
			public WeaponType Accessory; // 0x08
		}
	
		public struct PlayerPickedUpNewItemSignal // TypeDefIndex: 14332
		{
			// Fields
			public VampireSurvivors.Data.ItemType Item; // 0x00
			public WeaponType Weapon; // 0x04
			public bool IsWeapon; // 0x08
			public VampireSurvivors.Objects.Characters.CharacterController Character; // 0x10
		}
	
		public struct CharacterFoundSignal // TypeDefIndex: 14333
		{
			// Fields
			public VampireSurvivors.Data.CharacterType FoundCharacter; // 0x00
			public VampireSurvivors.Objects.Characters.CharacterController ControllingCharacter; // 0x08
		}
	
		public struct ReviveCharacterSignal // TypeDefIndex: 14334
		{
			// Fields
			public float RevivePercentage; // 0x00
		}
	
		public struct WeaponSelectionSignal // TypeDefIndex: 14335
		{
		}
	
		public struct RemoveEnemyFromStageSignal // TypeDefIndex: 14336
		{
			// Fields
			public EnemyController EnemyController; // 0x00
		}
	
		public struct EnemyKilledImmediateSignal // TypeDefIndex: 14337
		{
			// Fields
			public EnemyController EnemyController; // 0x00
		}
	
		public struct DestructibleDestroyed // TypeDefIndex: 14338
		{
			// Fields
			public Destructible destructible; // 0x00
		}
	
		public struct FireEnemyBulletSignal // TypeDefIndex: 14339
		{
			// Fields
			public Vector2 SpawnPos; // 0x00
			public EnemyType BulletType; // 0x08
		}
	
		public struct EnterTheBossi // TypeDefIndex: 14340
		{
		}
	
		public struct OpenTreasureSignal // TypeDefIndex: 14341
		{
			// Fields
			public Treasure Data; // 0x00
		}
	
		public struct OpenTreasureCompletedSignal // TypeDefIndex: 14342
		{
			// Fields
			public int TreasureHeldArcanaCount; // 0x00
			[FormerlySerializedAs("ArcanaWinner")]
			public VampireSurvivors.Objects.Characters.CharacterController TreasureWinner; // 0x08
		}
	
		public struct OnAfterCoinsAddedSignal // TypeDefIndex: 14343
		{
			// Fields
			public float Amount; // 0x00
		}
	
		public struct KillSoleSolutionTilemapFade // TypeDefIndex: 14344
		{
		}
	
		public struct LevelUpSignal // TypeDefIndex: 14345
		{
		}
	
		public struct LevelUpWithoutScreenSignal // TypeDefIndex: 14346
		{
		}
	
		public struct AutoLevelUpSignal // TypeDefIndex: 14347
		{
		}
	
		public struct LevelUpCompletedSignal // TypeDefIndex: 14348
		{
		}
	
		public struct SkipLevelUpSignal // TypeDefIndex: 14349
		{
			// Fields
			public VampireSurvivors.Objects.Characters.CharacterController Player; // 0x00
		}
	
		public struct BanishWeaponSignal // TypeDefIndex: 14350
		{
			// Fields
			public WeaponType Weapon; // 0x00
		}
	
		public struct RemoveWeaponFromExcluded // TypeDefIndex: 14351
		{
			// Fields
			public WeaponType Type; // 0x00
		}
	
		public struct ValidatePickupWeapons // TypeDefIndex: 14352
		{
		}
	
		public struct OpenSeasonFanSignal // TypeDefIndex: 14353
		{
			// Fields
			public string Color; // 0x00
			public string FrameName; // 0x08
		}
	
		public struct SetBackgroundVisible // TypeDefIndex: 14354
		{
			// Fields
			public bool Visible; // 0x00
		}
	}
}

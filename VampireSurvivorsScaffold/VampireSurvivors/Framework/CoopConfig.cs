/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.UI;
using VampireSurvivors.UI.Player;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	[CreateAssetMenu(fileName = "CoopConfig", menuName = "VampireSurvivors/New Coop Config")]
	public class CoopConfig : ScriptableObject // TypeDefIndex: 17458
	{
		// Fields
		[Tooltip("Can be set to 0 to disable enemy coffin-chomp behaviour")]
		public int _enemyChompMaxCount; // 0x18
		public float _enemyChompHPGainProportionPerChomp; // 0x1C
		public float _enemyChompScaleGainProportionPerChomp; // 0x20
		public HitVfxType _enemyChompEffect; // 0x24
		public float _levelupVibrationMilliseconds; // 0x28
		public float _chestRandomisationSpeedMultiplier; // 0x2C
		public float _chestRandomisationLength; // 0x30
		public AnimationCurve _chestRandomisationSpinPositionCurve; // 0x38
		public bool _spawningEnemiesTargetDeadPlayersAlso; // 0x40
		public bool _globalLevelNumber; // 0x41
		[Tooltip("XP Gain *= XPGainModifier")]
		public float _xpGainModifier; // 0x44
		[Tooltip("if (XPGainDivisionPerPlayer != 0) XP Gain /= XPGainDivisionPerPlayer * playerCount")]
		public float _xpGainDivisionPerPlayer; // 0x48
		public float _enemyHealthModifierPerMinute; // 0x4C
		public float _screenBoundsTopOffsetPixels; // 0x50
		public float _screenBoundsBottomOffsetPixels; // 0x54
		public float _fixedCameraOffsetPixels; // 0x58
		public bool _blockWeaponsOwnedByOtherPlayers; // 0x5C
		public bool _blockAccessoriesOwnedByOtherPlayers; // 0x5D
		public bool _limitAccessoriesLikeWeapons; // 0x5E
		public float _revivalSpeedWithRevive; // 0x60
		public float _revivalSpeedWithoutRevive; // 0x64
		public float _revivalLossSpeed; // 0x68
		public float _revivalRange; // 0x6C
		public bool _reviveAllRatherThanClosest; // 0x70
		public float _multiplayerIndicatorDuration; // 0x74
		[Tooltip("How many repeats of the players do we include in the random that determines who wins a chest.  The longer the set, the longer it takes for even distribution to happen, but the less predictable it is.")]
		public int _chestRandomnessSetSize; // 0x78
		public bool _chestRandomPrioritiseEvolvablePlayers; // 0x7C
		public bool _removeDeadPlayersFromCamera; // 0x7D
		public float _removeDeadPlayerFromCameraDuration; // 0x80
		public bool _immediateRevivalUsage; // 0x84
		public float _decompositionTimeSeconds; // 0x88
		public bool _ghostUsesCharacterSprite; // 0x8C
		public int _extraCharmPerPlayer; // 0x90
		public int _extraCharmCutoffMinute; // 0x94
		[Tooltip("Allows players to be dragged if they\'re on the edge of the screen")]
		public bool _usePhysicalCameraBounds; // 0x98
		public float _physicalScreenBoundsTopOffsetPixels; // 0x9C
		public MultiplayerRevivalUI _multiplayerRevivalUIPrefab; // 0xA0
		public PlayerIndicator _playerIndicatorUIPrefab; // 0xA8
		public Material _navigationUIMaterial; // 0xB0
		public int _amuletsInAmuletBag; // 0xB8
		public int _amuletBagSize; // 0xBC
		public CameraMode _cameraMode; // 0xC0
		public AccessoryBonusMode _accessoryBonusMode; // 0xC4
		public bool _shareEvolutionPassives; // 0xC8
		public float _goldBonusForNotSharingPassives; // 0xCC
	
		// Nested types
		public enum CameraMode // TypeDefIndex: 17456
		{
			AveragePosition = 0,
			PositionExtentsCenter = 1,
			VisualBoundsExtentsCenter = 2
		}
	
		public enum AccessoryBonusMode // TypeDefIndex: 17457
		{
			OwnerOnly = 0,
			MatchingDescription = 1,
			AllPlayers = 2
		}
	
		// Constructors
		public CoopConfig() {} // 0x00000001872D2640-0x00000001872D2740
	}
}

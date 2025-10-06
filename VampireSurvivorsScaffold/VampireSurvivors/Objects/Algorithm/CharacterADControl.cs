/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Algorithm
{
	public class CharacterADControl // TypeDefIndex: 16096
	{
		// Fields
		private AIType _currentType; // 0x10
		private VampireSurvivors.Objects.Characters.CharacterController _controlledPlayer; // 0x18
		private VampireSurvivors.Objects.Characters.CharacterController _followedCharacter; // 0x20
		private int _levelupLoadoutIndex; // 0x2C
		private List<WeaponType> _loadout; // 0x30
		private WeaponType _lasLevelledUpWeaponType; // 0x38
		private float2 _angleDistance; // 0x3C
		private float _congaMaxDistance; // 0x44
		private float _congaMinDistance; // 0x48
		private float _congaYOffset; // 0x4C
		private bool _initialPositionReached; // 0x50
		public bool ShouldOverrideFollowDelay; // 0x51
		private Queue<Vector2> _followedCharacterHistory; // 0x58
		private Vector2 _followedCharacterLastPosition; // 0x60
		private Unity.Mathematics.Random _loadoutShuffler; // 0x68
	
		// Properties
		public LevelupType LevelupType { get; set; } // 0x0000000181FFD1B0-0x0000000181FFD1C0 0x0000000181FFD1C0-0x0000000181FFD1D0
		public VampireSurvivors.Objects.Characters.CharacterController FollowedCharacter { get => default; set {} } // 0x0000000180B15530-0x0000000180B15540 0x0000000180B1C120-0x0000000180B1C180
	
		// Constructors
		public CharacterADControl() {} // 0x0000000186EEB4D0-0x0000000186EEB4F0
	
		// Methods
		public void SetAIType(AIType type, VampireSurvivors.Objects.Characters.CharacterController controlledPlayer, VampireSurvivors.Objects.Characters.CharacterController followedCharacter = null) {} // 0x000000018460BE70-0x000000018460BF20
		public void InitLoadoutShuffler(uint seed) {} // 0x0000000186EE9150-0x0000000186EE9170
		public void SetAIToAngleDistance(float angleDegrees, float distance, bool mirrorInput = false /* Metadata: 0x01977B59 */) {} // 0x0000000186EE9170-0x0000000186EE91B0
		public void SetAIToConga(float maxDistance, float minDistance, float yOffset = 0f /* Metadata: 0x01977B5A */) {} // 0x0000000186EE91B0-0x0000000186EE91D0
		public Vector2 CalculateMovement() => default; // 0x0000000186EE91D0-0x0000000186EEA6E0
		public void Update() {} // 0x0000000186EEA6E0-0x0000000186EEA790
		private float2 CombineWithStandardRepulsionAndDeadZone(float2 input, float repulsionScale = 0.001f /* Metadata: 0x01977B5E */) => default; // 0x0000000186EEA790-0x0000000186EEA870
		private float2 CalculateStandardRepulsionVector() => default; // 0x0000000186EEA870-0x0000000186EEAD70
		public void HandleWeaponLevelling() {} // 0x0000000186EEAD70-0x0000000186EEADA0
		public void HandleOnLevelUpCompleted() {} // 0x0000000186EEADA0-0x0000000186EEB020
		private void GiveNextLoadoutWeapon() {} // 0x0000000186EEB020-0x0000000186EEB110
		private void GiveNextShowcaseWeapon() {} // 0x0000000186EEB110-0x0000000186EEB240
		private void GiveNextLevelupPresetWeapon(int presetIndex) {} // 0x0000000186EEB240-0x0000000186EEB4D0
	}
}

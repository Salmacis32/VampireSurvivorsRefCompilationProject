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
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class EggManager : IInitializable, IDisposable // TypeDefIndex: 13928
	{
		// Fields
		private Dictionary<string, float> _attributes; // 0x10
		private List<string> _attributeKeys; // 0x18
		[Inject]
		private SignalBus _signalBus; // 0x20
		[Inject]
		private PlayerOptions _playerOptions; // 0x28
		[Inject]
		private GameSessionData _session; // 0x30
		public const string MAX_HP_PROPNAME = "maxHp"; // Metadata: 0x01976B49
		public const string ARMOR_PROPNAME = "armor"; // Metadata: 0x01976B4F
		public const string REGEN_PROPNAME = "regen"; // Metadata: 0x01976B55
		public const string MOVESPEED_PROPNAME = "moveSpeed"; // Metadata: 0x01976B5B
		public const string POWER_PROPNAME = "power"; // Metadata: 0x01976B65
		public const string COOLDOWN_PROPNAME = "cooldown"; // Metadata: 0x01976B6B
		public const string AREA_PROPNAME = "area"; // Metadata: 0x01976B74
		public const string SPEED_PROPNAME = "speed"; // Metadata: 0x01976B79
		public const string DURATION_PROPNAME = "duration"; // Metadata: 0x01976B7F
		public const string AMOUNT_PROPNAME = "amount"; // Metadata: 0x01976B88
		public const string LUCK_PROPNAME = "luck"; // Metadata: 0x01976B8F
		public const string GROWTH_PROPNAME = "growth"; // Metadata: 0x01976B94
		public const string GREED_PROPNAME = "greed"; // Metadata: 0x01976B9B
		public const string CURSE_PROPNAME = "curse"; // Metadata: 0x01976BA1
		public const string MAGNET_PROPNAME = "magnet"; // Metadata: 0x01976BA7
		public const string REVIVALS_PROPNAME = "revivals"; // Metadata: 0x01976BAE
		public const string REROLLS_PROPNAME = "rerolls"; // Metadata: 0x01976BB7
		public const string SKIPS_PROPNAME = "skips"; // Metadata: 0x01976BBF
		public const string BANISH_PROPNAME = "banish"; // Metadata: 0x01976BC5
	
		// Constructors
		public EggManager() {} // 0x00000001865CD280-0x00000001865CD3E0
	
		// Methods
		public void Initialize() {} // 0x00000001865C7500-0x00000001865C7510
		public void Dispose() {} // 0x0000000180B15170-0x0000000180B15180
		public KeyValuePair<string, float> AddGoldenEgg(VampireSurvivors.Data.CharacterType t, Unity.Mathematics.Random? rng = default) => default; // 0x00000001865C7510-0x00000001865C7760
		public string PickRandomAttribute() => default; // 0x00000001865C7760-0x00000001865C7840
		public void LightEgg(float amount) {} // 0x00000001865C7840-0x00000001865C8550
		public float GetCharacterEggStat(VampireSurvivors.Data.CharacterType t, PowerUpType p) => default; // 0x00000001865C8550-0x00000001865C8720
		public string GetTypeString(PowerUpType type) => default; // 0x00000001865C8720-0x00000001865C8A20
		public void ApplyBonuses(VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x00000001865C8A20-0x00000001865C97B0
		public float RemoveBonuses() => default; // 0x00000001865C97B0-0x00000001865CA380
		public void ShowResultAt(Vector2 target, KeyValuePair<string, float> result, float offsetX = -16f /* Metadata: 0x01976B41 */, float offsetY = 16f /* Metadata: 0x01976B45 */) {} // 0x00000001865CA380-0x00000001865CB090
		public void RemoveAllEggs() {} // 0x00000001865CB090-0x00000001865CB230
		public KeyValuePair<string, float> RemoveAllSpecificEggs(string attributeName) => default; // 0x00000001865CB230-0x00000001865CB910
		public KeyValuePair<string, float> RemoveRandomEgg() => default; // 0x00000001865CB910-0x00000001865CC050
		public static string GetFormattedEggCount(float eggCount) => default; // 0x00000001865CC050-0x00000001865CC160
		private void InitializeAttributes() {} // 0x00000001865CC160-0x00000001865CC8C0
		private string LookUpFrame(string frameName) => default; // 0x00000001865CC8C0-0x00000001865CD280
	}
}

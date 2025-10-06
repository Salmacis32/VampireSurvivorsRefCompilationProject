/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class CardInfoUI : MonoBehaviour // TypeDefIndex: 14714
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI Title; // 0x20
		[SerializeField]
		private TextMeshProUGUI LevelText; // 0x28
		[SerializeField]
		private Image Edition; // 0x30
		[SerializeField]
		private List<CardEntry> _oneColumnEntries; // 0x38
		[SerializeField]
		private List<CardEntry> _twoColumnEntries; // 0x40
		private DataManager _dataManager; // 0x48
	
		// Nested types
		[Serializable]
		public class CardEntry // TypeDefIndex: 14711
		{
			// Fields
			public GameObject Root; // 0x10
			public Image Image; // 0x18
			public TextMeshProUGUI Text; // 0x20
			public GameObject DecreaseImage; // 0x28
	
			// Constructors
			public CardEntry() {} // 0x0000000180B15170-0x0000000180B15180
		}
	
		private class EveryXDataHolder // TypeDefIndex: 14712
		{
			// Fields
			public PowerUpType Type; // 0x10
			public float Value; // 0x14
			public int EveryXLevels; // 0x18
			public int Count; // 0x1C
	
			// Constructors
			public EveryXDataHolder() {} // Dummy constructor
			public EveryXDataHolder(PowerUpType type, float value, int everyXLevels, int count) {} // 0x00000001867B1430-0x00000001867B1450
		}
	
		// Constructors
		public CardInfoUI() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		[Inject]
		private void Construct(DataManager dataManager) {} // 0x000000018268E650-0x000000018268E6B0
		public void SetData(CharacterSkillCard_Base card, ArcanaData data) {} // 0x00000001867ADF50-0x00000001867B04C0
		public static void RefreshLayoutGroupsImmediateAndRecursive(GameObject root) {} // 0x00000001867B04C0-0x00000001867B0600
		private string ReplaceDescriptionTextPlaceholder(string descriptionTextString, EveryXDataHolder stat, bool addStatsText) => default; // 0x00000001867B0600-0x00000001867B0710
		private string GetTextForEntry(PowerUpType powerUpType, float value, bool addStatText = true /* Metadata: 0x019771EB */) => default; // 0x00000001867B0710-0x00000001867B0B50
		private string GetSign(float value) => default; // 0x00000001867B0B50-0x00000001867B0BB0
		private List<Tuple<PowerUpType, float>> GetPowerUpTypesFromModifierStats(ModifierStats stats) => default; // 0x00000001867B0BB0-0x00000001867B1210
		public static Sprite GetSubSkillIcon(ArcanaType? type) => default; // 0x00000001867B1210-0x00000001867B1430
	}
}

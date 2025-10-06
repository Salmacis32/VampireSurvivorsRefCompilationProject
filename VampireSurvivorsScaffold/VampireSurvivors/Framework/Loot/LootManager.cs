/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Loot
{
	public class LootManager : IInitializable, IDisposable // TypeDefIndex: 18239
	{
		// Fields
		[Inject]
		private DataManager _dataManager; // 0x10
		[Inject]
		private GameSessionData _gameSessionData; // 0x18
		[Inject]
		private VampireSurvivors.Objects.Stage _stage; // 0x20
		private float _accumulatedWeight; // 0x28
		private List<WeightedItem> _weightedStore; // 0x30
		private List<VampireSurvivors.Data.ItemType> _forcedLootTable; // 0x38
		private List<VampireSurvivors.Data.ItemType> _addedLoot; // 0x40
	
		// Constructors
		public LootManager() {} // 0x0000000186719FB0-0x000000018671A110
	
		// Methods
		public void Initialize() {} // 0x0000000180B15170-0x0000000180B15180
		public void Dispose() {} // 0x0000000180B15170-0x0000000180B15180
		public void Init() {} // 0x00000001867172F0-0x0000000186717410
		public void SetPlainLootTable() {} // 0x0000000186717410-0x00000001867176A0
		public void AddToLootTable(VampireSurvivors.Data.ItemType itemToAdd) {} // 0x00000001867176A0-0x0000000186717790
		public void AddToLootTable(List<VampireSurvivors.Data.ItemType> itemsToAdd) {} // 0x0000000186717790-0x0000000186717A80
		public void RecalculateLoot() {} // 0x0000000186717A80-0x0000000186717B00
		public void CheckForAddedLoot() {} // 0x0000000186717B00-0x0000000186717F20
		public VampireSurvivors.Data.ItemType GetRandomWeightedItem(Unity.Mathematics.Random? rng = default) => default; // 0x0000000186717F20-0x0000000186718240
		public VampireSurvivors.Data.ItemType GetItemFromExportedTable(WeightedStore store) => default; // 0x0000000186718240-0x0000000186718500
		public WeightedStore ExportCustomLootTable(VampireSurvivors.Data.ItemType[] items, bool ignorePlayerLevel = false /* Metadata: 0x019788EB */) => default; // 0x0000000186718500-0x0000000186718910
		private void MakeDefaultLootTable() {} // 0x0000000186718910-0x0000000186718E80
		public VampireSurvivors.Data.ItemType GetSurvarotDraft() => default; // 0x0000000186718E80-0x0000000186719100
		public bool DropSurvarotsSuccessful() => default; // 0x0000000186719100-0x00000001867193A0
		private void MakeCustomLootTable(List<VampireSurvivors.Data.ItemType> items) {} // 0x00000001867193A0-0x0000000186719820
		private float ModifyItemWeight(VampireSurvivors.Data.ItemType itemType) => default; // 0x0000000186719820-0x0000000186719FB0
	}
}

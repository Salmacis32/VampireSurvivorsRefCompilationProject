/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using SuperTiled2Unity;
using UnityEngine;
using UnityEngine.AddressableAssets;
using VampireSurvivors.App.Tools;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Validation;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	[CreateAssetMenu(fileName = "TilesetFactory", menuName = "VampireSurvivors/New TilesetFactory")]
	public class TilesetFactory : SerializedScriptableObject, IValidateReferences // TypeDefIndex: 17534
	{
		// Fields
		[SerializeField]
		private TilesetPathsDictionary _TilesetPaths; // 0x58
		[SerializeField]
		private TilesetRefsDictionary _TilesetRefs; // 0x60
		[SerializeField]
		private TilesetRefsDictionary _TilesetSupportRefs; // 0x68
		[SerializeField]
		private List<TilesetFactory> _LinkedFactories; // 0x70
		private Dictionary<StageType, SuperMap> _mapInstances; // 0x78
	
		// Nested types
		[Serializable]
		public class TilesetRefsDictionary : UnitySerializedDictionary<StageType, PrefabRefData> // TypeDefIndex: 17529
		{
			// Constructors
			public TilesetRefsDictionary() {} // 0x0000000187353A30-0x0000000187353A70
		}
	
		[Serializable]
		public class PrefabRefData // TypeDefIndex: 17530
		{
			// Fields
			[SerializeField]
			private AssetReference _PrefabRef; // 0x10
	
			// Properties
			public AssetReference PrefabRef { get => default; set {} } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
	
			// Constructors
			public PrefabRefData() {} // 0x0000000180B15170-0x0000000180B15180
		}
	
		[Serializable]
		public class TilesetPathsDictionary : UnitySerializedDictionary<StageType, TilesetPathData> // TypeDefIndex: 17531
		{
			// Constructors
			public TilesetPathsDictionary() {} // 0x0000000187353A70-0x0000000187353AB0
		}
	
		[Serializable]
		public class TilesetPathData // TypeDefIndex: 17532
		{
			// Fields
			[SerializeField]
			private string _TilemapPath; // 0x10
	
			// Properties
			public string TilemapPath { get => default; } // 0x0000000187353AB0-0x0000000187353B10 
			public string TilemapPathWithExtension { get => default; } // 0x0000000180B15C10-0x0000000180B15C20 
	
			// Constructors
			public TilesetPathData() {} // 0x0000000180B15170-0x0000000180B15180
		}
	
		// Constructors
		public TilesetFactory() {} // 0x0000000187353780-0x0000000187353A30
	
		// Methods
		private SuperMap LoadFromAddressables(DlcType? dlcType, StageType stageType, TilesetFactory factory) => default; // 0x0000000187351350-0x0000000187351500
		private void LoadFromAddressablesAsync(DlcType? dlcType, StageType stageType, TilesetFactory factory, Action<SuperMap> onComplete) {} // 0x0000000187351500-0x00000001873516B0
		public SuperMap CacheTilesetInstance(StageType stageType) => default; // 0x00000001873516B0-0x0000000187351A90
		public SuperMap GetCachedTilesetInstance(StageType stageType) => default; // 0x0000000187351A90-0x0000000187351B40
		public void ClearCachedTilesets() {} // 0x0000000187351B40-0x0000000187351B90
		private SuperMap GetTilesetPrefabInternal(StageType stageType, Action<SuperMap> onComplete = null) => default; // 0x0000000187351B90-0x0000000187352380
		public GameObject GetTilesetSupportPrefab(StageType stageType) => default; // 0x0000000187352380-0x0000000187352390
		public void GetTilesetSupportPrefabAsync(StageType stageType, Action<GameObject> onComplete) {} // 0x0000000187352390-0x00000001873523A0
		private GameObject GetTilesetSupportPrefabInternal(StageType stageType, Action<GameObject> onComplete = null) => default; // 0x00000001873523A0-0x0000000187352D10
		public bool ContainsStage(StageType stageType) => default; // 0x0000000187352D10-0x0000000187352D90
		public List<string> ValidateReferences() => default; // 0x0000000187352D90-0x0000000187353780
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using QFSW.MOP2;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.AddressableAssets;
using VampireSurvivors.App.Tools;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Validation;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Framework
{
	[CreateAssetMenu(fileName = "EnemyFactory", menuName = "VampireSurvivors/New EnemyFactory")]
	public class EnemyFactory : SerializedScriptableObject, IValidateReferences // TypeDefIndex: 18591
	{
		// Fields
		[SerializeField]
		private GameObject _DefaultEnemyPrefab; // 0x58
		[SerializeField]
		private EnemyPoolsDictionary _EnemyPools; // 0x60
		[SerializeField]
		private EnemyRefsDictionary _EnemyRefs; // 0x68
		[SerializeField]
		private List<EnemyFactory> _LinkedFactories; // 0x70
		private readonly Dictionary<EnemyType, ObjectPool> _cachedEnemyPools; // 0x78
		private readonly Dictionary<GameObject, ObjectPool> _cachedPoolsByPrefab; // 0x80
	
		// Nested types
		[Serializable]
		public class EnemyPoolsDictionary : UnitySerializedDictionary<EnemyType, GameObject> // TypeDefIndex: 18586
		{
			// Constructors
			public EnemyPoolsDictionary() {} // 0x00000001867ED790-0x00000001867ED7D0
		}
	
		[Serializable]
		public class EnemyRefsDictionary : UnitySerializedDictionary<EnemyType, PrefabRefData> // TypeDefIndex: 18587
		{
			// Constructors
			public EnemyRefsDictionary() {} // 0x00000001867ED7D0-0x00000001867ED810
		}
	
		[Serializable]
		public class PrefabRefData // TypeDefIndex: 18588
		{
			// Fields
			[SerializeField]
			private AssetReferenceT<GameObject> _PrefabRef; // 0x10
	
			// Properties
			public AssetReferenceT<GameObject> PrefabRef { get => default; set {} } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
	
			// Constructors
			public PrefabRefData() {} // 0x0000000180B15170-0x0000000180B15180
		}
	
		[Serializable]
		public class PrefabPathData // TypeDefIndex: 18589
		{
			// Fields
			[SerializeField]
			private string _PrefabPath; // 0x10
	
			// Properties
			public string PrefabPath { get => default; set {} } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
			public string PathWithoutExtension { get => default; } // 0x00000001867ED810-0x00000001867ED870 
			public string PathWithExtension { get => default; } // 0x0000000180B15C10-0x0000000180B15C20 
	
			// Constructors
			public PrefabPathData() {} // 0x0000000180B15170-0x0000000180B15180
		}
	
		// Constructors
		public EnemyFactory() {} // 0x00000001867ED4E0-0x00000001867ED790
	
		// Methods
		public GameObject GetEnemyPrefab(EnemyType enemyType) => default; // 0x00000001867EA600-0x00000001867EADF0
		public void InitPools(VampireSurvivors.Objects.Stage stage, DataManager dataManager) {} // 0x00000001867EADF0-0x00000001867EB530
		private void MergeInNewEnemies(EnemyFactory other) {} // 0x00000001867EB530-0x00000001867EBAF0
		private void MergeInNewDlcEnemies(EnemyFactory other, DlcType dlcType) {} // 0x00000001867EBAF0-0x00000001867EC0C0
		public ObjectPool GetEnemyPool(string enemyTypeString) => default; // 0x00000001867EC0C0-0x00000001867EC130
		public ObjectPool GetEnemyPool(EnemyType enemyType) => default; // 0x00000001867EC130-0x00000001867EC1F0
		public void PurgePools() {} // 0x00000001867EC1F0-0x00000001867EC4A0
		private void GeneratePool(EnemyType et, GameObject prefab, int poolSize = 50 /* Metadata: 0x0197AD81 */) {} // 0x00000001867EC4A0-0x00000001867ECA50
		private async UniTask FillUpPoolsAsync(CancellationToken ct) => default; // 0x00000001867ECA50-0x00000001867ECC20
		public List<string> ValidateReferences() => default; // 0x00000001867ECC20-0x00000001867ED4E0
	}
}

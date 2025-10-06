/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using QFSW.MOP2;
using Rewired.Utils.Libraries.TinyJson;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.AddressableAssets;
using VampireSurvivors.App.Tools;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.DLC;
using VampireSurvivors.Framework.Validation;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Framework
{
	public class GenericPoolFactory<T> : SerializedScriptableObject, IValidateReferences // TypeDefIndex: 18595
	{
		// Fields
		[SerializeField]
		private ObjectPool _DefaultPool;
		[SerializeField]
		protected PoolsDictionary _Pools;
		[SerializeField]
		protected PoolRefsDictionary _PoolRefs;
		[SerializeField]
		private List<GenericPoolFactory<T>> _LinkedFactories;
		[DoNotSerialize]
		private readonly Dictionary<T, ObjectPool> _cachedPools;
	
		// Nested types
		[Serializable]
		public class PoolsDictionary : UnitySerializedDictionary<T, ObjectPool> // TypeDefIndex: 18592
		{
			// Constructors
			public PoolsDictionary() {}
		}
	
		[Serializable]
		public class PoolRefsDictionary : UnitySerializedDictionary<T, PrefabRefData> // TypeDefIndex: 18593
		{
			// Constructors
			public PoolRefsDictionary() {}
		}
	
		[Serializable]
		public class PrefabRefData // TypeDefIndex: 18594
		{
			// Fields
			[SerializeField]
			private AssetReference _PoolRef;
	
			// Properties
			public AssetReference PoolRef { get => default; set {} }
	
			// Constructors
			public PrefabRefData() {}
		}
	
		// Constructors
		public GenericPoolFactory() {}
	
		// Methods
		protected virtual GenericPoolFactory<T> GetDlcFactory(BundleManifestData bmd) => default;
		public void InitPools() {}
		public ObjectPool GetPool(T poolType) => default;
		public Dictionary<T, ObjectPool> GetAllPools() => default;
		public void PurgePools() {}
		private void InitPool(T poolType, ObjectPool pool) {}
		private void MergeFactoryAndInitPool(GenericPoolFactory<T> other, DlcType? dlcType) {}
		public List<string> ValidateReferences() => default;
	}
}

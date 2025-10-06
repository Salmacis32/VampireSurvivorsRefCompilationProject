/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace Coherence.Toolkit
{
	[Serializable]
	[DisplayName("EnemyProvider", "Load an Enemy Prefab using the EnemyFactory.")]
	public sealed class EnemyProvider : INetworkObjectProvider // TypeDefIndex: 13906
	{
		// Fields
		[SerializeField]
		private EnemyType _enemyType; // 0x10
	
		// Constructors
		public EnemyProvider() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public async void LoadAsset(string networkAssetId, Action<ICoherenceSync> onLoaded) {} // 0x00000001865BCCA0-0x00000001865BCED0
		private void LoadPrefab(Action<ICoherenceSync> onLoaded) {} // 0x00000001865BCED0-0x00000001865BCF90
		public ICoherenceSync LoadAsset(string networkAssetId) => default; // 0x00000001865BCF90-0x00000001865BD030
		public void Release(ICoherenceSync obj) {} // 0x0000000180B15170-0x0000000180B15180
		public void OnApplicationQuit() {} // 0x0000000180B15170-0x0000000180B15180
		public void Initialize(CoherenceSyncConfig entry) {} // 0x0000000180B15170-0x0000000180B15180
		public bool Validate(CoherenceSyncConfig entry) => default; // 0x00000001865BD030-0x00000001865BD040
	}
}

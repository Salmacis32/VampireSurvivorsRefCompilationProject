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
	[DisplayName("CharacterProvider", "Load a Character Prefab using the CharacterFactory.")]
	public sealed class CharacterProvider : INetworkObjectProvider // TypeDefIndex: 13904
	{
		// Fields
		[SerializeField]
		private VampireSurvivors.Data.CharacterType _characterType; // 0x10
	
		// Constructors
		public CharacterProvider() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void LoadAsset(string networkAssetId, Action<ICoherenceSync> onLoaded) {} // 0x00000001865BC9F0-0x00000001865BCC10
		public ICoherenceSync LoadAsset(string networkAssetId) => default; // 0x00000001865BCC10-0x00000001865BCCA0
		public void Release(ICoherenceSync obj) {} // 0x0000000180B15170-0x0000000180B15180
		public void OnApplicationQuit() {} // 0x0000000180B15170-0x0000000180B15180
		public void Initialize(CoherenceSyncConfig entry) {} // 0x0000000180B15170-0x0000000180B15180
		public bool Validate(CoherenceSyncConfig entry) => default; // 0x0000000184E43CA0-0x0000000184E43CB0
	}
}

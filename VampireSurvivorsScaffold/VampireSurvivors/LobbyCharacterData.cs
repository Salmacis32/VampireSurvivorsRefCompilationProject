/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Connection;
using Coherence.Toolkit;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class LobbyCharacterData : MonoBehaviour // TypeDefIndex: 14023
	{
		// Properties
		public static LobbyCharacterData Instance { get; private set; } // 0x0000000186AE21B0-0x0000000186AE21F0 0x0000000186AE21F0-0x0000000186AE2290
		[Sync]
		public int RnjNameIndex { get; set; } // 0x000000018195ECC0-0x000000018195ECD0 0x0000000181962000-0x0000000181962010
		[Sync]
		public string RnjSpriteName { get; set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000180B1D4C0-0x0000000180B1D520
		[Sync]
		public int RnjStartingWeapon { get; set; } // 0x0000000181953B80-0x0000000181953B90 0x0000000181953B90-0x0000000181953BA0
		[Sync]
		public uint MissingNoSeed { get; set; } // 0x00000001819496B0-0x00000001819496C0 0x00000001819496C0-0x00000001819496D0
	
		// Constructors
		public LobbyCharacterData() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Awake() {} // 0x0000000186AE2290-0x0000000186AE24D0
		private void OnDestroy() {} // 0x0000000186AE24D0-0x0000000186AE2620
		private void OnDisconnected(CoherenceBridge _, ConnectionCloseReason __) {} // 0x0000000186AE2620-0x0000000186AE26C0
	}
}

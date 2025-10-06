/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Builds;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Data
{
	[Serializable]
	public class BaseGameData : ScriptableObject // TypeDefIndex: 18388
	{
		// Fields
		public static readonly string ARTIFACT_TYPE; // 0x00
		public readonly string _Title; // 0x18
		[SerializeField]
		private BuildMeta _BuildMeta; // 0x20
		[SerializeField]
		public SteamBaseGameData _Steam; // 0x28
		[SerializeField]
		public EpicGamesStoreGameData _EpicGamesStore; // 0x30
		[SerializeField]
		public XboxBaseGameData _Xbox; // 0x38
		[SerializeField]
		public SwitchBaseGameData _Switch; // 0x40
		[SerializeField]
		public PS4BaseGameData _PS4; // 0x48
		[SerializeField]
		public PS5BaseGameData _PS5; // 0x50
		[SerializeField]
		public IOS _IOS; // 0x58
		[SerializeField]
		public AppleArcade _AppleArcade; // 0x60
	
		// Properties
		public BuildMeta BuildMeta { get => default; set {} } // 0x0000000180B15530-0x0000000180B15540 0x0000000180B1C120-0x0000000180B1C180
	
		// Constructors
		public BaseGameData() {} // 0x0000000186746740-0x0000000186746CA0
		static BaseGameData() {} // 0x0000000186746CA0-0x0000000186746D50
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.DLC
{
	[Serializable]
	[CreateAssetMenu(fileName = "DlcData", menuName = "VampireSurvivors/New VersionData")]
	public class VersionData : ScriptableObject // TypeDefIndex: 18365
	{
		// Fields
		public string _BuildId; // 0x18
		public string _BuildTime; // 0x20
		private static VersionData _instance; // 0x00
	
		// Properties
		public static VersionData Instance { get => default; } // 0x000000018673C6F0-0x000000018673C730 
	
		// Constructors
		public VersionData() {} // 0x000000018199F650-0x000000018199F660
	
		// Methods
		private void OnEnable() {} // 0x000000018673C730-0x000000018673C7D0
		private void OnDisable() {} // 0x000000018673C7D0-0x000000018673C970
		public string GetFormattedBuildId() => default; // 0x000000018673C970-0x000000018673CA20
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.DLC
{
	[CreateAssetMenu(fileName = "DlcCatalog", menuName = "VampireSurvivors/New DlcCatalog")]
	public class DlcCatalog : ScriptableObject // TypeDefIndex: 18321
	{
		// Fields
		[SerializeField]
		public DlcDataDictionary _DlcData; // 0x18
	
		// Constructors
		public DlcCatalog() {} // 0x000000018672F8C0-0x000000018672F9A0
	
		// Methods
		public DlcData GetData(DlcType dlcType) => default; // 0x000000018672F280-0x000000018672F330
		public string GetTitle(DlcType dlcType) => default; // 0x000000018672F330-0x000000018672F400
		public DlcType? GetDlcType_SteamAppId(string appId) => default; // 0x000000018672F400-0x000000018672F630
		public DlcType? GetDlcType_XboxStoreId(string storeId) => default; // 0x000000018672F630-0x000000018672F860
		public string GetXboxStoreId(DlcType dlcType) => default; // 0x000000018672F860-0x000000018672F890
		public string GetXboxStorePackageIdentifier(DlcType dlcType) => default; // 0x000000018672F890-0x000000018672F8C0
	}
}

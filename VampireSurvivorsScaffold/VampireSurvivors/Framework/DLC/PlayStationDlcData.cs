/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.DLC
{
	[Serializable]
	public class PlayStationDlcData // TypeDefIndex: 18327
	{
		// Fields
		[SerializeField]
		private string _ContentLabel; // 0x10
		[SerializeField]
		private string _ServiceId; // 0x18
		[SerializeField]
		private string _EntitlementKey; // 0x20
		[SerializeField]
		private string _IconAssetPath; // 0x28
	
		// Properties
		public string ContentLabel { get => default; } // 0x0000000180B15C10-0x0000000180B15C20 
		public string ServiceId { get => default; } // 0x0000000180B15520-0x0000000180B15530 
		public string EntitlementKey { get => default; } // 0x0000000180B15530-0x0000000180B15540 
		public string IconAssetPath { get => default; } // 0x0000000180B15540-0x0000000180B15550 
	
		// Constructors
		public PlayStationDlcData() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public string ContentId() => default; // 0x000000018672FD90-0x000000018672FE10
		public void UpdateEntitlementKey(string newEntitlementKey) {} // 0x0000000180B1C120-0x0000000180B1C180
		private bool IsContentLabelValid(string contentLabel, ref string errorMessage, ref InfoMessageType? messageType) => default; // 0x000000018672FE10-0x000000018672FF80
		private bool IsServiceIdValid(string serviceId, ref string errorMessage, ref InfoMessageType? messageType) => default; // 0x000000018672FF80-0x00000001867300F0
		private bool IsEntitlementKeyValid(string entitlementKey, ref string errorMessage, ref InfoMessageType? messageType) => default; // 0x00000001867300F0-0x00000001867302E0
	}
}

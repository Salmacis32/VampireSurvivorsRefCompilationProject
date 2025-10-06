/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.DLC
{
	public class LicenseManager // TypeDefIndex: 18354
	{
		// Fields
		private const string _freeDlcActivatedKey = "freedlcactivated"; // Metadata: 0x01978976
	
		// Properties
		public List<DlcType> OwnedDlc { get; } // 0x0000000180B15C10-0x0000000180B15C20 
		public List<DlcType> IncludedDlc { get; } // 0x0000000180B15520-0x0000000180B15530 
		public List<DlcType> AvailableDlc { get; } // 0x0000000180B15530-0x0000000180B15540 
	
		// Constructors
		public LicenseManager() {} // 0x0000000186739360-0x0000000186739510
	
		// Methods
		public void CheckDlcLicenses(Action callback) {} // 0x0000000186738650-0x0000000186738800
		public void AddIncludedDlc() {} // 0x0000000186738800-0x0000000186738AB0
		public bool IsFreeDlcActivated(DlcType dlcType) => default; // 0x0000000186738AB0-0x0000000186738BB0
		public void SetFreeDlcActivated(DlcType dlcType, bool activated = true /* Metadata: 0x01978975 */) {} // 0x0000000186738BB0-0x0000000186738CA0
		public void CheckAvailableDlc(Action callback) {} // 0x0000000186738CA0-0x0000000186738E50
		public void SortDlcLists() {} // 0x0000000186738E50-0x0000000186739360
	}
}

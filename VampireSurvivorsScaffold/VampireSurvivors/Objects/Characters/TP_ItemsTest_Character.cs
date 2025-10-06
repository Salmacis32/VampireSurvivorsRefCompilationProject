/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class TP_ItemsTest_Character : TP_Character // TypeDefIndex: 17075
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _sequentialTimer; // 0x3F0
		private int _sequentialSpawn; // 0x3F8
		private List<VampireSurvivors.Data.ItemType> _pickupTypes; // 0x400
	
		// Constructors
		public TP_ItemsTest_Character() {} // 0x0000000187169770-0x0000000187169A10
	
		// Methods
		public override void AfterFullInitialization() {} // 0x000000018714FF90-0x000000018714FFA0
		public override void LevelUp() {} // 0x00000001871692F0-0x0000000187169340
		private void SpawnPickups(int extra = 0 /* Metadata: 0x01977FFE */) {} // 0x0000000187169340-0x0000000187169660
		private void SpawnSingle(float x, float y, VampireSurvivors.Data.ItemType itemType, float delay) {} // 0x0000000187169660-0x0000000187169770
	}
}

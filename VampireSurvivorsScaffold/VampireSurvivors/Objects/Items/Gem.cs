/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Items
{
	public class Gem : Pickup // TypeDefIndex: 16029
	{
		// Fields
		public static List<string> GEMFRAMES; // 0x00
		private int _prevDepth; // 0x138
	
		// Constructors
		public Gem() {} // 0x0000000186EBA4F0-0x0000000186EBA550
		static Gem() {} // 0x0000000186EBA550-0x0000000186EBAAB0
	
		// Methods
		protected override void Awake() {} // 0x0000000186EB7BB0-0x0000000186EB7BE0
		public override void SetData(VampireSurvivors.Data.ItemType itemType) {} // 0x0000000186EB9D00-0x0000000186EB9D30
		public void SetDataAndValue(VampireSurvivors.Data.ItemType itemType, float value) {} // 0x0000000186EB9D30-0x0000000186EB9D70
		public void SetValue(float value) {} // 0x0000000186EB9D70-0x0000000186EB9EF0
		public override void UpdateDepth() {} // 0x0000000186EB9EF0-0x0000000186EB9FD0
		public override void Despawn() {} // 0x0000000186EB9FD0-0x0000000186EBA1A0
		public override void GetTaken() {} // 0x0000000186EBA1A0-0x0000000186EBA400
		public void BlessColor(float value, float index) {} // 0x0000000186EBA400-0x0000000186EBA4F0
	}
}

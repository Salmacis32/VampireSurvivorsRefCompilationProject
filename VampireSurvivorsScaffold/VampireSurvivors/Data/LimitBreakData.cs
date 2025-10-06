/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Data
{
	[Serializable]
	public class LimitBreakData // TypeDefIndex: 18400
	{
		// Properties
		public int rarity { get; set; } // 0x0000000180B15510-0x0000000180B15520 0x0000000180B19030-0x0000000180B19040
		public float? power { get; set; } // 0x0000000184079BF0-0x0000000184079C00 0x0000000182894100-0x0000000182894110
		public float? area { get; set; } // 0x0000000186751C00-0x0000000186751C10 0x0000000182894130-0x0000000182894140
		public float? speed { get; set; } // 0x0000000186751C10-0x0000000186751C20 0x0000000186751C20-0x0000000186751C30
		public int? max { get; set; } // 0x0000000186751C30-0x0000000186751C40 0x0000000186751C40-0x0000000186751C50
		public int? penetrating { get; set; } // 0x0000000185C0DF90-0x0000000185C0DFA0 0x0000000186751C50-0x0000000186751C60
		public int? amount { get; set; } // 0x0000000186751C60-0x0000000186751C70 0x0000000186751C70-0x0000000186751C80
		public float? chance { get; set; } // 0x000000018644F940-0x000000018644F950 0x00000001841C7E30-0x00000001841C7E40
		public int? duration { get; set; } // 0x0000000184B11800-0x0000000184B11810 0x00000001862D7470-0x00000001862D7480
		public float? critChance { get; set; } // 0x000000018644FB20-0x000000018644FB30 0x0000000186751C80-0x0000000186751C90
		public float? cooldown { get; set; } // 0x00000001847E3880-0x00000001847E3890 0x00000001847E3890-0x00000001847E38A0
		public WeaponType? addEvolvedWeapon { get; set; } // 0x0000000184BE3080-0x0000000184BE3090 0x0000000184BE3090-0x0000000184BE30A0
	
		// Constructors
		public LimitBreakData() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void AccumulateData(LimitBreakData limitBreakData) {} // 0x0000000186751C90-0x0000000186751FB0
		public void ApplyDataToWeapon(WeaponData weaponData) {} // 0x0000000186751FB0-0x0000000186752220
		public string GetLocalizedDescription() => default; // 0x0000000186752220-0x0000000186752D70
		private string GetDescription(string term, decimal value, int decimalPlaces = 0 /* Metadata: 0x01978A93 */) => default; // 0x0000000186752D70-0x0000000186752F70
	}
}

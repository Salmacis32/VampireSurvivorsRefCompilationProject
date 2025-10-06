/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	[Serializable]
	public class ModifierStats // TypeDefIndex: 15090
	{
		// Properties
		[JsonProperty("power")]
		public float Power { get; set; } // 0x0000000182740170-0x0000000182740180 0x0000000182740190-0x00000001827401A0
		[JsonProperty("area")]
		public float Area { get; set; } // 0x00000001828A3D30-0x00000001828A3D40 0x00000001828A3D40-0x00000001828A3D50
		[JsonProperty("speed")]
		public float Speed { get; set; } // 0x000000018264AEB0-0x000000018264AEC0 0x0000000183E6B500-0x0000000183E6B510
		[JsonProperty("moveSpeed")]
		public float MoveSpeed { get; set; } // 0x0000000182A6AC90-0x0000000182A6ACA0 0x0000000184F379E0-0x0000000184F379F0
		[JsonProperty("growth")]
		public float Growth { get; set; } // 0x0000000181967D10-0x0000000181967D20 0x0000000184C5EF70-0x0000000184C5EF80
		[JsonProperty("luck")]
		public float Luck { get; set; } // 0x0000000184C5EF80-0x0000000184C5EF90 0x0000000184C5EF90-0x0000000184C5EFA0
		[JsonProperty("duration")]
		public float Duration { get; set; } // 0x000000018273EC30-0x000000018273EC40 0x000000018273EE00-0x000000018273EE10
		[JsonProperty("cooldown")]
		public float Cooldown { get; set; } // 0x0000000181949670-0x0000000181949680 0x0000000181949680-0x0000000181949690
		[JsonProperty("amount")]
		public float Amount { get; set; } // 0x0000000181949690-0x00000001819496A0 0x00000001819496A0-0x00000001819496B0
		[JsonProperty("shields")]
		public float Shields { get; set; } // 0x000000018289A800-0x000000018289A810 0x000000018289C530-0x000000018289C540
		[JsonProperty("armor")]
		public float Armor { get; set; } // 0x000000018278EF40-0x000000018278EF50 0x000000018278EF50-0x000000018278EF60
		[JsonProperty("greed")]
		public float Greed { get; set; } // 0x000000018287CC70-0x000000018287CC80 0x000000018287CC80-0x000000018287CC90
		[JsonProperty("regen")]
		public float Regen { get; set; } // 0x000000018275A5A0-0x000000018275A5B0 0x000000018275A5B0-0x000000018275A5C0
		[JsonProperty("revivals")]
		public double Revivals { get; set; } // 0x00000001841A6E60-0x00000001841A6E70 0x00000001841A6E70-0x00000001841A6E80
		[JsonProperty("rerolls")]
		public float ReRolls { get; set; } // 0x0000000183A343D0-0x0000000183A343E0 0x0000000184C564A0-0x0000000184C564B0
		[JsonProperty("skips")]
		public float Skips { get; set; } // 0x0000000184C564B0-0x0000000184C564C0 0x0000000184C564C0-0x0000000184C564D0
		[JsonProperty("maxHp")]
		public float MaxHp { get; set; } // 0x00000001850805A0-0x00000001850805B0 0x00000001863ED450-0x00000001863ED460
		[JsonProperty("magnet")]
		public float Magnet { get; set; } // 0x00000001850805E0-0x00000001850805F0 0x00000001864C3C50-0x00000001864C3C60
		[JsonProperty("curse")]
		public float Curse { get; set; } // 0x00000001832F7340-0x00000001832F7350 0x000000018474CF00-0x000000018474CF10
		[JsonProperty("banish")]
		public float Banish { get; set; } // 0x000000018289FD70-0x000000018289FD80 0x00000001840BD5F0-0x00000001840BD600
		[JsonProperty("shroud")]
		public float Shroud { get; set; } // 0x000000018288A2A0-0x000000018288A2B0 0x000000018288A2B0-0x000000018288A2C0
		[JsonProperty("charm")]
		public int Charm { get; set; } // 0x0000000181B5A280-0x0000000181B5A290 0x0000000181B5A290-0x0000000181B5A2A0
		[JsonProperty("defang")]
		public float Defang { get; set; } // 0x0000000182886F10-0x0000000182886F20 0x0000000183C00630-0x0000000183C00640
		[JsonProperty("thorns")]
		public float Thorns { get; set; } // 0x000000018288A280-0x000000018288A290 0x000000018288A290-0x000000018288A2A0
		[JsonProperty("invulTimeBonus")]
		public float InvulTimeBonus { get; set; } // 0x000000018599D600-0x000000018599D610 0x00000001867E3C40-0x00000001867E3C50
		[JsonProperty("fever")]
		public float Fever { get; set; } // 0x000000018289FE70-0x000000018289FE80 0x00000001869FE560-0x00000001869FE570
		[JsonProperty("recycle")]
		public float Recycle { get; set; } // 0x000000018289FEA0-0x000000018289FEB0 0x00000001869FE570-0x00000001869FE580
	
		// Constructors
		public ModifierStats() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void ResetStats() {} // 0x00000001869FE580-0x00000001869FE5C0
		public void Upgrade(ModifierStats other, bool multiplicativeMaxHp = false /* Metadata: 0x019772EE */) {} // 0x00000001869FE5C0-0x00000001869FE790
		public void LogClass() {} // 0x00000001869FE790-0x00000001869FE820
		public static ModifierStats operator *(ModifierStats stats, float f) => default; // 0x00000001869FE820-0x00000001869FEA00
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Poncle.Schema.Attributes.Attributes;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Data.Stage
{
	[Serializable]
	public class Event // TypeDefIndex: 18458
	{
		// Properties
		public string eventType { get; set; } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
		public float delay { get; set; } // 0x000000018264AEB0-0x000000018264AEC0 0x0000000183E6B500-0x0000000183E6B510
		public int repeat { get; set; } // 0x00000001819457A0-0x00000001819457B0 0x00000001819457B0-0x00000001819457C0
		public float? chance { get; set; } // 0x0000000180B15530-0x0000000180B15540 0x0000000182759650-0x0000000182759660
		public float? duration { get; set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000185A2C780-0x0000000185A2C790
		[Type(new System.Type[2] {typeof(string), typeof(float) })]
		public int moreX { get; set; } // 0x0000000181953B80-0x0000000181953B90 0x0000000181953B90-0x0000000181953BA0
		[Type(new System.Type[3] {typeof(string), typeof(float), typeof(string[]) })]
		public object moreY { get; set; } // 0x0000000180B15560-0x0000000180B15570 0x0000000181953C20-0x0000000181953C80
		public float moreZ { get; set; } // 0x000000018275A5A0-0x000000018275A5B0 0x000000018275A5B0-0x000000018275A5C0
		public int minPlayersNeeded { get; set; } // 0x00000001828975B0-0x00000001828975C0 0x00000001828975C0-0x00000001828975D0
	
		// Constructors
		public Event() {} // 0x0000000180B15170-0x0000000180B15180
	}
}

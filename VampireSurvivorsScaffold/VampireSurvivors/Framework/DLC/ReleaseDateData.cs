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
	public class ReleaseDateData // TypeDefIndex: 18333
	{
		// Fields
		[Tooltip("Date in UK format... not American")]
		public DateInt _Date; // 0x10
		[Tooltip("Time in 24hr clock format")]
		public TimeInt _Time; // 0x1C
	
		// Nested types
		[Serializable]
		public struct DateInt // TypeDefIndex: 18331
		{
			// Fields
			public int _Day; // 0x00
			public int _Month; // 0x04
			public int _Year; // 0x08
		}
	
		[Serializable]
		public struct TimeInt // TypeDefIndex: 18332
		{
			// Fields
			public int _Hour; // 0x00
			public int _Minute; // 0x04
			public int _Second; // 0x08
		}
	
		// Constructors
		public ReleaseDateData() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public DateTime GetUtcDateTime() => default; // 0x00000001867302E0-0x0000000186730330
		public bool HasDatePassed() => default; // 0x0000000186730330-0x00000001867303E0
	}
}

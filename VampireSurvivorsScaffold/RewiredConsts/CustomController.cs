/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace RewiredConsts
{
	public static class CustomController // TypeDefIndex: 13900
	{
		// Nested types
		public static class OnScreenJoystick // TypeDefIndex: 13896
		{
			// Fields
			public const int sourceId = 0; // Metadata: 0x01976AD4
			public const string name = "OnScreenJoystick"; // Metadata: 0x01976AD5
			public static readonly Guid typeGuid; // 0x00
	
			// Nested types
			public static class Axis // TypeDefIndex: 13895
			{
				// Fields
				public const int StickX = 0; // Metadata: 0x01976AE6
				public const int StickY = 1; // Metadata: 0x01976AE7
			}
	
			// Constructors
			static OnScreenJoystick() {} // 0x00000001865BC1B0-0x00000001865BC310
		}
	
		public static class AutomationVirtualGamepad // TypeDefIndex: 13899
		{
			// Fields
			public const int sourceId = 1; // Metadata: 0x01976AE8
			public const string name = "AutomationVirtualGamepad"; // Metadata: 0x01976AE9
			public static readonly Guid typeGuid; // 0x00
	
			// Nested types
			public static class Axis // TypeDefIndex: 13897
			{
				// Fields
				public const int Left_Stick_X_Axis = 0; // Metadata: 0x01976B02
				public const int Left_Stick_Y_Axis = 1; // Metadata: 0x01976B03
			}
	
			public static class Button // TypeDefIndex: 13898
			{
				// Fields
				public const int Confirm__A_ = 2; // Metadata: 0x01976B04
				public const int Cancel__B_ = 3; // Metadata: 0x01976B05
				public const int Start = 4; // Metadata: 0x01976B06
			}
	
			// Constructors
			static AutomationVirtualGamepad() {} // 0x00000001865BC310-0x00000001865BC470
		}
	}
}

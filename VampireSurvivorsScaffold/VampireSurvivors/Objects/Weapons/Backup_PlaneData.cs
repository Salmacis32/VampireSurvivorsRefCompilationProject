/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class Backup_PlaneData // TypeDefIndex: 16129
	{
		// Fields
		public PhaserSprite planeSprite; // 0x10
		public float curveTime; // 0x18
		public float2 positionOffset; // 0x1C
		public VampireSurvivors.Framework.TimerSystem.Timer delay; // 0x28
		public bool available; // 0x30
		public bool moving; // 0x31
		public VampireSurvivors.Framework.TimerSystem.Timer[] explosionTimers; // 0x38
		public float2 direction; // 0x40
	
		// Constructors
		public Backup_PlaneData() {} // 0x000000018364F780-0x000000018364F790
	}
}

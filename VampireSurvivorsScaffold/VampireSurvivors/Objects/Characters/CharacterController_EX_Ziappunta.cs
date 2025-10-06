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
	public class CharacterController_EX_Ziappunta : CharacterController // TypeDefIndex: 16990
	{
		// Fields
		protected float _spawnPROPS_Delay; // 0x3F0
		protected float _spawnPROPS_Time; // 0x3F4
		protected VampireSurvivors.Framework.TimerSystem.Timer _PROPSactivationTimer; // 0x3F8
		protected List<PropType> _PROPSTypes; // 0x400
		protected bool _spawnExtraProps; // 0x408
		public int SpecialChestsSpawned; // 0x40C
	
		// Constructors
		public CharacterController_EX_Ziappunta() {} // 0x000000018713C320-0x000000018713C3F0
	
		// Methods
		public override void AfterFullInitialization() {} // 0x000000018713BCC0-0x000000018713BE10
		protected float PROPSSpawnInterval() => default; // 0x000000018713BE10-0x000000018713BE20
		protected override void OnUpdate() {} // 0x000000018713BE20-0x000000018713BFA0
		protected void SpawnProps() {} // 0x000000018713BFA0-0x000000018713C310
		public bool CheckAchievementStats() => default; // 0x000000018713C310-0x000000018713C320
	}
}

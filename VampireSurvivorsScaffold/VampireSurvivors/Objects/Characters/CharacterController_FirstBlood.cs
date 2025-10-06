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
	public class CharacterController_FirstBlood : CharacterController // TypeDefIndex: 16991
	{
		// Fields
		protected float _spawnPROPS_Delay; // 0x3F0
		protected float _spawnPROPS_Time; // 0x3F4
		protected VampireSurvivors.Framework.TimerSystem.Timer _PROPSactivationTimer; // 0x3F8
		protected List<PropType> _PROPSTypes; // 0x400
		protected bool _spawnExtraProps; // 0x408
	
		// Constructors
		public CharacterController_FirstBlood() {} // 0x000000018713D020-0x000000018713D0F0
	
		// Methods
		public override void AfterFullInitialization() {} // 0x000000018713C400-0x000000018713C780
		public override void OnDeath() {} // 0x000000018713C780-0x000000018713C950
		private void PlayDeathSound() {} // 0x000000018713C950-0x000000018713CB00
		protected float PROPSSpawnInterval() => default; // 0x000000018712C990-0x000000018712C9D0
		protected override void OnUpdate() {} // 0x000000018713CB00-0x000000018713CCB0
		protected void SpawnProps() {} // 0x000000018713CCB0-0x000000018713D020
	}
}

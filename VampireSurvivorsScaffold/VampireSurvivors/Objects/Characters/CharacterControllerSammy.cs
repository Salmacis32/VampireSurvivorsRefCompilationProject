/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterControllerSammy : CharacterController // TypeDefIndex: 16964
	{
		// Fields
		private Action<float> _onCoinPickupCallback; // 0x3F0
		private GrangattiWeapon _hungerWeapon; // 0x3F8
		private VampireSurvivors.Framework.TimerSystem.Timer _timeout1; // 0x400
		private VampireSurvivors.Framework.TimerSystem.Timer _timeout2; // 0x408
		private VampireSurvivors.Framework.TimerSystem.Timer _timeout3; // 0x410
	
		// Constructors
		public CharacterControllerSammy() {} // 0x0000000187107F90-0x0000000187107FA0
	
		// Methods
		public override void AfterFullInitialization() {} // 0x00000001871245F0-0x00000001871248C0
		public override void OnQuit() {} // 0x00000001871248C0-0x0000000187124960
		public override void LevelUp() {} // 0x0000000187124960-0x0000000187124B00
		public void OnCoinPickup(float value) {} // 0x0000000187124B00-0x0000000187124CC0
	}
}

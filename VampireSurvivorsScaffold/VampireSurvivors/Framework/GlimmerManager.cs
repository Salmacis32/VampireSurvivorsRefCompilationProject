/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	public class GlimmerManager // TypeDefIndex: 17492
	{
		// Fields
		private bool m_isFirstGlimmering; // 0x10
		private EME_Weapon m_currentFirstGlimmeringWeapon; // 0x18
	
		// Properties
		public bool IsFirstGlimmering { get => default; } // 0x0000000180B15AC0-0x0000000180B15AD0 
	
		// Constructors
		public GlimmerManager() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void AddNewGlimmerTechniqueToShow(Tuple<string, WeaponType> glimmerNameAndType) {} // 0x0000000187329D40-0x0000000187329F40
		public bool SetFirstGlimmering(EME_Weapon firstGlimmeringWeapon) => default; // 0x0000000187329F40-0x000000018732A100
		private void ClearFirstGlimmering() {} // 0x000000018732A100-0x000000018732A210
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_WindWhip1_Weapon : Weapon // TypeDefIndex: 16526
	{
		// Fields
		protected int _fireCounter; // 0x158
		protected int _specialCounter; // 0x15C
		protected int _subWeaponCounter; // 0x160
	
		// Constructors
		public TP_WindWhip1_Weapon() {} // 0x0000000187000BD0-0x0000000187000C40
	
		// Methods
		public override float PPower() => default; // 0x0000000187000B00-0x0000000187000B50
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B209C0-0x0000000180B209D0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977D28 */) {} // 0x0000000187000B50-0x0000000187000BD0
		public virtual void OnSpecialCounter(bool skipTriggers = false /* Metadata: 0x01977D29 */) {} // 0x0000000180B15170-0x0000000180B15180
		public virtual void OnSubWeaponCounter(bool skipTriggers = false /* Metadata: 0x01977D2A */) {} // 0x0000000180B15170-0x0000000180B15180
		public override void CheckArcanas() {} // 0x0000000186F8E930-0x0000000186F8E9F0
	}
}

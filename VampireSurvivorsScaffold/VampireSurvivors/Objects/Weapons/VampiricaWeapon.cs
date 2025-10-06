/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.TimerSystem;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class VampiricaWeapon : Weapon // TypeDefIndex: 16793
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _healTimer; // 0x158
		private bool _canHeal; // 0x160
		private float _healDelay; // 0x164
	
		// Constructors
		public VampiricaWeapon() {} // 0x00000001870C45A0-0x00000001870C4600
	
		// Methods
		public override void CheckArcanas() {} // 0x0000000186F8E930-0x0000000186F8E9F0
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870C41F0-0x00000001870C45A0
	}
}

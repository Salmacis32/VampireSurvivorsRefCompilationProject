/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Props
{
	public class PropCart : Destructible // TypeDefIndex: 15364
	{
		// Fields
		private WeaponsFacade _weaponsFacade; // 0xF8
		private bool _hasFired; // 0x100
		private static VampireSurvivors.Framework.TimerSystem.Timer _timerEvent; // 0x00
	
		// Constructors
		public PropCart() {} // 0x00000001869ECEE0-0x00000001869ECF40
	
		// Methods
		[Inject]
		private void Construct(WeaponsFacade weaponsFacade) {} // 0x0000000180B3E800-0x0000000180B3E860
		public override void Init(PropType destructibleType) {} // 0x0000000186B99BD0-0x0000000186B99C80
		protected override void OnDestroyed() {} // 0x0000000186B99C80-0x0000000186B9A0C0
	}
}

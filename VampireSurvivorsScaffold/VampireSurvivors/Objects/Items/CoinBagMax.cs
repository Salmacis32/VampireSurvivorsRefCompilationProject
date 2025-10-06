/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors;
using VampireSurvivors.Objects.Pickups;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Items
{
	public class CoinBagMax : Pickup // TypeDefIndex: 16026
	{
		// Fields
		private GoldFeverController _goldFever; // 0x138
	
		// Constructors
		public CoinBagMax() {} // 0x0000000186EB8FF0-0x0000000186EB9040
	
		// Methods
		[Inject]
		private void InjectGoldFever(GoldFeverController gold) {} // 0x0000000185D80170-0x0000000185D801D0
		protected override void Awake() {} // 0x0000000186EB7BB0-0x0000000186EB7BE0
		public override void GetTaken() {} // 0x0000000186EB8E60-0x0000000186EB8FF0
	}
}

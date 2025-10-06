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
	public class CoinBag1 : Pickup, ICountedPickup // TypeDefIndex: 16024
	{
		// Fields
		private GoldFeverController _goldFever; // 0x140
	
		// Properties
		public int AmountOnCollection { get; set; } // 0x0000000182944690-0x00000001829446A0 0x0000000186560990-0x00000001865609A0
	
		// Constructors
		public CoinBag1() {} // 0x0000000186EB8C70-0x0000000186EB8CD0
	
		// Methods
		[Inject]
		private void InjectGoldFever(GoldFeverController gold) {} // 0x0000000185F85960-0x0000000185F859C0
		protected override void Awake() {} // 0x0000000186EB7BB0-0x0000000186EB7BE0
		public override void GetTaken() {} // 0x0000000186EB8A40-0x0000000186EB8BD0
		public override void Despawn() {} // 0x0000000186EB8BD0-0x0000000186EB8C70
	}
}

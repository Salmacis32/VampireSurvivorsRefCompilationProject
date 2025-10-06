/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Pickups;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Items
{
	public class Coin : Pickup, ICountedPickup // TypeDefIndex: 16023
	{
		// Fields
		private GoldFeverController _goldFever; // 0x138
		private bool _isJewel; // 0x140
		private List<string> jewelFrames; // 0x148
	
		// Properties
		public int AmountOnCollection { get; set; } // 0x000000018208C620-0x000000018208C630 0x000000018208C630-0x000000018208C640
	
		// Constructors
		public Coin() {} // 0x0000000186EB85F0-0x0000000186EB8A40
	
		// Methods
		[Inject]
		private void InjectGoldFever(GoldFeverController gold) {} // 0x0000000185D80170-0x0000000185D801D0
		protected override void Awake() {} // 0x0000000186EB7F80-0x0000000186EB7FC0
		public override void SetData(VampireSurvivors.Data.ItemType itemType) {} // 0x0000000186EB7FC0-0x0000000186EB7FF0
		public override void Despawn() {} // 0x0000000186EB7FF0-0x0000000186EB81B0
		public override void GetTaken() {} // 0x0000000186EB81B0-0x0000000186EB83C0
		public override void Bless(float value, HitVfxType hitVFXType = HitVfxType.Prism /* Metadata: 0x019779EF */) {} // 0x0000000186EB83C0-0x0000000186EB8490
		public void Bejewel() {} // 0x0000000186EB8490-0x0000000186EB8560
		public void PublicSetSprite(string frameName, string textureName) {} // 0x0000000186EB8560-0x0000000186EB85F0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Items
{
	public class Pickup_Bonus_FrozenSoul : NetworkPickup, ICountedPickup // TypeDefIndex: 16064
	{
		// Fields
		private static int _sfxIndex; // 0x00
		private static float[] _detuneValues; // 0x08
		protected float _MaxHpMul; // 0x174
		protected float _RegenMul; // 0x178
		protected float _GrowthMul; // 0x17C
		private int _prevDepth; // 0x180
	
		// Properties
		public int AmountOnCollection { get; set; } // 0x00000001827669C0-0x00000001827669D0 0x0000000186EDD140-0x0000000186EDD150
	
		// Constructors
		public Pickup_Bonus_FrozenSoul() {} // 0x0000000186EDDAE0-0x0000000186EDDB20
		static Pickup_Bonus_FrozenSoul() {} // 0x0000000186EDDB20-0x0000000186EDDC20
	
		// Methods
		private static float GetDetune() => default; // 0x0000000186EDD150-0x0000000186EDD200
		protected override void Awake() {} // 0x0000000186EBAAB0-0x0000000186EBAAE0
		public override void GetTaken() {} // 0x0000000186EDD200-0x0000000186EDD740
		public override void UpdateDepth() {} // 0x0000000186EDD740-0x0000000186EDD820
		public override void Despawn() {} // 0x0000000186EDD820-0x0000000186EDD9D0
		protected override void ReturnPickupToPool() {} // 0x0000000186EDD9D0-0x0000000186EDDA70
		protected override void PreOnlineVacuum() {} // 0x0000000186EDDA70-0x0000000186EDDAE0
		protected override void PreOnlineTake() {} // 0x0000000186EDDA70-0x0000000186EDDAE0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Items
{
	public class PickupMerchantEgg : Pickup // TypeDefIndex: 16056
	{
		// Fields
		private ParticleEmitterManager _particleEmitterManager; // 0x138
		private ParticleSystem _pfxEmitter; // 0x140
	
		// Constructors
		public PickupMerchantEgg() {} // 0x0000000186ED2850-0x0000000186ED28A0
	
		// Methods
		protected override void Awake() {} // 0x0000000186ED1A10-0x0000000186ED1A50
		public override void SetData(VampireSurvivors.Data.ItemType itemType) {} // 0x0000000186ED1A50-0x0000000186ED1CA0
		public override void InternalUpdate() {} // 0x0000000186ECB110-0x0000000186ECB140
		public override void UpdateDepth() {} // 0x0000000186ED1CA0-0x0000000186ED1D10
		public override void GetTaken() {} // 0x0000000186ED1D10-0x0000000186ED1DC0
		private void GenerateParticleSystem() {} // 0x0000000186ED1DC0-0x0000000186ED2850
	}
}

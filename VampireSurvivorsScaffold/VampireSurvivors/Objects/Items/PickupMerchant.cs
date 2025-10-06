/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence;
using Coherence.Toolkit;
using UnityEngine;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Items
{
	public class PickupMerchant : NetworkPickup // TypeDefIndex: 16054
	{
		// Fields
		private ParticleEmitterManager _particleEmitterManager; // 0x170
		private ParticleSystem _pfxEmitter; // 0x178
	
		// Properties
		protected override bool UsesOrderedCommand { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public PickupMerchant() {} // 0x0000000186EB9C10-0x0000000186EB9C20
	
		// Methods
		protected override void Awake() {} // 0x0000000186ECFDC0-0x0000000186ECFE00
		public override void SetData(VampireSurvivors.Data.ItemType itemType) {} // 0x0000000186ECFE00-0x0000000186ED01F0
		public void RunAway(Vector2 velocity) {} // 0x0000000186ED01F0-0x0000000186ED0340
		public override void InternalUpdate() {} // 0x0000000186ECB110-0x0000000186ECB140
		public override void UpdateDepth() {} // 0x0000000186ED0340-0x0000000186ED03B0
		public override void GetTaken() {} // 0x0000000186ED03B0-0x0000000186ED0460
		[Command(defaultRouting = MessageTarget.AuthorityOnly)]
		public void RequestMerchantTake(CoherenceSync openingPlayer) {} // 0x0000000186ED0460-0x0000000186ED07B0
		[Command]
		public void PerformMerchantTake(long startingSimFrame, CoherenceSync openingPlayer, byte[] serializedWeapons, byte[] serializedItems) {} // 0x0000000186ED07B0-0x0000000186ED0B80
		public override void GetOnlineTaken() {} // 0x0000000186ED0B80-0x0000000186ED0CB0
		private void GenerateParticleSystem() {} // 0x0000000186ED0CB0-0x0000000186ED1880
	}
}

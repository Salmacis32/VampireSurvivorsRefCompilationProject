/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Items
{
	public class PickupGoldenEgg : NetworkPickup // TypeDefIndex: 16048
	{
		// Fields
		private EggManager _eggManager; // 0x170
	
		// Properties
		[Sync]
		public uint Seed { get; set; } // 0x00000001827669B0-0x00000001827669C0 0x0000000186ECB000-0x0000000186ECB010
	
		// Constructors
		public PickupGoldenEgg() {} // 0x0000000186EB9C10-0x0000000186EB9C20
	
		// Methods
		[Inject]
		private void Construct(EggManager eggManager) {} // 0x0000000185C36330-0x0000000185C36390
		protected override void Awake() {} // 0x0000000186EBAAB0-0x0000000186EBAAE0
		public override void SetData(VampireSurvivors.Data.ItemType itemType) {} // 0x0000000186ECB010-0x0000000186ECB110
		public override void InternalUpdate() {} // 0x0000000186ECB110-0x0000000186ECB140
		public override void Despawn() {} // 0x0000000186ECB140-0x0000000186ECB250
		public override void GetTaken() {} // 0x0000000186ECB250-0x0000000186ECBAE0
		private void SpawnCursor() {} // 0x0000000186ECBAE0-0x0000000186ECBED0
		private void RemoveCursor() {} // 0x0000000186ECBED0-0x0000000186ECBFA0
		protected override void ToggleCursors(UISignals.ToggleGuidesSignal sig) {} // 0x0000000186ECBFA0-0x0000000186ECC080
	}
}

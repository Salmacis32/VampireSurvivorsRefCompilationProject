/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using UnityEngine;
using VampireSurvivors.App.Objects;
using VampireSurvivors.Objects.Stages;
using VampireSurvivors.Signals;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Items
{
	public class Pickup_EME_Teleporter : PickupTeleporter // TypeDefIndex: 16073
	{
		// Fields
		[SerializeField]
		private GameObject _doorClosed; // 0x230
		[SerializeField]
		private GameObject _doorOpen; // 0x238
		[SerializeField]
		private float _playerProximityDistance; // 0x240
		[SerializeField]
		private float _maxDisabledTime; // 0x244
		private MapToken _mapToken; // 0x248
		private EME_TeleportFader _teleportFader; // 0x250
		private float _disabledTimer; // 0x258
		private bool _disabledDueToProximity; // 0x25C
		[SerializeField]
		public BackgroundEmerald.EmeraldsBiomes EmeraldBiome; // 0x260
		private BackgroundEmerald _bgManager; // 0x268
		private BackgroundEmerald.EmeraldsBiomes _myBiome; // 0x270
		private bool _showingCursor; // 0x274
		private bool _wantsCursors; // 0x275
		private bool _isOpen; // 0x276
	
		// Properties
		[Sync]
		public string DestinationName { get; set; } // 0x0000000186753760-0x0000000186753770 0x0000000186753770-0x00000001867537D0
	
		// Constructors
		public Pickup_EME_Teleporter() {} // 0x0000000186EE2400-0x0000000186EE2430
	
		// Methods
		public void Init(EME_TeleportFader teleportFader) {} // 0x0000000186EE0B10-0x0000000186EE0FC0
		public void SetDoorOpen(bool isOpen) {} // 0x0000000186EE0FC0-0x0000000186EE12F0
		public void SetDestinationName(string destination) {} // 0x0000000186753770-0x00000001867537D0
		public override void GetOnlineTaken() {} // 0x0000000186EE12F0-0x0000000186EE1460
		public override void GetTaken() {} // 0x0000000186EE1460-0x0000000186EE1630
		protected override void DoTeleportAnimation() {} // 0x0000000186EE1630-0x0000000186EE1710
		protected override void GenerateSpritesAndAnims() {} // 0x0000000186EE1710-0x0000000186EE1810
		private void InvertDoor(Transform doorTransform) {} // 0x0000000186EE1810-0x0000000186EE1960
		public void TemporarilyDisableDueToProximity() {} // 0x0000000186EE1960-0x0000000186EE1970
		public override void InternalUpdate() {} // 0x0000000186EE1970-0x0000000186EE1DE0
		public void SetMapTokenHidden(bool isHidden) {} // 0x0000000186EE1DE0-0x0000000186EE1E00
		protected override void OnDrawGizmos() {} // 0x0000000186EE1E00-0x0000000186EE1FB0
		protected override void ToggleCursors(UISignals.ToggleGuidesSignal sig) {} // 0x0000000186EE1FB0-0x0000000186EE1FD0
		private void SpawnCursor() {} // 0x0000000186EE1FD0-0x0000000186EE2330
		private void RemoveCursor() {} // 0x0000000186EE2330-0x0000000186EE2400
	}
}

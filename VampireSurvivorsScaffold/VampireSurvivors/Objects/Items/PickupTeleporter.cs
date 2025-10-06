/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Items
{
	public class PickupTeleporter : PickupGuarded // TypeDefIndex: 16059
	{
		// Fields
		[OnValueSynced("OnGateIndexChanged")]
		[Sync]
		public int GateIndex; // 0x1D0
		private bool _canTeleport; // 0x1D4
		private bool _canTeleportLocally; // 0x1D5
		private string _teleporterKey; // 0x1D8
		private float _destinationX; // 0x1E0
		private float _destinationY; // 0x1E4
		private Tween _glowTween; // 0x1E8
		private PickupTeleporter _link; // 0x1F0
		protected PhaserSprite _door; // 0x1F8
		protected bool _hasDoorAnimation; // 0x200
		[Sync]
		public float _triggerDelay; // 0x204
		private bool _teleporting; // 0x208
	
		// Properties
		[Sync]
		public bool CanTeleport { get => default; set {} } // 0x0000000186ED6A00-0x0000000186ED6A10 0x0000000186ED6A10-0x0000000186ED6A20
		public bool CanTeleportLocally { get => default; set {} } // 0x0000000186ED6A20-0x0000000186ED6A30 0x0000000186ED6A30-0x0000000186ED6A40
		[Sync]
		public GameObject Link { get => default; set {} } // 0x0000000186ED6A40-0x0000000186ED6B40 0x0000000186ED6B40-0x0000000186ED6D20
		[Sync]
		public bool IsAstralSecretDoor { get; set; } // 0x0000000185563830-0x0000000185563840 0x0000000186ED6D20-0x0000000186ED6D30
		[Sync]
		public string TeleporterKey { get => default; set {} } // 0x0000000182766D00-0x0000000182766D10 0x0000000182766D10-0x0000000182766D70
	
		// Events
		public event Action<VampireSurvivors.Objects.Characters.CharacterController> OnTeleportStartedAction;
		public event Action OnTeleportFinishedAction;
		public event Action<VampireSurvivors.Objects.Characters.CharacterController> OnPlayersTeleported;
	
		// Constructors
		public PickupTeleporter() {} // 0x0000000186ED9060-0x0000000186ED9090
	
		// Methods
		protected virtual void OnDrawGizmos() {} // 0x0000000186ED6D30-0x0000000186ED7040
		public override void SetData(VampireSurvivors.Data.ItemType itemType) {} // 0x0000000186ED7040-0x0000000186ED70C0
		public void SetTeleportKey(string teleportKey) {} // 0x0000000182766D10-0x0000000182766D70
		protected override void OnUpdate() {} // 0x0000000186ED70C0-0x0000000186ED71D0
		public override void GetTaken() {} // 0x0000000186ED71D0-0x0000000186ED72F0
		public override void GetOnlineTaken() {} // 0x0000000186ED72F0-0x0000000186ED73A0
		private bool CheckCanTakeTeleport() => default; // 0x0000000186ED73A0-0x0000000186ED7440
		protected override void TrackItemPickup(bool trackRunPickup = true /* Metadata: 0x01977A05 */) {} // 0x0000000186ED7440-0x0000000186ED7480
		public override void Despawn() {} // 0x0000000180B15170-0x0000000180B15180
		public void ActuallyDespawn() {} // 0x0000000186ED7480-0x0000000186ED7490
		public void LinkTo(PickupTeleporter gate) {} // 0x0000000186ED7490-0x0000000186ED7650
		public void Disable() {} // 0x0000000186ED7650-0x0000000186ED7730
		public void ForceDestination(float x, float y) {} // 0x0000000186ED7730-0x0000000186ED7750
		protected virtual void OnGateIndexChanged(int oldValue, int newValue) {} // 0x0000000180B15170-0x0000000180B15180
		protected override void OnRecycle() {} // 0x0000000186ED7750-0x0000000186ED7800
		protected virtual void GenerateSpritesAndAnims() {} // 0x0000000186ED7800-0x0000000186ED7C50
		protected virtual void DoTeleportAnimation() {} // 0x0000000186ED7C50-0x0000000186ED7DE0
		private void OnTweenYoyo() {} // 0x0000000186ED7DE0-0x0000000186ED7EE0
		public override void DisposeAsTaken() {} // 0x0000000186ED7EE0-0x0000000186ED8060
		public void CleanUpCallbacks() {} // 0x0000000186ED8060-0x0000000186ED8120
		private void StartTeleport() {} // 0x0000000186ED8120-0x0000000186ED83F0
		protected void DoTeleport() {} // 0x0000000186ED83F0-0x0000000186ED8970
		private float2 SecretCheck(float2 destinationPos, out bool secretFound) {
			secretFound = default;
			return default;
		} // 0x0000000186ED8970-0x0000000186ED8D40
		protected void OnTeleportFinished() {} // 0x0000000186ED8D40-0x0000000186ED8FF0
		private void CheckForWeapons(float2 destinationPos) {} // 0x0000000186ED8FF0-0x0000000186ED9060
	}
}

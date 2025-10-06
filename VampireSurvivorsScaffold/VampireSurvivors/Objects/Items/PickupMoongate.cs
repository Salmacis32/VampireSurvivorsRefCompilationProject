/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using DG.Tweening;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Items
{
	public class PickupMoongate : PickupGuarded // TypeDefIndex: 16057
	{
		// Fields
		private SpriteRenderer _glow; // 0x1D0
		private float _colorValue; // 0x1D8
		private Tween _glowTween; // 0x1E0
		private ParticleSystem _pfx; // 0x1E8
		private PickupMoongate _linkedGate; // 0x1F0
		private bool _canTeleport; // 0x1F8
		private bool _canTeleportLocally; // 0x1F9
		private const float TriggerDelay = 20000f; // Metadata: 0x01977A00
	
		// Properties
		[Sync]
		public bool CanTeleport { get => default; set {} } // 0x0000000185FA2570-0x0000000185FA2580 0x0000000186ED28A0-0x0000000186ED28B0
		public bool CanTeleportLocally { get => default; set {} } // 0x0000000186ED28B0-0x0000000186ED28C0 0x0000000186ED28C0-0x0000000186ED28D0
		[Sync]
		public GameObject Link { get => default; set {} } // 0x0000000186ED28D0-0x0000000186ED29D0 0x0000000186ED29D0-0x0000000186ED2BA0
	
		// Constructors
		public PickupMoongate() {} // 0x0000000186ED4370-0x0000000186ED4380
	
		// Methods
		protected override void Awake() {} // 0x0000000186ED2BA0-0x0000000186ED2DF0
		public override void InternalUpdate() {} // 0x0000000186ED2DF0-0x0000000186ED2E40
		public void LinkTo(PickupMoongate moongate) {} // 0x0000000186747280-0x00000001867472E0
		public override void UpdateDepth() {} // 0x0000000186ED2E40-0x0000000186ED2F00
		protected override void OnRecycle() {} // 0x0000000186ED2F00-0x0000000186ED31E0
		private void UpdateGlowColor() {} // 0x0000000186ED31E0-0x0000000186ED3480
		public override void GetTaken() {} // 0x0000000186ED3480-0x0000000186ED3700
		public override void GetOnlineTaken() {} // 0x0000000186ED3700-0x0000000186ED37B0
		private bool CheckCanTakeTeleport() => default; // 0x0000000186ED37B0-0x0000000186ED3850
		private void TempDisableTeleport() {} // 0x0000000186ED3850-0x0000000186ED3940
		private void GenerateParticleSystem() {} // 0x0000000186ED3940-0x0000000186ED4370
	}
}

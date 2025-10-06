/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence;
using Coherence.Connection;
using Coherence.Log;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings.TransformBindings;
using UnityEngine;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	[RequireComponent(typeof(CoherenceSync))]
	public class NetworkPickup : Pickup // TypeDefIndex: 14028
	{
		// Fields
		protected CoherenceSync _coherenceSync; // 0x138
		protected bool _vacuumAssigned; // 0x140
		protected bool _takeAssigned; // 0x141
		protected bool _performingVacuum; // 0x142
		protected bool _performingTake; // 0x143
		protected bool _requestedVacuum; // 0x144
		protected bool _requestedTake; // 0x145
		protected List<ClientID> _ackedClients; // 0x148
		protected bool _taken; // 0x150
		protected bool _canPauseSyncTimer; // 0x151
		protected bool _reactivateRenderer; // 0x152
		protected Coherence.Log.Logger _logger; // 0x158
		private PositionBinding _positionBinding; // 0x160
		private float _ackTimeout; // 0x168
		private const float MaxAckTimeout = 3.4028235E+38f; // Metadata: 0x01976CDA
	
		// Properties
		protected virtual bool UsesOrderedCommand { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		public CoherenceSync Sync { get => default; } // 0x0000000184F612E0-0x0000000184F612F0 
		public bool ForceDespawn { get; set; } // 0x0000000184F54F20-0x0000000184F54F30 0x0000000186AE3610-0x0000000186AE3620
	
		// Constructors
		public NetworkPickup() {} // 0x0000000186AE8FE0-0x0000000186AE90E0
	
		// Methods
		[Command(defaultRouting = MessageTarget.AuthorityOnly)]
		public void RequestVacuum(CoherenceSync requestingPlayer) {} // 0x0000000186AE3620-0x0000000186AE3D10
		[Command]
		public void PerformVacuum(long startingSimFrame, CoherenceSync requestingPlayer) {} // 0x0000000186AE3D10-0x0000000186AE4910
		[Command(defaultRouting = MessageTarget.AuthorityOnly)]
		public void RequestTake(CoherenceSync requestingPlayer) {} // 0x0000000186AE4910-0x0000000186AE5130
		[Command]
		public void PerformTake(long startingSimFrame, CoherenceSync requestingPlayer) {} // 0x0000000186AE5130-0x0000000186AE5D00
		[Command(defaultRouting = MessageTarget.AuthorityOnly)]
		public void AckTake(uint clientId) {} // 0x0000000186AE5D00-0x0000000186AE61E0
		[Command(defaultRouting = MessageTarget.AuthorityOnly)]
		public void OnlineForceDespawn() {} // 0x0000000186AE61E0-0x0000000186AE6200
		public virtual bool GetOnlineVacuum(VampireSurvivors.Objects.Characters.CharacterController targetPlayer) => default; // 0x0000000186AE6200-0x0000000186AE6820
		public virtual void GetOnlineTaken() {} // 0x0000000186AE6820-0x0000000186AE6E00
		protected override void Awake() {} // 0x0000000186AE6E00-0x0000000186AE6FE0
		protected override void OnEnable() {} // 0x0000000186AE6FE0-0x0000000186AE7000
		protected virtual void PreOnlineVacuum() {} // 0x0000000180B15170-0x0000000180B15180
		protected virtual void PreOnlineTake() {} // 0x0000000180B15170-0x0000000180B15180
		protected void Reset() {} // 0x0000000186AE7000-0x0000000186AE7550
		public override void Despawn() {} // 0x0000000186AE7550-0x0000000186AE75F0
		protected void OnlineDespawn() {} // 0x0000000186AE75F0-0x0000000186AE8660
		public override void GetTaken() {} // 0x0000000186AE8660-0x0000000186AE8B70
		[IteratorStateMachine(typeof(_WaitForAcksAndReturnToPool_d__39))]
		private IEnumerator WaitForAcksAndReturnToPool() => default; // 0x0000000186AE8B70-0x0000000186AE8C10
		private bool AllConnectedClientsAckedPickup() => default; // 0x0000000186AE8C10-0x0000000186AE8E60
		protected virtual void ReturnPickupToPool() {} // 0x0000000186AE8E60-0x0000000186AE8EB0
		private static float GetMaxAckTimeout() => default; // 0x0000000186AE8EB0-0x0000000186AE8FA0
		protected bool IsBeingTaken() => default; // 0x0000000186AE8FA0-0x0000000186AE8FC0
		protected bool IsBeingVacuumed() => default; // 0x0000000186AE8FC0-0x0000000186AE8FE0
		private bool IsPickupAlreadyDestroyed() => default; // 0x0000000185557750-0x0000000185557760
	}
}

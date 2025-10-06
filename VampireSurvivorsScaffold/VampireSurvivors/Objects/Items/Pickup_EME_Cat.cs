/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Items
{
	public class Pickup_EME_Cat : NetworkPickup // TypeDefIndex: 16071
	{
		// Fields
		[SerializeField]
		private bool _randomiseColour; // 0x170
		[SerializeField]
		private float _aggroRange; // 0x174
		[SerializeField]
		private float _runSpeed; // 0x178
		[SerializeField]
		[Space]
		private CatDespawnBehaviourType _despawnBehaviourType; // 0x17C
		[SerializeField]
		private float _maxDistanceFromPlayerBeforeDespawn; // 0x180
		[Header("Pickup Rewards")]
		[SerializeField]
		private float _healthRecoveredOnPickup; // 0x184
		[SerializeField]
		private bool _triggerVacuumOnPickup; // 0x188
		[SerializeField]
		private bool _giveStatRewardOnPickup; // 0x189
		[SerializeField]
		private CatPickupReward[] _pickupRewards; // 0x190
		protected VampireSurvivors.Objects.Characters.CharacterController AmeyaPlayer; // 0x198
		private CatBehaviourState _currentCatBehaviourState; // 0x1A0
		private Vector2 _velocity; // 0x1A4
		private uint _rewardSeed; // 0x1AC
		private uint _catTypeSeed; // 0x1B0
		protected Unity.Mathematics.Random _rewardRng; // 0x1B4
		protected Unity.Mathematics.Random _catTypeRng; // 0x1B8
		private static int _sfxIndex; // 0x00
		private const string IdleAnimationName = "idle"; // Metadata: 0x01977AD2
		private const string FleeAnimationName = "flee"; // Metadata: 0x01977AD7
		private const string DraggedAnimationName = "dragged"; // Metadata: 0x01977ADC
		protected const string EmeraldsTextureName = "character_eme_witch"; // Metadata: 0x01977AE4
		private readonly float[] _detuneValues; // 0x1C0
		public Action OnGoToPlayer; // 0x1C8
		public Action OnDespawn; // 0x1D0
	
		// Properties
		[Sync]
		public uint RewardSeed { get => default; set {} } // 0x0000000184F6B730-0x0000000184F6B740 0x0000000184F6B740-0x0000000184F6B750
		[Sync]
		public uint CatTypeSeed { get => default; set {} } // 0x0000000186EDE2C0-0x0000000186EDE2D0 0x000000018613C470-0x000000018613C480
	
		// Nested types
		[Serializable]
		private struct CatPickupReward // TypeDefIndex: 16066
		{
			// Fields
			public WeaponType RewardType; // 0x00
			[SerializeField]
			private float _minValue; // 0x04
			[SerializeField]
			private float _maxValue; // 0x08
	
			// Properties
			public float Value { get => default; } // 0x0000000186EE0320-0x0000000186EE0340 
		}
	
		private enum CatBehaviourState // TypeDefIndex: 16067
		{
			Idle = 0,
			Fleeing = 1,
			Taken = 2
		}
	
		private enum CatDespawnBehaviourType // TypeDefIndex: 16068
		{
			None = 0,
			CheckDistanceWhenFleeing = 1,
			CheckDistanceAlways = 2
		}
	
		// Constructors
		public Pickup_EME_Cat() {} // 0x0000000186EE01C0-0x0000000186EE02A0
	
		// Methods
		public override bool CanCharacterCollectPickup(VampireSurvivors.Data.CharacterType characterType) => default; // 0x0000000186EDE2D0-0x0000000186EDE2E0
		protected override void Awake() {} // 0x0000000186EBAAB0-0x0000000186EBAAE0
		public override void SetData(VampireSurvivors.Data.ItemType itemType) {} // 0x0000000186EDE2E0-0x0000000186EDE310
		private void OnRecycle() {} // 0x0000000186EDE310-0x0000000186EDE980
		public override void GetTaken() {} // 0x0000000186EDE980-0x0000000186EDEAB0
		protected virtual void OnCatPickedUp() {} // 0x0000000186EDEAB0-0x0000000186EDEEF0
		private void SetVelocity(Vector2 velocity) {} // 0x0000000184C486A0-0x0000000184C486E0
		public void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186EDEEF0-0x0000000186EDF060
		protected override void OnUpdate() {} // 0x0000000186EDF060-0x0000000186EDF480
		[Command]
		public void TransitionToFlee(Vector2 velocity) {} // 0x0000000186EDF480-0x0000000186EDF500
		protected override void GoToThePlayer() {} // 0x0000000186EDF500-0x0000000186EDF590
		private void DespawnIfTooFarFromPlayer() {} // 0x0000000186EDF590-0x0000000186EDF620
		[IteratorStateMachine(typeof(_DespawnAtEndOfFrame_d__45))]
		private IEnumerator DespawnAtEndOfFrame() => default; // 0x0000000186EDF620-0x0000000186EDF6C0
		public override void Despawn() {} // 0x0000000186EDF6C0-0x0000000186EDF770
		private void ConfigureAnimations() {} // 0x0000000186EDF770-0x0000000186EDF8E0
		protected virtual void GetCatAnimations(out List<Sprite> idle, out List<Sprite> flee, out List<Sprite> dragged) {
			idle = default;
			flee = default;
			dragged = default;
		} // 0x0000000186EDF8E0-0x0000000186EDFC40
		protected virtual VampireSurvivors.Data.ItemType GetCatType() => default; // 0x0000000186EDFC40-0x0000000186EDFCD0
		private float GetDetune() => default; // 0x0000000186EDFCD0-0x0000000186EDFD60
		private void AddAttribute(VampireSurvivors.Objects.Characters.CharacterController character, WeaponType weaponType, float value) {} // 0x0000000186EDFD60-0x0000000186EE01C0
	}
}

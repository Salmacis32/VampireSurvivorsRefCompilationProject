/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pickups;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	[UsedImplicitly]
	public class PhysicsManager : IInitializable, IDisposable // TypeDefIndex: 17516
	{
		// Fields
		public PhysicsGroup _playerGroup; // 0x10
		public PhysicsGroup _playersWithWallCollisionGroup; // 0x18
		public PhysicsGroup _enemyGroup; // 0x20
		public PhysicsGroup _bulletGroup; // 0x28
		public PhysicsGroup _pickupGroup; // 0x30
		public PhysicsGroup _goToPlayerPickupGroup; // 0x38
		public PhysicsGroup _destructiblesGroup; // 0x40
		public PhysicsGroup _magnetGroup; // 0x48
		public PhysicsGroup _doorGroup; // 0x50
		private static PhysicsManager _sInstance; // 0x00
		private GameManager _gameManager; // 0x58
		private VampireSurvivors.Data.ItemType[] _goldItems; // 0x60
		public bool PickupImmaterial; // 0x68
	
		// Properties
		public static PhysicsManager Instance { get => default; } // 0x0000000187342E40-0x0000000187342E80 
	
		// Constructors
		public PhysicsManager() {} // 0x0000000187345000-0x00000001873450C0
	
		// Methods
		public void Initialize() {} // 0x0000000187342E80-0x0000000187342F20
		public void Dispose() {} // 0x0000000187342F20-0x0000000187342FC0
		public void InitPhysicsGroups(GameManager gameManager) {} // 0x0000000187342FC0-0x0000000187343EB0
		public void InitPhysicsColliders() {} // 0x0000000187343EB0-0x0000000187344520
		public static void TakePickup(Pickup pickupItem, CharacterController playerCharacter) {} // 0x0000000187344520-0x0000000187344650
		private bool OnPlayerOverlapsEnemy(CallbackContext context, ArcadeColliderType first, ArcadeColliderType second) => default; // 0x0000000187344650-0x0000000187344990
		private bool OnPlayerOverlapsPickup(CallbackContext context, ArcadeColliderType player, ArcadeColliderType pickup) => default; // 0x0000000187344990-0x0000000187344B40
		private bool OnMagnetOverlapsPickup(CallbackContext context, ArcadeColliderType magnet, ArcadeColliderType pickup) => default; // 0x0000000187344B40-0x0000000187344F70
		private bool OnBulletOverlapsDoor(CallbackContext context, ArcadeColliderType bullet, ArcadeColliderType door) => default; // 0x0000000187344F70-0x0000000187345000
	}
}

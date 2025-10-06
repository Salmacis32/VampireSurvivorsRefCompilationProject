/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Objects.Items;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class EME_CharacterControllerAmeya : EME_CharacterControllerShowstopper // TypeDefIndex: 17134
	{
		// Fields
		[Tooltip("In seconds")]
		private float _catSpawnInterval; // 0x428
		private float _catsPerSpawn; // 0x42C
		[Range(0f, 1f)]
		[SerializeField]
		[Tooltip("Closer to 1 = higher probability")]
		private float _rainbowCatSpawnChance; // 0x430
		[SerializeField]
		private Vector2 _spawnRectangleSize; // 0x434
		[SerializeField]
		[Space]
		private bool _allowCatSpawnsInCameraView; // 0x43C
		private PhysicsGroup _catsPhysicsGroup; // 0x440
		private Camera _mainCamera; // 0x448
		private int _maxActiveCats; // 0x450
	
		// Constructors
		public EME_CharacterControllerAmeya() {} // 0x0000000187180E90-0x0000000187180EC0
	
		// Methods
		public override void AfterFullInitialization() {} // 0x000000018717EBC0-0x000000018717F4C0
		private void SpawnCats() {} // 0x000000018717F4C0-0x000000018717F670
		private Bounds CalculateSpawnBounds(Bounds cameraBounds) => default; // 0x000000018717F670-0x000000018717FC00
		private void SpawnCatsInsideBounds(Bounds spawnRect, Bounds cameraBounds) {} // 0x000000018717FC00-0x0000000187180690
		private bool OnCatOverlapsWall(CallbackContext context, ArcadeColliderType catCollider, ArcadeColliderType tileCollider) => default; // 0x0000000187180690-0x0000000187180860
		private void OnDrawGizmos() {} // 0x0000000187180860-0x0000000187180DF0
		public override void LevelUp() {} // 0x0000000187180DF0-0x0000000187180E90
	}
}

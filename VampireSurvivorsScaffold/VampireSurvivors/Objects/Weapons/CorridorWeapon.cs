/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using QFSW.MOP2;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class CorridorWeapon : Weapon // TypeDefIndex: 16158
	{
		// Fields
		[SerializeField]
		private GameObject _CorridorProjectilePrefab; // 0x158
		[SerializeField]
		private GameObject _LancetPierceEffectPrefab; // 0x160
		private ObjectPool _effectPool; // 0x168
		private BulletPool _corridorPool; // 0x170
		private int _ticks; // 0x178
		private readonly List<Vector2> _targets; // 0x180
		private readonly List<float> _angles; // 0x188
	
		// Constructors
		public CorridorWeapon() {} // 0x0000000186F32940-0x0000000186F32AE0
	
		// Methods
		public override float PAmount() => default; // 0x0000000186DE50C0-0x0000000186DE50D0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F31390-0x0000000186F318D0
		public override void Cleanup() {} // 0x0000000186F318D0-0x0000000186F319D0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977B97 */) {} // 0x0000000186F319D0-0x0000000186F32110
		private void FireOneLancet(int index, float angle, Vector2 targetPos) {} // 0x0000000186F32110-0x0000000186F32490
		private void FireCorridor() {} // 0x0000000186F32490-0x0000000186F325A0
		private ObjectPool GeneratePool(GameObject prefab, int defaultSize = 1 /* Metadata: 0x01977B98 */, int maxSize = -1 /* Metadata: 0x01977B99 */) => default; // 0x0000000186F325A0-0x0000000186F32700
		private void CleanupPool(ObjectPool pool) {} // 0x0000000186F32700-0x0000000186F327D0
		private bool OnCorridorOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F327D0-0x0000000186F32940
	}
}

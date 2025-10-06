/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_RPG1_Weapon : Weapon // TypeDefIndex: 16454
	{
		// Fields
		protected float exploRadius; // 0x158
		private BulletPool _invisibleProjectilePool; // 0x160
		[SerializeField]
		private Projectile _invisibleProjectilePrefab; // 0x168
	
		// Constructors
		public TP_RPG1_Weapon() {} // 0x0000000186FE1A40-0x0000000186FE1AA0
	
		// Methods
		protected override void Awake() {} // 0x0000000186FE0E30-0x0000000186FE1110
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977CC9 */) {} // 0x0000000186FE1110-0x0000000186FE1250
		public void SpawnExplosionClustersAt(float2 pos) {} // 0x0000000186FE1250-0x0000000186FE1650
		public void SpawnExplosionWavesAt(Vector2 pos, Vector2 velocity) {} // 0x0000000186FE1650-0x0000000186FE1A40
		public override void CheckArcanas() {} // 0x0000000186F71380-0x0000000186F71480
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B21570-0x0000000180B21580
	}
}

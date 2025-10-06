/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class FB_DiverMinesProjectile : Projectile // TypeDefIndex: 15467
	{
		// Fields
		private bool _anticlockwiseSpin; // 0xD0
		private bool _hasHitAnything; // 0xD1
		private VampireSurvivors.Framework.TimerSystem.Timer _explosionTimer; // 0xD8
		private ScreenEdge _screenEdge; // 0xE0
		private float2 _lastVelocity; // 0xE4
	
		// Nested types
		private enum ScreenEdge // TypeDefIndex: 15466
		{
			None = 0,
			Top = 1,
			Bottom = 2,
			Left = 3,
			Right = 4
		}
	
		// Constructors
		public FB_DiverMinesProjectile() {} // 0x0000000186C1EE60-0x0000000186C1EEB0
	
		// Methods
		protected override void Awake() {} // 0x0000000186C1DEC0-0x0000000186C1E040
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C1E040-0x0000000186C1E390
		private void DoExplode() {} // 0x0000000186C1E390-0x0000000186C1E5B0
		public override void InternalUpdate() {} // 0x0000000186C1E5B0-0x0000000186C1E7B0
		private void LateUpdate() {} // 0x0000000186C1E7B0-0x0000000186C1E7C0
		private void HandleScreenEdges() {} // 0x0000000186C1E7C0-0x0000000186C1E930
		private void StickToScreenEdge(ScreenEdge nextEdge, ArcadeRect playArea) {} // 0x0000000186C1E930-0x0000000186C1EAD0
		private bool HitsTop(ArcadeRect playArea) => default; // 0x0000000186C1EAD0-0x0000000186C1EB10
		private bool HitsBottom(ArcadeRect playArea) => default; // 0x0000000186C1EB10-0x0000000186C1EB40
		private bool HitsRight(ArcadeRect playArea) => default; // 0x0000000186C1EB40-0x0000000186C1EB80
		private bool HitsLeft(ArcadeRect playArea) => default; // 0x0000000186C1EB80-0x0000000186C1EBB0
		private void StickToWall(float2 normal) {} // 0x0000000186C1EBB0-0x0000000186C1EC80
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186C1EC80-0x0000000186C1EDA0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C1EDA0-0x0000000186C1EDB0
		public override void Despawn() {} // 0x0000000186C1EDB0-0x0000000186C1EE60
	}
}

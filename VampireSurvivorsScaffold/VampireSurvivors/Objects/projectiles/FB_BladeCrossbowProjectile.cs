/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class FB_BladeCrossbowProjectile : Projectile // TypeDefIndex: 15462
	{
		// Fields
		private BladeCrossbowState _state; // 0xD0
		private float2 _positionBeforeReturning; // 0xD4
		private float _returningT; // 0xDC
		private float2 _originalPosition; // 0xE0
		private float _age; // 0xE8
	
		// Properties
		protected virtual string _FrameName { get => default; } // 0x0000000186C17C80-0x0000000186C17CC0 
	
		// Nested types
		private enum BladeCrossbowState // TypeDefIndex: 15461
		{
			GoingOutwards = 0,
			Paused = 1,
			Returning = 2
		}
	
		// Constructors
		public FB_BladeCrossbowProjectile() {} // 0x0000000186C17C30-0x0000000186C17C80
	
		// Methods
		protected override void Awake() {} // 0x0000000186C17CC0-0x0000000186C17D60
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C17D60-0x0000000186C18020
		public override void InternalUpdate() {} // 0x0000000186C18020-0x0000000186C187E0
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186C187E0-0x0000000186C18800
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C18800-0x0000000186C18900
		private void PauseAttack() {} // 0x0000000186C18900-0x0000000186C18CF0
		private void ClearEnemiesHit() {} // 0x0000000186C18CF0-0x0000000186C18D40
		private void RecallProjectile() {} // 0x0000000186C18D40-0x0000000186C18D90
		public override void Despawn() {} // 0x0000000186C18D90-0x0000000186C18DD0
	}
}

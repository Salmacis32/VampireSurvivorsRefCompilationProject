/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EnemyProjectile : ArcadeSprite // TypeDefIndex: 15857
	{
		// Fields
		protected SpriteTrail _spriteTrail; // 0x58
		protected float _speed; // 0x60
		protected int _indexInWeapon; // 0x64
		private EnemyBulletPool _pool; // 0x68
	
		// Properties
		public float ProjectileSpeed { get => default; } // 0x0000000186DF3DE0-0x0000000186DF3DF0 
		public float Damage { get; protected set; } // 0x0000000182886F10-0x0000000182886F20 0x0000000183C00630-0x0000000183C00640
	
		// Constructors
		public EnemyProjectile() {} // 0x0000000186DF2C50-0x0000000186DF2CA0
	
		// Methods
		protected virtual new void Awake() {} // 0x0000000186DF3DF0-0x0000000186DF3E80
		public virtual void InitProjectile(int index, float2 direction, EnemyBulletPool pool) {} // 0x0000000186DF3E80-0x0000000186DF4050
		public virtual void Despawn() {} // 0x0000000186DF4050-0x0000000186DF40C0
		public virtual void OnHitPlayer(VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x0000000186DF40C0-0x0000000186DF4110
		public virtual void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000184887810-0x0000000184887830
		public virtual bool ShouldHitWalls() => default; // 0x0000000181958370-0x0000000181958380
		public void SetVelocity(Vector2 velocity) {} // 0x0000000184C486A0-0x0000000184C486E0
	}
}

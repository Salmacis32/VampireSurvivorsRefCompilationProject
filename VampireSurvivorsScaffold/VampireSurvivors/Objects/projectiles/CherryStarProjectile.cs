/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class CherryStarProjectile : Projectile // TypeDefIndex: 15411
	{
		// Fields
		[SerializeField]
		private TrailRenderer _trail; // 0xD0
		protected List<float2> _positions; // 0xD8
		protected float _maxPositions; // 0xE0
		protected uint _color; // 0xE4
		private float2 _target; // 0xE8
		private List<float2> _targets; // 0xF0
		private bool _canUpdate; // 0xF8
		private VampireSurvivors.Framework.TimerSystem.Timer _bounceTimer; // 0x100
		private CherryStarsWeapon _trueWeapon; // 0x108
		private float _maxStars; // 0x110
		private List<PhaserSprite> _stars1; // 0x118
		private List<PhaserSprite> _stars2; // 0x120
		private float _bouncedTimes; // 0x128
		private float _sin; // 0x12C
		private float _cos; // 0x130
		private int starIndex; // 0x134
	
		// Constructors
		public CherryStarProjectile() {} // 0x0000000186BD8F70-0x0000000186BD8FE0
	
		// Methods
		protected override void Awake() {} // 0x0000000186BD69C0-0x0000000186BD7400
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BD7400-0x0000000186BD7600
		public override void Despawn() {} // 0x0000000180B15170-0x0000000180B15180
		public void ForceDespawn() {} // 0x0000000186BD7600-0x0000000186BD7890
		public void PickNewTarget() {} // 0x0000000186BD7890-0x0000000186BD7C80
		protected override void OnUpdate() {} // 0x0000000186BD7C80-0x0000000186BD80D0
		public void MakeStar() {} // 0x0000000186BD80D0-0x0000000186BD8230
		public void CheckTimer() {} // 0x0000000186BD8230-0x0000000186BD82B0
		public void StartTimer() {} // 0x0000000186BD82B0-0x0000000186BD83B0
		public void ExplodeAll() {} // 0x0000000186BD83B0-0x0000000186BD8E90
		protected void clearPositions() {} // 0x0000000186BD8E90-0x0000000186BD8F50
		public float Approach(float start, float end, float shift) => default; // 0x0000000186BD8F50-0x0000000186BD8F70
		public override void SetTarget(Transform target) {} // 0x0000000180B15170-0x0000000180B15180
		public override void SetNullTarget() {} // 0x0000000180B15170-0x0000000180B15180
	}
}

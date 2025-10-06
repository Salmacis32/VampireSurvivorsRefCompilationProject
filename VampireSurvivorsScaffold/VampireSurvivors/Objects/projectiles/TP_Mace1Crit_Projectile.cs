/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Mace1Crit_Projectile : Projectile // TypeDefIndex: 15616
	{
		// Fields
		protected List<Projectile> _swipeAfterImageBodies; // 0xD0
		protected List<Vector2> _lerpRightList; // 0xD8
		protected List<Vector2> _lerpLeftList; // 0xE0
		protected List<Vector2> _lerpList; // 0xE8
		protected SpriteAnimation _anim; // 0xF0
		protected VampireSurvivors.Framework.TimerSystem.Timer _bodyDisableTimer; // 0xF8
		protected int _flipNum; // 0x100
		protected float _lerpDist; // 0x104
		protected bool _lerpActive; // 0x108
		protected MultiTargetTween _lerpTween; // 0x110
		[NonSerialized]
		public float lerpRatio; // 0x118
		private VampireSurvivors.Framework.TimerSystem.Timer _freezeTimer; // 0x120
		private bool _isMoving; // 0x128
	
		// Constructors
		public TP_Mace1Crit_Projectile() {} // 0x0000000186CE5660-0x0000000186CE5A20
	
		// Methods
		protected override void Awake() {} // 0x0000000186CE3E40-0x0000000186CE4010
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CE4010-0x0000000186CE4840
		public override void InternalUpdate() {} // 0x0000000186CE4840-0x0000000186CE4850
		public void UpdatePositions() {} // 0x0000000186CE4850-0x0000000186CE4D40
		protected float2 MultiLerp(List<Vector2> waypoints, float ratio) => default; // 0x0000000186CE4D40-0x0000000186CE5000
		protected int GetVectorIndexFromDistanceTravelled(List<Vector2> waypoints, float distanceTravelled) => default; // 0x0000000186CE5000-0x0000000186CE50E0
		protected float MultiDistance(List<Vector2> waypoints) => default; // 0x0000000186CE50E0-0x0000000186CE5280
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186CE5280-0x0000000186CE5390
		public override void Despawn() {} // 0x0000000186CE5390-0x0000000186CE5660
	}
}

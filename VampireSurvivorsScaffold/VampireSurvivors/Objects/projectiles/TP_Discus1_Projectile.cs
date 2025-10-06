/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Discus1_Projectile : Projectile // TypeDefIndex: 15541
	{
		// Fields
		private Vector3 _movement; // 0xD0
		private float _rotationInc; // 0xDC
		private float _flipSwitch; // 0xE0
		[NonSerialized]
		public float orbitRadius; // 0xE4
		[NonSerialized]
		public float orbitAngle; // 0xE8
		private MultiTargetTween _radiusTween; // 0xF0
		private MultiTargetTween _speedTween; // 0xF8
		private MultiTargetTween _scaleTween; // 0x100
		private float _spinDuration; // 0x108
		private bool _rotatingState; // 0x10C
		private bool _shootState; // 0x10D
		private bool _anticlockwiseSpin; // 0x10E
		private bool _hasStucktoWall; // 0x10F
		private VampireSurvivors.Framework.TimerSystem.Timer _explosionTimer; // 0x110
		private ScreenEdge _screenEdge; // 0x118
		private float2 _lastVelocity; // 0x11C
	
		// Properties
		protected virtual float SpeedFactor { get => default; } // 0x0000000185EC0950-0x0000000185EC0960 
		protected virtual bool CanBounce { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected virtual string FrameName { get => default; } // 0x0000000186C8C140-0x0000000186C8C180 
	
		// Nested types
		private enum ScreenEdge // TypeDefIndex: 15540
		{
			None = 0,
			Top = 1,
			Bottom = 2,
			Left = 3,
			Right = 4
		}
	
		// Constructors
		public TP_Discus1_Projectile() {} // 0x0000000186C8DC50-0x0000000186C8DCA0
	
		// Methods
		protected override void Awake() {} // 0x0000000186C8C180-0x0000000186C8C230
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C8C230-0x0000000186C8CE20
		public void InitBouncing() {} // 0x0000000186C8CE20-0x0000000186C8CFA0
		public void shootDiscus() {} // 0x0000000186C8CFA0-0x0000000186C8D090
		protected override void OnUpdate() {} // 0x0000000186C8D090-0x0000000186C8D5B0
		private void HandleScreenEdges() {} // 0x0000000186C8D5B0-0x0000000186C8D700
		private void StickToScreenEdge(ScreenEdge nextEdge, ArcadeRect playArea) {} // 0x0000000186C8D700-0x0000000186C8D8A0
		private bool HitsTop(ArcadeRect playArea) => default; // 0x0000000186C1EAD0-0x0000000186C1EB10
		private bool HitsBottom(ArcadeRect playArea) => default; // 0x0000000186C1EB10-0x0000000186C1EB40
		private bool HitsRight(ArcadeRect playArea) => default; // 0x0000000186C1EB40-0x0000000186C1EB80
		private bool HitsLeft(ArcadeRect playArea) => default; // 0x0000000186C1EB80-0x0000000186C1EBB0
		private void StickToWall(float2 normal) {} // 0x0000000186C8D8A0-0x0000000186C8DAA0
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186C8DAA0-0x0000000186C8DBE0
		public override void Despawn() {} // 0x0000000186C8DBE0-0x0000000186C8DC50
	}
}

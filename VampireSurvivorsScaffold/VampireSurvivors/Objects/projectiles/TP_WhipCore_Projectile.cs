/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_WhipCore_Projectile : Projectile // TypeDefIndex: 15717
	{
		// Fields
		public LineRenderer _lineRenderer; // 0xD0
		protected WhipVerletNode[] _nodes; // 0xD8
		protected Projectile[] _nodeProjectiles; // 0xE0
		protected float2 _gravity; // 0xE8
		protected float _flipNum; // 0xF0
		protected bool _applyNodeControl; // 0xF4
		protected float _nodeDistance; // 0xF8
		protected float2 _characterOffset; // 0xFC
		protected float _whipSize; // 0x104
		protected float _timeStartAttack; // 0x108
		protected float _timeFadeOut; // 0x10C
		protected float _delayFadeOut; // 0x110
		protected float _timeLerpRatio; // 0x114
	
		// Properties
		public virtual int Nodes { get => default; } // 0x0000000182107FB0-0x0000000182107FC0 
	
		// Constructors
		public TP_WhipCore_Projectile() {} // 0x0000000186D4BE20-0x0000000186D4BEC0
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D4A430-0x0000000186D4A470
		protected virtual float WhipLength() => default; // 0x0000000186D4A470-0x0000000186D4A4F0
		protected virtual float2 GetCharacterOffset() => default; // 0x0000000186D4A4F0-0x0000000186D4A530
		protected virtual void InitWhips() {} // 0x0000000186D4A530-0x0000000186D4ADC0
		protected virtual Projectile CreateNodeProjectile(float2 pos) => default; // 0x0000000180B15D70-0x0000000180B15D80
		protected void bodyEnabled(bool enable) {} // 0x0000000186D4ADC0-0x0000000186D4AE40
		protected void ApplyGravity() {} // 0x0000000186D4AE40-0x0000000186D4B0A0
		protected void ApplyVerletConstraints() {} // 0x0000000186D4B0A0-0x0000000186D4B2F0
		protected virtual float CalculateIndexNodeDistance(int index) => default; // 0x0000000186D4B2F0-0x0000000186D4B370
		protected float2 MultiLerp(List<Vector2> waypoints, float lerp) => default; // 0x0000000186D4B370-0x0000000186D4B660
		protected int GetVectorIndexFromDistanceTravelled(List<Vector2> waypoints, float distanceTravelled) => default; // 0x0000000186D4B660-0x0000000186D4B740
		protected float MultiDistance(List<Vector2> waypoints) => default; // 0x0000000186D4B740-0x0000000186D4B8E0
		public static List<Vector2> GenerateSpline(WhipVerletNode[] points, int stepsPerCurve = 5 /* Metadata: 0x019777C1 */, float tension = 1f /* Metadata: 0x019777C2 */) => default; // 0x0000000186D4B8E0-0x0000000186D4BD20
		public override void Despawn() {} // 0x0000000186D4BD20-0x0000000186D4BE20
	}
}

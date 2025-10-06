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
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class Unused_TP_Lemuria1_Projectile : TP_WhipCore_Projectile // TypeDefIndex: 15735
	{
		// Fields
		[NonSerialized]
		public float LineAlpha; // 0x118
		private MultiTargetTween _lineTween; // 0x120
		[NonSerialized]
		public float LerpRatio; // 0x128
		private MultiTargetTween _lerpTween; // 0x130
		private List<Vector2> _waypointList; // 0x138
		private VampireSurvivors.Framework.TimerSystem.Timer _spikeTimer; // 0x140
		private float2 _spikePosition; // 0x148
		private int _attackCount; // 0x150
		private int _attackAmount; // 0x154
	
		// Constructors
		public Unused_TP_Lemuria1_Projectile() {} // 0x0000000186D5EBF0-0x0000000186D5EEC0
	
		// Methods
		protected override float WhipLength() => default; // 0x0000000186D5D400-0x0000000186D5D450
		protected override void Awake() {} // 0x0000000186D5D450-0x0000000186D5D490
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D5D490-0x0000000186D5D7E0
		private void startAttack(float delay) {} // 0x0000000186D5D7E0-0x0000000186D5DC10
		protected override Projectile CreateNodeProjectile(float2 pos) => default; // 0x0000000186D5DC10-0x0000000186D5DCD0
		private void OnWhipStart() {} // 0x0000000186D5A500-0x0000000186D5A560
		private void OnWhipComplete() {} // 0x0000000186D5DCD0-0x0000000186D5E1B0
		public override void InternalUpdate() {} // 0x0000000186D5E1B0-0x0000000186D5E910
		private void ApplyManualNodeControl() {} // 0x0000000186D5E910-0x0000000186D5EB40
		protected override float CalculateIndexNodeDistance(int index) => default; // 0x0000000186D5EB40-0x0000000186D5EB90
		public override void Despawn() {} // 0x0000000186D5EB90-0x0000000186D5EBF0
	}
}

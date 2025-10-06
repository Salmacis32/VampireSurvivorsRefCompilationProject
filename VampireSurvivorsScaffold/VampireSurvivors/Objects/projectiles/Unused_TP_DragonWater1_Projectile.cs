/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class Unused_TP_DragonWater1_Projectile : TP_WhipCore_Projectile // TypeDefIndex: 15734
	{
		// Fields
		[NonSerialized]
		public float LineAlpha; // 0x118
		private MultiTargetTween _lineTween; // 0x120
		[NonSerialized]
		public float LerpRatio; // 0x128
		private MultiTargetTween _lerpTween; // 0x130
		private VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0x138
		private List<Vector2> _waypointList; // 0x140
		private int _attackCount; // 0x148
		private int _attackAmount; // 0x14C
	
		// Constructors
		public Unused_TP_DragonWater1_Projectile() {} // 0x0000000186D5CF40-0x0000000186D5D400
	
		// Methods
		protected override void Awake() {} // 0x0000000186D5BBA0-0x0000000186D5BBE0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D5BBE0-0x0000000186D5BC40
		private void startAttack(float delay) {} // 0x0000000186D5BC40-0x0000000186D5C070
		private void OnWhipStart() {} // 0x0000000186D5C070-0x0000000186D5C0F0
		private void OnWhipComplete() {} // 0x0000000186D5C0F0-0x0000000186D5C590
		private void StartOrbTracker() {} // 0x0000000180B15170-0x0000000180B15180
		private void StepOrbTracker() {} // 0x0000000180B15170-0x0000000180B15180
		private void CompleteOrbTracker() {} // 0x0000000180B15170-0x0000000180B15180
		public override void InternalUpdate() {} // 0x0000000186D5C590-0x0000000186D5CCF0
		private void ApplyManualNodeControl() {} // 0x0000000186D5CCF0-0x0000000186D5CEF0
		protected override float CalculateIndexNodeDistance(int index) => default; // 0x0000000186D5CEF0-0x0000000186D5CF40
		public override void Despawn() {} // 0x0000000186D1D360-0x0000000186D1D3C0
	}
}

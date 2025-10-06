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
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class Unused_TP_WindWhip1_Projectile : TP_WhipCore_Projectile // TypeDefIndex: 15741
	{
		// Fields
		[NonSerialized]
		public float LineAlpha; // 0x118
		private MultiTargetTween _lineTween; // 0x120
		[NonSerialized]
		public float LerpRatio; // 0x128
		private MultiTargetTween _lerpTween; // 0x130
		[NonSerialized]
		public float Lerp2Ratio; // 0x138
		private MultiTargetTween _lerp2Tween; // 0x140
		private List<Vector2> _waypointList; // 0x148
		private List<Vector2> _waypoint2List; // 0x150
		private int _attackCount; // 0x158
		private int _attackAmount; // 0x15C
	
		// Constructors
		public Unused_TP_WindWhip1_Projectile() {} // 0x0000000186D66870-0x0000000186D66E60
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D65470-0x0000000186D654D0
		private void startAttack(int delay) {} // 0x0000000186D654D0-0x0000000186D65B50
		protected override Projectile CreateNodeProjectile(float2 pos) => default; // 0x0000000186D65B50-0x0000000186D65C10
		private void OnWhipStart() {} // 0x0000000186D5A500-0x0000000186D5A560
		private void OnWhipComplete() {} // 0x0000000186D65C10-0x0000000186D660B0
		public override void InternalUpdate() {} // 0x0000000186D660B0-0x0000000186D66810
		private void ApplyManualNodeControl() {} // 0x0000000186D5B2D0-0x0000000186D5B5C0
		protected override float CalculateIndexNodeDistance(int index) => default; // 0x0000000186CC8400-0x0000000186CC8450
		public override void Despawn() {} // 0x0000000186D66810-0x0000000186D66870
	}
}

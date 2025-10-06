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
	public class TP_MartialWhip1_Projectile : TP_WhipCore_Projectile // TypeDefIndex: 15622
	{
		// Fields
		[NonSerialized]
		public float LineAlpha; // 0x118
		private MultiTargetTween _lineTween; // 0x120
		[NonSerialized]
		public float LerpRatio; // 0x128
		private MultiTargetTween _lerpTween; // 0x130
		private List<Vector2> _waypointListDefault; // 0x138
		private List<Vector2> _waypointList; // 0x140
		private bool _targetEnemy; // 0x148
		private int _attackCount; // 0x14C
		private int _attackAmount; // 0x150
	
		// Constructors
		public TP_MartialWhip1_Projectile() {} // 0x0000000186CEBB70-0x0000000186CEC030
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CEA070-0x0000000186CEA0D0
		protected override Projectile CreateNodeProjectile(float2 pos) => default; // 0x0000000186CEA0D0-0x0000000186CEA190
		private void startAttack(float delay) {} // 0x0000000186CEA190-0x0000000186CEA5C0
		private void OnWhipStart() {} // 0x0000000186CEA5C0-0x0000000186CEAE70
		private void OnWhipComplete() {} // 0x0000000186CEAE70-0x0000000186CEB350
		public override void InternalUpdate() {} // 0x0000000186CEB350-0x0000000186CEBB70
		private void ApplyManualNodeControl() {} // 0x0000000186CC8160-0x0000000186CC8400
		protected override float CalculateIndexNodeDistance(int index) => default; // 0x0000000186CC8400-0x0000000186CC8450
		public override void Despawn() {} // 0x0000000186CC8450-0x0000000186CC84A0
	}
}

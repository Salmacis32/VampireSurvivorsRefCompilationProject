/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Lemuria1Spike_Projectile : Projectile // TypeDefIndex: 15611
	{
		// Fields
		public LineRenderer _lineRenderer; // 0xD0
		protected MultiTargetTween _alphaTween; // 0xD8
		[NonSerialized]
		public float LineAlpha; // 0xE0
		protected MultiTargetTween _lineTween; // 0xE8
		[NonSerialized]
		public float LineRatio; // 0xF0
		private float _spikeHeight; // 0xF4
	
		// Constructors
		public TP_Lemuria1Spike_Projectile() {} // 0x0000000186CE0900-0x0000000186CE0950
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CDFBF0-0x0000000186CE02A0
		public override void InternalUpdate() {} // 0x0000000186CE02A0-0x0000000186CE0520
		private void OnLineComplete() {} // 0x0000000186CE0520-0x0000000186CE08B0
		public override void Despawn() {} // 0x0000000186CE08B0-0x0000000186CE0900
	}
}

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
	public class TP_SonicWhip1_Projectile : TP_WhipCore_Projectile // TypeDefIndex: 15665
	{
		// Fields
		[NonSerialized]
		public float LineAlpha; // 0x118
		private MultiTargetTween _lineTween; // 0x120
		[NonSerialized]
		public float LerpRatio; // 0x128
		[NonSerialized]
		public float WaveRatio; // 0x12C
		private MultiTargetTween _lerpTween; // 0x130
		private VampireSurvivors.Framework.TimerSystem.Timer _durationTimer; // 0x138
		private int _attackCount; // 0x140
		private int _attackAmount; // 0x144
		private float _wavePixelHeight; // 0x148
		public List<Gradient> _gradients; // 0x150
	
		// Properties
		public override int Nodes { get => default; } // 0x000000018200BFB0-0x000000018200BFC0 
	
		// Constructors
		public TP_SonicWhip1_Projectile() {} // 0x0000000186D1D3C0-0x0000000186D1D3E0
	
		// Methods
		protected override void Awake() {} // 0x0000000186BB4A00-0x0000000186BB4A10
		protected override float WhipLength() => default; // 0x0000000186D1C130-0x0000000186D1C1C0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D1C1C0-0x0000000186D1C460
		private void PlaySFX() {} // 0x0000000186D1C460-0x0000000186D1C590
		private void startAttack(float delay) {} // 0x0000000186D1C590-0x0000000186D1CA50
		protected override Projectile CreateNodeProjectile(float2 pos) => default; // 0x0000000186D1CA50-0x0000000186D1CB10
		private void OnWhipStart() {} // 0x0000000186D1CB10-0x0000000186D1CCB0
		private void OnWhipComplete() {} // 0x0000000186D1CCB0-0x0000000186D1CD60
		public override void InternalUpdate() {} // 0x0000000186D1CD60-0x0000000186D1CDD0
		private void UpdateWhipLineRenderer() {} // 0x0000000186D1CDD0-0x0000000186D1D0F0
		private void ApplyManualNodeControl() {} // 0x0000000186D1D0F0-0x0000000186D1D360
		protected override float CalculateIndexNodeDistance(int index) => default; // 0x0000000186CC8400-0x0000000186CC8450
		public override void Despawn() {} // 0x0000000186D1D360-0x0000000186D1D3C0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Pneuma_Spikes_Projectile : Projectile // TypeDefIndex: 15628
	{
		// Fields
		private const float Radius = 0.25f; // Metadata: 0x01977786
		private float _spacer; // 0xD0
		private float _timer; // 0xD4
		private int _counter; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer _spikeTimerEvent; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _completeTimerEvent; // 0xE8
		private float2 _originalPos; // 0xF0
		private float2 _direction; // 0xF8
		private float _angle; // 0x100
		private float _iterationScale; // 0x104
		private float _iterationScaleMultiply; // 0x108
		private float _iterationAlpha; // 0x10C
		private float _iterationAlphaMultiply; // 0x110
	
		// Constructors
		public TP_Pneuma_Spikes_Projectile() {} // 0x0000000186CF33F0-0x0000000186CF3460
	
		// Methods
		protected override void Awake() {} // 0x0000000186BB4A00-0x0000000186BB4A10
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CF2BF0-0x0000000186CF2FF0
		private void updateSpikePos() {} // 0x0000000186CF2FF0-0x0000000186CF31F0
		public override void InternalUpdate() {} // 0x0000000186CF31F0-0x0000000186CF3300
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186CF3300-0x0000000186CF33F0
		public void manuallySetDirection(float2 direction) {} // 0x0000000182A45AC0-0x0000000182A45AD0
		public void manuallySetOriginalPos(float2 originalPos) {} // 0x0000000182A45AB0-0x0000000182A45AC0
		public override void Despawn() {} // 0x0000000186C219F0-0x0000000186C21A40
	}
}

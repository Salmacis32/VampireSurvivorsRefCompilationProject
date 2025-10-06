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
	public class FB_FireWallProjectile : Projectile // TypeDefIndex: 15470
	{
		// Fields
		private const float Radius = 0.25f; // Metadata: 0x01977641
		private float _spacer; // 0xD0
		private float _timer; // 0xD4
		private int _counter; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer _flameTimerEvent; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _completeTimerEvent; // 0xE8
		private float2 _originalPos; // 0xF0
		private float2 _direction; // 0xF8
	
		// Constructors
		public FB_FireWallProjectile() {} // 0x0000000186C21A40-0x0000000186C21AA0
	
		// Methods
		protected override void Awake() {} // 0x0000000186BB4A00-0x0000000186BB4A10
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C21230-0x0000000186C215D0
		private void updateFlamePos() {} // 0x0000000186C215D0-0x0000000186C217F0
		public override void InternalUpdate() {} // 0x0000000186C217F0-0x0000000186C21900
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C21900-0x0000000186C219F0
		public void manuallySetDirection(float2 direction) {} // 0x0000000182A45AC0-0x0000000182A45AD0
		public void manuallySetOriginalPos(float2 originalPos) {} // 0x0000000182A45AB0-0x0000000182A45AC0
		public override void Despawn() {} // 0x0000000186C219F0-0x0000000186C21A40
	}
}

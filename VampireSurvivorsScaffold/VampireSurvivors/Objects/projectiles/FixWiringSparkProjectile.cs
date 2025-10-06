/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class FixWiringSparkProjectile : Projectile // TypeDefIndex: 15440
	{
		// Fields
		private PhaserSprite _pulseSprite; // 0xD0
		private FixWiringWeapon _trueWeapon; // 0xD8
		private MultiTargetTween _pulseTween; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _pulseTimer; // 0xE8
		private bool _follow; // 0xF0
		private float radius; // 0xF4
	
		// Constructors
		public FixWiringSparkProjectile() {} // 0x0000000186BFFBC0-0x0000000186BFFC20
	
		// Methods
		protected override void Awake() {} // 0x0000000186BFD780-0x0000000186BFD7A0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BFEEF0-0x0000000186BFF450
		public override void Despawn() {} // 0x0000000186BFF450-0x0000000186BFF4D0
		public void Pulse(float2 from, float2 to, uint color, float speedMultiplier = 1f /* Metadata: 0x0197761F */) {} // 0x0000000186BFF4D0-0x0000000186BFFB10
		protected override void OnUpdate() {} // 0x0000000186BFFB10-0x0000000186BFFB50
		private void ClearLine() {} // 0x0000000186BFFB50-0x0000000186BFFBC0
	}
}

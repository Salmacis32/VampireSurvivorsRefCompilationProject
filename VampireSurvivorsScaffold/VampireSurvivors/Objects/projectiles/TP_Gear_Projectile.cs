/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Gear_Projectile : Projectile // TypeDefIndex: 15572
	{
		// Fields
		private float _radius; // 0xD0
		private PhaserSprite _animatedSprite; // 0xD8
		private PhaserSprite _animatedSprite2; // 0xE0
		private Tween _radiusTween; // 0xE8
		private MultiTargetTween _scaleTween; // 0xF0
		private float __force; // 0xF8
		private Tween _forceTween; // 0x100
		private float _saveVelX; // 0x108
		private float _saveVelY; // 0x10C
		private bool _isDespawning; // 0x110
		private List<string> _framesFront; // 0x118
		private List<string> _framesBack; // 0x120
		private MultiTargetTween _angleTween; // 0x128
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x130
		private VampireSurvivors.Framework.TimerSystem.Timer _hitBoxTimer; // 0x138
		private MultiTargetTween _angleTween2; // 0x140
	
		// Constructors
		public TP_Gear_Projectile() {} // 0x0000000186CB2960-0x0000000186CB3040
	
		// Methods
		protected override void Awake() {} // 0x0000000186CB1150-0x0000000186CB14B0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CB14B0-0x0000000186CB2650
		private void StartDespawn() {} // 0x0000000186CB2650-0x0000000186CB28F0
		public override void Despawn() {} // 0x0000000186CB28F0-0x0000000186CB2960
	}
}

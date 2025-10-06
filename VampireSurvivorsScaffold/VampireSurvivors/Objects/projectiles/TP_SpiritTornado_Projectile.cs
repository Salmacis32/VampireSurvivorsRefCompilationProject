/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_SpiritTornado_Projectile : Projectile // TypeDefIndex: 15676
	{
		// Fields
		private float _radius; // 0xD0
		private Vector2 _aimVec; // 0xD4
		private PhaserSprite _displaySprite; // 0xE0
		private PhaserSprite _animatedSprite; // 0xE8
		private uint[] _colors; // 0xF0
		private readonly VampireSurvivors.Framework.Particles.BlendMode[] _blendModes; // 0xF8
		private bool _initSpriteTrail; // 0x100
		private MultiTargetTween _scaleTween; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x110
		private VampireSurvivors.Framework.TimerSystem.Timer _chooseTimer; // 0x118
	
		// Constructors
		public TP_SpiritTornado_Projectile() {} // 0x0000000186D23E20-0x0000000186D23FE0
	
		// Methods
		protected override void Awake() {} // 0x0000000186D22320-0x0000000186D22AD0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D22AD0-0x0000000186D23150
		private void TweenInOut(bool tweenIn = true /* Metadata: 0x019777AB */) {} // 0x0000000186D23150-0x0000000186D23590
		private void StartDespawn() {} // 0x0000000186D23590-0x0000000186D235A0
		private void TargetPlayer() {} // 0x0000000186D235A0-0x0000000186D23660
		private void ChooseTarget() {} // 0x0000000186D23660-0x0000000186D23BA0
		private void StartChooseTargetTimer() {} // 0x0000000186D23BA0-0x0000000186D23D50
		private void LateUpdate() {} // 0x0000000186D23D50-0x0000000186D23DC0
		public override void Despawn() {} // 0x0000000186D23DC0-0x0000000186D23E20
	}
}

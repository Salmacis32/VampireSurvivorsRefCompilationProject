/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
	public class Sample1ExplosionProjectile : Projectile // TypeDefIndex: 15449
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _ringRenderer; // 0xD0
		[SerializeField]
		private SpriteRenderer _rainbowRenderer; // 0xD8
		[SerializeField]
		private SpriteRenderer _raysRenderer; // 0xE0
		[SerializeField]
		private Transform _spritesContainer; // 0xE8
		private MultiTargetTween _ttween4; // 0xF0
		private MultiTargetTween _ttween3; // 0xF8
		private MultiTargetTween _ttween2; // 0x100
		private MultiTargetTween _ttween1; // 0x108
		private Weapon _trueWeapon; // 0x110
		private MultiTargetTween scaleTween; // 0x118
		private float SelfRadius; // 0x120
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x128
	
		// Constructors
		public Sample1ExplosionProjectile() {} // 0x0000000186C0A230-0x0000000186C0A290
	
		// Methods
		protected override void Awake() {} // 0x0000000186C08A50-0x0000000186C08C90
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C08C90-0x0000000186C09320
		private void Detonate() {} // 0x0000000186C09320-0x0000000186C0A130
		public override void Despawn() {} // 0x0000000186C0A130-0x0000000186C0A230
	}
}

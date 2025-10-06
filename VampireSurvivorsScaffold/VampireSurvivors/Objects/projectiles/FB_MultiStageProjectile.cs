/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class FB_MultiStageProjectile : Projectile // TypeDefIndex: 15477
	{
		// Fields
		[SerializeField]
		private SpriteAnimation _anim; // 0xD0
		public float2 _targetPosition; // 0xD8
		public float _timeSinceChangedTarget; // 0xE0
		private TrailRenderer _trail; // 0xE8
		private MultiTargetTween _trailFade; // 0xF0
		private float _MaxAlpha; // 0xF8
		private float _AlphaDiff; // 0xFC
	
		// Constructors
		public FB_MultiStageProjectile() {} // 0x0000000186C27E30-0x0000000186C27EA0
	
		// Methods
		protected override void Awake() {} // 0x0000000186C268B0-0x0000000186C26EB0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C26EB0-0x0000000186C27230
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C27230-0x0000000186C27470
		public override void Despawn() {} // 0x0000000186C27470-0x0000000186C274F0
		private void DoExplosion(int missilesToSpawn = 5 /* Metadata: 0x01977649 */) {} // 0x0000000186C274F0-0x0000000186C27E30
	}
}

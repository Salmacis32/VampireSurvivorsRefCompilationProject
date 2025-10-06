/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class GrangattiProjectile : Projectile // TypeDefIndex: 15889
	{
		// Fields
		private ParticleEmitterManager _pfxEmitter; // 0xD0
		private Weapon _trueWeapon; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer _chooseTimer; // 0xE0
		private float _save_vel_x; // 0xE8
		private float _save_vel_y; // 0xEC
		private Vector2 _aimVec; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xF8
		private MultiTargetTween _onExpireAlphaTween; // 0x100
		private SpriteRenderer _summon; // 0x108
		private MultiTargetTween _summonTween; // 0x110
		private float _defaultSpeed; // 0x118
		private MultiTargetTween _entryTween; // 0x120
		private Circle _explosionCircle; // 0x128
		private ParticleEmitterManager _pfxEmitter2; // 0x130
		private List<Vector2> _ellipsePoints; // 0x138
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x140
		private SpriteAnimation _anims; // 0x148
	
		// Constructors
		public GrangattiProjectile() {} // 0x0000000186E2B350-0x0000000186E2B3A0
	
		// Methods
		protected override void Awake() {} // 0x0000000186E27E70-0x0000000186E295C0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E295C0-0x0000000186E2A4F0
		private void onExpireTimer() {} // 0x0000000186E2A4F0-0x0000000186E2A790
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186E2A790-0x0000000186E2A800
		public void TargetPlayer() {} // 0x0000000186E2A800-0x0000000186E2A8C0
		public void ChooseTarget() {} // 0x0000000186E2A8C0-0x0000000186E2AF60
		public override void InternalUpdate() {} // 0x0000000186E2AF60-0x0000000186E2B310
		public override void Despawn() {} // 0x0000000186E2B310-0x0000000186E2B350
	}
}

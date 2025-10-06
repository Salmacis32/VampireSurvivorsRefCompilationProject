/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class GattiProjectile : Projectile // TypeDefIndex: 15882
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _chooseTimer; // 0xD0
		private float _saveVelX; // 0xD8
		private float _saveVelY; // 0xDC
		private Vector2 _aimVec; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xE8
		private MultiTargetTween _onExpireAlphaTween; // 0xF0
		private SpriteRenderer _summon; // 0xF8
		private MultiTargetTween _summonTween; // 0x100
		private float _defaultSpeed; // 0x108
		private MultiTargetTween _entryTween; // 0x110
		private SpriteAnimation _anims; // 0x118
		protected List<string> _catFrames; // 0x120
	
		// Constructors
		public GattiProjectile() {} // 0x0000000186E20970-0x0000000186E209C0
	
		// Methods
		protected override void Awake() {} // 0x0000000186E209C0-0x0000000186E20B40
		protected virtual void CreateCatAnim() {} // 0x0000000186E20B40-0x0000000186E20DA0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E20DA0-0x0000000186E21CB0
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186E21CB0-0x0000000186E21D20
		public override void InternalUpdate() {} // 0x0000000186E21D20-0x0000000186E21F30
		public override void Despawn() {} // 0x0000000186E21F30-0x0000000186E21F80
		private void OnExpireTimer() {} // 0x0000000186E21F80-0x0000000186E22210
		private void TargetPlayer() {} // 0x0000000186E22210-0x0000000186E222D0
		private void ChooseTarget() {} // 0x0000000186E222D0-0x0000000186E22B60
	}
}

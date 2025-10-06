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
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class Bubble2Projectile : Projectile // TypeDefIndex: 15402
	{
		// Fields
		private MultiTargetTween _speedTween; // 0xD0
		private MultiTargetTween _tween1; // 0xD8
		private float _saveVelX; // 0xE0
		private float _saveVelY; // 0xE4
		private bool _canBounce; // 0xE8
		private Vector2 _aimVec; // 0xEC
		public float _BombDeceleration; // 0xF4
		private List<Color> _colors; // 0xF8
		private int _colorIndex; // 0x100
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x108
	
		// Constructors
		public Bubble2Projectile() {} // 0x0000000186BC48E0-0x0000000186BC49D0
	
		// Methods
		protected override void Awake() {} // 0x0000000186BC2FE0-0x0000000186BC3080
		public void SetColor(uint color) {} // 0x0000000186BC3080-0x0000000186BC32A0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BC32A0-0x0000000186BC4440
		public void FadeOut() {} // 0x0000000186BC4440-0x0000000186BC4690
		private void Bounce(Body bdy, bool up, bool down, bool left, bool right) {} // 0x0000000180B15170-0x0000000180B15180
		public void Decelerate() {} // 0x0000000186BC4690-0x0000000186BC46A0
		private void JustBounce() {} // 0x0000000186BC46A0-0x0000000186BC46E0
		public override void InternalUpdate() {} // 0x0000000186BC46E0-0x0000000186BC4760
		public override void Despawn() {} // 0x0000000186BC4760-0x0000000186BC48E0
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186BC4690-0x0000000186BC46A0
	}
}

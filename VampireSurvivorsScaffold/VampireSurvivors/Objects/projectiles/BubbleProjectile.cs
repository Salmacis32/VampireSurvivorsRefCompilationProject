/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class BubbleProjectile : Projectile // TypeDefIndex: 15403
	{
		// Fields
		private MultiTargetTween _speedTween; // 0xD0
		private MultiTargetTween _tween1; // 0xD8
		private float _saveVelX; // 0xE0
		private float _saveVelY; // 0xE4
		private bool _canBounce; // 0xE8
		private Vector2 _aimVec; // 0xEC
		public float _BombDeceleration; // 0xF4
	
		// Constructors
		public BubbleProjectile() {} // 0x0000000186BC5B90-0x0000000186BC5BF0
	
		// Methods
		protected override void Awake() {} // 0x0000000186BC4AC0-0x0000000186BC4B60
		public void SetColor(uint color) {} // 0x0000000186BC4B60-0x0000000186BC4D80
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BC4D80-0x0000000186BC56F0
		public void FadeOut() {} // 0x0000000186BC56F0-0x0000000186BC5940
		private void Bounce(Body bdy, bool up, bool down, bool left, bool right) {} // 0x0000000180B15170-0x0000000180B15180
		public void Decelerate() {} // 0x0000000186BC4690-0x0000000186BC46A0
		private void JustBounce() {} // 0x0000000186BC46A0-0x0000000186BC46E0
		public override void InternalUpdate() {} // 0x0000000186BC5940-0x0000000186BC5A20
		public override void Despawn() {} // 0x0000000186BC5A20-0x0000000186BC5B90
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186BC4690-0x0000000186BC46A0
	}
}

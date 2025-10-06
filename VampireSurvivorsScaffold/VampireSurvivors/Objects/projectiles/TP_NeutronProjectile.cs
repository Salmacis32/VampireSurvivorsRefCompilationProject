/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_NeutronProjectile : Projectile // TypeDefIndex: 15624
	{
		// Fields
		private float _displaySpritePxSize; // 0xD0
		private float _innerRadius; // 0xD4
		private MultiTargetTween _tween1; // 0xD8
		private PhaserSprite _displaySprite; // 0xE0
		private int frameIndex; // 0xE8
		private float frameTime; // 0xEC
		private bool _isActivated; // 0xF0
		private MultiTargetTween _tween2; // 0xF8
		private bool _canUpdate; // 0x100
		private bool _isUnionWeapon; // 0x101
	
		// Constructors
		public TP_NeutronProjectile() {} // 0x0000000186CEE7B0-0x0000000186CEE820
	
		// Methods
		protected override void Awake() {} // 0x0000000186CED7D0-0x0000000186CED9C0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CED9C0-0x0000000186CEDE50
		public override void InternalUpdate() {} // 0x0000000186CEDE50-0x0000000186CEE1E0
		private void ActivateBomb() {} // 0x0000000186CEE1E0-0x0000000186CEE610
		private void PlaySfx() {} // 0x0000000186CEE610-0x0000000186CEE770
		public override void Despawn() {} // 0x0000000186CEE770-0x0000000186CEE7B0
	}
}

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
	public class TP_Universitas_Projectile : Projectile // TypeDefIndex: 15704
	{
		// Fields
		private TP_Universitas_Weapon trueWeapon; // 0xD0
		private PhaserSprite _sprite1; // 0xD8
		private PhaserSprite _sprite2; // 0xE0
		private PhaserSprite _spriteCircle; // 0xE8
		private PhaserSprite _faderImage; // 0xF0
		private MultiTargetTween _circleTween; // 0xF8
		private MultiTargetTween _faderTween; // 0x100
		private MultiTargetTween _explosionTween; // 0x108
		private MultiTargetTween _explosionLoopTween; // 0x110
		private MultiTargetTween _explosionLoop2Tween; // 0x118
		private MultiTargetTween _fadeOutTween; // 0x120
		private MultiTargetTween _fadeOut2Tween; // 0x128
		private float wHeight; // 0x130
		private float wWidth; // 0x134
	
		// Constructors
		public TP_Universitas_Projectile() {} // 0x0000000186D3F640-0x0000000186D3F690
	
		// Methods
		protected override void Awake() {} // 0x0000000186D3D490-0x0000000186D3DBF0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D3DBF0-0x0000000186D3DD70
		private void DisplayDarkness() {} // 0x0000000186D3DD70-0x0000000186D3E020
		private void Explode() {} // 0x0000000186D3E020-0x0000000186D3E8E0
		private void ExplosionLoop() {} // 0x0000000186D3E8E0-0x0000000186D3F070
		private void Disappear() {} // 0x0000000186D3F070-0x0000000186D3F5A0
		public override void Despawn() {} // 0x0000000186D3F5A0-0x0000000186D3F640
	}
}

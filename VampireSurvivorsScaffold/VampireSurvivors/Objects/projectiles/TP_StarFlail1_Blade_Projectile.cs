/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_StarFlail1_Blade_Projectile : Projectile // TypeDefIndex: 15684
	{
		// Fields
		private MultiTargetTween _posTween; // 0xD0
		private SpriteAnimation _anim; // 0xD8
		private MultiTargetTween _rotTween; // 0xE0
		private MultiTargetTween _despawnTween; // 0xE8
		private MultiTargetTween _scaleTween; // 0xF0
	
		// Constructors
		public TP_StarFlail1_Blade_Projectile() {} // 0x0000000186D2DA90-0x0000000186D2DAE0
	
		// Methods
		protected override void Awake() {} // 0x0000000186D2CCE0-0x0000000186D2D0A0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D2D0A0-0x0000000186D2D3B0
		public void ManualIntProjectile(float flyAngle, bool isFlipped) {} // 0x0000000186D2D3B0-0x0000000186D2D760
		public void FadeOut() {} // 0x0000000186D2D760-0x0000000186D2DA30
		public override void Despawn() {} // 0x0000000186D2DA30-0x0000000186D2DA90
	}
}

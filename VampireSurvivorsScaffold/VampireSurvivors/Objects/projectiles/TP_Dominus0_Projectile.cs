/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Dominus0_Projectile : Projectile // TypeDefIndex: 15543
	{
		// Fields
		private PhaserSprite _displaySprite; // 0xD0
		private PhaserSprite _stretchySprite; // 0xD8
		private bool _isDespawning; // 0xE0
		private MultiTargetTween _scaleTween; // 0xE8
		private float __area; // 0xF0
		private MultiTargetTween _scale2Tween; // 0xF8
		private MultiTargetTween _scale3Tween; // 0x100
		private VampireSurvivors.Framework.TimerSystem.Timer hitBoxTimer; // 0x108
		private TP_Dominus2_Weapon _trueWeapon; // 0x110
		private bool inverted; // 0x118
		private string mainFrameName; // 0x120
		private string topFrameName; // 0x128
	
		// Constructors
		public TP_Dominus0_Projectile() {} // 0x0000000186C8F040-0x0000000186C8F180
	
		// Methods
		protected override void Awake() {} // 0x0000000186C8DCF0-0x0000000186C8E030
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C8E030-0x0000000186C8EDE0
		private void LateUpdate() {} // 0x0000000186C8EDE0-0x0000000186C8EEF0
		private void StartDespawn() {} // 0x0000000186C8EEF0-0x0000000186C8EFA0
		public override void Despawn() {} // 0x0000000186C8EFA0-0x0000000186C8F040
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_DraculaHand_Projectile : Projectile // TypeDefIndex: 15552
	{
		// Fields
		[NonSerialized]
		public bool _isMoving; // 0xD0
		private PhaserSprite _arm; // 0xD8
		private int _armFrameCount; // 0xE0
		private float _armProgress; // 0xE4
		private int _armFrame; // 0xE8
		private bool animsSetup; // 0xEC
	
		// Constructors
		public TP_DraculaHand_Projectile() {} // 0x0000000186C98E80-0x0000000186C98ED0
	
		// Methods
		protected override void Awake() {} // 0x0000000186C98190-0x0000000186C98230
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C98230-0x0000000186C98600
		private void InitAnims() {} // 0x0000000186C98600-0x0000000186C987B0
		private void SetArmFrame(int frame) {} // 0x0000000186C987B0-0x0000000186C988F0
		public void Swipe() {} // 0x0000000186C988F0-0x0000000186C989C0
		public override void InternalUpdate() {} // 0x0000000180B15170-0x0000000180B15180
		private void LateUpdate() {} // 0x0000000186C989C0-0x0000000186C98E80
	}
}

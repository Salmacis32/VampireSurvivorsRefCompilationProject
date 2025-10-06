/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class InsatiableWeapon : Weapon // TypeDefIndex: 16163
	{
		// Fields
		private PhaserSprite _image; // 0x158
		private MultiTargetTween _imageTween; // 0x160
		private MultiTargetTween _imageTween2; // 0x168
		private float _imagePixelSize; // 0x170
		public bool IsFromDarkana; // 0x174
	
		// Constructors
		public InsatiableWeapon() {} // 0x0000000186F351D0-0x0000000186F35230
	
		// Methods
		public override float PPower() => default; // 0x0000000186F33FD0-0x0000000186F340C0
		public override float PAmount() => default; // 0x0000000185C0CCB0-0x0000000185C0CCC0
		public override float PArea() => default; // 0x0000000186F340C0-0x0000000186F34240
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F34240-0x0000000186F34850
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977B9D */) {} // 0x0000000186F34850-0x0000000186F348F0
		protected override void OnUpdate() {} // 0x0000000186F348F0-0x0000000186F34AC0
		public override void Cleanup() {} // 0x0000000186F34AC0-0x0000000186F34B50
		public override void SetVisible(bool visible) {} // 0x0000000186F34B50-0x0000000186F34B80
		private float GetImageScale() => default; // 0x0000000186F34B80-0x0000000186F34F80
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F34F80-0x0000000186F351D0
	}
}

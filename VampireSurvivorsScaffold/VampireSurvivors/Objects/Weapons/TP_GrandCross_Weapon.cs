/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_GrandCross_Weapon : Weapon // TypeDefIndex: 16376
	{
		// Fields
		public float defaultWidth; // 0x158
		private float _crossTime; // 0x15C
		private float _nextInterval; // 0x160
		private float _projectileStock; // 0x164
		private float _projectileTime; // 0x168
		private float _projectileInterval; // 0x16C
		private PhaserSprite _lightSprite; // 0x170
		private bool _hasSprites; // 0x178
		private MultiTargetTween _scaleTween; // 0x180
		private MultiTargetTween _alphaTween; // 0x188
		private ParticleSystem _pfx; // 0x190
		private Rectangle _pfxRecta; // 0x198
		public bool ManualFire; // 0x1A0
	
		// Constructors
		public TP_GrandCross_Weapon() {} // 0x0000000186FC3220-0x0000000186FC3290
	
		// Methods
		private float Intensity() => default; // 0x0000000186FC1510-0x0000000186FC15D0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FC15D0-0x0000000186FC21D0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C87 */) {} // 0x0000000186FC21D0-0x0000000186FC2880
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void InternalUpdate() {} // 0x0000000186FC2880-0x0000000186FC2D20
		private void CheckForVFXTweenOut() {} // 0x0000000186FC2D20-0x0000000186FC3120
		private void LateUpdate() {} // 0x0000000186FC3120-0x0000000186FC3160
		public override void SetVisible(bool visible) {} // 0x0000000186FC3160-0x0000000186FC31B0
		public override void Cleanup() {} // 0x0000000186FC31B0-0x0000000186FC3220
	}
}

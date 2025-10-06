/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class Guns3Weapon : Weapon // TypeDefIndex: 16704
	{
		// Fields
		private float _rayAngle; // 0x158
		private float _angleUnit; // 0x15C
		private MultiTargetTween _scaleTween; // 0x160
		private List<PhaserSprite> _rays; // 0x168
		private float _pxUnit; // 0x170
		private MultiTargetTween _permaTween; // 0x178
		protected WeaponType _counterWeaponType1; // 0x180
		protected WeaponType _counterWeaponType2; // 0x184
		protected Weapon _counterWeapon1; // 0x188
		protected Weapon _counterWeapon2; // 0x190
	
		// Constructors
		public Guns3Weapon() {} // 0x000000018708D2E0-0x000000018708D350
	
		// Methods
		public override float PAmount() => default; // 0x000000018708A7C0-0x000000018708A920
		public override float PPower() => default; // 0x000000018708A920-0x000000018708AAA0
		public override float PSpeed() => default; // 0x000000018708AAA0-0x000000018708ABC0
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x000000018708ABC0-0x000000018708AF10
		public override void CheckArcanas() {} // 0x000000018708AF10-0x000000018708B5A0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977DE0 */) {} // 0x000000018708B5A0-0x000000018708C230
		public Projectile FireOneBullet(float x, float y, int index, double angle, BulletPool pool = null) => default; // 0x000000018708C230-0x000000018708C490
		public override void InternalUpdate() {} // 0x000000018708C490-0x000000018708C980
		public override void Cleanup() {} // 0x000000018708C980-0x000000018708CAC0
		public override bool LevelUp() => default; // 0x000000018708CAC0-0x000000018708CC90
		public override bool ApplyLimitBreak(WeightedLimitBreak weightedLimitBreak) => default; // 0x000000018708CC90-0x000000018708CE70
		public override void SetVisible(bool visible) {} // 0x000000018708CE70-0x000000018708CF50
		private void PermaTween() {} // 0x000000018708CF50-0x000000018708D2E0
	}
}

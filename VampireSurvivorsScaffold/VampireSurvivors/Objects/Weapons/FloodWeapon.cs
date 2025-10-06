/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics.Blitters;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class FloodWeapon : Weapon // TypeDefIndex: 16682
	{
		// Fields
		public float VerticalOffset; // 0x158
		private Blitter _blitter; // 0x160
		private float _elapsed; // 0x168
		private float _gravity; // 0x16C
		private float _wave1Alpha; // 0x170
		private List<Bob> _wave1Group; // 0x178
		private Tween _waveTween; // 0x180
		private float _blitterWidth; // 0x188
		private float _blitterHeight; // 0x18C
		private PhaserSprite _displaySprite; // 0x190
		private PhaserSprite _damageSprite; // 0x198
		private MultiTargetTween _alphaTween; // 0x1A0
	
		// Constructors
		public FloodWeapon() {} // 0x0000000187072A50-0x0000000187072B40
	
		// Methods
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x00000001870702F0-0x0000000187070C90
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977DCB */) {} // 0x0000000187070C90-0x0000000187071010
		private void DamageBelow(int index) {} // 0x0000000187071010-0x00000001870715B0
		private void MakeBlitter() {} // 0x00000001870715B0-0x0000000187072270
		private void LateUpdate() {} // 0x0000000187072270-0x0000000187072370
		public void UpdateVerticalOffset() {} // 0x0000000187072370-0x0000000187072530
		private void UpdateBlitter() {} // 0x0000000187072530-0x00000001870729E0
		public override void Cleanup() {} // 0x00000001870729E0-0x0000000187072A50
	}
}

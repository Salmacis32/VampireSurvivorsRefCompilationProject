/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class EX_Rune1_Weapon : Weapon // TypeDefIndex: 16669
	{
		// Fields
		public int AccumulatedProjectiles; // 0x158
		private int activations; // 0x15C
		private List<PhaserSprite> magicCircles; // 0x160
		private int magicCircleIndex; // 0x168
		private float _angle1; // 0x16C
		private float _angle2; // 0x170
		private float _angle3; // 0x174
	
		// Constructors
		public EX_Rune1_Weapon() {} // 0x00000001870664F0-0x00000001870665E0
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000187064A50-0x0000000187064DC0
		protected float StripLength() => default; // 0x0000000187064DC0-0x0000000187064E40
		private void FireStripAtEnemy(EnemyController enemy, int index, Vector2 startPosition) {} // 0x0000000187064E40-0x00000001870653C0
		private Vector2 GetScreenPosition() => default; // 0x00000001870653C0-0x0000000187065540
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977DC6 */) {} // 0x0000000187065540-0x0000000187065C40
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000181BA4B30-0x0000000181BA4B40
		private void ShowMagicCircleAt(Vector2 position, int times) {} // 0x0000000187065C40-0x00000001870660E0
		public override void InternalUpdate() {} // 0x00000001870660E0-0x0000000187066390
		public override void Cleanup() {} // 0x0000000187066390-0x00000001870664F0
	}
}

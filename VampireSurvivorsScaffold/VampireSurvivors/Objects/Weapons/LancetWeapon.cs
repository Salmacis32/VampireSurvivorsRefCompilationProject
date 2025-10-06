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
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class LancetWeapon : Weapon // TypeDefIndex: 16719
	{
		// Fields
		[SerializeField]
		private GameObject _LancetPierceEffectPrefab; // 0x158
		private PhaserSprite _image; // 0x160
		private SpriteAnimation _imageAnim; // 0x168
		private MultiTargetTween _imageTween; // 0x170
		private int _ticks; // 0x178
		private readonly List<Vector2> _targets; // 0x180
		private readonly List<float> _angles; // 0x188
		private const string AnimPierce = "pierce"; // Metadata: 0x01977DE9
	
		// Constructors
		public LancetWeapon() {} // 0x00000001870966A0-0x0000000187096840
	
		// Methods
		public override float PAmount() => default; // 0x0000000186DE50C0-0x0000000186DE50D0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000187095010-0x0000000187095230
		public override void Cleanup() {} // 0x0000000187095230-0x00000001870953F0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977DE8 */) {} // 0x00000001870953F0-0x0000000187095CA0
		private void FireOneLancet(int index, float angle, Vector2 targetPos) {} // 0x0000000187095CA0-0x0000000187096020
		private void SetupLancetEffect() {} // 0x0000000187096020-0x00000001870966A0
	}
}

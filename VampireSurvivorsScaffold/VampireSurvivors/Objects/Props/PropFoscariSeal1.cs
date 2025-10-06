/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using UnityEngine;
using VampireSurvivors.App.Objects;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Props
{
	public class PropFoscariSeal1 : Destructible // TypeDefIndex: 15368
	{
		// Fields
		private bool _alreadyDestroyed; // 0xF8
		private MultiTargetTween _floatTween; // 0x100
		private PhaserSprite _sDarkness; // 0x108
		private PhaserSprite _sFog; // 0x110
		public MeshRenderer magicWaterImage; // 0x118
		private MapToken _mapToken; // 0x120
	
		// Constructors
		public PropFoscariSeal1() {} // 0x00000001869ECEE0-0x00000001869ECF40
	
		// Methods
		public override void Awake() {} // 0x0000000186B9D830-0x0000000186B9DD80
		public override void Init(PropType destructibleType) {} // 0x0000000186B9DD80-0x0000000186B9E3B0
		public override void GetDamaged(float value, HitVfxType showHitVFX, float knockbackMul, WeaponType damageType, bool hasKnockback = true /* Metadata: 0x019775DB */) {} // 0x0000000186B9E3B0-0x0000000186B9E760
		[Command]
		public void DestroySeal(long startingSimFrame) {} // 0x0000000186B9E760-0x0000000186B9E840
		public override void Despawn() {} // 0x0000000186B9E840-0x0000000186B9E850
		protected override void OnDestroyed() {} // 0x0000000186B9E850-0x0000000186B9F5B0
		private void SaveProgress() {} // 0x0000000186B9F5B0-0x0000000186B9F700
		private void ShakeEarth() {} // 0x0000000186B9F700-0x0000000186B9F710
		private void RemoveWater() {} // 0x0000000186B9F710-0x0000000186B9FBF0
		private void ChangeStage() {} // 0x0000000186B9FBF0-0x0000000186BA02C0
		private void ScreenShake(int repeats = 6 /* Metadata: 0x019775DC */) {} // 0x0000000186BA02C0-0x0000000186BA05E0
		private void EditorBreakSeal() {} // 0x0000000186AE61E0-0x0000000186AE6200
	}
}

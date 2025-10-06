/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Signals;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class ShroudWeapon : Weapon // TypeDefIndex: 16768
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _Renderer; // 0x158
		private DG.Tweening.Sequence _fadeTween; // 0x160
		private Tween _angleTween; // 0x168
		private int _maxCharges; // 0x170
		private bool _hasThorns; // 0x174
		private float _lastReceivedDamage; // 0x178
		private bool _wasActiveOnMadeInvisible; // 0x17C
	
		// Constructors
		public ShroudWeapon() {} // 0x00000001870B3600-0x00000001870B3660
	
		// Methods
		public override float PPower() => default; // 0x00000001870B2040-0x00000001870B2110
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x00000001870B2110-0x00000001870B28D0
		[IteratorStateMachine(typeof(_DelayAFrame_d__9))]
		private IEnumerator DelayAFrame() => default; // 0x00000001870B28D0-0x00000001870B2970
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977E2F */) {} // 0x00000001870B2970-0x00000001870B2AF0
		public override void Cleanup() {} // 0x00000001870B2AF0-0x00000001870B2D50
		public override void InternalUpdate() {} // 0x00000001870B2D50-0x00000001870B2E60
		public override bool LevelUp() => default; // 0x00000001870B2E60-0x00000001870B2FB0
		public override void SetVisible(bool visible) {} // 0x00000001870B2FB0-0x00000001870B3090
		protected override void OnStart() {} // 0x00000001870B3090-0x00000001870B3300
		private void OnLostShield(GameplaySignals.CharacterLostShieldSignal sig) {} // 0x00000001870B3300-0x00000001870B3450
		private void CheckColor(GameplaySignals.CharacterLostShieldSignal sig) {} // 0x00000001870B3450-0x00000001870B3600
	}
}

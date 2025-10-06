/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Dominus3_Weapon : Weapon // TypeDefIndex: 16324
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _Renderer; // 0x158
		[SerializeField]
		private SpriteRenderer _ZoneRenderer; // 0x160
		private Tween _angleTween; // 0x168
		private DG.Tweening.Sequence _fadeTween; // 0x170
		private DG.Tweening.Sequence _fadeTween2; // 0x178
		private List<bool> _cachedInRange; // 0x180
		private const float _baseDamageValue = 3f; // Metadata: 0x01977C52
		private const float _baseStatBonusValue = 0.08f; // Metadata: 0x01977C56
		private int _statBonusMultiplier; // 0x188
	
		// Constructors
		public TP_Dominus3_Weapon() {} // 0x0000000186FA39C0-0x0000000186FA3AC0
	
		// Methods
		protected override void Awake() {} // 0x0000000186FA1AC0-0x0000000186FA1B70
		public override float PAmount() => default; // 0x0000000185C0CCB0-0x0000000185C0CCC0
		public override float PInterval() => default; // 0x0000000186FA1B70-0x0000000186FA1BA0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FA1BA0-0x0000000186FA2630
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C4C */) {} // 0x0000000186FA2630-0x0000000186FA2900
		public override void Cleanup() {} // 0x0000000186FA2900-0x0000000186FA2C70
		public override void InternalUpdate() {} // 0x0000000186FA2C70-0x0000000186FA2D40
		private bool IsCharacterInRange(VampireSurvivors.Objects.Characters.CharacterController character) => default; // 0x0000000186FA2D40-0x0000000186FA2EF0
		private void UpdateStatBonuses() {} // 0x0000000186FA2EF0-0x0000000186FA3160
		private void ApplyStatBonuses(VampireSurvivors.Objects.Characters.CharacterController character, bool addStats = true /* Metadata: 0x01977C4D */) {} // 0x0000000186FA3160-0x0000000186FA3560
		private void ClearStatBonuses() {} // 0x0000000186FA3560-0x0000000186FA3780
		private float GetRadius() => default; // 0x0000000186FA3780-0x0000000186FA37B0
		private void UpdateRendererScaleToArea(SpriteRenderer renderer, float multiplier = 1f /* Metadata: 0x01977C4E */) {} // 0x0000000186FA37B0-0x0000000186FA3920
		public override void SetVisible(bool visible) {} // 0x0000000186FA3920-0x0000000186FA39C0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_RulerSword_Weapon : Weapon // TypeDefIndex: 16456
	{
		// Fields
		[SerializeField]
		private Projectile _InvisibleProjectilePrefab; // 0x158
		[SerializeField]
		private GameObject _SwordsContainer; // 0x160
		public BulletPool InvisibleProjectilesPool; // 0x168
		private List<TP_RulerSword_Weapon_Sprite> _swords; // 0x170
		private Vector3 innerRadius; // 0x178
		private float momentum; // 0x184
		private float velocity; // 0x188
		private float lastVelX; // 0x18C
		private int _activeCount; // 0x190
		private bool _isAttacking; // 0x194
	
		// Properties
		public BulletPool SwordsPool { get => default; } // 0x00000001827666D0-0x00000001827666E0 
	
		// Constructors
		public TP_RulerSword_Weapon() {} // 0x0000000186FE3A40-0x0000000186FE3B50
	
		// Methods
		protected override void OnStart() {} // 0x0000000186FE2450-0x0000000186FE2460
		private TP_RulerSword_Weapon_Sprite AddRulerSwordSprite(Vector2 pos, string textureName, string spriteName) => default; // 0x0000000186FE2460-0x0000000186FE2760
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FE2760-0x0000000186FE2A90
		public bool ShowNextSword() => default; // 0x0000000186FE2A90-0x0000000186FE2B40
		private void AddSword(TP_RulerSword_Weapon_Sprite swordToAdd) {} // 0x0000000186FE2B40-0x0000000186FE2FD0
		private TP_RulerSword_Weapon_Sprite MakeSword_Large() => default; // 0x0000000186FE2FD0-0x0000000186FE3090
		private TP_RulerSword_Weapon_Sprite MakeSword_Small() => default; // 0x0000000186FE3090-0x0000000186FE3150
		public bool AddNextSword() => default; // 0x0000000186FE3150-0x0000000186FE32D0
		public override void Fire() {} // 0x0000000180B15170-0x0000000180B15180
		public void Attack() {} // 0x0000000186FE32D0-0x0000000186FE35D0
		protected override void OnUpdate() {} // 0x0000000186FE35D0-0x0000000186FE3A40
		public override void SetVisible(bool visible) {} // 0x0000000180B15170-0x0000000180B15180
	}
}

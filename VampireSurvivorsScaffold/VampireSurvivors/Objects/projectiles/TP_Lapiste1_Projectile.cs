/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Lapiste1_Projectile : Projectile // TypeDefIndex: 15605
	{
		// Fields
		private const float Radius = 16f; // Metadata: 0x01977772
		private const float ScaleModifier = 1.5f; // Metadata: 0x01977776
		private readonly Vector2 BaseOffset; // 0xD0
		private TP_Lapiste1_Weapon _trueWeapon; // 0xD8
		private PhaserSprite _knuckleSprite; // 0xE0
		private int _cachedAmount; // 0xE8
		private float _cachedArea; // 0xEC
		private int _repeatCounter; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _hitBoxTimer; // 0xF8
		private Tween _scaleTween; // 0x100
	
		// Constructors
		public TP_Lapiste1_Projectile() {} // 0x0000000186CDA7F0-0x0000000186CDA8A0
	
		// Methods
		protected override void Awake() {} // 0x0000000186CD9300-0x0000000186CD9950
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CD9950-0x0000000186CD9E90
		private void InitSprite() {} // 0x0000000186CD9E90-0x0000000186CDA010
		private void ScaleIn() {} // 0x0000000186CDA010-0x0000000186CDA290
		private void PlaySfx() {} // 0x0000000186CDA290-0x0000000186CDA450
		private void StartHitBoxTimer() {} // 0x0000000186CDA450-0x0000000186CDA5B0
		public override void InternalUpdate() {} // 0x0000000186CDA5B0-0x0000000186CDA740
		private void UpdatePosition() {} // 0x0000000186CDA5B0-0x0000000186CDA740
		public override void Despawn() {} // 0x0000000186CDA740-0x0000000186CDA7F0
	}
}

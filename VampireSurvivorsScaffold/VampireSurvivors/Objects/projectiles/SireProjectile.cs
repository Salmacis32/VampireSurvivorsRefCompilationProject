/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pickups;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.VFX.Shatter;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class SireProjectile : Projectile // TypeDefIndex: 15966
	{
		// Fields
		private Transform _playerCachedTransform; // 0xD0
		private ShatterVFX _shatterVfx; // 0xD8
		private MultiTargetTween[] _tweens; // 0xE0
		private float _globalScale; // 0xE8
		private bool _eraseItems; // 0xEC
		protected SireWeapon _trueWeapon; // 0xF0
		private float[] _offsets; // 0xF8
		private string[] _frames; // 0x100
	
		// Constructors
		public SireProjectile() {} // 0x0000000186E70E00-0x0000000186E71080
	
		// Methods
		protected override void Awake() {} // 0x0000000186E6DB80-0x0000000186E6DC30
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E6DC30-0x0000000186E6DFE0
		private void OnRecycle() {} // 0x0000000186E6DFE0-0x0000000186E6E940
		public override void InternalUpdate() {} // 0x0000000186E6E940-0x0000000186E6EB80
		private void EraseRandomEnemy(SfxType sfx, int index = 0 /* Metadata: 0x0197799E */, int detune = 0 /* Metadata: 0x0197799F */, float offset = 0f /* Metadata: 0x019779A0 */) {} // 0x0000000186E6EB80-0x0000000186E6F1A0
		private void MoonDamage(EnemyController target, int index = 0 /* Metadata: 0x019779A4 */) {} // 0x0000000186E6F1A0-0x0000000186E6F570
		protected void EraseEnemies() {} // 0x0000000186E6F570-0x0000000186E6F9D0
		private void DrawSymbol() {} // 0x0000000186E6F9D0-0x0000000186E6FE00
		private void Shatter() {} // 0x0000000186E6FE00-0x0000000186E70A80
		public override void Despawn() {} // 0x0000000186E70A80-0x0000000186E70BC0
		private void InitShatterVfx() {} // 0x0000000186E70BC0-0x0000000186E70E00
		private void KillTweens() {} // 0x0000000186E54FA0-0x0000000186E55000
		private static void KillTween(MultiTargetTween[] tweens) {} // 0x0000000186D90750-0x0000000186D907B0
	}
}

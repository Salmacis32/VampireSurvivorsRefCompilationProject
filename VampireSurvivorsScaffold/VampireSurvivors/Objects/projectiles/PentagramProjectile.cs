/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.VFX.Shatter;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class PentagramProjectile : Projectile // TypeDefIndex: 15936
	{
		// Fields
		private Transform _playerCachedTransform; // 0xD0
		private ShatterVFX _shatterVfx; // 0xD8
		private MultiTargetTween[] _tweens; // 0xE0
		private float _globalScale; // 0xE8
		private bool _eraseItems; // 0xEC
	
		// Constructors
		public PentagramProjectile() {} // 0x0000000186E55150-0x0000000186E55220
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E53330-0x0000000186E53850
		protected void EraseEnemies(bool erase = false /* Metadata: 0x01977974 */) {} // 0x0000000186E53850-0x0000000186E53AF0
		protected void EraseItems() {} // 0x0000000186E53AF0-0x0000000186E541A0
		public override void InternalUpdate() {} // 0x0000000186E541A0-0x0000000186E54470
		private void Shatter() {} // 0x0000000186E54470-0x0000000186E54CE0
		public override void Despawn() {} // 0x0000000186E54CE0-0x0000000186E54D60
		private void InitShatterVfx() {} // 0x0000000186E54D60-0x0000000186E54FA0
		private void KillTweens() {} // 0x0000000186E54FA0-0x0000000186E55000
		private void KillTween(MultiTargetTween[] tweens) {} // 0x0000000186E55000-0x0000000186E55060
		private PentagramType GetPentType() => default; // 0x0000000186E55060-0x0000000186E55150
	}
}

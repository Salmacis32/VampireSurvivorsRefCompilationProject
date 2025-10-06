/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Spite0_Projectile : Projectile // TypeDefIndex: 15677
	{
		// Fields
		[SerializeField]
		private bool ShowWhiteTrail; // 0xD0
		private TrailRenderer _ShotTrail; // 0xD8
		private float _bodyRadius; // 0xE0
		private MultiTargetTween _scaleTween; // 0xE8
		private MultiTargetTween _fadeInTrailTween; // 0xF0
		private List<TP_Spite1_Projectile> _damageBoxes; // 0xF8
	
		// Constructors
		public TP_Spite0_Projectile() {} // 0x0000000186D252D0-0x0000000186D253D0
	
		// Methods
		protected override void Awake() {} // 0x0000000186D24230-0x0000000186D245B0
		public void SetDamageBoxes(List<TP_Spite1_Projectile> boxes) {} // 0x0000000186D245B0-0x0000000186D247A0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D247A0-0x0000000186D24C40
		private void StartDespawn() {} // 0x0000000186D24C40-0x0000000186D24ED0
		public override void Despawn() {} // 0x0000000186D24ED0-0x0000000186D252D0
	}
}

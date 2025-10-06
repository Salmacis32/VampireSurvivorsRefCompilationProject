/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Confodere1_Projectile : Projectile // TypeDefIndex: 15514
	{
		// Fields
		private MultiTargetTween _scaleTween; // 0xD0
		private MultiTargetTween _fadeTween; // 0xD8
		private TP_Confodere1_Weapon _trueWeapon; // 0xE0
	
		// Constructors
		public TP_Confodere1_Projectile() {} // 0x0000000186C74D60-0x0000000186C74DB0
	
		// Methods
		protected override void Awake() {} // 0x0000000186C74240-0x0000000186C742F0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C742F0-0x0000000186C744B0
		public override void Despawn() {} // 0x0000000186C741B0-0x0000000186C741F0
		public override void SetNullTarget() {} // 0x0000000186BB8730-0x0000000186BB8750
		public override void SetTarget(Transform target) {} // 0x0000000186C744B0-0x0000000186C74D60
	}
}

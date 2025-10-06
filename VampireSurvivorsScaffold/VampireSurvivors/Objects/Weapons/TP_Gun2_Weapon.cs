/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Gun2_Weapon : TP_Gun1_Weapon // TypeDefIndex: 16380
	{
		// Fields
		private ParticleSystem _jewelPickupVfx; // 0x180
		private List<Color32> _colors; // 0x188
	
		// Constructors
		public TP_Gun2_Weapon() {} // 0x0000000186FC5400-0x0000000186FC5750
	
		// Methods
		protected override void Awake() {} // 0x0000000186FC3E30-0x0000000186FC49B0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C8D */) {} // 0x0000000186FC49B0-0x0000000186FC4D20
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186FC4D20-0x0000000186FC5210
		public void ShowBigDamage(float value, Vector3 position) {} // 0x0000000186FC5210-0x0000000186FC5400
	}
}

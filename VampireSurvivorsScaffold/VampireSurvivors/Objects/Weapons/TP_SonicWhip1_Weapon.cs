/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_SonicWhip1_Weapon : TP_WhipCore1_Weapon // TypeDefIndex: 16480
	{
		// Constructors
		public TP_SonicWhip1_Weapon() {} // 0x0000000186FC8280-0x0000000186FC8290
	
		// Methods
		protected override void Awake() {} // 0x0000000186FEFAA0-0x0000000186FEFAC0
		public override float PDuration() => default; // 0x0000000186FEFAC0-0x0000000186FEFC30
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977CDE */) {} // 0x0000000186FEFC30-0x0000000186FEFFF0
		public override void CheckArcanas() {} // 0x0000000186F8E930-0x0000000186F8E9F0
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186FEFFF0-0x0000000186FF0420
		protected bool IsInstaKill() => default; // 0x0000000186FF0420-0x0000000186FF04D0
		protected void ShowBigDamage(float value, Vector3 position) {} // 0x0000000186FF04D0-0x0000000186FF0640
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B209C0-0x0000000180B209D0
	}
}

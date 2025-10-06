/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_Magic2Projectile : EME_Magic1Projectile // TypeDefIndex: 15804
	{
		// Fields
		[SerializeField]
		[Tooltip("The speed at which the invisible hitboxes orbit the player while the visuals stay stationary. Shouldbe high enough that enemies won\'t be able to get through the gaps between the hitboxes")]
		private float _hitboxOrbitSpeed; // 0x120
		private float _vfxPositionInCircumference; // 0x124
		private float _angleTravelled; // 0x128
		private const float RadiansInAFullCircle = 6.2831855f; // Metadata: 0x01977870
	
		// Properties
		protected override float OrbitSpeed { get => default; } // 0x0000000186DC2440-0x0000000186DC2460 
	
		// Constructors
		public EME_Magic2Projectile() {} // 0x0000000186DC21C0-0x0000000186DC2230
	
		// Methods
		public override void InternalUpdate() {} // 0x0000000186DC2460-0x0000000186DC26E0
		public override void SetOffsetPosition(int index) {} // 0x0000000186DC26E0-0x0000000186DC2710
	}
}

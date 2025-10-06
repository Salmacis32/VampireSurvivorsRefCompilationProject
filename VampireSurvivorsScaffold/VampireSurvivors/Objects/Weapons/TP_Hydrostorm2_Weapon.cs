/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Hydrostorm2_Weapon : TP_Hydrostorm_Weapon // TypeDefIndex: 16391
	{
		// Fields
		private const float Mul = 333.33334f; // Metadata: 0x01977C92
		private bool _cooldownAffectedByMovement; // 0x198
		private VampireSurvivors.Framework.TimerSystem.Timer _sfxTimer; // 0x1A0
		private int _sfxDetune; // 0x1A8
	
		// Properties
		protected override uint RainEmitterTint1 { get => default; } // 0x0000000186FC89D0-0x0000000186FC89E0 
		protected override uint RainEmitterTint2 { get => default; } // 0x0000000186FC89E0-0x0000000186FC89F0 
		protected override int RainEmitterQuantity { get => default; } // 0x0000000181B80A30-0x0000000181B80A40 
		protected override ParticleSystem.MinMaxCurve RainEmitterAlpha { get => default; } // 0x0000000186FC89F0-0x0000000186FC8A30 
		protected override bool EnableBottleEmitters { get => default; } // 0x0000000181958370-0x0000000181958380 
		protected override bool EnableGroundEmitters { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public TP_Hydrostorm2_Weapon() {} // 0x0000000186FC9120-0x0000000186FC9170
	
		// Methods
		protected override void UpdateFiringInterval() {} // 0x0000000186FC8A30-0x0000000186FC8B10
		protected override void PlaySfx() {} // 0x0000000186FC8B10-0x0000000186FC8EB0
		private void PlayHolyWaterSfx() {} // 0x0000000186FC8EB0-0x0000000186FC8FC0
		public override void CheckArcanas() {} // 0x0000000186FC8FC0-0x0000000186FC9120
	}
}

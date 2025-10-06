/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	public class WickedSeason // TypeDefIndex: 17544
	{
		// Fields
		private SignalBus _signalBus; // 0x10
		private bool _hasWickedSeason; // 0x18
		private float _seasonTime; // 0x1C
		private float _seasonDuration; // 0x20
		private int _seasonIndex; // 0x24
		private float _curse; // 0x28
		private float _growth; // 0x2C
		private float _luck; // 0x30
		private float _greed; // 0x34
		private readonly List<string> _wickedSeasonAttributes; // 0x38
		private List<string> _seasonColors; // 0x40
		private List<string> _seasonIcons; // 0x48
		private readonly List<SfxType> _seasonSfx; // 0x50
	
		// Properties
		public float SeasonDuration { get => default; } // 0x0000000181967D10-0x0000000181967D20 
		public float Curse { get => default; } // 0x000000018273EC30-0x000000018273EC40 
		public float Growth { get => default; } // 0x0000000181949670-0x0000000181949680 
		public float Luck { get => default; } // 0x0000000181949690-0x00000001819496A0 
		public float Greed { get => default; } // 0x000000018289A800-0x000000018289A810 
	
		// Constructors
		public WickedSeason() {} // 0x0000000187357F90-0x0000000187358870
	
		// Methods
		public void Init(SignalBus signalBus) {} // 0x0000000181958310-0x0000000181958370
		public void Update() {} // 0x0000000187357B00-0x0000000187357F90
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.VFX;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class EME_CharacterControllerShowstopper : CharacterController // TypeDefIndex: 17153
	{
		// Fields
		private float _mightBonus; // 0x3F0
		private float _cooldownBonus; // 0x3F4
		private float _luckBonus; // 0x3F8
		private float _morphDuration; // 0x3FC
		private bool _isMorphed; // 0x400
		private bool _hasBonusApplied; // 0x401
		private EME_ShowstopperVfx _showStoperVfx; // 0x408
		private BgmType _playerCurrentMusic; // 0x410
		private BgmModType _playerCurrentbgmMod; // 0x414
		private VampireSurvivors.Framework.TimerSystem.Timer _showstopperTimer; // 0x418
		private VampireSurvivors.Framework.TimerSystem.Timer _showstopperMusicTimer; // 0x420
	
		// Constructors
		public EME_CharacterControllerShowstopper() {} // 0x0000000187181240-0x0000000187181260
	
		// Methods
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x019780FF */) {} // 0x0000000187187540-0x0000000187187570
		public override void AfterFullInitialization() {} // 0x0000000187187570-0x00000001871877F0
		private void CriticalHP() {} // 0x00000001871877F0-0x0000000187187800
		protected virtual void OnShowStopperStarted() {} // 0x0000000180B15170-0x0000000180B15180
		protected void StartShowstopper() {} // 0x0000000187187800-0x0000000187188060
		private void Unmorph() {} // 0x0000000187188060-0x0000000187188440
	}
}

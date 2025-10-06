/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterControllerLuminaire : CharacterController // TypeDefIndex: 16945
	{
		// Fields
		private float _cooldownBonus; // 0x3F0
		private float _moveBonus; // 0x3F4
		private float _bonusDuration; // 0x3F8
		private bool _hasBonus; // 0x3FC
		private List<PhaserSprite> _doilies; // 0x400
		private MultiTargetTween _tween1; // 0x408
		private float _mightBonus; // 0x410
		private MorphVFX _morphVFX; // 0x418
		private float _elapsedGFBonusTime; // 0x420
		private PhaserSprite _fogRays; // 0x428
		private float _timesRevived; // 0x430
		private float _originalMoveSpeed; // 0x434
	
		// Properties
		public override bool NeedsCart { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	
		// Constructors
		public CharacterControllerLuminaire() {} // 0x0000000187112450-0x0000000187112470
	
		// Methods
		protected override void OnUpdate() {} // 0x0000000187110850-0x0000000187110940
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977F25 */) {} // 0x0000000187110940-0x0000000187110980
		public override void AfterFullInitialization() {} // 0x0000000187110980-0x00000001871113F0
		public override void LevelUp() {} // 0x00000001871113F0-0x00000001871115D0
		public override void Revive(float percentage = 1f /* Metadata: 0x01977F26 */, bool instantRevival = false /* Metadata: 0x01977F2A */) {} // 0x00000001871115D0-0x0000000187111B90
		public void RemoveBonus() {} // 0x0000000187111B90-0x0000000187111ED0
		protected override void OnStop() {} // 0x00000001871084A0-0x00000001871084D0
		private void RosaryDamage() {} // 0x0000000187111ED0-0x0000000187111F50
		private void PlayRosaryAnim() {} // 0x0000000187111F50-0x0000000187112450
	}
}

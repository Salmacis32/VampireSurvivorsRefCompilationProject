/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterSkillCard_FS004Luminaire : CharacterSkillCard_Base // TypeDefIndex: 16859
	{
		// Fields
		private float _cooldownBonus; // 0x70
		private float _moveBonus; // 0x74
		private float _bonusDuration; // 0x78
		private bool _hasBonus; // 0x7C
		private List<PhaserSprite> _doilies; // 0x80
		private MultiTargetTween _tween1; // 0x88
		private float _mightBonus; // 0x90
		private MorphVFX _morphVFX; // 0x98
		private float _elapsedGFBonusTime; // 0xA0
		private PhaserSprite _fogRays; // 0xA8
		private float _timesRevived; // 0xB0
		private float _originalMoveSpeed; // 0xB4
	
		// Constructors
		public CharacterSkillCard_FS004Luminaire() {} // Dummy constructor
		public CharacterSkillCard_FS004Luminaire(ArcanaType type) {} // 0x00000001870DEBE0-0x00000001870DEC90
	
		// Methods
		public override void InitialActivate() {} // 0x00000001870DEC90-0x00000001870DECE0
		public void SetupGraphics() {} // 0x00000001870DECE0-0x00000001870DF780
		public override void Update() {} // 0x00000001870DF780-0x00000001870DF860
		public override void OnOwnerLevelUp() {} // 0x00000001870DF860-0x00000001870DF910
		public override void OnOwnerRevived(float percentage = 1f /* Metadata: 0x01977EA6 */, bool instantRevival = false /* Metadata: 0x01977EAA */) {} // 0x00000001870DF910-0x00000001870DFF00
		public void RemoveBonus() {} // 0x00000001870DFF00-0x00000001870E0270
		private void RosaryDamage() {} // 0x00000001870E0270-0x00000001870E02F0
		private void PlayRosaryAnim() {} // 0x00000001870E02F0-0x00000001870E07F0
	}
}

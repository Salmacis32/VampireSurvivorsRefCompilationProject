/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public class WorldEaterVFX // TypeDefIndex: 15176
	{
		// Fields
		private PhaserSprite _sprite1; // 0x10
		private MultiTargetTween _tween1; // 0x18
		private PhaserSprite _faderImage; // 0x20
		private MultiTargetTween _worldEaterTween1; // 0x28
		private MultiTargetTween _worldEaterTween2; // 0x30
		private MultiTargetTween _worldEaterTween3; // 0x38
		private bool _isPlayingWorldEaterVfx; // 0x40
		private PhaserSprite _worldEaterImage; // 0x48
		private ParticleEmitterManager _pfxEmitter; // 0x50
		private ParticleSystem _ppp; // 0x58
		private List<PhaserSprite> _rays; // 0x60
		private MultiTargetTween _raysTween; // 0x68
		private VampireSurvivors.Objects.Characters.CharacterController _Owner; // 0x70
		public int TriggeredTimes; // 0x78
	
		// Constructors
		public WorldEaterVFX() {} // Dummy constructor
		public WorldEaterVFX(VampireSurvivors.Objects.Characters.CharacterController owner) {} // 0x0000000186A76420-0x0000000186A76BE0
	
		// Methods
		public void CastSoulSteal(Action callback = null, bool isCursed = false /* Metadata: 0x01977433 */) {} // 0x0000000186A76BE0-0x0000000186A77430
		public void PlayWorldEater(Action callback = null, bool isCursed = false /* Metadata: 0x01977434 */) {} // 0x0000000186A77430-0x0000000186A77D80
		public void DoSoulSteal(bool isCursed = false /* Metadata: 0x01977435 */) {} // 0x0000000186A77D80-0x0000000186A78250
		public void ScreenShake() {} // 0x0000000186A78250-0x0000000186A78770
	}
}

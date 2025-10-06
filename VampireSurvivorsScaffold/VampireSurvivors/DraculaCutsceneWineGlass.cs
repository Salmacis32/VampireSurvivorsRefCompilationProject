/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class DraculaCutsceneWineGlass : ArcadeSprite // TypeDefIndex: 13971
	{
		// Fields
		[SerializeField]
		private AnimationCurve _xAnimationCurve; // 0x58
		[SerializeField]
		private AnimationCurve _yAnimationCurve; // 0x60
		[SerializeField]
		private float _ThrowDuration; // 0x68
		[SerializeField]
		private float _ThrowEndRotation; // 0x6C
		[SerializeField]
		private PhaserSprite _ImpactExplosion; // 0x70
		[SerializeField]
		private ParticleSystem _WineGlassImpactParticles; // 0x78
		private MultiTargetTween _scaleTween; // 0x80
		private const string WineGlassSpriteName = "TP_VFX_WineGlass01"; // Metadata: 0x01976C59
		private const string WineGlassAnimName = "TP_VFX_WineGlass"; // Metadata: 0x01976C6C
		private const string WineGlassParticleSpriteName = "TP_VFX_WineGlass04"; // Metadata: 0x01976C7D
		private const string ThosePeopleTextureName = "ThosePeople"; // Metadata: 0x01976C90
		private const string ExplodeAnimName = "explode"; // Metadata: 0x01976C9C
		private readonly List<SfxType> _glassLight; // 0x88
	
		// Constructors
		public DraculaCutsceneWineGlass() {} // 0x000000018697DF30-0x000000018697E450
	
		// Methods
		public void InitWineGlass() {} // 0x000000018697D2A0-0x000000018697D3A0
		public void ThrowWineGlass(float delay, Vector2 startPosition, Vector2 endPosition) {} // 0x000000018697D3A0-0x000000018697D490
		private void InitImpactExplosion() {} // 0x000000018697D490-0x000000018697D8D0
		[IteratorStateMachine(typeof(_ThrowCoroutine_d__16))]
		private IEnumerator ThrowCoroutine(float delay, Vector2 startPosition, Vector2 endPosition) => default; // 0x000000018697D8D0-0x000000018697D9B0
		private void BreakOnImpact() {} // 0x000000018697D9B0-0x000000018697DE30
		protected override void OnDestroy() {} // 0x000000018697DE30-0x000000018697DF30
	}
}

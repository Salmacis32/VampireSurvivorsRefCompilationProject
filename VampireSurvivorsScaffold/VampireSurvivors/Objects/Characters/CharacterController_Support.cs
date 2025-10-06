/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.VFX;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	[DefaultExecutionOrder(851)]
	public class CharacterController_Support // TypeDefIndex: 16997
	{
		// Fields
		[NonSerialized]
		public float RapidFire_Life; // 0x10
		[NonSerialized]
		public float HeartRefresh_Life; // 0x14
		[NonSerialized]
		public float MirrorOfTruth_Life; // 0x18
		private TemporaryEffect _rapidFireEffect; // 0x20
		private TemporaryEffect _heartRefreshEffect; // 0x28
		private KarmaCoinVFX _lastKarmaCoinVFX; // 0x30
		private int _karmaCoinCount; // 0x38
		private HeartRefreshVFX _lastHeartRefreshVFX; // 0x40
		private TemporaryEffect _mirrorOfTruthEffect; // 0x48
		private readonly CharacterController controller; // 0x50
	
		// Nested types
		public class TemporaryEffect // TypeDefIndex: 16993
		{
			// Fields
			public ParticleSystem ParticleSystem; // 0x10
			public int Actives; // 0x18
			public MultiTargetTween Tween; // 0x20
			public List<float> ActiveValueChanges; // 0x28
	
			// Constructors
			public TemporaryEffect() {} // 0x0000000180B15170-0x0000000180B15180
		}
	
		// Constructors
		public CharacterController_Support() {} // Dummy constructor
		public CharacterController_Support(CharacterController controller) {} // 0x000000018261D810-0x000000018261D870
	
		// Methods
		public void InternalUpdate() {} // 0x000000018713D100-0x000000018713D230
		private void InitRapidFireEffect() {} // 0x000000018713D230-0x000000018713DCB0
		public void AddActiveRapidFire(float cooldownChange, float speedChange, float duration) {} // 0x000000018713DCB0-0x000000018713E230
		private void InitHeartRefreshEffect() {} // 0x000000018713E230-0x000000018713ECB0
		public void AddActiveHeartRefresh(float statChange1, float statChange2, float duration) {} // 0x000000018713ECB0-0x000000018713F600
		public void AddKarmaCoin() {} // 0x00000001858B67F0-0x00000001858B6800
		private void ActivateKarmaCoin(float pLuck) {} // 0x000000018713F600-0x000000018713FA20
		private void ApplyKarmaCoinEffect() {} // 0x000000018713FA20-0x000000018713FC10
		private void InitMirrorOfTruthEffect() {} // 0x000000018713FC10-0x00000001871404F0
		public void AddActiveMirrorOfTruth(float statChange1, float statChange2, float duration) {} // 0x00000001871404F0-0x0000000187140B30
	}
}

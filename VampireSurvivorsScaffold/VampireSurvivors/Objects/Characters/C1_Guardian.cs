/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class C1_Guardian : CharacterController // TypeDefIndex: 17002
	{
		// Fields
		private List<CharacterController> _charactersAffectedByAura; // 0x3F0
		private ParticleSystem _guardianParticleSystem; // 0x3F8
		private float _timer; // 0x400
	
		// Constructors
		public C1_Guardian() {} // 0x0000000187107F90-0x0000000187107FA0
	
		// Methods
		protected override void OnStop() {} // 0x00000001871084A0-0x00000001871084D0
		public override void AfterFullInitialization() {} // 0x00000001871430D0-0x0000000187143AB0
		protected override void OnUpdate() {} // 0x0000000187143AB0-0x0000000187144000
		private void ApplyAuraToPlayer(CharacterController character) {} // 0x00000001870ED530-0x00000001870ED700
		private void RemoveAuraFromPlayer(CharacterController character) {} // 0x00000001870ED700-0x00000001870ED8D0
		public override void DoPostRevivalActions(CharacterController revived, bool instantRevival = false /* Metadata: 0x01977FC2 */) {} // 0x0000000187144000-0x0000000187144130
		public override bool ShouldCollideWithWalls() => default; // 0x0000000180B15290-0x0000000180B152A0
	}
}

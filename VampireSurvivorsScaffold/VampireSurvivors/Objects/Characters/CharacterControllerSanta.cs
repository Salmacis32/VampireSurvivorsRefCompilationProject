/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterControllerSanta : CharacterController // TypeDefIndex: 16968
	{
		// Fields
		private List<string> _WeaponIcons; // 0x3F0
		private bool _AddedHiddenWeapons; // 0x3F8
	
		// Constructors
		public CharacterControllerSanta() {} // 0x0000000187107F90-0x0000000187107FA0
	
		// Methods
		public override void AfterFullInitialization() {} // 0x0000000187125710-0x0000000187126100
		public override void GetTreasureModifier() {} // 0x0000000187126100-0x00000001871262D0
		private void CriticalHP() {} // 0x00000001871262D0-0x0000000187126510
		private void OnCriticalHp() {} // 0x0000000187126510-0x00000001871265C0
		[Command]
		public void TriggerOnCriticalHp(long startingSimFrame) {} // 0x00000001871265C0-0x00000001871266A0
		public override void LevelUp() {} // 0x00000001871266A0-0x0000000187127540
		private Weapon AddHiddenWeaponAndRemoveEvolution(WeaponType type) => default; // 0x0000000187127540-0x00000001871277B0
		public void ShowRings(ref List<string> frames) {} // 0x00000001871277B0-0x00000001871283A0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI.Player
{
	public class HealthBarUi : MonoBehaviour // TypeDefIndex: 15057
	{
		// Fields
		[SerializeField]
		private Image _HealthBar; // 0x20
		[SerializeField]
		private Image _HealthBarFill; // 0x28
		private VampireSurvivors.Objects.Characters.CharacterController _character; // 0x30
	
		// Constructors
		public HealthBarUi() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Awake() {} // 0x00000001869D0210-0x00000001869D02C0
		private void Update() {} // 0x00000001869D02C0-0x00000001869D0470
		public void Initialize(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x0000000180B1D520-0x0000000180B1D580
	}
}

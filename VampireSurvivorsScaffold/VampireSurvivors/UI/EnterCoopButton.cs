/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using I2.Loc;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Framework;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class EnterCoopButton : MonoBehaviour // TypeDefIndex: 14757
	{
		// Fields
		public UnityEngine.UI.Button _button; // 0x20
		private MultiplayerManager _multiplayerManager; // 0x28
		[SerializeField]
		private Localize _titleLocalize; // 0x30
		[SerializeField]
		private GameObject _partymodeHat; // 0x38
	
		// Constructors
		public EnterCoopButton() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		[Inject]
		private void Construct(MultiplayerManager multiplayerManager) {} // 0x0000000180B1D4C0-0x0000000180B1D520
		private void Awake() {} // 0x00000001868813C0-0x00000001868814D0
		public void SetPartyActive() {} // 0x00000001868814D0-0x0000000186881540
		private void EnterCoop() {} // 0x0000000186881540-0x00000001868815A0
		public void ShowButton() {} // 0x00000001868815A0-0x0000000186881600
	}
}

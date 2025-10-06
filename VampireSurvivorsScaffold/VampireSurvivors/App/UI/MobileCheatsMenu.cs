/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.UI
{
	public class MobileCheatsMenu : MonoBehaviour // TypeDefIndex: 18520
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Button _ShowMobileCheatsButton; // 0x20
		private PlayerOptions _playerOptions; // 0x28
		private DataManager _dataManager; // 0x30
	
		// Constructors
		public MobileCheatsMenu() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		[Inject]
		private void Construct(PlayerOptions playerOptions, DataManager dataManager) {} // 0x0000000185268990-0x0000000185268A40
		private void Awake() {} // 0x00000001867BF8B0-0x00000001867BFA60
		public void CheatF2() {} // 0x0000000180B15170-0x0000000180B15180
		public void ForcePreMoongolowSave() {} // 0x0000000180B15170-0x0000000180B15180
		private static void Reload() {} // 0x00000001867BFA60-0x00000001867BFB00
	}
}

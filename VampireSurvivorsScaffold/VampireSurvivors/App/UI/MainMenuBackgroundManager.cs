/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.Data;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.UI
{
	public class MainMenuBackgroundManager : MonoBehaviour // TypeDefIndex: 18517
	{
		// Fields
		[SerializeField]
		private Transform _CustomBackgroundHolder; // 0x20
		private MainMenuBackgroundFactory _mainMenuBackgroundFactory; // 0x28
		private AdventureManager _adventureManager; // 0x30
	
		// Constructors
		public MainMenuBackgroundManager() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		[Inject]
		private void Construct(MainMenuBackgroundFactory mainMenuBackgroundFactory, AdventureManager adventureManager) {} // 0x0000000185268990-0x0000000185268A40
		private void Awake() {} // 0x00000001867BEC70-0x00000001867BECA0
		private void Start() {} // 0x00000001867BECA0-0x00000001867BED60
		public void SetBackgroundForAdventure(AdventureType adventureType) {} // 0x00000001867BED60-0x00000001867BF050
		public void ForceCustomBackground(Transform customBackground) {} // 0x00000001867BF050-0x00000001867BF1B0
		public void ResetBackgroundToMainGame() {} // 0x00000001867BF1B0-0x00000001867BF5D0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class AutomationButtonsMainMenu : MonoBehaviour // TypeDefIndex: 14148
	{
		// Fields
		[SerializeField]
		private MainMenuButtonsDictionary _buttons; // 0x20
		private static AutomationButtonsMainMenu _instance; // 0x00
	
		// Nested types
		public enum MainMenuButtons // TypeDefIndex: 14147
		{
			Start = 0,
			Bestiary = 1,
			CharacterConfirm = 2,
			CharacterStart = 3,
			StageConfirm = 4,
			StageStart = 5
		}
	
		// Constructors
		public AutomationButtonsMainMenu() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Awake() {} // 0x0000000186DA0730-0x0000000186DA07D0
		private void OnDestroy() {} // 0x0000000186DA07D0-0x0000000186DA0970
		public static GameObject GetButtonGameObject(MainMenuButtons button) => default; // 0x0000000186DA0970-0x0000000186DA0AB0
	}
}

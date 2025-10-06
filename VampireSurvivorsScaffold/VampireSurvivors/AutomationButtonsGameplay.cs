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
	public class AutomationButtonsGameplay : MonoBehaviour // TypeDefIndex: 14145
	{
		// Fields
		[SerializeField]
		private GameplayButtonsDictionary _buttons; // 0x20
		private static AutomationButtonsGameplay _instance; // 0x00
	
		// Nested types
		public enum GameplayButtons // TypeDefIndex: 14144
		{
			Options = 0,
			Quit = 1,
			Resume = 2,
			RecapDone = 3
		}
	
		// Constructors
		public AutomationButtonsGameplay() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Awake() {} // 0x0000000186DA0370-0x0000000186DA0410
		private void OnDestroy() {} // 0x0000000186DA0410-0x0000000186DA05B0
		public static GameObject GetButtonGameObject(GameplayButtons button) => default; // 0x0000000186DA05B0-0x0000000186DA06F0
	}
}

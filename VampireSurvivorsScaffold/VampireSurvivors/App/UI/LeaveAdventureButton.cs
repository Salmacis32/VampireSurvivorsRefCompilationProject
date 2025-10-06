/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.UI
{
	[RequireComponent(typeof(UnityEngine.UI.Button))]
	public class LeaveAdventureButton : MonoBehaviour // TypeDefIndex: 18512
	{
		// Fields
		private UnityEngine.UI.Button _button; // 0x20
		private AdventureManager _adventureManager; // 0x28
	
		// Constructors
		public LeaveAdventureButton() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		[Inject]
		private void Construct(AdventureManager adventureManager) {} // 0x0000000180B1D4C0-0x0000000180B1D520
		private void Awake() {} // 0x00000001867BD690-0x00000001867BD7A0
		private void LeaveAdventure() {} // 0x00000001867BD7A0-0x00000001867BD860
	}
}

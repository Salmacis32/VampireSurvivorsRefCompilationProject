/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using VampireSurvivors.Framework;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class AdvancedUIButtonEvents : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 14654
	{
		// Fields
		private MultiplayerManager Multiplayer; // 0x20
		private global::Rewired.Player Player; // 0x28
		private bool _Selected; // 0x30
		private bool _Pressed; // 0x31
		public UnityEvent OnPressed; // 0x38
		public UnityEvent OnUnpressed; // 0x40
	
		// Properties
		public bool isPressed { get => default; } // 0x000000018197EA20-0x000000018197EA30 
	
		// Constructors
		public AdvancedUIButtonEvents() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public void OnPointerDown(PointerEventData eventData) {} // 0x00000001873181B0-0x0000000187318230
		public void OnPointerUp(PointerEventData eventData) {} // 0x0000000187318230-0x00000001873182B0
		public void OnSelect(BaseEventData eventData) {} // 0x00000001873182B0-0x0000000187318320
		public void OnDeselect(BaseEventData eventData) {} // 0x0000000187318320-0x0000000187318390
		[Inject]
		private void Construct(MultiplayerManager _mult) {} // 0x0000000180B1C120-0x0000000180B1C180
		private void Update() {} // 0x0000000187318390-0x0000000187318650
	}
}

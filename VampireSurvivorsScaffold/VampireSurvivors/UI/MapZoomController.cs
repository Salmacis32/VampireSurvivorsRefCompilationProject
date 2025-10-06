/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;
using VampireSurvivors.Framework;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class MapZoomController : MonoBehaviour // TypeDefIndex: 14857
	{
		// Fields
		[SerializeField]
		private float ZoomInterval; // 0x20
		[SerializeField]
		private AdvancedUIButtonEvents _ZoomInButton; // 0x28
		[SerializeField]
		private AdvancedUIButtonEvents _ZoomOutButton; // 0x30
		[SerializeField]
		private MapManager _mapManager; // 0x38
		private global::Rewired.Player _player; // 0x40
		private MultiplayerManager _multiplayer; // 0x48
		private bool _ZoomingIn; // 0x50
		private bool _isZooming; // 0x51
		private float _timeToNextZoom; // 0x54
	
		// Constructors
		public MapZoomController() {} // 0x00000001868E48B0-0x00000001868E4900
	
		// Methods
		private void Awake() {} // 0x00000001868E3F60-0x00000001868E41B0
		private void OnDestroy() {} // 0x00000001868E41B0-0x00000001868E4430
		[Inject]
		private void Construct(MultiplayerManager _mult) {} // 0x000000018268E650-0x000000018268E6B0
		private void Update() {} // 0x00000001868E4430-0x00000001868E4800
		private void ZoomInPressed() {} // 0x00000001868E4800-0x00000001868E4850
		private void ZoomInUnpressed() {} // 0x00000001868E4850-0x00000001868E4860
		private void ZoomOutPressed() {} // 0x00000001868E4860-0x00000001868E48B0
		private void ZoomOutUnpressed() {} // 0x00000001868E4850-0x00000001868E4860
	}
}

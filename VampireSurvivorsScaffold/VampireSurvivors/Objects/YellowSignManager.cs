/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Achievements;
using VampireSurvivors.UI;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public class YellowSignManager : GameMonoBehaviour // TypeDefIndex: 15181
	{
		// Fields
		[SerializeField]
		private Canvas _Canvas; // 0x28
		[SerializeField]
		private GameObject _Clapper; // 0x30
		[SerializeField]
		private RectTransform _ZoomTarget; // 0x38
		[SerializeField]
		private UISpriteAnimation _InAnimation; // 0x40
		[SerializeField]
		private UISpriteAnimation _OutAnimation; // 0x48
		[SerializeField]
		private Image _Blackout; // 0x50
		[SerializeField]
		private RectTransform _Panel; // 0x58
		[SerializeField]
		private List<Vector3> _PanelPositions; // 0x60
		[SerializeField]
		private List<Vector3> _PanelScales; // 0x68
		private int _zoomIndex; // 0x70
		private SignalBus _signalBus; // 0x78
		private PlayerOptions _playerOptions; // 0x80
		private AchievementManager _achievementManager; // 0x88
		private float _orthoCameraSize; // 0x90
		private float _orthoCameraIteration; // 0x94
		private float _orthoCameraZoomTarget; // 0x98
		private Vector3 _cameraPos; // 0x9C
		private Vector3 _screenPos; // 0xA8
	
		// Constructors
		public YellowSignManager() {} // 0x0000000186A7E7C0-0x0000000186A7E940
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus, PlayerOptions playerOptions, AchievementManager achievementManager) {} // 0x0000000186A7CA90-0x0000000186A7CBB0
		protected override void OnEnable() {} // 0x0000000186A7CBB0-0x0000000186A7CC90
		public void DoClaps(Action onComplete = null) {} // 0x0000000186A7CC90-0x0000000186A7D0C0
		private Tween Clap(float clapDelay) => default; // 0x0000000186A7D0C0-0x0000000186A7D250
		private void PlayClapSound() {} // 0x0000000186A7D250-0x0000000186A7D2D0
		private void Zoom() {} // 0x0000000186A7D2D0-0x0000000186A7E1B0
		private Vector3 GetCameraPosition(float delta) => default; // 0x0000000186A7E1B0-0x0000000186A7E290
		private void UnlockWeapons() {} // 0x0000000186A7E290-0x0000000186A7E7C0
	}
}

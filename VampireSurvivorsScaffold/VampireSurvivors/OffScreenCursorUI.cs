/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using VampireSurvivors.Signals;
using VampireSurvivors.UI;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class OffScreenCursorUI : MonoBehaviour // TypeDefIndex: 14214
	{
		// Fields
		[FormerlySerializedAs("_cursorPrefab")]
		[SerializeField]
		private GameObject _CursorPrefab; // 0x20
		[FormerlySerializedAs("_canvasRect")]
		[SerializeField]
		private RectTransform _CanvasRect; // 0x28
		[SerializeField]
		private float _ScreenBoundsOffset; // 0x30
		private readonly Dictionary<GameObject, OffScreenCursor> _spawnedCursors; // 0x38
		private SignalBus _signalBus; // 0x40
		private GameManager _gameManager; // 0x48
		private DataManager _data; // 0x50
		private PlayerOptions _playerOptions; // 0x58
		private Camera _cam; // 0x60
		private Vector3 _screenCenter; // 0x68
		private Vector3 _screenBounds; // 0x74
	
		// Constructors
		public OffScreenCursorUI() {} // 0x0000000186EEF940-0x0000000186EEFA40
	
		// Methods
		[Inject]
		private void Construct(SignalBus signal, GameManager gameManager, DataManager data, PlayerOptions player) {} // 0x00000001869699E0-0x0000000186969B30
		private void Start() {} // 0x0000000186EEEB50-0x0000000186EEED50
		private void OnDestroy() {} // 0x0000000180B15170-0x0000000180B15180
		public static void GetArrowIndicatorPositionAndAngle(ref Vector3 screenPosition, ref float angle, Vector3 screenCentre, Vector3 screenBounds) {} // 0x0000000186EEED50-0x0000000186EEEEC0
		[IteratorStateMachine(typeof(_DoLateUpdate_d__15))]
		private IEnumerator DoLateUpdate() => default; // 0x0000000186EEEEC0-0x0000000186EEEF60
		private bool CheckIfInScreenBounds(Vector2 pos) => default; // 0x0000000186EEEF60-0x0000000186EEF070
		private void SpawnCursor(UISignals.SpawnOffScreenCursorSignal sig) {} // 0x0000000186EEF070-0x0000000186EEF2F0
		private void RemoveCursor(UISignals.RemoveOffScreenCursorSignal sig) {} // 0x0000000186EEF2F0-0x0000000186EEF450
		private void PositionNearScreenEdge(OffScreenCursor offScreenCursor, Vector3 screenPos) {} // 0x0000000186EEF450-0x0000000186EEF6E0
		private void PointAtTarget(OffScreenCursor offScreenCursor, Vector3 screenPos) {} // 0x0000000186EEF6E0-0x0000000186EEF940
	}
}

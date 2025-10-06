/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using QFSW.MOP2;
using UnityEngine;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Cursors
{
	public class CursorsManager : MonoBehaviour // TypeDefIndex: 18370
	{
		// Fields
		[SerializeField]
		private GameObject _CursorIndicatorPrefab; // 0x20
		private SignalBus _signalBus; // 0x28
		private ObjectPool _cursorsPool; // 0x30
		private bool _cursorsHidden; // 0x38
		private readonly Dictionary<GameObject, CursorIndicator> _cursorIndicators; // 0x40
	
		// Constructors
		public CursorsManager() {} // 0x0000000186741890-0x0000000186741990
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus) {} // 0x0000000180B1D4C0-0x0000000180B1D520
		public void Awake() {} // 0x000000018673D640-0x000000018673E1D0
		protected void OnDestroy() {} // 0x000000018673E1D0-0x000000018673E8E0
		protected void LateUpdate() {} // 0x000000018673E8E0-0x000000018673F770
		private void SpawnCursor(UISignals.SpawnOffScreenCursorSignal signal) {} // 0x000000018673F770-0x000000018673FB90
		private void RemoveCursor(UISignals.RemoveOffScreenCursorSignal signal) {} // 0x000000018673FB90-0x000000018673FCF0
		private void HideCursor(UISignals.HideCursorSignal signal) {} // 0x000000018673FCF0-0x000000018673FE20
		private void ShowCursor(UISignals.ShowCursorSignal signal) {} // 0x000000018673FE20-0x000000018673FF50
		private void HideAllCursors(UISignals.HideAllCursorsSignal signal) {} // 0x000000018673FF50-0x00000001867402C0
		private void UnHideCursors(UISignals.UnhideCursorsSignal signal) {} // 0x00000001867402C0-0x00000001867406A0
		private CursorIndicator SpawnCursorIndicator() => default; // 0x00000001867406A0-0x00000001867406F0
		private void PositionNearScreenEdge(CursorIndicator cursorIndicator, Vector3 targetPos) {} // 0x00000001867406F0-0x00000001867409B0
		private void PointAtTarget(CursorIndicator cursorIndicator, Vector3 targetPos) {} // 0x00000001867409B0-0x0000000186740C30
		private void GenerateCursorsPool() {} // 0x0000000186740C30-0x0000000186740D90
		private static bool IsTargetVisible(Vector3 screenPosition) => default; // 0x0000000186740D90-0x00000001867410B0
		private static void GetArrowIndicatorPositionAndAngle(ref Vector3 screenPosition, ref float angle, float proportionOfScreenFromCenter = 0.45f /* Metadata: 0x0197899E */) {} // 0x00000001867410B0-0x0000000186741390
		private static Vector2 GetPPURoundedPosition(Vector2 position) => default; // 0x0000000186741390-0x0000000186741400
		private void RefreshCursors() {} // 0x0000000186741400-0x0000000186741890
	}
}

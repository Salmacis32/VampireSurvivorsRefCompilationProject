/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Dreamteck.Splines;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class TreasureRibbonTrailGenerator : MonoBehaviour // TypeDefIndex: 14250
	{
		// Fields
		[SerializeField]
		private float _Scale; // 0x20
		[SerializeField]
		private List<Vector2> _Points; // 0x28
		[SerializeField]
		private GameObject _TrailPrefab; // 0x30
		[SerializeField]
		private List<Vector2> _Ribbon3Points; // 0x38
		[SerializeField]
		private GameObject _RibbonTrailPrefab; // 0x40
		[SerializeField]
		private RectTransform _Reels3StartPosition; // 0x48
		[SerializeField]
		private RectTransform ReelsIconsContainer; // 0x50
		private List<SplineComputer> _spawnedCurves; // 0x58
		private List<GameObject> _trails; // 0x60
		private List<SplineComputer> _spawnedReelCurves; // 0x68
		private List<GameObject> _reelTrails; // 0x70
		private List<GameObject> _reelTrails3; // 0x78
	
		// Constructors
		public TreasureRibbonTrailGenerator() {} // 0x0000000186F0EA40-0x0000000186F0EE40
	
		// Methods
		private void Awake() {} // 0x0000000186F0C010-0x0000000186F0C020
		private float GetCameraRTScale() => default; // 0x0000000186F0C020-0x0000000186F0C120
		public void MakeRibbons() {} // 0x0000000186F0C120-0x0000000186F0C6D0
		public void MakeRibbons3() {} // 0x0000000186F0C6D0-0x0000000186F0CE60
		private void GenerateReelCurves() {} // 0x0000000186F0CE60-0x0000000186F0D230
		public void ClearExisting() {} // 0x0000000186F0D230-0x0000000186F0D570
		public void Play(float duration, float delay, int playCount, int howMany) {} // 0x0000000186F0D570-0x0000000186F0DB40
		public void PlayReelTrails(float duration, float delay, int playCount) {} // 0x0000000186F0DB40-0x0000000186F0E610
		private void SetTexture() {} // 0x0000000186F0E610-0x0000000186F0E670
		private void OnDisable() {} // 0x0000000186F0E670-0x0000000186F0E680
		public Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angles) => default; // 0x0000000186F0E680-0x0000000186F0E960
		public Vector2 RotateVectorByDegrees(Vector2 vec2, float degrees) => default; // 0x0000000186F0E960-0x0000000186F0EA40
	}
}

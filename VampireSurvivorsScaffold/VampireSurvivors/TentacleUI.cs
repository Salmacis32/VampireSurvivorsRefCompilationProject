/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class TentacleUI : MonoBehaviour // TypeDefIndex: 14236
	{
		// Fields
		public float maxAngle; // 0x20
		public float speed; // 0x24
		public GameObject TentaclePrefab; // 0x28
		public RectTransform Anchor; // 0x30
		public int Tentaclindex; // 0x38
		public RectTransform Ring; // 0x40
		public List<GameObject> Decorations; // 0x48
		private float _currentTime; // 0x50
		private GameObject _tentaclette; // 0x58
		private Vector3 _startRotation; // 0x60
		private bool isRoot; // 0x6C
		private int depth; // 0x70
		private List<Tween> _tweens; // 0x78
	
		// Constructors
		public TentacleUI() {} // 0x0000000186F045B0-0x0000000186F04760
	
		// Methods
		private void Awake() {} // 0x0000000186F03710-0x0000000186F03790
		private void OnDestroy() {} // 0x0000000186F03790-0x0000000186F03930
		private void Start() {} // 0x0000000186F03930-0x0000000186F03B10
		private void Toggle(ArcanaMainSelectionPage.ArcanaMode mode) {} // 0x0000000186F03B10-0x0000000186F03C10
		private void Hide() {} // 0x0000000186F03C10-0x0000000186F03C90
		public void InstantHide() {} // 0x0000000186F03C90-0x0000000186F03D80
		private void Show() {} // 0x0000000186F03D80-0x0000000186F03E00
		public void Initialize() {} // 0x0000000186F03E00-0x0000000186F03F00
		private void Update() {} // 0x0000000186F03F00-0x0000000186F040D0
		public TentacleUI AddSegment() => default; // 0x0000000186F040D0-0x0000000186F04540
		public void SetStats(float _speed, float _maxAngle, int _depth) {} // 0x0000000186F04540-0x0000000186F045B0
	}
}

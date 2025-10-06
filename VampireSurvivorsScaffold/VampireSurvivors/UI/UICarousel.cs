/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class UICarousel : MonoBehaviour // TypeDefIndex: 15040
	{
		// Fields
		[SerializeField]
		private RectTransform _TopSlot; // 0x20
		[SerializeField]
		private RectTransform _BottomSlot; // 0x28
		[SerializeField]
		private RectTransform _Disabled; // 0x30
		[SerializeField]
		private RectTransform _Container; // 0x38
		[SerializeField]
		private float _Padding; // 0x40
		[SerializeField]
		private float _MaxDistance; // 0x44
		[SerializeField]
		private float _ItemsToShow; // 0x48
		[SerializeField]
		private CarouselAxis _Axis; // 0x4C
		private RectTransform _rTrans; // 0x58
		private float _size; // 0x60
		private float _itemCount; // 0x64
		private float _spacing; // 0x68
		private int _halfSize; // 0x6C
		private int _midIndex; // 0x70
		private float _itemHeight; // 0x74
		private float _itemWidth; // 0x78
		private List<GameObject> _cachedItems; // 0x80
		private List<Transform> _slots; // 0x88
		private List<GameObject> _spawnedItems; // 0x90
		private int _currentIndex; // 0x98
	
		// Events
		public event OnSelectionChanged SelectionChanged;
	
		// Nested types
		public enum CarouselAxis // TypeDefIndex: 15036
		{
			X = 0,
			Y = 1
		}
	
		public delegate void OnSelectionChanged(int index); // TypeDefIndex: 15037; 0x000000018196C5F0-0x000000018196C600
	
		// Constructors
		public UICarousel() {} // 0x00000001869C9EF0-0x00000001869CA100
	
		// Methods
		public void Initialize(List<GameObject> carouselItems, int selectedIndex = 0 /* Metadata: 0x0197727F */) {} // 0x00000001869C5E30-0x00000001869C6420
		public void Clear() {} // 0x00000001869C6420-0x00000001869C6A60
		public void MoveNext() {} // 0x00000001869C6A60-0x00000001869C7320
		public GameObject GetSelectedItem() => default; // 0x00000001869C7320-0x00000001869C7390
		public void MovePrevious() {} // 0x00000001869C7390-0x00000001869C7D00
		private void CreateItems() {} // 0x00000001869C7D00-0x00000001869C7FB0
		private GameObject CreateInitialItem(int spawnIndex, int slotIndex) => default; // 0x00000001869C7FB0-0x00000001869C8130
		private GameObject SpawnNewItem(int spawnIndex, int slotIndex) => default; // 0x00000001869C8130-0x00000001869C82C0
		private void CreateSlots2() {} // 0x00000001869C82C0-0x00000001869C8A20
		private void ApplyScales() {} // 0x00000001869C8A20-0x00000001869C8D50
		private void ApplyPositions() {} // 0x00000001869C8D50-0x00000001869C9100
		private void AdjustMask() {} // 0x00000001869C9100-0x00000001869C9B60
		private GameObject CreateSlot2() => default; // 0x00000001869C9B60-0x00000001869C9D30
		private GameObject GetNextItem() => default; // 0x00000001869C9D30-0x00000001869C9DE0
		private GameObject GetPreviousItem() => default; // 0x00000001869C9DE0-0x00000001869C9E80
		private GameObject GetCurrentItem() => default; // 0x00000001869C9E80-0x00000001869C9EF0
	}
}

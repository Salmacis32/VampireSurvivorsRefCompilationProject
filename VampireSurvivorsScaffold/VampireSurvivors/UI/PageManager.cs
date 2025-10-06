/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class PageManager : MonoBehaviour // TypeDefIndex: 14909
	{
		// Fields
		[SerializeField]
		private List<GameObject> _Pages; // 0x20
		[SerializeField]
		private TextMeshProUGUI _PageCount; // 0x28
		[SerializeField]
		private UnityEngine.UI.Button _LeftArrow; // 0x30
		[SerializeField]
		private UnityEngine.UI.Button _RightArrow; // 0x38
		private int pageIndex; // 0x40
		protected global::Rewired.Player Player; // 0x48
	
		// Constructors
		public PageManager() {} // 0x0000000186928FB0-0x00000001869290B0
	
		// Methods
		private void Awake() {} // 0x0000000186927E80-0x0000000186928000
		private void OnEnable() {} // 0x0000000186928000-0x0000000186928380
		public void NextPage() {} // 0x0000000186928380-0x0000000186928600
		public void ClearAllPages() {} // 0x0000000186928600-0x00000001869287F0
		public void PreviousPage() {} // 0x00000001869287F0-0x0000000186928A60
		public void RemovePage(GameObject g) {} // 0x0000000186928A60-0x0000000186928C60
		public void AddPage(GameObject g) {} // 0x0000000186928C60-0x0000000186928EE0
		public int GetPageCount() => default; // 0x0000000186928EE0-0x0000000186928F30
		public void SetDownNavigation(Selectable s) {} // 0x0000000186928F30-0x0000000186928F70
		public void SetUpNavigation(Selectable s) {} // 0x0000000186928F70-0x0000000186928FB0
		public Selectable GetSelectable() => default; // 0x0000000180B15560-0x0000000180B15570
	}
}

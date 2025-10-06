/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Cloud;
using TMPro;
using UnityEngine;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class OnlineDLCSection : MonoBehaviour // TypeDefIndex: 14880
	{
		// Fields
		[SerializeField]
		private List<OnlineDLCIcon> _OnlineDLCIcons; // 0x20
		[SerializeField]
		private GameObject _DLCIconContainer; // 0x28
		[SerializeField]
		private OnlineDLCIcon _DLCIconPrefab; // 0x30
		[SerializeField]
		private GameObject _DLCInfoContainer; // 0x38
		[SerializeField]
		private TextMeshProUGUI _DLCInfoTitle; // 0x40
		[SerializeField]
		private TextMeshProUGUI _DLCInfoMessage; // 0x48
		private bool _isPopulated; // 0x50
		private Dictionary<LobbyPlayer, List<DlcType>> _PlayerOwnedDLCs; // 0x58
		private List<DlcType> _AvailableDLCs; // 0x60
	
		// Constructors
		public OnlineDLCSection() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void OnEnable() {} // 0x00000001868F7300-0x00000001868F7310
		private void Populate() {} // 0x00000001868F7310-0x00000001868F76A0
		public void UpdateUI(List<DlcType> availableDLCs, Dictionary<LobbyPlayer, List<DlcType>> playerOwnedDLCs) {} // 0x00000001868F76A0-0x00000001868F79C0
		public void ToggleInfoPanel(DlcType dlcType) {} // 0x00000001868F79C0-0x00000001868F80E0
		public void HideInfoPanel() {} // 0x00000001868F71B0-0x00000001868F71E0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class SealPanel : MonoBehaviour // TypeDefIndex: 14956
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _Title; // 0x20
		[SerializeField]
		private TextMeshProUGUI _Amount; // 0x28
		[SerializeField]
		private CanvasGroup _Warning; // 0x30
		[SerializeField]
		private UnityEngine.UI.Button _PortraitMegaSealButton; // 0x38
		private PlayerOptions _playerOptions; // 0x40
		private Tween _warningTween; // 0x48
	
		// Constructors
		public SealPanel() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public void Initialize(PlayerOptions player) {} // 0x00000001869502A0-0x0000000186950350
		public void ShowWarning() {} // 0x0000000186950350-0x0000000186950650
		public void UpdateValues() {} // 0x0000000186950650-0x0000000186950710
		private void SetNormalLayout() {} // 0x0000000186950710-0x0000000186950A30
		private void SetPortraitMegaSealLayout() {} // 0x0000000186950A30-0x0000000186950D30
		private bool ShowPortraitMegaFormat() => default; // 0x0000000186950D30-0x0000000186950DA0
	}
}

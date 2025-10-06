/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.UI
{
	public class FastForwardButton : MonoBehaviour // TypeDefIndex: 18510
	{
		// Fields
		[SerializeField]
		private GameObject _icon1; // 0x20
		[SerializeField]
		private GameObject _icon2; // 0x28
		[SerializeField]
		private GameObject _icon3; // 0x30
		private float _tempTimeScale; // 0x38
		private const float PaddingBelowTopMaskBar = 20f; // Metadata: 0x0197A9FE
		private const float PaddingBelowKillCount = 80f; // Metadata: 0x0197AA02
	
		// Constructors
		public FastForwardButton() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Start() {} // 0x00000001867BCDD0-0x00000001867BCF90
		private void OnEnable() {} // 0x00000001867BCF90-0x00000001867BCFA0
		private void Update() {} // 0x00000001867BCFA0-0x00000001867BD180
		private void CheckTimescale() {} // 0x00000001867BD180-0x00000001867BD250
		private void FastForward() {} // 0x00000001867BD250-0x00000001867BD2B0
		private void RepositionFastForwardButton() {} // 0x00000001867BD2B0-0x00000001867BD3F0
		private static bool IsKillsCountAboveTopAspectBarBottom(RectTransform topMask, RectTransform killCount) => default; // 0x00000001867BD3F0-0x00000001867BD4F0
		private static float GetBottomY(RectTransform rectTransform) => default; // 0x00000001867BD4F0-0x00000001867BD570
	}
}

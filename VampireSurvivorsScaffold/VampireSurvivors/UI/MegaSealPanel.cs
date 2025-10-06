/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class MegaSealPanel : MonoBehaviour // TypeDefIndex: 14859
	{
		// Fields
		[SerializeField]
		private GameObject _DLCSealPrefab; // 0x20
		private PlayerOptions _playerOptions; // 0x28
		private CollectionsPage _page; // 0x30
		private List<DLCSealItem> _dlcSealItems; // 0x38
	
		// Properties
		public bool IsAvailable { get => default; } // 0x00000001868E4900-0x00000001868E49B0 
	
		// Constructors
		public MegaSealPanel() {} // 0x00000001868E5BB0-0x00000001868E5CB0
	
		// Methods
		[Inject]
		private void Construct(PlayerOptions player) {} // 0x0000000180B1D4C0-0x0000000180B1D520
		private void Start() {} // 0x00000001868E49B0-0x00000001868E4E90
		public void TryShow() {} // 0x00000001868E4E90-0x00000001868E5060
		public void Initialize(CollectionsPage page) {} // 0x0000000180B1D520-0x0000000180B1D580
		private void SpawnDLC(ContentGroupType group) {} // 0x00000001868E5060-0x00000001868E5320
		public void SetBanished(ContentGroupType t, bool isBanished, bool playSound, bool updatePage = true /* Metadata: 0x01977235 */) {} // 0x00000001868E5320-0x00000001868E5670
		public void UnsealAll(bool playSound = true /* Metadata: 0x01977236 */) {} // 0x00000001868E5670-0x00000001868E5B40
		private bool IsBanished(ContentGroupType group) => default; // 0x00000001868E5B40-0x00000001868E5BB0
	}
}

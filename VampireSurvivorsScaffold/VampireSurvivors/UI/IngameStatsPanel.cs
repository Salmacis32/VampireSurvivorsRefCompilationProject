/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class IngameStatsPanel : MonoBehaviour // TypeDefIndex: 14810
	{
		// Fields
		[SerializeField]
		private List<StatItemUI> _StatObjects; // 0x20
		private SignalBus _signalBus; // 0x28
		private GameSessionData _session; // 0x30
		private DataManager _dataManager; // 0x38
		private bool _hasInitialized; // 0x40
		private List<TextMeshProUGUI> _statTextLines; // 0x48
	
		// Constructors
		public IngameStatsPanel() {} // 0x00000001868B2320-0x00000001868B24B0
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus, GameSessionData session, DataManager data) {} // 0x00000001868B1970-0x00000001868B1A80
		public void OnEnable() {} // 0x00000001868B1A80-0x00000001868B2320
	}
}

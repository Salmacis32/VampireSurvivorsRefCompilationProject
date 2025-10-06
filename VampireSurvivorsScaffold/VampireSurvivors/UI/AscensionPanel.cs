/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class AscensionPanel : MonoBehaviour // TypeDefIndex: 14689
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _CompletionText; // 0x20
		[SerializeField]
		private TextMeshProUGUI _PortraitCompletionText; // 0x28
		[SerializeField]
		private AdjustValuePanel _LuckPanel; // 0x30
		[SerializeField]
		private AdjustValuePanel _GrowthPanel; // 0x38
		[SerializeField]
		private AdjustValuePanel _GreedPanel; // 0x40
		[SerializeField]
		private AdjustValuePanel _CursePanel; // 0x48
		[SerializeField]
		private List<AdjustValuePanel> _NavigationPanels; // 0x50
		[SerializeField]
		private UnityEngine.UI.Button _AscendAdventureButton; // 0x58
		[SerializeField]
		private UISpriteAnimation _Sheen; // 0x60
		private PlayerOptions _playerOptions; // 0x68
		private AdventureManager _adventureManager; // 0x70
		private int _completionCount; // 0x78
		private int _currentSpend; // 0x7C
		private bool _shouldGenerateNavigation; // 0x80
		private PlayerOptionsData _adventurePod; // 0x88
		private Selectable _selectableToReturnTo; // 0x90
		private AdventureType _adventureType; // 0x98
		private Transform _ascendSender; // 0xA0
	
		// Constructors
		public AscensionPanel() {} // 0x00000001865FC2C0-0x00000001865FC470
	
		// Methods
		[Inject]
		private void Construct(PlayerOptions player, AdventureManager adventureManager) {} // 0x00000001865FA5D0-0x00000001865FA680
		private void Awake() {} // 0x00000001865FA680-0x00000001865FA7D0
		private void OnDestroy() {} // 0x00000001865FA7D0-0x00000001865FA920
		private void LateUpdate() {} // 0x00000001865FA920-0x00000001865FA950
		private void OnEnable() {} // 0x00000001865FA950-0x00000001865FAA70
		private void OnAdventureAscended(bool obj) {} // 0x00000001865FAA70-0x00000001865FAAA0
		private void OnDisable() {} // 0x00000001865FAAA0-0x00000001865FABC0
		public void SetData(PlayerOptionsData adventurePod, AdventureType adventureType) {} // 0x00000001865FABC0-0x00000001865FAC30
		public void RefreshData() {} // 0x00000001865FAC30-0x00000001865FB2C0
		public void SetRegenerateNavigation() {} // 0x00000001865FB2C0-0x00000001865FB2D0
		public void SetSelected(Selectable selectedItem) {} // 0x00000001865FB2D0-0x00000001865FB340
		public Selectable GetFirstSelectable() => default; // 0x00000001865FB340-0x00000001865FB460
		public Selectable GetLastSelectable() => default; // 0x00000001865FB460-0x00000001865FB570
		public void GenerateNavigation() {} // 0x00000001865FB570-0x00000001865FB8D0
		public void Apply() {} // 0x00000001865FB8D0-0x00000001865FBD30
		private void ValueChanged(AdjustValuePanel panel, bool positive) {} // 0x00000001865FBD30-0x00000001865FBE00
		private void SetInteractionsFromSpend() {} // 0x00000001865FBE00-0x00000001865FBFD0
		private void SetPanelsInteractionUp(bool enabled) {} // 0x00000001865FBFD0-0x00000001865FC2C0
	}
}

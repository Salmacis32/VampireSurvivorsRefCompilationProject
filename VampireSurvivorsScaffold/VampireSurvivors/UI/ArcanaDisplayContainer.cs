/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects.Characters;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class ArcanaDisplayContainer : MonoBehaviour, IArcanaDisplayContainer // TypeDefIndex: 14664
	{
		// Fields
		[SerializeField]
		private ArcanaCardUI _ArcanaCardPrefab; // 0x20
		[SerializeField]
		private RectTransform _ArcanaCardContainer; // 0x28
		[SerializeField]
		private ArcanaInfoPanel _ArcanaInfoPanel; // 0x30
		[SerializeField]
		private float _ArcanaInfoScaleInDuration; // 0x38
		[SerializeField]
		private float _ArcanaPortraitInfoPanelOffset; // 0x3C
		private DataManager _dataManager; // 0x40
		private GameManager _gameManager; // 0x48
		private List<ArcanaCardUI> _spawnedCards; // 0x50
		private List<Tween> _spawnedCardTimers; // 0x58
		private ArcanaType _currentShowingArcana; // 0x60
		private bool _ignoreNextArcanaClick; // 0x64
	
		// Properties
		public Selectable FirstCardSelectable { get => default; } // 0x00000001865DC5F0-0x00000001865DC6A0 
	
		// Constructors
		public ArcanaDisplayContainer() {} // 0x00000001865DF1E0-0x00000001865DF390
	
		// Methods
		[Inject]
		private void Construct(DataManager dataManager, GameManager game) {} // 0x00000001865DC6A0-0x00000001865DC750
		private void Start() {} // 0x00000001865DC750-0x00000001865DC7A0
		public void SetArcanaInfoPanelControllingPlayer(VampireSurvivors.Objects.Characters.CharacterController characterController) {} // 0x00000001865DC7A0-0x00000001865DC810
		public void SetArcanaDetails() {} // 0x00000001865DC810-0x00000001865DE360
		private void OnEnable() {} // 0x00000001865DE360-0x00000001865DE460
		private void CardOnBecameSelected(SelectableUI arcanaCardUI, ArcanaData arcanaData, ArcanaType arcanaType, Transform cardTransform) {} // 0x00000001865DE460-0x00000001865DE710
		private void CardOnBecameDeselected(ArcanaType arcanaType) {} // 0x00000001865DE710-0x00000001865DE750
		public void ToggleArcanaInfoPanel(SelectableUI arcanaCardUI, ArcanaData arcanaData, ArcanaType arcanaType, Transform cardTransform, bool toggleFromClick, bool toggleFromSelectionChange) {} // 0x00000001865DE750-0x00000001865DE8B0
		public void ShowArcanaInfoPanel(ArcanaData arcanaData, ArcanaType arcanaType, Transform cardTransform) {} // 0x00000001865DE8B0-0x00000001865DED00
		public void HideArcanaInfoPanel() {} // 0x00000001865DE710-0x00000001865DE750
		public void ConfigureNavigationForArcanaCards(Selectable down = null, Selectable left = null, Selectable right = null, Selectable up = null) {} // 0x00000001865DED00-0x00000001865DF1E0
	}
}

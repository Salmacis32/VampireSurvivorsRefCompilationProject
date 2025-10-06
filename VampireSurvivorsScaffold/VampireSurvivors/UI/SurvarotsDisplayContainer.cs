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
	public class SurvarotsDisplayContainer : MonoBehaviour, IArcanaDisplayContainer // TypeDefIndex: 14994
	{
		// Fields
		[SerializeField]
		private ArcanaCardUI _ArcanaCardPrefab; // 0x20
		[SerializeField]
		private RectTransform _ArcanaCardContainer; // 0x28
		[SerializeField]
		private CardInfoUI _cardInfoPanel; // 0x30
		[SerializeField]
		private float _ArcanaInfoScaleInDuration; // 0x38
		[SerializeField]
		private float _ArcanaPortraitInfoPanelOffset; // 0x3C
		private DataManager _dataManager; // 0x40
		private GameManager _gameManager; // 0x48
		private List<ArcanaCardUI> _spawnedCards; // 0x50
		private List<Tween> _spawnedCardTimers; // 0x58
		private CharacterSkillCard_Base _currentShowingCard; // 0x60
		private bool _ignoreNextArcanaClick; // 0x68
	
		// Properties
		public Selectable FirstCardSelectable { get => default; } // 0x000000018699B610-0x000000018699B6C0 
	
		// Constructors
		public SurvarotsDisplayContainer() {} // 0x000000018699E1D0-0x000000018699E380
	
		// Methods
		[Inject]
		private void Construct(DataManager dataManager, GameManager game) {} // 0x00000001865DC6A0-0x00000001865DC750
		private void Start() {} // 0x000000018699B6C0-0x000000018699B6F0
		public void SetCardDetails() {} // 0x000000018699B6F0-0x000000018699D370
		private void CardOnBecameSelected(SelectableUI arcanaCardUI, ArcanaData arcanaData, ArcanaType arcanaType, Transform cardTransform) {} // 0x000000018699D370-0x000000018699D660
		private void CardOnBecameDeselected(ArcanaType arcanaType) {} // 0x000000018699D660-0x000000018699D670
		public void ToggleArcanaInfoPanel(SelectableUI arcanaCardUI, ArcanaData arcanaData, ArcanaType arcanaType, Transform cardTransform, bool toggleFromClick, bool toggleFromSelectionChange) {} // 0x000000018699D670-0x000000018699D810
		public void ShowArcanaInfoPanel(CharacterSkillCard_Base card, Transform cardTransform, ArcanaData arcanaData) {} // 0x000000018699D810-0x000000018699DC60
		public void HideArcanaInfoPanel() {} // 0x000000018699DC60-0x000000018699DCF0
		public void ConfigureNavigationForCharacterCards(Selectable down = null, Selectable left = null, Selectable right = null, Selectable up = null) {} // 0x000000018699DCF0-0x000000018699E1D0
	}
}

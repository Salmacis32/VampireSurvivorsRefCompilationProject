/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coffee.UIEffects;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class ArcanaCardUI : SelectableUI // TypeDefIndex: 14661
	{
		// Fields
		public bool _IsOpen; // 0xA0
		public Action<SelectableUI, ArcanaData, ArcanaType, Transform> OnArcanaCardSelected; // 0xA8
		public Action<ArcanaType> OnArcanaCardDeselected; // 0xB0
		[SerializeField]
		private bool DEBUGTHIS; // 0xB8
		[SerializeField]
		private GameObject _Selected; // 0xC0
		[SerializeField]
		private Image _Icon; // 0xC8
		[SerializeField]
		private Image _Transitioner; // 0xD0
		[SerializeField]
		private Image _rarityIcon; // 0xD8
		[SerializeField]
		private Image _editionIcon; // 0xE0
		[SerializeField]
		private Material _foilMat; // 0xE8
		[SerializeField]
		private Material _holoMat; // 0xF0
		[SerializeField]
		private Material _polyMat; // 0xF8
		[SerializeField]
		private Material _inveMat; // 0x100
		[SerializeField]
		private Material _galaMat; // 0x108
		private ArcanaData _data; // 0x118
		private ArcanaType _type; // 0x120
		private ISetArcanaInfo _selectionPage; // 0x128
		private IArcanaDisplayContainer _displayContainer; // 0x130
		private float _halfTime; // 0x138
		private bool _isFlipping; // 0x13C
		private Vector3 _scale; // 0x140
		private Tween _flipTween; // 0x150
		private Tween _backTween; // 0x158
		private int _spinTimes; // 0x160
		private Selectable _cachedSelectable; // 0x168
		private Sprite _back; // 0x170
		private bool _interactable; // 0x178
		private Tween _tween; // 0x180
		private string _overrideBackFrameName; // 0x188
		private bool _ignoreDarkana; // 0x190
	
		// Properties
		public Selectable Selectable { get => default; } // 0x00000001829176E0-0x00000001829176F0 
		public CharacterSkillCard_Base CharacterCard { get; private set; } // 0x0000000182A45AF0-0x0000000182A45B00 0x0000000184BB6350-0x0000000184BB63B0
		private bool ShowEditionIcon { get => default; } // 0x000000018731F780-0x000000018731F7A0 
		private bool ShowRarityIcon { get => default; } // 0x000000018731F7A0-0x000000018731F7B0 
	
		// Constructors
		public ArcanaCardUI() {} // 0x0000000187321E30-0x0000000187321EE0
	
		// Methods
		protected override void Awake() {} // 0x000000018731F7B0-0x000000018731F8B0
		protected override void OnDestroy() {} // 0x000000018731F8B0-0x000000018731F940
		protected override void OnDisable() {} // 0x000000018731F940-0x000000018731F9E0
		protected override void OnSelected() {} // 0x000000018731F9E0-0x000000018731FA50
		protected override void OnDeselected() {} // 0x000000018731FA50-0x000000018731FA70
		public void SetData(ArcanaData data, ArcanaType type, ArcanaMainSelectionPage page) {} // 0x000000018731FA70-0x000000018731FC60
		public void SetData(ArcanaData data, ArcanaType type, ISetArcanaInfo page, bool isShowing) {} // 0x000000018731FC60-0x000000018731FE40
		public void SetArcanaDisplayContainer(IArcanaDisplayContainer container) {} // 0x0000000182A45BA0-0x0000000182A45C00
		private void ModeChanged(ArcanaMainSelectionPage.ArcanaMode m) {} // 0x000000018731FE40-0x0000000187320660
		public void SetOwned() {} // 0x0000000187320660-0x0000000187320730
		public void SetData(ArcanaData data, ArcanaType t, bool isOpen = false /* Metadata: 0x019771C2 */, bool isInteractable = false /* Metadata: 0x019771C3 */) {} // 0x0000000187320730-0x0000000187320900
		public void SetDarkBack() {} // 0x0000000187320900-0x00000001873209F0
		public void SetBackOnly() {} // 0x00000001873209F0-0x0000000187320BE0
		public void SetGreyBackOnly() {} // 0x0000000187320BE0-0x0000000187320CB0
		public void OnClick() {} // 0x0000000187320CB0-0x0000000187320F70
		public void SetActiveSelection(bool b) {} // 0x0000000187320F70-0x0000000187320FA0
		public Tween Reveal(float delay = 0f /* Metadata: 0x019771C4 */) => default; // 0x0000000187320FA0-0x0000000187321130
		private Tween GenerateFlipTween(float delay = 0f /* Metadata: 0x019771C8 */) => default; // 0x0000000187321130-0x00000001873212A0
		public void KillReveal() {} // 0x00000001873212A0-0x0000000187321300
		public void Hide() {} // 0x0000000187321300-0x00000001873214B0
		public Tween Spin(int spinTimes) => default; // 0x00000001873214B0-0x00000001873214D0
		public void SpinDelay(float delay, int times) {} // 0x00000001873214D0-0x0000000187321590
		[IteratorStateMachine(typeof(_Wait_d__62))]
		private IEnumerator Wait(float d, int times) => default; // 0x0000000187321590-0x0000000187321650
		public void ChangeSide() {} // 0x0000000187321650-0x0000000187321680
		public void SetOpen() {} // 0x0000000187321680-0x0000000187321830
		public void SetClosed() {} // 0x0000000187321830-0x00000001873218F0
		public ArcanaData GetData() => default; // 0x00000001829475E0-0x00000001829475F0
		public ArcanaType GetArcanaType() => default; // 0x00000001820926E0-0x00000001820926F0
		public void OverrideBackFrameName(string frameName) {} // 0x00000001873218F0-0x0000000187321B00
		public void SetIgnoreDarkana() {} // 0x0000000187321B00-0x0000000187321B10
		public void SetCharacterCard(CharacterSkillCard_Base characterCard) {} // 0x0000000187321B10-0x0000000187321E30
	}
}

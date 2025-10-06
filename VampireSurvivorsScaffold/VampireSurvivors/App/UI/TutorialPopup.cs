/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Objects;
using VampireSurvivors.UI;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.UI
{
	public class TutorialPopup : BasePopup // TypeDefIndex: 18530
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Button _OkButton; // 0x48
		[SerializeField]
		private RectTransform _Panel; // 0x50
		[SerializeField]
		private TextMeshProUGUI _TitleText; // 0x58
		[SerializeField]
		private TextMeshProUGUI _DescriptionText; // 0x60
		private PlayerOptions _playerOptions; // 0x70
		private Selectable _previousSelection; // 0x78
	
		// Events
		public event OnOkButtonClicked OKButtonClicked;
	
		// Nested types
		public delegate void OnOkButtonClicked(); // TypeDefIndex: 18528; 0x000000018196C270-0x000000018196C280
	
		// Constructors
		public TutorialPopup() {} // 0x00000001867AC2E0-0x00000001867AC2F0
	
		// Methods
		[Inject]
		private void Construct(PlayerOptions playerOptions) {} // 0x00000001826E9A00-0x00000001826E9A60
		private void Awake() {} // 0x00000001867C1080-0x00000001867C10D0
		private void Update() {} // 0x0000000180B15170-0x0000000180B15180
		public void Initialize(string id, string titleTerm, string descriptionTerm, string buttonTerm) {} // 0x00000001867C10D0-0x00000001867C12D0
		public override void Show() {} // 0x00000001867C12D0-0x00000001867C1680
		[IteratorStateMachine(typeof(_WaitAndSelect_d__15))]
		private IEnumerator WaitAndSelect() => default; // 0x00000001867C1680-0x00000001867C1720
		public override void Hide() {} // 0x00000001867C1720-0x00000001867C18A0
	}
}

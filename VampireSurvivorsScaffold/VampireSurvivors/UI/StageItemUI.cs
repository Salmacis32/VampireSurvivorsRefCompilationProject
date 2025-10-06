/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class StageItemUI : SelectableUI // TypeDefIndex: 14982
	{
		// Fields
		[SerializeField]
		private Image _Background; // 0xA0
		[SerializeField]
		private Image _Icon; // 0xA8
		[SerializeField]
		private Localize _NameText; // 0xB0
		[SerializeField]
		private Localize _DescriptionText; // 0xB8
		[SerializeField]
		private UnityEngine.UI.Text _StageNumber; // 0xC0
		[SerializeField]
		private Image _Overlay; // 0xC8
		[SerializeField]
		private Image _FrameCorners; // 0xD0
		[SerializeField]
		private GameObject _Exclamation; // 0xD8
		private bool _unlocked; // 0xE0
		private DG.Tweening.Sequence _specialTween; // 0xE8
		private StageSelectPage _page; // 0xF0
		private StageData _stage; // 0xF8
		private PlayerOptions _playerOptions; // 0x100
		private readonly string[] _frameNames; // 0x108
	
		// Properties
		public StageType Type { get; set; } // 0x0000000184E07690-0x0000000184E076A0 0x0000000184E076A0-0x0000000184E076B0
		public TextMeshProUGUI DescriptionText { get => default; } // 0x000000018698AAB0-0x000000018698AC60 
	
		// Constructors
		public StageItemUI() {} // 0x000000018698CD70-0x000000018698CF00
	
		// Methods
		protected override void OnDestroy() {} // 0x000000018698AC60-0x000000018698AD50
		public void DoHighlight() {} // 0x000000018698AD50-0x000000018698AD80
		public void DoUnhighlight() {} // 0x000000018698AD80-0x000000018698ADB0
		public void SetData(PlayerOptions player, StageSelectPage page, StageData stage, Sprite mapSprite, StageType stageType, int index) {} // 0x000000018698ADB0-0x000000018698C5D0
		public void SetInfoPanel() {} // 0x000000018698C5D0-0x000000018698C850
		public StageData GetData() => default; // 0x0000000181945E90-0x0000000181945EA0
		public StageType GetStageType() => default; // 0x0000000184E07690-0x0000000184E076A0
		public bool HasHyperUnlocked() => default; // 0x000000018698C850-0x000000018698C880
		public void MakeDisabled() {} // 0x000000018698C880-0x000000018698CBD0
		public void MakeEnabled() {} // 0x000000018698CBD0-0x000000018698CD60
		protected override void OnSelected() {} // 0x000000018698CD60-0x000000018698CD70
	}
}

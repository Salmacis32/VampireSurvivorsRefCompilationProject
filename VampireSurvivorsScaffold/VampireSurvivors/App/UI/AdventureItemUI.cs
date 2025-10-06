/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using VampireSurvivors.App.Data.Adventures;
using VampireSurvivors.App.Scripts.UI;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.UI
{
	public class AdventureItemUI : MonoBehaviour, ISelectHandler // TypeDefIndex: 18505
	{
		// Fields
		[SerializeField]
		private Image _Icon; // 0x20
		[SerializeField]
		private Image _Selection; // 0x28
		[SerializeField]
		private TextMeshProUGUI _Title; // 0x30
		[SerializeField]
		private TextMeshProUGUI _CoinCount; // 0x38
		[SerializeField]
		private TextMeshProUGUI _ProgressCount; // 0x40
		[SerializeField]
		private Image _ProgressFill; // 0x48
		[SerializeField]
		private GameObject _AvailableGroup; // 0x50
		[SerializeField]
		private GameObject _RequiresDlcPurchaseGroup; // 0x58
		[SerializeField]
		private GameObject _CompletedGroup; // 0x60
		[SerializeField]
		private GameObject _LockedGroup; // 0x68
		[SerializeField]
		private UnityEngine.UI.Button _AscendAdventureButton; // 0x70
		[SerializeField]
		private Image _Flash; // 0x78
		[SerializeField]
		private RectTransform _BackgroundContainer; // 0x80
		[SerializeField]
		private Image _CompletionStar; // 0x88
		private AdventureType _type; // 0x90
		private AdventureData _data; // 0x98
		private SelectAdventuresPage _page; // 0xA0
		private GameObject _background; // 0xA8
		private bool _isUnlockedViaAtlas; // 0xB0
		private bool _ownsRequiredDlc; // 0xB1
	
		// Constructors
		public AdventureItemUI() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Awake() {} // 0x00000001867915B0-0x0000000186791660
		private void Start() {} // 0x0000000180B15170-0x0000000180B15180
		public UnityEngine.UI.Button GetAscendButton() => default; // 0x00000001826E99F0-0x00000001826E9A00
		public void SetData(SelectAdventuresPage page, AdventureType type, AdventureData adventureData) {} // 0x0000000186791660-0x0000000186792380
		public void OpenDLC() {} // 0x0000000186792380-0x00000001867923B0
		public void OnClick() {} // 0x0000000180B15170-0x0000000180B15180
		public GameObject GetBackground() => default; // 0x00000001819716D0-0x00000001819716E0
		public AdventureType GetAdventureType() => default; // 0x0000000181BA6030-0x0000000181BA6040
		public AdventureData GetAdventureData() => default; // 0x0000000181971630-0x0000000181971640
		public void SetAscendingItem() {} // 0x00000001867923B0-0x0000000186792420
		public void OnSelect(BaseEventData eventData) {} // 0x0000000186792420-0x0000000186792470
		public void Deselect() {} // 0x0000000186792470-0x00000001867924A0
		private float CurrentAdventureCompletionProgress(PlayerOptionsData pod, AdventureData adventureData, AdventureType adventureType) => default; // 0x00000001867924A0-0x0000000186792540
		public void DoAscenscionFeedback() {} // 0x0000000186792540-0x00000001867927D0
	}
}

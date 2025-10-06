/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using VampireSurvivors.App.Scripts.Objects.VFX;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.UI.Twitch
{
	public class TwitchStageEventsPanel : MonoBehaviour // TypeDefIndex: 18539
	{
		// Fields
		[SerializeField]
		private CanvasGroup _CanvasGroup; // 0x20
		[SerializeField]
		private CanvasGroup _UsernamesCanvasGroup; // 0x28
		[SerializeField]
		private TextMeshProUGUI _Text1; // 0x30
		[SerializeField]
		private TextMeshProUGUI _Text2; // 0x38
		[SerializeField]
		private TextMeshProUGUI _Text3; // 0x40
		[SerializeField]
		private TextMeshProUGUI _Option1; // 0x48
		[SerializeField]
		private TextMeshProUGUI _Option2; // 0x50
		[SerializeField]
		private TextMeshProUGUI _Option3; // 0x58
		[SerializeField]
		private TwitchUsername _TwitchUsernamePrefab; // 0x60
		[SerializeField]
		private Transform _TwitchUsernamesRoot; // 0x68
		private RectTransform _rectTransform; // 0x70
		private Vector2? _defaultAnchoredPos; // 0x78
		private Vector2? _hideAnchorPos; // 0x84
	
		// Properties
		public TextMeshProUGUI Text1 { get => default; } // 0x0000000180B15550-0x0000000180B15560 
		public TextMeshProUGUI Text2 { get => default; } // 0x0000000180B15560-0x0000000180B15570 
		public TextMeshProUGUI Text3 { get => default; } // 0x0000000180B15750-0x0000000180B15760 
		public TextMeshProUGUI Option1 { get => default; } // 0x0000000180B15760-0x0000000180B15770 
		public TextMeshProUGUI Option2 { get => default; } // 0x000000018197EAB0-0x000000018197EAC0 
		public TextMeshProUGUI Option3 { get => default; } // 0x0000000180B15730-0x0000000180B15740 
	
		// Constructors
		public TwitchStageEventsPanel() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Awake() {} // 0x00000001867C6EA0-0x00000001867C6FA0
		private void Start() {} // 0x00000001867C6FA0-0x00000001867C7180
		private void OnEnable() {} // 0x00000001867C7180-0x00000001867C7200
		public void AnimatePanelIn() {} // 0x00000001867C7200-0x00000001867C73C0
		public void AnimatePanelOut() {} // 0x00000001867C73C0-0x00000001867C7580
		public void QuickShow() {} // 0x00000001867C7580-0x00000001867C75D0
		public void QuickHide() {} // 0x00000001867C75D0-0x00000001867C7610
		public void ShowUsernameAt(Vector3 usernameGizmoPos, string username) {} // 0x00000001867C7610-0x00000001867C76D0
		private void CacheDefaultPosition() {} // 0x00000001867C76D0-0x00000001867C7850
		private void EditorShowRandomUsername(int num) {} // 0x00000001867C7850-0x00000001867C7940
	}
}

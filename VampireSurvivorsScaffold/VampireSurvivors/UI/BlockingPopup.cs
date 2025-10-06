/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class BlockingPopup : BasePopup // TypeDefIndex: 14707
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _Title; // 0x48
		[SerializeField]
		private TextMeshProUGUI _Description; // 0x50
		[SerializeField]
		private UISpriteAnimation _AnimLeft; // 0x58
		[SerializeField]
		private UISpriteAnimation _AnimRight; // 0x60
		private Action _onClose; // 0x68
		private DataManager _data; // 0x70
		private PlayerOptions _playerOptions; // 0x78
	
		// Constructors
		public BlockingPopup() {} // 0x00000001867AC2E0-0x00000001867AC2F0
	
		// Methods
		[Inject]
		private void Construct(DataManager data, PlayerOptions player) {} // 0x00000001867ABC20-0x00000001867ABCD0
		public virtual void Initialize(string id, string title, string description, Action onClose = null) {} // 0x00000001867ABCD0-0x00000001867ABE00
		public override void Hide() {} // 0x00000001867ABE00-0x00000001867ABE30
		public void UpdateDescriptionText(string newDescription) {} // 0x00000001867ABE30-0x00000001867ABF30
		private void OnDestroy() {} // 0x00000001867ABF30-0x00000001867ABF40
		private void SetAnimation() {} // 0x00000001867ABF40-0x00000001867AC2E0
	}
}

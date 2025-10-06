/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class SecretItemUI : SelectableUI // TypeDefIndex: 14957
	{
		// Fields
		[SerializeField]
		private Image _Tick; // 0xA0
		[SerializeField]
		private TextMeshProUGUI _Description; // 0xA8
		[SerializeField]
		private Image _Reward; // 0xB0
		private SecretData _data; // 0xB8
		private SecretType _type; // 0xC0
		private DataManager _dataManager; // 0xC8
		private SecretsPage _page; // 0xD0
		private bool _hasAchieved; // 0xD8
	
		// Constructors
		public SecretItemUI() {} // 0x00000001865B2B50-0x00000001865B2BB0
	
		// Methods
		public void SetData(DataManager dataManager, SecretsPage page, SecretData data, SecretType type, bool hasAchieved) {} // 0x0000000186950E40-0x0000000186951210
		public SecretType GetSecretType() => default; // 0x00000001831C30C0-0x00000001831C30D0
		public bool CheckAchieved() => default; // 0x0000000182816BD0-0x0000000182816BE0
		public Sprite GetSecondReward(SecretData bad) => default; // 0x0000000186951210-0x00000001869516A0
		public Sprite GetCharacterReward(SecretData bad) => default; // 0x00000001869516A0-0x00000001869518B0
		public Sprite GetOtherReward(SecretData bad) => default; // 0x00000001869518B0-0x0000000186951A00
		private Sprite GetRewardSprite(SecretData bad) => default; // 0x0000000186951A00-0x0000000186951C40
		protected override void OnSelected() {} // 0x0000000186951C40-0x0000000186951C80
		public void SetInfoPanel() {} // 0x0000000186951C40-0x0000000186951C80
	}
}

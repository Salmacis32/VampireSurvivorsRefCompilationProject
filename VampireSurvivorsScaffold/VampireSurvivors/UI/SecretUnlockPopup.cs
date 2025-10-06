/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class SecretUnlockPopup : MonoBehaviour // TypeDefIndex: 14969
	{
		// Fields
		[SerializeField]
		private Localize _SecretUnlock; // 0x20
		[SerializeField]
		private Image _Icon; // 0x28
		[SerializeField]
		private RectTransform _Panel; // 0x30
		[SerializeField]
		private TextMeshProUGUI _PageCount; // 0x38
		[SerializeField]
		private GameObject _UnlocksCircle; // 0x40
		[SerializeField]
		private TextMeshProUGUI _UnlockText; // 0x48
		[SerializeField]
		private CanvasGroup _CircleGroup; // 0x50
		private List<SecretUnlockInfo> _secretsToShow; // 0x58
		private int _currentSecretIndex; // 0x60
		private DataManager _dataManager; // 0x68
		private Dictionary<SecretType, SecretData> _secrets; // 0x70
		private Action _onComplete; // 0x78
	
		// Constructors
		public SecretUnlockPopup() {} // 0x0000000186965F90-0x0000000186966090
	
		// Methods
		[Inject]
		private void Construct(DataManager data) {} // 0x00000001827660A0-0x0000000182766100
		public void SetSecrets(List<SecretUnlockInfo> unlocks, Action onComplete) {} // 0x0000000186965230-0x0000000186965800
		private void StartShowLoop() {} // 0x0000000186965800-0x0000000186965F90
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class CharacterStageCompletionPanel : MonoBehaviour // TypeDefIndex: 14734
	{
		// Fields
		[SerializeField]
		private GameObject _StagePrefab; // 0x20
		[SerializeField]
		private RectTransform _Container; // 0x28
		private Dictionary<StageType, Image> _stageIcons; // 0x30
		private DataManager _dataManager; // 0x38
		private SignalBus _signalBus; // 0x40
		private PlayerOptions _playerOptions; // 0x48
		private bool _formatSize; // 0x50
	
		// Constructors
		public CharacterStageCompletionPanel() {} // 0x000000018686BC60-0x000000018686BD60
	
		// Methods
		[Inject]
		private void Construct(DataManager data, SignalBus signal, PlayerOptions player) {} // 0x0000000183B86C30-0x0000000183B86D30
		public void Initialize() {} // 0x000000018686A5F0-0x000000018686B1A0
		private void LateUpdate() {} // 0x000000018686B1A0-0x000000018686B2B0
		public void TryShow() {} // 0x000000018686B2B0-0x000000018686B6B0
		public void SetPanel(VampireSurvivors.Data.CharacterType cType) {} // 0x000000018686B6B0-0x000000018686BC60
	}
}

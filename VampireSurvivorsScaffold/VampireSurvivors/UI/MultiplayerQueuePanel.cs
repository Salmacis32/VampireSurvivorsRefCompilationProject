/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Rewired;
using TMPro;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class MultiplayerQueuePanel : MonoBehaviour // TypeDefIndex: 14873
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _PressToStartText; // 0x20
		[SerializeField]
		private GameObject _PlayerPrefab; // 0x28
		[SerializeField]
		private RectTransform _Container; // 0x30
		[SerializeField]
		private GameObject _TextPanel; // 0x38
		[SerializeField]
		private GameObject _PlayerPanel; // 0x40
		[SerializeField]
		private GameObject _EntirePanel; // 0x48
		private DG.Tweening.Sequence _flashSequence; // 0x50
		private Dictionary<global::Rewired.Player, GameObject> _spawnedPlayers; // 0x58
		private MultiplayerManager _multiplayer; // 0x60
		private PlayerOptions _playerOptions; // 0x68
		private DataManager _data; // 0x70
	
		// Constructors
		public MultiplayerQueuePanel() {} // 0x00000001868F5A90-0x00000001868F5B90
	
		// Methods
		[Inject]
		private void Construct(MultiplayerManager multi, PlayerOptions player, DataManager data) {} // 0x00000001868F29C0-0x00000001868F2AC0
		private void Awake() {} // 0x00000001868F2AC0-0x00000001868F2AD0
		private void Start() {} // 0x00000001868F2AD0-0x00000001868F2AE0
		public void Initialize() {} // 0x00000001868F2AE0-0x00000001868F3860
		private void OnDestroy() {} // 0x00000001868F3860-0x00000001868F3B80
		private void Update() {} // 0x00000001868F3B80-0x00000001868F42F0
		public void AddPlayer(global::Rewired.Player player) {} // 0x00000001868F42F0-0x00000001868F4870
		public void RemovePlayer(global::Rewired.Player player) {} // 0x00000001868F4870-0x00000001868F4AB0
		[IteratorStateMachine(typeof(_WaitAndReformat_d__19))]
		private IEnumerator WaitAndReformat() => default; // 0x00000001868F4AB0-0x00000001868F4B50
		private Sprite GetCharacterSprite(VampireSurvivors.Data.CharacterType t) => default; // 0x00000001868F4B50-0x00000001868F4C30
		private CoopSelections GetSelection(global::Rewired.Player player) => default; // 0x00000001868F4C30-0x00000001868F4D40
		public void HighlightPlayer(global::Rewired.Player p) {} // 0x00000001868F4D40-0x00000001868F52F0
		public void Refresh() {} // 0x00000001868F52F0-0x00000001868F5900
		public void ShowTextPanel() {} // 0x00000001868F5900-0x00000001868F59C0
		public void ShowPlayerPanel() {} // 0x00000001868F59C0-0x00000001868F5A90
	}
}

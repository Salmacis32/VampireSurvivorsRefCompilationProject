/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DarkTonic.MasterAudio;
using DG.Tweening;
using TMPro;
using Unity.Collections;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Characters;
using VampireSurvivors.Data.Enemies;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class FinalCreditsPage : BaseUIPage // TypeDefIndex: 14769
	{
		// Fields
		[SerializeField]
		private RectTransform _Container; // 0xE0
		[SerializeField]
		private GameObject _TextPrefab; // 0xE8
		[SerializeField]
		private TextMeshProUGUI _Title; // 0xF0
		[SerializeField]
		private RectTransform _CongaContainer; // 0xF8
		[SerializeField]
		private GameObject _CongaItem; // 0x100
		[SerializeField]
		private RectTransform _BackButton; // 0x108
		private PlayerOptions _playerOptions; // 0x110
		private DataManager _data; // 0x118
		private int switchCount; // 0x120
		private List<WiggleTween> _movementTweens; // 0x128
		private List<EnemyType> _enemyList; // 0x130
		private List<VampireSurvivors.Data.CharacterType> _characterList; // 0x138
		private Dictionary<EnemyType, List<EnemyData>> _enemyData; // 0x140
		private Dictionary<VampireSurvivors.Data.CharacterType, List<CharacterData>> _characterData; // 0x148
		private List<float> _switchTimes; // 0x150
		private float _chickenTime; // 0x158
		private List<UISpriteAnimation> _anims; // 0x160
		private int _moveTweenIndex; // 0x168
		[ReadOnly]
		[SerializeField]
		private float _congaSpeed; // 0x16C
		private bool _carrySkip; // 0x170
		private int _congaLength; // 0x174
		private float _widthCounter; // 0x178
		private int _enemyCount; // 0x17C
		private int _characterCount; // 0x180
		private Vector2 _JSDefaultScreenSize; // 0x184
		private List<RectTransform> _spawnedConga; // 0x190
		private PlaySoundResult _soundResult; // 0x198
	
		// Constructors
		public FinalCreditsPage() {} // 0x000000018688A9D0-0x000000018688B0B0
	
		// Methods
		[Inject]
		private void Construct(PlayerOptions player, DataManager data) {} // 0x0000000186886270-0x0000000186886330
		public void Back() {} // 0x0000000186886330-0x00000001868865B0
		protected void FixedUpdate() {} // 0x00000001868865B0-0x0000000186887130
		protected override void OnShowStart(GameObject g) {} // 0x0000000186887130-0x0000000186887AF0
		private void FadeInText() {} // 0x0000000186887AF0-0x0000000186887CB0
		private void ScrollText() {} // 0x0000000186887CB0-0x0000000186887E50
		private void FadeOutText() {} // 0x0000000186887E50-0x0000000186887F20
		private void CreateConga() {} // 0x0000000186887F20-0x0000000186888050
		private void CongaSwitch() {} // 0x0000000186888050-0x00000001868887D0
		private void CarryButton() {} // 0x00000001868887D0-0x0000000186888850
		private void CreateWiggleTweens() {} // 0x0000000186888850-0x0000000186888940
		private void CreateEnemyList() {} // 0x0000000186888940-0x0000000186889500
		private void GetNextCharacter() {} // 0x0000000186889500-0x0000000186889AB0
		private GameObject CreateEnemyAnimation(EnemyType type, int frameIndex = 0 /* Metadata: 0x019771FC */) => default; // 0x0000000186889AB0-0x0000000186889C90
		private void CreateCharacterAnimation(VampireSurvivors.Data.CharacterType type, int frameIndex = 0 /* Metadata: 0x019771FD */) {} // 0x0000000186889C90-0x0000000186889FB0
		private GameObject CreatePawn(List<Sprite> sprites, bool flip = false /* Metadata: 0x019771FE */) => default; // 0x0000000186889FB0-0x000000018688A540
		private void CreateCharacterList() {} // 0x000000018688A540-0x000000018688A950
		private void BuildCredits() {} // 0x000000018688A950-0x000000018688A9D0
	}
}

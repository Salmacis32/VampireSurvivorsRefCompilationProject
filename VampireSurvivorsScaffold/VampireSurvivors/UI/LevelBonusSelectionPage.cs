/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class LevelBonusSelectionPage : BaseUIPage // TypeDefIndex: 14830
	{
		// Fields
		[SerializeField]
		private RectTransform _Container; // 0xE0
		[SerializeField]
		private GameObject _WeaponPrefab; // 0xE8
		[SerializeField]
		private RectTransform _Panel; // 0xF0
		[SerializeField]
		private RectTransform _SkipButton; // 0xF8
		[SerializeField]
		private SpriteReel _LeftBanner; // 0x100
		[SerializeField]
		private SpriteReel _RightBanner; // 0x108
		[SerializeField]
		private UISpriteAnimation _VFX; // 0x110
		private DataManager _dataManager; // 0x118
		private Dictionary<WeaponType, List<WeaponData>> _weapons; // 0x120
		private LevelBonusSelectionItem _currentSelected; // 0x128
		private PowerUpType _currentType; // 0x130
		private List<LevelBonusSelectionItem> _spawned; // 0x138
		private VampireSurvivors.Objects.Characters.CharacterController _targetCharacter; // 0x140
	
		// Constructors
		public LevelBonusSelectionPage() {} // 0x00000001868BD840-0x00000001868BD930
	
		// Methods
		[Inject]
		private void Construct(DataManager data) {} // 0x00000001868BB800-0x00000001868BBC10
		private void OnLevelBonusSkippedRemotely() {} // 0x00000001868BBC10-0x00000001868BBC20
		private void OnLevelUpBonusRemotely(OnlineSignals.SelectLevelUpBonus bonus) {} // 0x00000001868BBC20-0x00000001868BBC30
		protected void OnDestroy() {} // 0x00000001868BBC30-0x00000001868BBE70
		public void SetSelected(LevelBonusSelectionItem item) {} // 0x00000001868BBE70-0x00000001868BBF00
		public void Skip() {} // 0x00000001868BBF00-0x00000001868BC060
		public void ConfirmBonus(LevelBonusSelectionItem item) {} // 0x00000001868BC060-0x00000001868BC260
		private void ExecuteLevelUpBonus(PowerUpType item) {} // 0x00000001868BC260-0x00000001868BC390
		private void ExecuteSkip() {} // 0x00000001868BC390-0x00000001868BC4D0
		private void ApplyChosenBonus(PowerUpType powerUpType) {} // 0x00000001868BC4D0-0x00000001868BC750
		protected override void OnShowStart(GameObject g) {} // 0x00000001868BC750-0x00000001868BD010
		protected override VampireSurvivors.Objects.Characters.CharacterController GetCharacterControllingUi() => default; // 0x0000000184F612F0-0x0000000184F61300
		[IteratorStateMachine(typeof(_ShowRoutine_d__25))]
		private IEnumerator ShowRoutine() => default; // 0x00000001868BD010-0x00000001868BD0B0
		private void Populate() {} // 0x00000001868BD0B0-0x00000001868BD290
		[IteratorStateMachine(typeof(_WaitAndSelect_d__27))]
		private IEnumerator WaitAndSelect() => default; // 0x00000001868BD290-0x00000001868BD330
		private void SpawnItem(PowerUpType p) {} // 0x00000001868BD330-0x00000001868BD580
		private void Clear() {} // 0x00000001868BD580-0x00000001868BD840
	}
}

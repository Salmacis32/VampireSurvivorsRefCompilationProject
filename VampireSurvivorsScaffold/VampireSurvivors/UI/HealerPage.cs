/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Items;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class HealerPage : GameWindowedUIPage // TypeDefIndex: 14804
	{
		// Fields
		[SerializeField]
		private GameObject _EggPrefab; // 0x158
		[SerializeField]
		private RectTransform _EggContainer; // 0x160
		[SerializeField]
		private GameObject _ItemPrefab; // 0x168
		[SerializeField]
		private TextMeshProUGUI _EggCountText; // 0x170
		[SerializeField]
		private RectTransform _EggPanel; // 0x178
		[SerializeField]
		private UISpriteAnimation _BurstVFX; // 0x180
		[SerializeField]
		private VerticalLayoutGroup _Grid; // 0x188
		private DataManager _data; // 0x190
		private PlayerOptions _playerOptions; // 0x198
		private EggManager _egg; // 0x1A0
		private BgmType _currentTrack; // 0x1A8
		private BgmModType _currentMod; // 0x1AC
		private List<Image> _spawnedEggs; // 0x1B0
		private int _spriteIndex; // 0x1B8
		private ParticleSystem _happyPfx1; // 0x1C0
		private ParticleSystem _happyPfx2; // 0x1C8
		private bool _happyParticlesCreated; // 0x1D0
	
		// Constructors
		public HealerPage() {} // 0x00000001868AFE80-0x00000001868AFF50
	
		// Methods
		[Inject]
		private void Constructor(DataManager data, PlayerOptions player, EggManager egg) {} // 0x00000001868ABF40-0x00000001868AC060
		public override void Purchase(VampireSurvivors.Data.ItemType t, ItemData d, ShopItemUI item, float price, RectTransform sender) {} // 0x00000001868AC060-0x00000001868AC4D0
		public void Back() {} // 0x00000001868AC4D0-0x00000001868AC5C0
		protected override void OnShowStart(GameObject g) {} // 0x00000001868AC5C0-0x00000001868AC970
		private void IntroAnimation() {} // 0x00000001868AC970-0x00000001868AD030
		[IteratorStateMachine(typeof(_WaitAndTween_d__22))]
		private IEnumerator WaitAndTween() => default; // 0x00000001868AD030-0x00000001868AD0D0
		protected override void OnHideStart(GameObject g) {} // 0x00000001868AD0D0-0x00000001868AD1E0
		private void UnsetMusic() {} // 0x00000001868AD1E0-0x00000001868AD2E0
		private void SetMusic() {} // 0x00000001868AD2E0-0x00000001868AD510
		private void CreateHappyParticles() {} // 0x00000001868AD510-0x00000001868AE4C0
		private void Populate() {} // 0x00000001868AE4C0-0x00000001868AE940
		private void SpawnItem(VampireSurvivors.Data.ItemType t, int index) {} // 0x00000001868AE940-0x00000001868AEAC0
		private void SpawnEggs() {} // 0x00000001868AEAC0-0x00000001868AECA0
		private void ShuffleText() {} // 0x00000001868AECA0-0x00000001868AF420
		private void RemoveEggs(int value, Vector2 pos) {} // 0x00000001868AF420-0x00000001868AF730
		private void PlayRemovalAnimation(Vector2 pos) {} // 0x00000001868AF730-0x00000001868AF990
		private void UpdateEggsTotal() {} // 0x00000001868AF990-0x00000001868AFE80
	}
}

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
using VampireSurvivors.Framework;
using VampireSurvivors.Objects.Characters;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class PauseEquipmentPanel : MonoBehaviour // TypeDefIndex: 14910
	{
		// Fields
		[SerializeField]
		private Image _PlayerSprite; // 0x20
		[SerializeField]
		private RectTransform _Weapons; // 0x28
		[SerializeField]
		private RectTransform _Accessories; // 0x30
		[SerializeField]
		private GameObject _EquipmentIconPrefab; // 0x38
		private List<GameObject> _spawned; // 0x40
		private DataManager _data; // 0x48
		private LevelUpFactory _levelUpFactory; // 0x50
		private CanvasGroup _Group; // 0x58
	
		// Constructors
		public PauseEquipmentPanel() {} // 0x000000018692AC90-0x000000018692AD90
	
		// Methods
		[Inject]
		private void Construct(DataManager data, LevelUpFactory level) {} // 0x00000001869290B0-0x0000000186929160
		public void Populate(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x0000000186929160-0x000000018692A350
		private void WaitAndRefresh() {} // 0x000000018692A350-0x000000018692A970
		private EquipmentIconPaused Spawn(WeaponType t, Sprite s, int level, int maxLevel, RectTransform rTrans, bool isBanished) => default; // 0x000000018692A970-0x000000018692AAA0
		private void ClearSpawned() {} // 0x000000018692AAA0-0x000000018692AC90
	}
}

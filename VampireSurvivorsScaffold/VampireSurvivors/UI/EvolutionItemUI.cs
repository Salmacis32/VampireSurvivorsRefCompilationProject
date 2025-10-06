/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class EvolutionItemUI : MonoBehaviour // TypeDefIndex: 14761
	{
		// Fields
		[SerializeField]
		private Image _HighlightPanel; // 0x20
		[SerializeField]
		private GameObject _WeaponPrefab; // 0x28
		[SerializeField]
		private GameObject _TextPrefab; // 0x30
		[SerializeField]
		private GameObject _QuestionMarkPrefab; // 0x38
		[SerializeField]
		private CanvasGroup _CanvasGroup; // 0x40
		private EvolutionData _evoData; // 0x48
		private PlayerOptions _playerOptions; // 0x50
		private Dictionary<WeaponType, List<WeaponData>> _weapons; // 0x58
		private VampireSurvivors.Objects.Characters.CharacterController _character; // 0x60
		private List<Equipment> _equipment; // 0x68
		private List<WeaponType> _owned; // 0x70
		private float _iconPos; // 0x78
		private float _symbolSpacing; // 0x7C
		private List<GameObject> addedWeaponObjects; // 0x80
		private bool formatHighlight; // 0x88
	
		// Constructors
		public EvolutionItemUI() {} // 0x0000000186884A70-0x0000000186884B70
	
		// Methods
		public void CreateWeaponContainer(PlayerOptions player, Dictionary<WeaponType, List<WeaponData>> weapons, List<WeaponType> owned, EvolutionData evo, VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x0000000186881E90-0x0000000186882990
		private void OnEnable() {} // 0x0000000186882990-0x0000000186882A50
		[IteratorStateMachine(typeof(_FormatHighlightSize_d__17))]
		private IEnumerator FormatHighlightSize() => default; // 0x0000000186882A50-0x0000000186882AF0
		public void CreateTriassoContainer(PlayerOptions player, Dictionary<WeaponType, List<WeaponData>> weapons, List<WeaponType> owned, EvolutionData evo, VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x0000000186882AF0-0x0000000186882E90
		public void CreateGenericContainer(PlayerOptions player, Dictionary<WeaponType, List<WeaponData>> weapons, List<WeaponType> owned, EvolutionData evo, VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x0000000186882E90-0x0000000186883500
		private void SetVisibility() {} // 0x0000000186883500-0x0000000186883590
		private void AddCharacterIcon(string character) {} // 0x0000000186883590-0x00000001868836C0
		private GameObject AddWeaponIcon(WeaponType t) => default; // 0x00000001868836C0-0x00000001868839A0
		private void AddQuestionIcon() {} // 0x00000001868839A0-0x0000000186883A80
		private bool VisibleItem() => default; // 0x0000000186883A80-0x0000000186883DE0
		private bool DisabledItem() => default; // 0x0000000186883DE0-0x0000000186883F90
		private bool UnobtainableItem() => default; // 0x0000000186883F90-0x0000000186884240
		private int GetAvailableWeaponSlots() => default; // 0x0000000186884240-0x00000001868842B0
		private int GetAvailablePassiveSlots() => default; // 0x00000001868842B0-0x0000000186884320
		private static bool WeaponsInThisStage(WeaponType t) => default; // 0x0000000186884320-0x0000000186884510
		private bool OwnsWeapon(WeaponType t) => default; // 0x0000000186884510-0x0000000186884560
		private List<WeaponType> CreateRequiredWeaponList() => default; // 0x0000000186884560-0x0000000186884A70
	}
}

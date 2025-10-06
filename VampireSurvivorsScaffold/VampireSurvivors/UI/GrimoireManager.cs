/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class GrimoireManager : MonoBehaviour // TypeDefIndex: 14800
	{
		// Fields
		[SerializeField]
		private GameObject _EvolutionPrefab; // 0x20
		[SerializeField]
		private List<RectTransform> _Containers; // 0x28
		[SerializeField]
		private GameObject _ButtonsNoMap; // 0x30
		[SerializeField]
		private GameObject _ButtonsHasMap; // 0x38
		[SerializeField]
		private GameObject _Pager; // 0x40
		[SerializeField]
		private PageManager _PageManager; // 0x48
		[SerializeField]
		private GameObject _ContainerPrefab; // 0x50
		[SerializeField]
		private RectTransform _ContainerContainer; // 0x58
		[SerializeField]
		private CanvasGroup _CanvasGroup; // 0x60
		[SerializeField]
		private float _DefaultAlpha; // 0x68
		[SerializeField]
		private float _AlphaWhileArcanaInfoShown; // 0x6C
		private SignalBus _signalBus; // 0x70
		private PlayerOptions _playerOptions; // 0x78
		private DataManager _data; // 0x80
		private GameSessionData _session; // 0x88
		private List<Equipment> _equipment; // 0x90
		private List<EvolutionItemUI> _evolutionItems; // 0x98
		private Dictionary<WeaponType, List<WeaponData>> _weapons; // 0xA0
		private List<EvolutionData> _evolutionData; // 0xA8
		private List<WeaponType> _ownedWeapons; // 0xB0
		private List<GameObject> _spawned; // 0xB8
		private RectTransform _ActiveContainer; // 0xC0
	
		// Constructors
		public GrimoireManager() {} // 0x00000001868ABB30-0x00000001868ABEA0
	
		// Methods
		[Inject]
		private void Construct(SignalBus signal, PlayerOptions player, DataManager data, GameSessionData session) {} // 0x00000001868A9030-0x00000001868A91B0
		public void Init() {} // 0x00000001868A91B0-0x00000001868AA810
		public PageManager GetPageManager() => default; // 0x0000000180B15760-0x0000000180B15770
		private void AddNewContainer() {} // 0x00000001868AA810-0x00000001868AA980
		public void ReduceAlphaOnArcanaInfoShown() {} // 0x00000001868AA980-0x00000001868AA9B0
		public void ResetToDefaultAlpha() {} // 0x00000001868AA9B0-0x00000001868AA9E0
		private void SpawnWeapon(EvolutionData d) {} // 0x00000001868AA9E0-0x00000001868AAB30
		private void SpawnGenericLine(EvolutionData d) {} // 0x00000001868AAB30-0x00000001868AAC80
		private void SpawnTriasso(EvolutionData d) {} // 0x00000001868AAC80-0x00000001868AADD0
		private void CreateEvolutionList() {} // 0x00000001868AADD0-0x00000001868AB5E0
		private bool RequiresYellowSign(EvolutionData d) => default; // 0x00000001868AB5E0-0x00000001868AB7C0
		private bool OwnsWeapon(WeaponType t) => default; // 0x00000001868AB7C0-0x00000001868AB820
		private void Clear() {} // 0x00000001868AB820-0x00000001868ABB30
	}
}

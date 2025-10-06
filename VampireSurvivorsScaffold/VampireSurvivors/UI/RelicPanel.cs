/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class RelicPanel : MonoBehaviour // TypeDefIndex: 14937
	{
		// Fields
		[SerializeField]
		private GameObject _Prefab; // 0x20
		[SerializeField]
		private RectTransform _Container; // 0x28
		private List<GameObject> _spawned; // 0x30
		private List<VampireSurvivors.Data.ItemType> _spawnedType; // 0x38
		private DataManager _data; // 0x40
		private PlayerOptions _playerOptions; // 0x48
		private bool _hasYellowRelic; // 0x50
	
		// Constructors
		public RelicPanel() {} // 0x000000018693EAF0-0x000000018693EC80
	
		// Methods
		[Inject]
		private void Construct(DataManager data, PlayerOptions player) {} // 0x00000001865DC6A0-0x00000001865DC750
		public void SetRelics(StageData stage, StageType stageType) {} // 0x000000018693DBD0-0x000000018693EAF0
	}
}

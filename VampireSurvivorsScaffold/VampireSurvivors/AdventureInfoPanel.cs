/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.App.Data.Adventures;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class AdventureInfoPanel : MonoBehaviour // TypeDefIndex: 14185
	{
		// Fields
		[SerializeField]
		private GameObject SpritePrefab; // 0x20
		[SerializeField]
		private MultipleLineHorizontalList CharacterContainer; // 0x28
		[SerializeField]
		private MultipleLineHorizontalList WeaponContainer; // 0x30
		private AdventureData _currentData; // 0x38
		private AdventureType _currentType; // 0x40
		private DataManager _data; // 0x48
		private PlayerOptions _playerOptions; // 0x50
		private bool _shouldUpdateFormatting; // 0x58
	
		// Constructors
		public AdventureInfoPanel() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		[Inject]
		private void Construct(DataManager data, PlayerOptions player) {} // 0x00000001869290B0-0x0000000186929160
		public void SetData(AdventureType type) {} // 0x0000000186DA8E80-0x0000000186DA9F70
		public void Hide() {} // 0x0000000186DA9F70-0x0000000186DA9FF0
		public void Show() {} // 0x0000000186DA9FF0-0x0000000186DAA070
		private void LateUpdate() {} // 0x0000000186DAA070-0x0000000186DAA1A0
	}
}

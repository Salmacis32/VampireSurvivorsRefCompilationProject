/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.DLC;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class OptionsVersionText : MonoBehaviour, IInitializable // TypeDefIndex: 14908
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _VersionText; // 0x20
		[SerializeField]
		private VersionData _VersionData; // 0x28
		[Inject]
		private DataManager _dataManager; // 0x30
	
		// Constructors
		public OptionsVersionText() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public void Initialize() {} // 0x0000000180B15170-0x0000000180B15180
		private void Start() {} // 0x0000000186927690-0x0000000186927E80
	}
}

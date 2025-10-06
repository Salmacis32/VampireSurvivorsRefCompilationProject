/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class MenuBannerPage : BaseUIPage // TypeDefIndex: 14860
	{
		// Fields
		[SerializeField]
		private RectTransform _Banner; // 0xE0
		[SerializeField]
		private RectTransform _SafeArea; // 0xE8
		[SerializeField]
		private GameObject _TwitchModeEnabled; // 0xF0
		[SerializeField]
		private GameObject _AccountButton; // 0xF8
		[SerializeField]
		private GameObject _LeaveAdventureButton; // 0x100
		[SerializeField]
		private GameObject _QuitGameButton; // 0x108
		[SerializeField]
		private RectTransform _LocalSafeArea; // 0x110
		private AdventureManager _adventure; // 0x118
	
		// Constructors
		public MenuBannerPage() {} // 0x00000001868E6270-0x00000001868E62C0
	
		// Methods
		[Inject]
		private void Construct(AdventureManager adventure) {} // 0x0000000184BDAFE0-0x0000000184BDB040
		private void Start() {} // 0x00000001868E5E10-0x00000001868E5E20
		protected override void Update() {} // 0x00000001868E5E20-0x00000001868E5E40
		private void UpdateLayout() {} // 0x00000001868E5E40-0x00000001868E6140
		protected override void OnShowStart(GameObject g) {} // 0x00000001868E6140-0x00000001868E6230
		public void LeaveAdventure() {} // 0x00000001868E6230-0x00000001868E6270
	}
}

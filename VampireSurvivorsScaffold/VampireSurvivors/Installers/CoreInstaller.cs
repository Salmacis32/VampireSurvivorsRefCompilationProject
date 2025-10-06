/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.App.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.DLC;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Installers
{
	public class CoreInstaller : MonoInstaller<VampireSurvivors.Installers.CoreInstaller> // TypeDefIndex: 14518
	{
		// Fields
		[SerializeField]
		private GameObject _Graphy; // 0x28
		[SerializeField]
		private GameObject _InGameDebugConsole; // 0x30
		[SerializeField]
		private DlcCatalog _DlcCatalog; // 0x38
		[SerializeField]
		private BaseGameData _BaseGameData; // 0x40
		[SerializeField]
		private MainMenuBackgroundFactory _MainMenuBackgroundFactory; // 0x48
	
		// Constructors
		public CoreInstaller() {} // 0x0000000187055620-0x0000000187055690
	
		// Methods
		public void Awake() {} // 0x0000000187053BB0-0x0000000187053C50
		public override void InstallBindings() {} // 0x0000000187053C50-0x0000000187054DF0
		private void SetupGraphics() {} // 0x0000000187054DF0-0x0000000187055470
		private static void SetupOrientations() {} // 0x0000000187055470-0x0000000187055500
		private static void UpdateLogging() {} // 0x0000000187055500-0x0000000187055620
	}
}

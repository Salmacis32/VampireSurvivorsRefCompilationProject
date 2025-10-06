/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Objects;
using VampireSurvivors.UI;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.UI
{
	public class RandomizeOptionsButtonMobile : MobileConfig // TypeDefIndex: 18633
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Button _Fader; // 0x98
		private PlayerOptions _playerOptions; // 0xA0
	
		// Constructors
		public RandomizeOptionsButtonMobile() {} // 0x00000001868030F0-0x0000000186803100
	
		// Methods
		[Inject]
		private void Construct(PlayerOptions playerOptions) {} // 0x0000000181918C00-0x0000000181918C60
		public void Open() {} // 0x0000000186802BF0-0x0000000186802CC0
		public void Close() {} // 0x0000000186802CC0-0x0000000186802DC0
		protected override void Apply() {} // 0x0000000186802DC0-0x0000000186802F90
		private void SetupValuesBasedOnCollectionState() {} // 0x0000000186802F90-0x00000001868030F0
	}
}

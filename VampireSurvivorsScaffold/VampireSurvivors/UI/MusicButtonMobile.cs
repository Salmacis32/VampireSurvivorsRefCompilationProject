/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class MusicButtonMobile : MobileConfig // TypeDefIndex: 14874
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Button _Fader; // 0x98
		private PlayerOptions _playerOptions; // 0xA0
	
		// Constructors
		public MusicButtonMobile() {} // 0x00000001868030F0-0x0000000186803100
	
		// Methods
		[Inject]
		private void Construct(PlayerOptions player) {} // 0x0000000181918C00-0x0000000181918C60
		public void Open() {} // 0x00000001868F5DA0-0x00000001868F5E70
		public void Close() {} // 0x00000001868F5E70-0x00000001868F5F70
		protected override void Apply() {} // 0x00000001868F5F70-0x00000001868F6150
		private void SetupValuesBasedOnCollectionState() {} // 0x00000001868F6150-0x00000001868F62C0
	}
}

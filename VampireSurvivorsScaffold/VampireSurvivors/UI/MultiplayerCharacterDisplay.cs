/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class MultiplayerCharacterDisplay : MonoBehaviour // TypeDefIndex: 14870
	{
		// Fields
		protected DataManager Data; // 0x20
		protected PlayerOptions PlayerOptions; // 0x28
		protected Sprite CharacterSprite; // 0x30
		protected Coroutine ShowRoutine; // 0x38
		private CanvasGroup _cg; // 0x40
	
		// Constructors
		public MultiplayerCharacterDisplay() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		[Inject]
		private void Construct(DataManager data, PlayerOptions playerOptions) {} // 0x00000001852686F0-0x00000001852687A0
		private void Awake() {} // 0x00000001868F21C0-0x00000001868F2260
		protected virtual void OnEnable() {} // 0x00000001868F2260-0x00000001868F2340
		private void OnDestroy() {} // 0x00000001868F2340-0x00000001868F2440
		public virtual void Show() {} // 0x00000001868F2440-0x00000001868F2590
	}
}

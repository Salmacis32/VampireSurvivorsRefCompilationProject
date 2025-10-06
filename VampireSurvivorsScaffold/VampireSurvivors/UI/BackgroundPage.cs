/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class BackgroundPage : BaseUIPage // TypeDefIndex: 14696
	{
		// Fields
		[SerializeField]
		private PixelateEffect _pixelateEffect; // 0xE0
		[SerializeField]
		private TextMeshProUGUI _VersionText; // 0xE8
		[SerializeField]
		private Image _Villain; // 0xF0
		[SerializeField]
		private Image _Antonio; // 0xF8
		[SerializeField]
		private Image _Imelda; // 0x100
		[SerializeField]
		private Image _Fader; // 0x108
		[SerializeField]
		private Image _AdventureSubtitleImage; // 0x110
		public Animator _Animator; // 0x118
		private Material _pixelizer; // 0x120
		private Slider _slider; // 0x128
		private SignalBus _signalBus; // 0x130
		private PlayerOptions _playerOptions; // 0x138
		private AdventureManager _adventureManager; // 0x140
		private LobbiesManager _lobbiesManager; // 0x148
		private static bool _hasPlayedSong; // 0x00
		private bool _doTrumpetGag; // 0x150
		private bool _doMirrorGag; // 0x151
		private static readonly int CellSizeX; // 0x04
		private static readonly int CellSizeY; // 0x08
		private static readonly int PixelSize; // 0x0C
		private static readonly int TexSize; // 0x10
	
		// Constructors
		public BackgroundPage() {} // 0x0000000186796C20-0x0000000186796C70
		static BackgroundPage() {} // 0x0000000186796C70-0x0000000186796D60
	
		// Methods
		[Inject]
		private void Construct(SignalBus signal, PlayerOptions playerOptions, AdventureManager adventureManager, LobbiesManager lobbiesManager) {} // 0x0000000186795B00-0x0000000186795C80
		private void Start() {} // 0x0000000186795C80-0x0000000186795EA0
		private void OnDestroy() {} // 0x0000000186795EA0-0x00000001867960C0
		public void CompleteIntroAnimation() {} // 0x00000001867960C0-0x0000000186796150
		public void ProceedToNextPage() {} // 0x0000000186796150-0x0000000186796290
		public void PlayIntroSound() {} // 0x0000000186796290-0x0000000186796400
		public static void AllowJinglePlayback() {} // 0x0000000186796400-0x0000000186796460
		protected override void OnShowStart(GameObject g) {} // 0x0000000186796460-0x0000000186796720
		private void OnEnable() {} // 0x0000000186796720-0x0000000186796760
		[IteratorStateMachine(typeof(_WaitAndHideFader_d__30))]
		private IEnumerator WaitAndHideFader() => default; // 0x0000000186796760-0x0000000186796800
		private void OnAdventureStarted(AdventureType adventureType) {} // 0x0000000186796800-0x0000000186796810
		private void OnAdventureExit() {} // 0x0000000186796810-0x0000000186796850
		private void SetupAdventureSubtitleImage() {} // 0x0000000186796850-0x0000000186796C20
	}
}

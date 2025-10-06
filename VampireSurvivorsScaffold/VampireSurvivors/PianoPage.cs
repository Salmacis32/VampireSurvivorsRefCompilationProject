/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Signals;
using VampireSurvivors.UI;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class PianoPage : BaseUIPage // TypeDefIndex: 14224
	{
		// Fields
		[SerializeField]
		private bool _DEBUG; // 0xE0
		[SerializeField]
		private Image _Fader; // 0xE8
		[SerializeField]
		private Image _Piano; // 0xF0
		[SerializeField]
		private Image _PianoOverlay; // 0xF8
		[SerializeField]
		private RectTransform _PeachoneHelper; // 0x100
		[SerializeField]
		private RectTransform _EbonyHelper; // 0x108
		[SerializeField]
		private RectTransform _BirdBox; // 0x110
		[SerializeField]
		private GameObject _BackButton; // 0x118
		[SerializeField]
		private List<RectTransform> _CorrectKeys; // 0x120
		private PlayerOptions _playerOptions; // 0x128
		private SignalBus _signalBus; // 0x130
		private bool _hasPeachone; // 0x138
		private bool _hasEbony; // 0x139
		private int[] _keysToPush; // 0x140
		private List<int> _keysPushed; // 0x148
		private int _hintCounter; // 0x150
		private float _birdSpeed; // 0x154
		private Tween _peachoneXTween; // 0x158
		private Tween _peachoneYTween; // 0x160
		private Tween _peachoneAlphaTween; // 0x168
		private Tween _ebonyXTween; // 0x170
		private Tween _ebonyYTween; // 0x178
		private Tween _ebonyAlphaTween; // 0x180
	
		// Constructors
		public PianoPage() {} // 0x0000000186EF9400-0x0000000186EF9650
	
		// Methods
		[Inject]
		private void Construct(SignalBus signal, PlayerOptions player) {} // 0x0000000186EF5F60-0x0000000186EF6620
		private void OnTouchedKeyRemotely(OnlineSignals.TouchedPianoKeySignal signal) {} // 0x0000000186EF6620-0x0000000186EF6630
		private void OnExitPianoRemotely() {} // 0x0000000186EF6630-0x0000000186EF6640
		private void OnSuccessfulPianoRemotely() {} // 0x0000000186EF6640-0x0000000186EF6690
		public void PlayKey(int i) {} // 0x0000000186EF6690-0x0000000186EF68C0
		private static void PlaySoundForKey(int i) {} // 0x0000000186EF68C0-0x0000000186EF6B70
		public void Back() {} // 0x0000000186EF6B70-0x0000000186EF6CE0
		protected void OnDestroy() {} // 0x0000000186EF6CE0-0x0000000186EF6F10
		protected override void OnShowStart(GameObject g) {} // 0x0000000186EF6F10-0x0000000186EF74D0
		protected override void OnHideFinish(GameObject g) {} // 0x0000000186EF74D0-0x0000000186EF74F0
		protected override VampireSurvivors.Objects.Characters.CharacterController GetCharacterControllingUi() => default; // 0x0000000186EF74F0-0x0000000186EF7540
		private void FlyInNext() {} // 0x0000000186EF7540-0x0000000186EF76D0
		[IteratorStateMachine(typeof(_WaitForNextHint_d__35))]
		private IEnumerator WaitForNextHint(float wait) => default; // 0x0000000186EF76D0-0x0000000186EF7790
		private void FlyInEbony(int nextKey) {} // 0x0000000186EF7790-0x0000000186EF80E0
		private void FlyOutEbony() {} // 0x0000000186EF80E0-0x0000000186EF81C0
		private void FlyInPeachone(int nextKey) {} // 0x0000000186EF81C0-0x0000000186EF8B10
		private void FlyOutPeachone() {} // 0x0000000186EF8B10-0x0000000186EF8BF0
		private void Exit() {} // 0x0000000186EF8BF0-0x0000000186EF8EA0
		private void ExitSuccessfully() {} // 0x0000000186EF8EA0-0x0000000186EF9190
		private void ProcessPianoSuccess() {} // 0x0000000186EF6640-0x0000000186EF6690
		private void DoTheBigSpoop() {} // 0x0000000186EF9190-0x0000000186EF9400
	}
}

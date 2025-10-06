/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class DirectorPage : GameWindowedUIPage // TypeDefIndex: 14751
	{
		// Fields
		[SerializeField]
		private RectTransform _MaskContainer; // 0x158
		[SerializeField]
		private List<RectTransform> _MaskIcons; // 0x160
		[SerializeField]
		private UISpriteAnimation _BurstVFX; // 0x168
		[SerializeField]
		private RectTransform EasyButton; // 0x170
		[SerializeField]
		private RectTransform HardButton; // 0x178
		[SerializeField]
		private RectTransform OKButton; // 0x180
		private string langKey; // 0x188
		private int sceneFlag; // 0x190
		private bool _hasTrumpet; // 0x194
		private bool _hasMirror; // 0x195
		private SignalBus _signalBus; // 0x198
		private PlayerOptions _playerOptions; // 0x1A0
		private ParticleSystem _angryPfx1; // 0x1A8
		private ParticleSystem _angryPfx2; // 0x1B0
		private bool _angryPfxCreated; // 0x1B8
		private bool _hasSwitched; // 0x1B9
		private DG.Tweening.Sequence _shuffleSequence; // 0x1C0
		private DG.Tweening.Sequence _okButtonOutSequence; // 0x1C8
	
		// Constructors
		public DirectorPage() {} // 0x0000000186880260-0x0000000186880330
	
		// Methods
		[Inject]
		private void Construct(SignalBus signal, PlayerOptions player) {} // 0x000000018687B8D0-0x000000018687BEE0
		private void OnRemoteOkButton() {} // 0x000000018687BEE0-0x000000018687BEF0
		private void OnRemoteTooEasy() {} // 0x000000018687BEF0-0x000000018687BF00
		private void OnRemoteTooHard() {} // 0x000000018687BF00-0x000000018687BF10
		public void SelectTooEasy() {} // 0x000000018687BF10-0x000000018687C070
		private void OnSelectedTooEasy() {} // 0x000000018687C070-0x000000018687C1A0
		public void SelectTooHard() {} // 0x000000018687C1A0-0x000000018687C300
		private void OnSelectedTooHard() {} // 0x000000018687C300-0x000000018687C430
		protected void OnDestroy() {} // 0x000000018687C430-0x000000018687C750
		protected override void OnShowStart(GameObject g) {} // 0x000000018687C750-0x000000018687D8D0
		private void ShowPanels() {} // 0x000000018687D8D0-0x000000018687DE70
		protected override VampireSurvivors.Objects.Characters.CharacterController GetCharacterControllingUi() => default; // 0x000000018687DE70-0x000000018687DEC0
		private void TweenButtonIn(RectTransform b) {} // 0x000000018687DEC0-0x000000018687E120
		private DG.Tweening.Sequence TweenButtonOut(RectTransform b) => default; // 0x000000018687E120-0x000000018687E290
		private void DoMaskTween() {} // 0x000000018687E290-0x000000018687E630
		public void OKButtonClicked() {} // 0x000000018687E630-0x000000018687E790
		private void OnOkButtonClicked() {} // 0x000000018687E790-0x000000018687F1E0
		private void CreateAngryParticles() {} // 0x000000018687F1E0-0x0000000186880260
	}
}

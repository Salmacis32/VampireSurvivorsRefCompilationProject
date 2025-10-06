/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DarkTonic.MasterAudio;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Characters;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class CharacterFoundPage : BaseUIPage // TypeDefIndex: 14719
	{
		// Fields
		[SerializeField]
		private Image _Icon; // 0xE0
		[SerializeField]
		private TextMeshProUGUI _Name; // 0xE8
		[SerializeField]
		private TextMeshProUGUI _ThankYouText; // 0xF0
		[SerializeField]
		private RectTransform _TextPanel; // 0xF8
		[SerializeField]
		private GameObject _ThankYouTextPanel; // 0x100
		[SerializeField]
		private Image _BGFader; // 0x108
		[SerializeField]
		private Image _PanelDarkOverlay; // 0x110
		[SerializeField]
		private GameObject _DoneButton; // 0x118
		[SerializeField]
		private GameObject _OkButton; // 0x120
		[SerializeField]
		private GameObject _Ray; // 0x128
		[SerializeField]
		private Transform _RayContainer; // 0x130
		[SerializeField]
		private ParticleEmitterManager _Particles; // 0x138
		[SerializeField]
		private RectTransform _Panel; // 0x140
		[FormerlySerializedAs("_BGOverlay")]
		[SerializeField]
		private Image _BGAdditiveOverlay; // 0x148
		[SerializeField]
		private GameObject VFX; // 0x150
		private SignalBus _signalBus; // 0x158
		private DataManager _dataManager; // 0x160
		private CharacterData _unlockedCharacterData; // 0x168
		private VampireSurvivors.Data.CharacterType _unlockedCharacterType; // 0x170
		private List<Image> _ghosts; // 0x178
		private List<GameObject> _rays; // 0x180
		private Image _darkIcon; // 0x188
		private ParticleSystem _darkParticles; // 0x190
		private ParticleSystem _colorParticles; // 0x198
		private List<Tween> _tweens; // 0x1A0
		private GravityWell _gravityWell; // 0x1A8
		private VampireSurvivors.Objects.Characters.CharacterController _currentCharacter; // 0x1B0
		private bool _playDarkParticles; // 0x1B8
		private bool _canSkip; // 0x1B9
		private List<Tween> _toCompleteOnSkip; // 0x1C0
		private PlaySoundResult _openCoffinSoundResult; // 0x1C8
		private GravityWellConfig gravityWellCongfig; // 0x1D0
	
		// Constructors
		public CharacterFoundPage() {} // 0x00000001867BB560-0x00000001867BB800
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus, DataManager data) {} // 0x00000001867B1C60-0x00000001867B2280
		private void OnRevealCharacterRemotely() {} // 0x00000001867B2280-0x00000001867B2290
		private void OnCollectedCharacterRemotely() {} // 0x00000001867B2290-0x00000001867B22A0
		private void OnDestroy() {} // 0x00000001867B22A0-0x00000001867B25D0
		private void FixedUpdate() {} // 0x00000001867B25D0-0x00000001867B27C0
		public void CollectCharacter() {} // 0x00000001867B27C0-0x00000001867B2920
		private void PerformCollectCharacter() {} // 0x00000001867B2920-0x00000001867B2BD0
		private void AnimateOut() {} // 0x00000001867B2BD0-0x00000001867B3160
		public void Reveal() {} // 0x00000001867B3160-0x00000001867B3290
		private void PerformReveal() {} // 0x00000001867B3290-0x00000001867B38E0
		protected override void OnShowStart(GameObject g) {} // 0x00000001867B38E0-0x00000001867B5A80
		protected override VampireSurvivors.Objects.Characters.CharacterController GetCharacterControllingUi() => default; // 0x0000000185FA26F0-0x0000000185FA2700
		private void Skip() {} // 0x00000001867B5A80-0x00000001867B5F50
		protected override void OnHideFinish(GameObject g) {} // 0x00000001867B5F50-0x00000001867B6A40
		private void EnableDoneButton() {} // 0x00000001867B6A40-0x00000001867B6DE0
		private void CreateBlackParticles() {} // 0x00000001867B6DE0-0x00000001867B7AF0
		protected override void OnCancelPressed() {} // 0x00000001867B7AF0-0x00000001867B7B00
		private void MakeColorParticles() {} // 0x00000001867B7B00-0x00000001867B8820
		private void EnableOkButton() {} // 0x00000001867B8820-0x00000001867B8BC0
		private void DisableOkButton() {} // 0x00000001867B8BC0-0x00000001867B9050
		private void SaveCharacterData(GameplaySignals.CharacterFoundSignal sig) {} // 0x00000001867B9050-0x00000001867B92D0
		private void PlayGhosts() {} // 0x00000001867B92D0-0x00000001867B9FC0
		private void PlayFirework() {} // 0x00000001867B9FC0-0x00000001867BA420
		private void AddRays() {} // 0x00000001867BA420-0x00000001867BADE0
		private GameObject CreateRay(string color) => default; // 0x00000001867BADE0-0x00000001867BAF10
		private static Color hexToColor(string hex) => default; // 0x00000001867BAF10-0x00000001867BB560
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class FinalFireworksPage : BaseUIPage // TypeDefIndex: 14770
	{
		// Fields
		[SerializeField]
		private ParticleEmitterManager _PfxEmitter; // 0xE0
		[SerializeField]
		private ParticleEmitterManager _FireworksEmitter; // 0xE8
		[SerializeField]
		private RectTransform _OkButton; // 0xF0
		[SerializeField]
		private RectTransform _DoneButton; // 0xF8
		[SerializeField]
		private Image _BGFader; // 0x100
		[SerializeField]
		private Image _FGFader; // 0x108
		[SerializeField]
		private TextMeshProUGUI _PanelText; // 0x110
		[SerializeField]
		private RectTransform _Panel; // 0x118
		[SerializeField]
		private GameObject _RayPrefab; // 0x120
		[SerializeField]
		private RectTransform _RayContainer; // 0x128
		[SerializeField]
		private Image _FakeFireworkPanel; // 0x130
		[SerializeField]
		private RectTransform _ScaleContainer; // 0x138
		[SerializeField]
		private TextMeshProUGUI _Name; // 0x140
		[SerializeField]
		private TextMeshProUGUI _Description; // 0x148
		[SerializeField]
		private TextMeshProUGUI _Tips; // 0x150
		[SerializeField]
		private Image _Icon; // 0x158
		[SerializeField]
		private RectTransform _WeaponPanel; // 0x160
		private List<Image> _rays; // 0x168
		private List<Tween> _rayTweens; // 0x170
		private List<ParticleSystem> _fireworks; // 0x178
		private ParticleSystem _blackParticles; // 0x180
		private ParticleSystem _colorParticles; // 0x188
		private PlayerOptions _playerOptions; // 0x190
		private DataManager _data; // 0x198
		private List<string> _frames; // 0x1A0
	
		// Constructors
		public FinalFireworksPage() {} // 0x000000018688F880-0x000000018688FCF0
	
		// Methods
		[Inject]
		private void Construct(PlayerOptions player, DataManager data) {} // 0x000000018688B2A0-0x000000018688B360
		protected override void OnShowStart(GameObject g) {} // 0x000000018688B360-0x000000018688B950
		private void CreateBlackParticles() {} // 0x000000018688B950-0x000000018688CA10
		private void AddItemPanel() {} // 0x000000018688CA10-0x000000018688D260
		private void PlayReveal() {} // 0x000000018688D260-0x000000018688D660
		private void EnableDoneButton() {} // 0x000000018688D660-0x000000018688D870
		public void OnOKButtonClicked() {} // 0x000000018688D870-0x000000018688D9E0
		public void OnDoneClicked() {} // 0x000000018688D9E0-0x000000018688E170
		private void OnExitScene() {} // 0x000000018688E170-0x000000018688E2E0
		private void EnablePanelsInput() {} // 0x000000018688E2E0-0x000000018688E4F0
		private void AddRays() {} // 0x000000018688E4F0-0x000000018688EEA0
		private void StartFireworks() {} // 0x000000018688EEA0-0x000000018688F790
		private void PlayFirework(int i) {} // 0x000000018688F790-0x000000018688F880
	}
}

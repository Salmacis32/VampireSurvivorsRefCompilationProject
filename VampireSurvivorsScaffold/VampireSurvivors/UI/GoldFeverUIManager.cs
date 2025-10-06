/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class GoldFeverUIManager : MonoBehaviour // TypeDefIndex: 14794
	{
		// Fields
		[SerializeField]
		private Image _FillBackground; // 0x20
		[SerializeField]
		private Image _Panel; // 0x28
		[SerializeField]
		private Image _ProgressFill; // 0x30
		[SerializeField]
		private UnityEngine.UI.Text _RewardText; // 0x38
		[SerializeField]
		private UnityEngine.UI.Text _TimeLeft; // 0x40
		[SerializeField]
		private ParticleEmitterManager _Emitter; // 0x48
		[SerializeField]
		private RectTransform _Title; // 0x50
		[SerializeField]
		private GoldFeverFlashingLights _Lights; // 0x58
		[SerializeField]
		private Vector3 _TitleStartPos; // 0x60
		[SerializeField]
		private Vector3 _TitleEndPos; // 0x6C
		private DG.Tweening.Sequence _exitSequence1; // 0x78
		private DG.Tweening.Sequence _exitSequence2; // 0x80
		private Vector3 _RewardOriginPos; // 0x88
		private Vector3 _RewardScale; // 0x94
		private bool _isActive; // 0xA0
		private SignalBus _signalBus; // 0xA8
		private GoldFeverController _goldFever; // 0xB0
		private ParticleSystem _particles; // 0xB8
		private bool _emitterBuilt; // 0xC0
	
		// Properties
		public bool IsGoldFeverShowing { get; private set; } // 0x000000018293AC70-0x000000018293AC80 0x0000000186398B90-0x0000000186398BA0
	
		// Constructors
		public GoldFeverUIManager() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus, GoldFeverController fever) {} // 0x00000001868A3750-0x00000001868A3810
		private void Start() {} // 0x00000001868A3810-0x00000001868A38B0
		private void OnEnable() {} // 0x00000001868A38B0-0x00000001868A3C70
		private void OnDisable() {} // 0x00000001868A3C70-0x00000001868A3EA0
		private void Update() {} // 0x00000001868A3EA0-0x00000001868A4720
		public void Hide() {} // 0x00000001868A4720-0x00000001868A47A0
		public void Show() {} // 0x00000001868A47A0-0x00000001868A47D0
		private void FormatTitle(UISignals.GoldFeverCoinCollectedSignal sig) {} // 0x00000001868A47D0-0x00000001868A4CA0
		private void DoParticles(UISignals.EmitGoldFeverParticleSignal sig) {} // 0x00000001868A4CA0-0x00000001868A4ED0
		private void BuildEmitter() {} // 0x00000001868A4ED0-0x00000001868A57B0
		private void IntroTween() {} // 0x00000001868A57B0-0x00000001868A63D0
		private void ExitTween() {} // 0x00000001868A63D0-0x00000001868A6EC0
		private float Approach(float start, float end, float shift) => default; // 0x00000001868A6EC0-0x00000001868A6F70
	}
}

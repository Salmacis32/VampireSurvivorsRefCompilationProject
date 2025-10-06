/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class GospelManager : MonoBehaviour // TypeDefIndex: 14797
	{
		// Fields
		[SerializeField]
		private Image _Clap; // 0x20
		[SerializeField]
		private UISpriteAnimation _ClapInAnim; // 0x28
		[SerializeField]
		private UISpriteAnimation _ClapOutAnim; // 0x30
		[SerializeField]
		private ParticleEmitterManager _ParticleEmitter; // 0x38
		[CanBeNull]
		[SerializeField]
		private Image _Panel; // 0x40
		private int _claps; // 0x48
		private int _maxClaps; // 0x4C
		private Action _callback; // 0x50
		private List<ParticleSystem> _particles; // 0x58
		private GravityWell _gravityWell; // 0x60
		private PlayerOptions _playerOptions; // 0x68
		private List<string> _frames; // 0x70
	
		// Constructors
		public GospelManager() {} // 0x00000001868A8530-0x00000001868A87E0
	
		// Methods
		[Inject]
		private void Construct(PlayerOptions player) {} // 0x00000001827660A0-0x0000000182766100
		public void PlayEffect(Action cb = null) {} // 0x00000001868A70A0-0x00000001868A7260
		private void Clap() {} // 0x00000001868A7260-0x00000001868A7610
		private void BuildFireworks() {} // 0x00000001868A7610-0x00000001868A81F0
		private void SetRandomPosition(ParticleSystem ps) {} // 0x00000001868A81F0-0x00000001868A8320
		private void PlayFirework(int i) {} // 0x00000001868A8320-0x00000001868A8530
	}
}

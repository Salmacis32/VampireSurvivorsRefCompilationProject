/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DG.Tweening.Core;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using VampireSurvivors.Signals;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	[Serializable]
	public class DirecterManager // TypeDefIndex: 15331
	{
		// Fields
		private Background6 _background6; // 0x10
		private VampireSurvivors.Objects.Stage _stage; // 0x18
		private int _currentPhase; // 0x20
		private float _combatTimer; // 0x24
		private List<Tween> _bgmTimers; // 0x28
		private Tween _timer0; // 0x30
		private bool _quickDebug; // 0x38
		private bool _startedPhase2; // 0x39
		private bool _startedPhase4; // 0x3A
		private bool _startedPhase3; // 0x3B
		private bool _startedPhase5; // 0x3C
		private AudioSource _currentBgm; // 0x40
		private float _volume; // 0x48
		private DirecterAudioManager _directerAudioManager; // 0x50
		private List<List<float>> _delays; // 0x58
		private List<BgmType> _soundKeys; // 0x60
		private const float ThresholdPhase1 = 30.000002f; // Metadata: 0x01977575
		private const float ThresholdPhase2 = 60.000004f; // Metadata: 0x01977579
		private const float ThresholdPhase3 = 60.000004f; // Metadata: 0x0197757D
		private const float ThresholdPhase4 = 45.000004f; // Metadata: 0x01977581
		private const float _soundTweenDuration = 0.85f; // Metadata: 0x01977585
	
		// Constructors
		public DirecterManager() {} // Dummy constructor
		public DirecterManager(Background6 background6) {} // 0x0000000186B814D0-0x0000000186B82320
	
		// Methods
		public void Update(float deltaTime) {} // 0x0000000186B82320-0x0000000186B82A20
		private static void ResetPlayersGrowth() {} // 0x0000000186B82A20-0x0000000186B82C10
		private void ResetMasks() {} // 0x0000000186B82C10-0x0000000186B82C60
		public void Cleanup() {} // 0x0000000186B82C60-0x0000000186B82D40
		public void StartPhase0() {} // 0x0000000186B82D40-0x0000000186B83050
		private void OnOnlineStageSwitch(OnlineSignals.OnDirecterStageSwitch newPhase) {} // 0x0000000186B83050-0x0000000186B83270
		private Tween SetTimeout(float delay, TweenCallback callback) => default; // 0x0000000186B83270-0x0000000186B83330
		private void CheckTime1(int soundPhase, int phaseSwitch, bool fadeIn = true /* Metadata: 0x01977574 */) {} // 0x0000000186B83330-0x0000000186B83B00
		private static void DestroySound(AudioSource sound1) {} // 0x0000000186B83B00-0x0000000186B83C30
		private void PerformChangePhase(int soundPhase, int phaseSwitch) {} // 0x0000000186B83C30-0x0000000186B83DD0
		private void RemoveTimers() {} // 0x0000000186B83DD0-0x0000000186B83F00
		private void ChangePhase() {} // 0x0000000186B83F00-0x0000000186B83FE0
		private void StartPhase1() {} // 0x0000000186B83FE0-0x0000000186B841D0
		private void StartPhase2() {} // 0x0000000186B841D0-0x0000000186B847B0
		private void SetParticlesVelocity(ParticleSystem ps, float yVel) {} // 0x0000000186B847B0-0x0000000186B84A50
		private void StartPhase3() {} // 0x0000000186B84A50-0x0000000186B84FE0
		private void StartPhase4() {} // 0x0000000186B84FE0-0x0000000186B85630
		private void StartPhase5() {} // 0x0000000186B85630-0x0000000186B85C90
	}
}

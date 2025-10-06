/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DG.Tweening.Core;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	public class WhiteHandManager : GameMonoBehaviour // TypeDefIndex: 17543
	{
		// Fields
		private Camera _mainCamera; // 0x28
		private GameManager _gameManager; // 0x30
		private GameSessionData _gameSessionData; // 0x38
		private bool _triggered; // 0x40
		private bool _kill; // 0x41
		private float _bellTime; // 0x44
		private DG.Tweening.Sequence _bellTollEvent; // 0x48
		private PhaserSprite _whiteHand; // 0x50
	
		// Constructors
		public WhiteHandManager() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		[Inject]
		private void Construct(GameManager gameManager, GameSessionData gameSessionData) {} // 0x00000001873566B0-0x0000000187356770
		private new void Awake() {} // 0x0000000187356770-0x00000001873567E0
		protected override void OnUpdate() {} // 0x00000001873567E0-0x0000000187356AF0
		public void SummonWhiteHand(bool forceStageTimerEnd = false /* Metadata: 0x01978719 */) {} // 0x0000000187356AF0-0x00000001873572E0
		private void ZoomOnPlayer() {} // 0x00000001873572E0-0x0000000187357300
		private void SpawnWhiteHand(bool forceStageTimerEnd = false /* Metadata: 0x0197871A */) {} // 0x0000000187357300-0x00000001873578E0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using QFSW.MOP2;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.VFX.Gizmos
{
	public class LevelUpGizmo : PoolableMonoBehaviour // TypeDefIndex: 15202
	{
		// Fields
		[SerializeField]
		private Transform _TextParent; // 0x30
		[SerializeField]
		private SpriteRenderer _Blur; // 0x38
		[HideInInspector]
		public float _YOffset; // 0x40
		private ParticleEmitterManager _particleEmitterManager; // 0x48
		private ParticleSystem _pfxEmitter; // 0x50
		private VampireSurvivors.Objects.Characters.CharacterController _activePlayer; // 0x58
		private bool _hasSetupEmitter; // 0x60
		private bool _defaultBlurPositionSet; // 0x61
		private Vector3 _blurDefaultLocalPosition; // 0x64
	
		// Properties
		private Vector2 PlayerPos { get => default; } // 0x0000000186A8F870-0x0000000186A8F950 
	
		// Constructors
		public LevelUpGizmo() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		private void Update() {} // 0x0000000186A8F950-0x0000000186A8FB90
		public void Init(VampireSurvivors.Objects.Characters.CharacterController activePlayer) {} // 0x0000000186A8FB90-0x0000000186A8FCD0
		private void SetupEmitter() {} // 0x0000000186A8FCD0-0x0000000186A908C0
		public void Play() {} // 0x0000000186A908C0-0x0000000186A90BC0
		private void AnimateLevelUpText() {} // 0x0000000186A90BC0-0x0000000186A91370
		private MultiTargetTween AnimateBlur() => default; // 0x0000000186A91370-0x0000000186A91770
		private void Despawn() {} // 0x0000000184E3DC10-0x0000000184E3DC80
	}
}

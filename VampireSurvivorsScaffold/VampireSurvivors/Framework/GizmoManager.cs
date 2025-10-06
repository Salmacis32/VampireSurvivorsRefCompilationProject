/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using QFSW.MOP2;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	public class GizmoManager : IInitializable, IDisposable, ITickable // TypeDefIndex: 17490
	{
		// Fields
		public float AngelYOffset; // 0x10
		public float IconYOffset; // 0x14
		public float LevelUpYOffset; // 0x18
		[Inject]
		private GameSessionData _gameSessionData; // 0x20
		private GameObject _particlesObject; // 0x28
		private ParticleEmitterManager _particleEmitterManager; // 0x30
		private ParticleSystem _pfxEmitter; // 0x38
		private ParticleSystem _quickTreasureEmitter; // 0x40
		private List<Sprite> _angelFrames; // 0x48
		private PhaserSprite _highlight; // 0x50
		private PhaserSprite _rainbow; // 0x58
		private MultiTargetTween _highlightTween; // 0x60
		private MultiTargetTween _highlightTween2; // 0x68
		private MultiTargetTween _rainbowTween; // 0x70
		private MultiTargetTween _rainbowTween2; // 0x78
	
		// Constructors
		public GizmoManager() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void Initialize() {} // 0x0000000187325C40-0x0000000187325C60
		public void Dispose() {} // 0x0000000180B15170-0x0000000180B15180
		public void Tick() {} // 0x0000000180B15170-0x0000000180B15180
		public void ShowHighlightAt(float x, float y) {} // 0x0000000187325C60-0x0000000187326760
		public void DisplayLevelUp(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x0000000187326760-0x0000000187326A00
		public void DisplayLimitBreakLevelUp(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x0000000187326A00-0x0000000187326AF0
		public void DisplayMultiplayerRevive(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x0000000187326AF0-0x0000000187326BD0
		public void DisplayWeaponLevelup(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x0000000187326BD0-0x0000000187326CB0
		public void DisplayWeaponIconOverhead(WeaponType weaponType, string value, Color? color, VampireSurvivors.Objects.Characters.CharacterController character, float displayTimeMultiplier = 1f /* Metadata: 0x0197869D */, Vector2 vOffset = default) {} // 0x0000000187326CB0-0x0000000187326E60
		public void DisplayIconOverhead(string frameName, string value, Color? color, VampireSurvivors.Objects.Characters.CharacterController character, float displayTimeMultiplier = 1f /* Metadata: 0x019786A1 */, Vector2 vOffset = default, string textureName = "items" /* Metadata: 0x019786A5 */) {} // 0x0000000187326E60-0x0000000187327040
		public void DisplayQuickTreasureChestAnimation(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x0000000187327040-0x0000000187327330
		private void Init() {} // 0x0000000187325C40-0x0000000187325C60
		private void InitLevelUp() {} // 0x0000000187327330-0x0000000187328000
		private void InitQuickTreasureChest() {} // 0x0000000187328000-0x0000000187328940
		private void DisplayAngel(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x0000000187328940-0x0000000187329090
	}
}

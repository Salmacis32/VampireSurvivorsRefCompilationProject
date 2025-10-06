/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterControllerRamba : CharacterController // TypeDefIndex: 16961
	{
		// Fields
		[SerializeField]
		private bool _DebugAutoMorph; // 0x3F0
		private const VampireSurvivors.Data.ItemType MorphRelic = VampireSurvivors.Data.ItemType.RELIC_LAZULIA; // Metadata: 0x01977F56
		private const float BonusAmount = 1f; // Metadata: 0x01977F58
		private const float BonusArmor = 2f; // Metadata: 0x01977F5C
		private const float BonusMaxHP = 100f; // Metadata: 0x01977F60
		private MorphVFX _morphVFX; // 0x3F8
		private bool _isMorphed; // 0x400
		private ParticleEmitterManager _pfxManager; // 0x408
		private ParticleSystem _twinklePfx; // 0x410
		private ParticleSystem _cartPfx; // 0x418
		private PhaserSprite _cartFront; // 0x420
		private PhaserSprite _cartBack; // 0x428
		private MultiTargetTween _tintTween; // 0x430
		private List<uint> _tints; // 0x438
		private int _tintCounter; // 0x440
	
		// Properties
		public bool MorphAbilityUnlocked { get => default; } // 0x00000001871227C0-0x00000001871228D0 
		public bool IsMorphed { get => default; } // 0x00000001871228D0-0x00000001871228E0 
		public bool EnableTintTween { get => default; } // 0x0000000181958370-0x0000000181958380 
		public bool EnableTwinklePfx { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		public bool SitsOnCart { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	
		// Constructors
		public CharacterControllerRamba() {} // 0x00000001871242A0-0x0000000187124490
	
		// Methods
		public override void LevelUp() {} // 0x00000001871228E0-0x0000000187122A00
		protected override void OnUpdate() {} // 0x0000000187122A00-0x0000000187122A60
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977F4F */) {} // 0x0000000187122A60-0x0000000187122C50
		private void CheckForMorph() {} // 0x0000000187122C50-0x0000000187122D60
		private void MorphedOnStop() {} // 0x00000001871208C0-0x0000000187120900
		private void MakeMorphVFX() {} // 0x0000000187122D60-0x0000000187122FD0
		protected override void OnStop() {} // 0x0000000187122FD0-0x0000000187123020
		public override void OnDeath() {} // 0x0000000187123020-0x0000000187123060
		public override void Revive(float percentage = 1f /* Metadata: 0x01977F50 */, bool instantRevival = false /* Metadata: 0x01977F54 */) {} // 0x0000000187123060-0x00000001871230A0
		private void Morph() {} // 0x00000001871230A0-0x0000000187123890
		private void SpawnCart() {} // 0x0000000187123890-0x0000000187123900
		private void DoTintTween() {} // 0x0000000187123900-0x0000000187123DB0
		private void GenerateTwinklePfx() {} // 0x0000000187123DB0-0x0000000187123EC0
		private void GenerateCartPfx() {} // 0x0000000187123EC0-0x0000000187123F80
		private void UpdateCartPfx() {} // 0x0000000187123F80-0x0000000187123FB0
		private void UpdateDepths() {} // 0x0000000187123FB0-0x0000000187124250
		private void PlayTwinklePfx(bool play = true /* Metadata: 0x01977F55 */) {} // 0x0000000187124250-0x0000000187124280
		public override void Despawn() {} // 0x0000000187124280-0x00000001871242A0
	}
}

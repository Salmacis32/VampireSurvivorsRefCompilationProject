/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.App.Objects;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pickups;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class BackgroundBatCountry : BackgroundManager // TypeDefIndex: 15249
	{
		// Fields
		[HideInInspector]
		public float _LerpV; // 0x80
		private bool _canChangeColor; // 0x84
		private bool _fixedBgColor; // 0x85
		private int _colorIndex; // 0x88
		private float2 _center; // 0x8C
		private readonly uint[] _colorsTop; // 0x98
		private readonly uint[] _colorsBottom; // 0xA0
		private GottaSphereFast _sphereImage; // 0xA8
		private RainbowCheckerboard _checkerboardImage; // 0xB0
		private MultiTargetTween _sphereAlphaTween; // 0xB8
		private MultiTargetTween _checkerboardAlphaTween; // 0xC0
		private VampireSurvivors.Framework.TimerSystem.Timer _colorChangeTimeout; // 0xC8
		private PhaserSprite _backgroundTile; // 0xD0
		private VampireSurvivors.Framework.TimerSystem.Timer _pizzaDelayTimer; // 0xD8
		private bool _customBG; // 0xE0
		private bool _canPizza; // 0xE1
		private bool _isTilesetVisible; // 0xE2
		private bool _isCheckerBoardVisible; // 0xE3
		private bool _isSphereVisible; // 0xE4
		private Circle _pizzaA; // 0xE8
		private PhaserSprite _pizzaAsprite; // 0xF0
		private PhaserSprite _pizzaBsprite; // 0xF8
		private Circle _pizzaB; // 0x100
		private PhaserSprite _pizzaCsprite; // 0x108
		private Circle _pizzaC; // 0x110
		private MapToken _mapToken; // 0x118
		private VampireSurvivors.Framework.TimerSystem.Timer _checkSecretTimer; // 0x120
	
		// Constructors
		public BackgroundBatCountry() {} // 0x0000000186AD6910-0x0000000186AD6AA0
	
		// Methods
		protected override void OnUpdate() {} // 0x0000000186AD2020-0x0000000186AD21C0
		public override void Cleanup() {} // 0x0000000186AD21C0-0x0000000186AD2210
		public override void Create() {} // 0x0000000186AD2210-0x0000000186AD2240
		public override void OnInitCompleted() {} // 0x0000000186AD2240-0x0000000186AD2680
		public override void CheckMinute(int minute) {} // 0x0000000186AD2680-0x0000000186AD2870
		private void InitBackground() {} // 0x0000000186AD2870-0x0000000186AD2C30
		private void InitVFX() {} // 0x0000000186AD2C30-0x0000000186AD3100
		private void StartColorChange() {} // 0x0000000186AD3100-0x0000000186AD3550
		private void GetCenter() {} // 0x0000000186AD3550-0x0000000186AD36B0
		private void ChangeColor() {} // 0x0000000186AD36B0-0x0000000186AD3B60
		public override void DisableMovingBackground() {} // 0x0000000186AD3B60-0x0000000186AD3BD0
		public override void EnableMovingBackground() {} // 0x0000000186AD3BD0-0x0000000186AD3C40
		private void FadeSphere(float value, float duration) {} // 0x0000000186AD3C40-0x0000000186AD40D0
		private void FadeCheckerboard(float value, float duration) {} // 0x0000000186AD40D0-0x0000000186AD4560
		private void BonusRound() {} // 0x0000000186AD4560-0x0000000186AD4660
		private void EndBonusRound() {} // 0x0000000186AD4660-0x0000000186AD4760
		private void FadeTileset(float alpha = 1f /* Metadata: 0x01977482 */, float durationMillis = 1000f /* Metadata: 0x01977486 */) {} // 0x0000000186AD4760-0x0000000186AD47F0
		private void SpawnRelicInConcrete(VampireSurvivors.Data.ItemType relicType) {} // 0x0000000186AD47F0-0x0000000186AD4930
		private void DisplayWarningZone() {} // 0x0000000186AD4930-0x0000000186AD4DA0
		private void SingleWarning(float2 position) {} // 0x0000000186AD4DA0-0x0000000186AD5220
		public void MakePizza() {} // 0x0000000186AD5220-0x0000000186AD59F0
		public void CheckPizzas(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x0000000186AD59F0-0x0000000186AD5BF0
		public void AnimPizza(PhaserSprite pizzaSprite) {} // 0x0000000186AD5BF0-0x0000000186AD5E80
		public void DelayPizza() {} // 0x0000000186AD5E80-0x0000000186AD5F80
		public void MakeRings() {} // 0x0000000186AD5F80-0x0000000186AD6400
		public void CheckSecret() {} // 0x0000000186AD6400-0x0000000186AD6910
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class GoldFingerManager // TypeDefIndex: 13934
	{
		// Fields
		private PhaserScene _scene; // 0x10
		private CharacterController _player; // 0x18
		private PhaserSprite _fogRays; // 0x20
		private PhaserSprite _logoSprite; // 0x28
		private PhaserSprite _logoSpriteShadow; // 0x30
		private PhaserSprite _clapSpriteL; // 0x38
		private PhaserSprite _clapSpriteR; // 0x40
		private BitmapText _totalText; // 0x48
		private float _targetScale; // 0x50
		private int _awardReached; // 0x54
		private float _elapsedGfBonusTime; // 0x58
		private float _gFCooldownBonus; // 0x5C
		private float _startingEnemiesCounter; // 0x60
		private int _shadowBumps; // 0x64
		private int _previousAwardReached; // 0x68
		private float _gfEndInvulBonusTime; // 0x6C
		private MultiTargetTween _logoTween1; // 0x70
		private MultiTargetTween _logoTween2; // 0x78
		private MultiTargetTween _logoTween3; // 0x80
		private MultiTargetTween _exitTween; // 0x88
		private MultiTargetTween _clapTweenL; // 0x90
		private MultiTargetTween _clapTweenR; // 0x98
		private MultiTargetTween _clapAlphaTween; // 0xA0
		private MultiTargetTween _shadowTween; // 0xA8
		private List<float> _fontScales; // 0xB0
		private List<uint> _fontTints; // 0xB8
		private List<int> _thresholds; // 0xC0
		private List<string> _frames; // 0xC8
		private const float GfDuration = 10000f; // Metadata: 0x01976BCF
	
		// Properties
		private float GFDurationWithBonus { get => default; } // 0x00000001865CED50-0x00000001865CEFA0 
	
		// Constructors
		public GoldFingerManager() {} // Dummy constructor
		public GoldFingerManager(PhaserScene scene) {} // 0x00000001865CEFA0-0x00000001865CFA20
	
		// Methods
		public void ActivateGoldFinger(CharacterController targetPlayer) {} // 0x00000001865CFA20-0x00000001865D16F0
		public void GoldenFingerUpdate() {} // 0x00000001865D16F0-0x00000001865D2BD0
		private void GiveAward(int award = 0 /* Metadata: 0x01976BCC */) {} // 0x00000001865D2BD0-0x00000001865D39F0
		private void DoExitAnimation() {} // 0x00000001865D39F0-0x00000001865D45F0
		private float CurrentEnemiesCounter() => default; // 0x00000001865D45F0-0x00000001865D4670
		private void MakeItem(List<VampireSurvivors.Data.ItemType> choices) {} // 0x00000001865D4670-0x00000001865D4800
		private void GiveRandomWeapon(List<WeaponType> choices) {} // 0x00000001865D4800-0x00000001865D4D00
		private void SendCoins(bool isRandomType = false /* Metadata: 0x01976BCD */, int totalCoins = 32 /* Metadata: 0x01976BCE */) {} // 0x00000001865D4D00-0x00000001865D5720
		private static float Approach(float start, float end, float shift) => default; // 0x00000001865D5720-0x00000001865D5740
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyCosmicEgg : EnemyRedBlue // TypeDefIndex: 17281
	{
		// Fields
		private bool _hasGeneratedSprites; // 0x280
		private bool _damageDone; // 0x281
		private float _infiniteCorridorTime; // 0x284
		private float _infiniteCorridorDelay; // 0x288
		private float _worldScreenHeight; // 0x28C
		private PhaserSprite _wingL; // 0x290
		private PhaserSprite _wingR; // 0x298
		private PhaserSprite _eye; // 0x2A0
		private PhaserSprite _corridorBg; // 0x2A8
		private PhaserSprite _corridorLight; // 0x2B0
		private MultiTargetTween _spritesDeathTween; // 0x2B8
		private MultiTargetTween _icLightTween; // 0x2C0
		private MultiTargetTween _icAngleTween; // 0x2C8
		private MultiTargetTween _icScaleTween; // 0x2D0
		private const string FrameNameEyeBlue = "CEye_i01.png"; // Metadata: 0x01978375
		private const string FrameNameEyeRed = "CEyeRed_i01.png"; // Metadata: 0x01978382
		private const string FrameNameEggBlue = "CEgg_i01.png"; // Metadata: 0x01978392
		private const string FrameNameEggRed = "CEggRed_i01.png"; // Metadata: 0x0197839F
		private const string FrameNameWing = "Wing_i01.png"; // Metadata: 0x019783AF
	
		// Properties
		protected override List<uint> Tints { get; } // 0x0000000186753AB0-0x0000000186753AC0 
	
		// Constructors
		public EnemyCosmicEgg() {} // 0x00000001872347B0-0x0000000187234930
	
		// Methods
		protected override void Awake() {} // 0x0000000187232190-0x00000001872321C0
		protected override void OnUpdate() {} // 0x00000001872321C0-0x0000000187232340
		public override void Disappear() {} // 0x0000000187232340-0x00000001872323A0
		protected override void Die() {} // 0x00000001872323A0-0x00000001872326E0
		public override void Despawn() {} // 0x00000001872326E0-0x0000000187232740
		protected override void OnRecycleEnemy() {} // 0x0000000187232740-0x0000000187232AD0
		private void GenerateSpritesAndAnimations() {} // 0x0000000187232AD0-0x0000000187233730
		private void UpdateSprites() {} // 0x0000000187233730-0x0000000187233A80
		private void CastInfiniteCorridor() {} // 0x0000000187233A80-0x00000001872344E0
		public override void TurnBlue() {} // 0x00000001872344E0-0x0000000187234650
		public override void TurnRed() {} // 0x0000000187234650-0x00000001872347B0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Unity.Mathematics;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class FixWiringWeapon : Weapon // TypeDefIndex: 16193
	{
		// Fields
		private int currentLineNum; // 0x158
		private List<FixWiringProjectile> _wireList; // 0x160
		private List<uint> _colourList; // 0x168
		private List<int> _remainingWireList; // 0x170
		private List<float2> _wireLeftPosY; // 0x178
		private List<float2> _wireRightPosY; // 0x180
		private List<PhaserSprite> _leftSprites; // 0x188
		private List<PhaserSprite> _rightSprites; // 0x190
		private List<PhaserSprite> _endCapRightSprites; // 0x198
		private MultiTargetTween alphaTween; // 0x1A0
		public int failedAttempts; // 0x1A8
		private BulletPool _wireSparkPool; // 0x1B0
		private VampireSurvivors.Framework.TimerSystem.Timer _completeTimer; // 0x1B8
	
		// Constructors
		public FixWiringWeapon() {} // 0x0000000186F56DD0-0x0000000186F57260
	
		// Methods
		public override float SecondaryPPower() => default; // 0x0000000184E5D5E0-0x0000000184E5D600
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F50C20-0x0000000186F513E0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BB5 */) {} // 0x0000000186F513E0-0x0000000186F51770
		public void ScreenShake() {} // 0x0000000186F51770-0x0000000186F51C90
		public void LineComplete() {} // 0x0000000186F51C90-0x0000000186F52270
		public override void Cleanup() {} // 0x0000000186F52270-0x0000000186F52800
		private void shufflePositions() {} // 0x0000000186F52800-0x0000000186F52C20
		private void drawSides() {} // 0x0000000186F52C20-0x0000000186F53850
		private void shuffleWirePositions() {} // 0x0000000186F53850-0x0000000186F54B40
		private void setWireCaps() {} // 0x0000000186F54B40-0x0000000186F54D80
		private void fireSpark(FixWiringProjectile wire, float speedMultiplier = 1f /* Metadata: 0x01977BB6 */) {} // 0x0000000186F54D80-0x0000000186F550F0
		private void PickNewTarget() {} // 0x0000000186F550F0-0x0000000186F55510
		private void checkIfAllLinesComplete() {} // 0x0000000186F55510-0x0000000186F55A20
		private void HideWeapon() {} // 0x0000000186F55A20-0x0000000186F561D0
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F561D0-0x0000000186F563D0
		public override void SetVisible(bool visible) {} // 0x0000000186F563D0-0x0000000186F56DD0
	}
}

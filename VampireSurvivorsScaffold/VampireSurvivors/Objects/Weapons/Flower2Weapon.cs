/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class Flower2Weapon : Weapon // TypeDefIndex: 16683
	{
		// Fields
		public float BoomBallExplodingSpeed; // 0x158
		public float BoomBallMAXRADIUS; // 0x15C
		private float _mul; // 0x160
		private bool _explosionTriggered; // 0x164
		private VampireSurvivors.Framework.TimerSystem.Timer _chainTimer; // 0x168
		private bool _canChainExplosion; // 0x170
		[NonSerialized]
		public float WORLD_RIGHT; // 0x174
		[NonSerialized]
		public float WORLD_LEFT; // 0x178
		[NonSerialized]
		public float WORLD_TOP; // 0x17C
		[NonSerialized]
		public float WORLD_BOTTOM; // 0x180
		private BulletPool _boomBallPool; // 0x188
		[NonSerialized]
		public PhysicsGroup _activeBalls; // 0x190
		private float _firingTimes; // 0x198
		private List<Vector2> _positions; // 0x1A0
		private List<float> _offsetsX; // 0x1A8
		private List<float> _offsetsY; // 0x1B0
		private PhaserSprite _sprCore; // 0x1B8
		private PhaserSprite _sprFlower; // 0x1C0
		private PhaserSprite _sprPond; // 0x1C8
		private PhaserSprite _sprSplash; // 0x1D0
		private PhaserSprite _sprGrass; // 0x1D8
		private bool _hasFlex; // 0x1E0
		private bool _hasCharacterFlex; // 0x1E1
	
		// Constructors
		public Flower2Weapon() {} // 0x0000000187076390-0x0000000187076400
	
		// Methods
		protected override void OnStart() {} // 0x0000000187072C50-0x0000000187072EC0
		public void createFlex() {} // 0x0000000187072EC0-0x0000000187073BA0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000187073BA0-0x0000000187073E30
		private void PrepareArrays(float amount) {} // 0x0000000187073E30-0x0000000187074430
		public override void InternalUpdate() {} // 0x0000000187074430-0x0000000187074690
		protected override void OnUpdate() {} // 0x0000000187074690-0x00000001870746C0
		private void LateUpdate() {} // 0x00000001870746C0-0x00000001870747C0
		private void UpdateFlex() {} // 0x00000001870747C0-0x00000001870748B0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977DCC */) {} // 0x00000001870748B0-0x0000000187074E10
		private void DetonateBoomBalls() {} // 0x0000000187074E10-0x0000000187075070
		private bool onBulletOverlapsBullet(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000187075070-0x00000001870751E0
		public override void ResetFiringTimer() {} // 0x0000000186F292B0-0x0000000186F292D0
		public override void CheckArcanas() {} // 0x00000001870751E0-0x0000000187075440
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000187075440-0x0000000187075880
		protected bool onBoomBallOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000187075880-0x0000000187075D30
		public bool CircleOnCircle(float2 v1, float r1, float2 v2, float r2) => default; // 0x0000000187075D30-0x0000000187075D90
		public override void Cleanup() {} // 0x0000000187075D90-0x0000000187076070
		public override void SetVisible(bool visible) {} // 0x0000000187076070-0x0000000187076390
	}
}

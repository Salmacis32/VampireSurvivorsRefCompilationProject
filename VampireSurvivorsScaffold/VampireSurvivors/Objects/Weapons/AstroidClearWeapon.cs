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
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class AstroidClearWeapon : Weapon // TypeDefIndex: 16190
	{
		// Fields
		[NonSerialized]
		public PhaserSprite _crosshairSprite; // 0x158
		private PhaserSprite _bulletSprite1; // 0x160
		private PhaserSprite _bulletSprite2; // 0x168
		private List<PhaserSprite> _asteroidSprites; // 0x170
		private List<bool> _asteroidActive; // 0x178
		private List<bool> _asteroidShootable; // 0x180
		private List<Vector2> _asteroidVelocity; // 0x188
		private List<float> _asteroidRotation; // 0x190
		private MultiTargetTween _moveTween; // 0x198
		private int _asteroidHitNum; // 0x1A0
		[NonSerialized]
		public float CrosshairOffsetX; // 0x1A4
		[NonSerialized]
		public float CrosshairOffsetY; // 0x1A8
		private int _maxAsteroids; // 0x1AC
		private MultiTargetTween explodeScaleTween; // 0x1B0
		private float sureFire; // 0x1B8
		private bool justFired; // 0x1BC
	
		// Constructors
		public AstroidClearWeapon() {} // 0x0000000186F508E0-0x0000000186F50950
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F4B890-0x0000000186F4C970
		public override void Cleanup() {} // 0x0000000186F4C970-0x0000000186F4CBB0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BB4 */) {} // 0x0000000186F4CBB0-0x0000000186F4CEE0
		private void fireAsteroid(int asteroidInt, bool shootable) {} // 0x0000000186F4CEE0-0x0000000186F4D110
		private Vector2 getBorderPosition() => default; // 0x0000000186F4D110-0x0000000186F4D330
		private Vector2 getRandomCentralPoint() => default; // 0x0000000186F4D330-0x0000000186F4D550
		private int getNextAvailableAsteroid() => default; // 0x0000000186F4D550-0x0000000186F4D600
		private int findClosestCentralAsteroid() => default; // 0x0000000186F4D600-0x0000000186F4DB40
		private void moveTarget() {} // 0x0000000186F4DB40-0x0000000186F4E810
		private void checkAsteroidCollision() {} // 0x0000000186F4E810-0x0000000186F4F250
		private void AsteroidExplode() {} // 0x0000000186F4F250-0x0000000186F4FB20
		private void OnExplodeComplete(int asteroidNum) {} // 0x0000000186F4FB20-0x0000000186F4FC10
		private void LateUpdate() {} // 0x0000000186F4FC10-0x0000000186F507B0
		public override void SetVisible(bool visible) {} // 0x0000000186F507B0-0x0000000186F508E0
	}
}

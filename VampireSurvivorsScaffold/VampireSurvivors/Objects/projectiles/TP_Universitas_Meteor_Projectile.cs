/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Universitas_Meteor_Projectile : Projectile // TypeDefIndex: 15701
	{
		// Fields
		private float _radius; // 0xD0
		private PhaserSprite _animatedSprite; // 0xD8
		private Tween _radiusTween; // 0xE0
		private float startingScale; // 0xE8
		private MultiTargetTween _alphaTween; // 0xF0
	
		// Constructors
		public TP_Universitas_Meteor_Projectile() {} // 0x0000000186D3D430-0x0000000186D3D490
	
		// Methods
		protected override void Awake() {} // 0x0000000186D3CA00-0x0000000186D3CD50
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D3CD50-0x0000000186D3D2C0
		private void LateUpdate() {} // 0x0000000186D3D2C0-0x0000000186D3D400
		public override void Despawn() {} // 0x0000000186D3D400-0x0000000186D3D430
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Slash1Projectile : Projectile // TypeDefIndex: 15662
	{
		// Fields
		[SerializeField]
		private SpriteTrail _Trail; // 0xD0
		private Tween _angleTween; // 0xD8
		private Tween _accelTween; // 0xE0
		private Tween _backwardsTween; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _cullingTimer; // 0xF0
		private const float AccelForward = 2f; // Metadata: 0x0197779F
		private const float AccelBack = -4f; // Metadata: 0x019777A3
		private float _acceleration; // 0xF8
		private Vector2 _velocity; // 0xFC
		private VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0x108
		private bool _isGoingBack; // 0x110
		private float _accumulatedTime; // 0x114
		private MultiTargetTween _despawnTween; // 0x118
		private bool _isDespawning; // 0x120
		private float2 offset; // 0x124
	
		// Constructors
		public TP_Slash1Projectile() {} // 0x0000000186D1A0C0-0x0000000186D1A160
	
		// Methods
		protected override void Awake() {} // 0x0000000186D18EA0-0x0000000186D18F40
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D18F40-0x0000000186D195F0
		public override void InternalUpdate() {} // 0x0000000186D195F0-0x0000000186D19900
		private void GoBackwards() {} // 0x0000000186D19900-0x0000000186D19D10
		public void StartDespawn() {} // 0x0000000186D19D10-0x0000000186D19FD0
		public void OwnerHit() {} // 0x0000000186D19FD0-0x0000000186D19FF0
		public override void Despawn() {} // 0x0000000186D19FF0-0x0000000186D1A0C0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_StarFlail2_Projectile : Projectile // TypeDefIndex: 15687
	{
		// Fields
		private float _angleTime; // 0xD0
		private VampireSurvivors.Framework.TimerSystem.Timer _swingTimer; // 0xD8
		private MultiTargetTween _alphaTween; // 0xE0
		private MultiTargetTween _scaleTween; // 0xE8
		private float _multiplier; // 0xF0
		private Projectile _swipeBody; // 0xF8
		private float2 _playerOffset; // 0x100
		private int _flipNum; // 0x108
		private bool _isFlipped; // 0x10C
		private bool _isMoving; // 0x10D
		private float _attackDistance; // 0x110
		private VampireSurvivors.Framework.TimerSystem.Timer _starCreationTimer; // 0x118
		private float _swingTime; // 0x120
	
		// Constructors
		public TP_StarFlail2_Projectile() {} // 0x0000000186D316F0-0x0000000186D31750
	
		// Methods
		protected override void Awake() {} // 0x0000000186D306A0-0x0000000186D30740
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D30740-0x0000000186D30F70
		public override void InternalUpdate() {} // 0x0000000186D30F70-0x0000000186D30FF0
		private void updateAttackAngle(float attackAngle) {} // 0x0000000186D30FF0-0x0000000186D31190
		private void LandHit() {} // 0x0000000186D31190-0x0000000186D31450
		private void CreateStar() {} // 0x0000000186D31450-0x0000000186D31680
		public override void Despawn() {} // 0x0000000186D31680-0x0000000186D316F0
	}
}

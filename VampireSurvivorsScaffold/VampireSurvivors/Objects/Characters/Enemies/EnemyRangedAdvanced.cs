/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyRangedAdvanced : EnemyController // TypeDefIndex: 17372
	{
		// Fields
		private EnemyType _originalBullet; // 0x270
		private float _keepMoving; // 0x274
		private float _fireDelay; // 0x278
		private float _firingRandom; // 0x27C
		private float _minRange; // 0x280
		private float _maxRange; // 0x284
		private Tween _onEnterTween; // 0x288
		private VampireSurvivors.Framework.TimerSystem.Timer _onFireTimer; // 0x290
	
		// Constructors
		public EnemyRangedAdvanced() {} // 0x0000000187292CA0-0x0000000187292D20
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187291ED0-0x00000001872924B0
		protected override void OnUpdate() {} // 0x00000001872924B0-0x00000001872929F0
		protected override void Die() {} // 0x00000001872929F0-0x0000000187292A20
		public override void Despawn() {} // 0x0000000187292A20-0x0000000187292A50
		private void Fire() {} // 0x0000000187292A50-0x0000000187292CA0
	}
}

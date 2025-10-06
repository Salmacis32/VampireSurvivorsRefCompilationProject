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
	public class EnemyRanged : EnemyController // TypeDefIndex: 17371
	{
		// Fields
		private EnemyType _originalBullet; // 0x270
		private float _keepMoving; // 0x274
		private float _fireDelay; // 0x278
		private float _previousDistance; // 0x27C
		private Tween _onEnterTween; // 0x280
		private VampireSurvivors.Framework.TimerSystem.Timer _onFireTimer; // 0x288
		private const float Distance = 50000f; // Metadata: 0x019784BB
	
		// Constructors
		public EnemyRanged() {} // 0x0000000187291E60-0x0000000187291ED0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187291340-0x00000001872917C0
		protected override void OnUpdate() {} // 0x00000001872917C0-0x0000000187291CF0
		protected override void Die() {} // 0x0000000187291CF0-0x0000000187291D20
		public override void Despawn() {} // 0x0000000187291D20-0x0000000187291D50
		private void Fire() {} // 0x0000000187291D50-0x0000000187291E60
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyStalkerNoob : EnemyController // TypeDefIndex: 17398
	{
		// Fields
		private float _sineF; // 0x270
		private float _fireTime; // 0x274
		private float _fireDelay; // 0x278
		private EnemyType _bulletType; // 0x27C
		private Tween _onEnterTween; // 0x280
		private Tween _onFireTimer; // 0x288
		private DG.Tweening.Sequence _onSineTween; // 0x290
		public Action OnDefeat; // 0x298
	
		// Constructors
		public EnemyStalkerNoob() {} // 0x00000001872A3EB0-0x00000001872A3F20
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872A3280-0x00000001872A3B10
		public override void Disappear() {} // 0x00000001872A3B10-0x00000001872A3CD0
		public override void Despawn() {} // 0x00000001872A3CD0-0x00000001872A3D30
		protected override void Die() {} // 0x00000001872A3D30-0x00000001872A3DA0
		private void Fire() {} // 0x00000001872A3DA0-0x00000001872A3EB0
	}
}

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
	public class EnemyPile1 : EnemyController // TypeDefIndex: 17365
	{
		// Fields
		private float _fireTime; // 0x270
		protected EnemyType _bulletType; // 0x274
		private DG.Tweening.Sequence _onEnterTween; // 0x278
		private Tween _onFireTimer; // 0x280
	
		// Constructors
		public EnemyPile1() {} // 0x000000018728B550-0x000000018728B5B0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x000000018728ABB0-0x000000018728B320
		public override void Despawn() {} // 0x000000018726E3C0-0x000000018726E410
		protected override void Die() {} // 0x000000018728B320-0x000000018728B370
		private void KillTweens() {} // 0x000000018728B370-0x000000018728B3B0
		protected virtual float FireDelay() => default; // 0x000000018728B3B0-0x000000018728B440
		protected virtual void Fire() {} // 0x000000018728B440-0x000000018728B550
	}
}

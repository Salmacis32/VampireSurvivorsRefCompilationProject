/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyPatrol : EnemyController // TypeDefIndex: 17363
	{
		// Fields
		private Tween _scaleTween; // 0x270
		private Tween _sineTween; // 0x278
		private float _patrolDuration; // 0x280
		private float _sineF; // 0x284
		protected Pickup _ownerAsPickup; // 0x288
	
		// Constructors
		public EnemyPatrol() {} // 0x000000018728A070-0x000000018728A0E0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187289680-0x0000000187289BC0
		public override void SetOwner(GameObject owner) {} // 0x0000000187289BC0-0x0000000187289DE0
		protected override void OnUpdate() {} // 0x0000000187289DE0-0x000000018728A070
	}
}

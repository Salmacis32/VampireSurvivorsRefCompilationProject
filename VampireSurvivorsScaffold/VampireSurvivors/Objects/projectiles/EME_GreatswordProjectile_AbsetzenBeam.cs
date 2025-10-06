/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_GreatswordProjectile_AbsetzenBeam : Projectile // TypeDefIndex: 15774
	{
		// Fields
		[SerializeField]
		protected TrailRenderer _Trail; // 0xD0
		[SerializeField]
		private ParticleSystem _TrailHeadFX; // 0xD8
		private const float Radius = 18f; // Metadata: 0x0197780A
		private const float DelayDuration = 50f; // Metadata: 0x0197780E
		private readonly List<EME_GreatswordProjectile_Absetzen> _targets; // 0xE0
		private int _targetIndex; // 0xE8
		private MultiTargetTween _moveTween; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _delayTimer; // 0xF8
		private VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0x100
		private float _finalAngle; // 0x108
	
		// Properties
		public List<EME_GreatswordProjectile_Absetzen> Targets { get => default; } // 0x000000018282D820-0x000000018282D830 
	
		// Constructors
		public EME_GreatswordProjectile_AbsetzenBeam() {} // 0x0000000186D85A60-0x0000000186D85B50
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D84280-0x0000000186D84540
		private void SetupTrail() {} // 0x0000000186D84540-0x0000000186D846C0
		public void AddTarget(EME_GreatswordProjectile_Absetzen target) {} // 0x0000000186D846C0-0x0000000186D84720
		public void PrepareToFire() {} // 0x0000000186D84720-0x0000000186D84880
		public void SetInitialTarget() {} // 0x0000000186D84880-0x0000000186D84920
		private void SetNextTarget() {} // 0x0000000186D84920-0x0000000186D849F0
		private void MoveTo(Vector2 position) {} // 0x0000000186D849F0-0x0000000186D84CE0
		private void MoveAtFinalAngle() {} // 0x0000000186D84CE0-0x0000000186D850C0
		public float GetFinalAngle() => default; // 0x0000000186D850C0-0x0000000186D85720
		public float GetRandomAngle() => default; // 0x0000000186D85720-0x0000000186D85780
		private void PlaySfx() {} // 0x0000000186D85780-0x0000000186D858A0
		private void StartDespawn() {} // 0x0000000186D858A0-0x0000000186D859A0
		public override void Despawn() {} // 0x0000000186D859A0-0x0000000186D85A60
	}
}

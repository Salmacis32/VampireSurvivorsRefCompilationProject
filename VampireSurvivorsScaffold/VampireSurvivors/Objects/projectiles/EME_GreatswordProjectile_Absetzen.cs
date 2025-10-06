/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_GreatswordProjectile_Absetzen : EME_GreatswordProjectile // TypeDefIndex: 15772
	{
		// Fields
		[SerializeField]
		private ParticleSystem _SwordHeadFX; // 0x138
		private Vector3 _defaultSwordSpriteRotation; // 0x140
	
		// Properties
		protected override float MinTimeToLand { get => default; } // 0x0000000186D83A90-0x0000000186D83AA0 
		protected override float MaxTimeToLand { get => default; } // 0x0000000186D70F90-0x0000000186D70FA0 
	
		// Constructors
		public EME_GreatswordProjectile_Absetzen() {} // 0x0000000186D83840-0x0000000186D83890
	
		// Methods
		protected override void DoGlimmerAttack() {} // 0x0000000180B15170-0x0000000180B15180
		protected override void InitVelocity() {} // 0x0000000186D83AA0-0x0000000186D83B60
		public void RotateTowardsBeamTarget(EME_GreatswordProjectile_Absetzen target) {} // 0x0000000186D83B60-0x0000000186D83BE0
		public void RotateAtAngle(float angle) {} // 0x0000000186D83BE0-0x0000000186D83BF0
		private void RotateSwordSprite(float angle) {} // 0x0000000186D83BF0-0x0000000186D84050
		private void PlaySwordHeadVfx() {} // 0x0000000186D84050-0x0000000186D84140
		public override void Despawn() {} // 0x0000000186D84140-0x0000000186D84280
	}
}

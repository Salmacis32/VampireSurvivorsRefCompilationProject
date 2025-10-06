/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_GreatswordProjectile_BullCrush : EME_GreatswordProjectile // TypeDefIndex: 15775
	{
		// Fields
		[SerializeField]
		private ParticleSystem _SlashVFX; // 0x138
		private const float VFXScale = 0.5f; // Metadata: 0x01977812
		private const float VFXRotationZ = -20f; // Metadata: 0x01977816
		private const float SwordRotationZ = 165f; // Metadata: 0x0197781A
		private Vector3 _defaultSwordSpriteRotation; // 0x140
		private float2 _bodySize; // 0x14C
		private float2 _bodyOffset; // 0x154
		private Tween _scaleTween2; // 0x160
	
		// Constructors
		public EME_GreatswordProjectile_BullCrush() {} // 0x0000000186D83840-0x0000000186D83890
	
		// Methods
		protected override void DoGlimmerAttack() {} // 0x0000000186D85DB0-0x0000000186D85FE0
		public override void InternalUpdate() {} // 0x0000000186D85FE0-0x0000000186D861E0
		private void PlaySlashVFX() {} // 0x0000000186D861E0-0x0000000186D865B0
		private void SetBodyForSlash() {} // 0x0000000186D865B0-0x0000000186D866F0
		private void UpdateBodyForSlash() {} // 0x0000000186D866F0-0x0000000186D868A0
		private void RotateSwordSprite() {} // 0x0000000186D868A0-0x0000000186D86C30
		private void PlaySlashSfx() {} // 0x0000000186D86C30-0x0000000186D86D10
		public override void Despawn() {} // 0x0000000186D86D10-0x0000000186D86E70
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Particles
{
	public class TestParticleGenerator : GameMonoBehaviour // TypeDefIndex: 18235
	{
		// Fields
		[SerializeField]
		private RectTransform _Canvas; // 0x28
		private ParticleSystem _playerDamageVfx; // 0x30
		private ParticleSystem _pickupVfx; // 0x38
		private ParticleEmitterManager _explosionManager; // 0x40
		private ParticleSystem _explosion1Pfx; // 0x48
		private ParticleSystem _explosion2Pfx; // 0x50
		private GravityWell _explosionGravWell; // 0x58
		private ParticleEmitterManager _fireworksManager; // 0x60
	
		// Constructors
		public TestParticleGenerator() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		protected override void OnUpdate() {} // 0x0000000186710470-0x0000000186710560
		private void TestFireworksVfx(int index) {} // 0x0000000186710560-0x00000001867110B0
		private void TestPlayerDamageVfx() {} // 0x00000001867110B0-0x00000001867119B0
		private void TestPickupVfx() {} // 0x00000001867119B0-0x0000000186712260
		private void TestExplosion() {} // 0x0000000186712260-0x0000000186713620
		private void TestArcanaParticles() {} // 0x0000000186713620-0x00000001867142B0
		private void TestEnemyEye() {} // 0x00000001867142B0-0x0000000186714C00
		private void TestGoldFever() {} // 0x0000000186714C00-0x00000001867151C0
		private void TestBackground4Particles() {} // 0x00000001867151C0-0x0000000186715BC0
		private void TestUiFireworks() {} // 0x0000000186715BC0-0x0000000186716470
	}
}

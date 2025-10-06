/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class EX_Rumba1_Weapon : Weapon // TypeDefIndex: 16664
	{
		// Fields
		private ParticleEmitterManager _pfxManager; // 0x158
		private ParticleSystem _pfx; // 0x160
		private float fxRadius; // 0x168
	
		// Constructors
		public EX_Rumba1_Weapon() {} // 0x000000018703CBA0-0x000000018703CBF0
	
		// Methods
		public override float PSpeed() => default; // 0x0000000185C0CCB0-0x0000000185C0CCC0
		public override float PAmount() => default; // 0x0000000185C0CCB0-0x0000000185C0CCC0
		protected override void OnStart() {} // 0x000000018703A9E0-0x000000018703B270
		protected override bool OnBulletOverlapsDestructible(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018703B270-0x000000018703B420
		private bool OnBulletOverlapsPickup(CallbackContext context, ArcadeColliderType left, ArcadeColliderType right) => default; // 0x000000018703B420-0x000000018703B7E0
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018703B7E0-0x000000018703B990
		protected override bool OnBulletOverlapsPlayer(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018703B990-0x000000018703BC10
		private void GenerateParticleSystem() {} // 0x000000018703BC10-0x000000018703CA00
		public override void InternalUpdate() {} // 0x000000018703CA00-0x000000018703CBA0
	}
}

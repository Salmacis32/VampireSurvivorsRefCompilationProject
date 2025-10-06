/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Gun2_Projectile : TP_Gun1_Projectile // TypeDefIndex: 15583
	{
		// Fields
		[SerializeField]
		private TrailRenderer _trail; // 0xE0
		private List<Color> colors; // 0xE8
		private ParticleEmitterManager _pfxManager; // 0xF0
		private ParticleSystem _pfx; // 0xF8
		private List<List<string>> sparkFrames; // 0x100
	
		// Constructors
		public TP_Gun2_Projectile() {} // 0x0000000186CC0520-0x0000000186CC1240
	
		// Methods
		protected override void Awake() {} // 0x0000000186CBF460-0x0000000186CBF6A0
		private void GenerateParticleSystem() {} // 0x0000000186CBF6A0-0x0000000186CBFDC0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CBFDC0-0x0000000186CC0410
		public override void Despawn() {} // 0x0000000186CC0410-0x0000000186CC0520
	}
}

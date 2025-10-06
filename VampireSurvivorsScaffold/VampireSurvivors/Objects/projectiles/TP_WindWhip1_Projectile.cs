/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_WindWhip1_Projectile : Projectile // TypeDefIndex: 15722
	{
		// Fields
		private MultiTargetTween _scaleTween; // 0xD0
		private MultiTargetTween _alphaTween; // 0xD8
		private float hOffset; // 0xE0
		private List<float> vOffsets; // 0xE8
		private uint[] _colors; // 0xF0
		private readonly VampireSurvivors.Framework.Particles.BlendMode[] _blendModes; // 0xF8
	
		// Constructors
		public TP_WindWhip1_Projectile() {} // 0x0000000186D51BD0-0x0000000186D51F50
	
		// Methods
		protected override void Awake() {} // 0x0000000186D50F30-0x0000000186D51020
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D51020-0x0000000186D51BD0
		public override void Despawn() {} // 0x0000000186C741B0-0x0000000186C741F0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class JubileeRaysProjectile : Projectile // TypeDefIndex: 15908
	{
		// Fields
		private MultiTargetTween _scaleTween; // 0xD0
		private MultiTargetTween _emitterCounter; // 0xD8
		private int _basePixelSize; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xE8
		private float _yOffset; // 0xF0
	
		// Constructors
		public JubileeRaysProjectile() {} // 0x0000000186E39E40-0x0000000186E39EA0
	
		// Methods
		protected override void Awake() {} // 0x0000000186E399E0-0x0000000186E39A10
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E39A10-0x0000000186E39DA0
		protected override void OnUpdate() {} // 0x0000000186E39DA0-0x0000000186E39E40
	}
}

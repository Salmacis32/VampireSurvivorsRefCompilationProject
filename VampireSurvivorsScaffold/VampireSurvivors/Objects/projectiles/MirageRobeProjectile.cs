/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class MirageRobeProjectile : Projectile // TypeDefIndex: 15927
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD0
		private string _textureName; // 0xD8
		private string _frameName; // 0xE0
		private float _amount; // 0xE8
		private MultiTargetTween _fadeOutTween; // 0xF0
	
		// Constructors
		public MirageRobeProjectile() {} // 0x0000000186E4B130-0x0000000186E4B180
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E4A790-0x0000000186E4AC20
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186E4AC20-0x0000000186E4AE80
		public void FadeOut() {} // 0x0000000186E4AE80-0x0000000186E4B130
	}
}

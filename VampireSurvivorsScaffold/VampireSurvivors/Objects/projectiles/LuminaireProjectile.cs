/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class LuminaireProjectile : Projectile // TypeDefIndex: 15422
	{
		// Fields
		private bool _alreadyRecycled; // 0xD0
		private MultiTargetTween _alphaTween; // 0xD8
		private MultiTargetTween _scaleTween; // 0xE0
		[NonSerialized]
		public float radius; // 0xE8
		private float2 _pfxLocation; // 0xEC
		public uint[] _colors; // 0xF8
		public int[] _detunes; // 0x100
		private LuminaireWeapon _trueWeapon; // 0x108
	
		// Constructors
		public LuminaireProjectile() {} // 0x0000000186BE5AC0-0x0000000186BE5C80
	
		// Methods
		protected override void Awake() {} // 0x0000000186BE4C60-0x0000000186BE4DA0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BE4DA0-0x0000000186BE5990
		public override void Despawn() {} // 0x0000000186BE5990-0x0000000186BE59B0
		protected override void OnHasHitAnObject(IDamageable target) {} // 0x0000000186BE59B0-0x0000000186BE5AC0
	}
}

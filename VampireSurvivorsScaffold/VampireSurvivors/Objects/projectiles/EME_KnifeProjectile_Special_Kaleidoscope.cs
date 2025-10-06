/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_KnifeProjectile_Special_Kaleidoscope : Projectile // TypeDefIndex: 15793
	{
		// Fields
		private MultiTargetTween _scaleTween; // 0xD0
		private MultiTargetTween _despawnTween; // 0xD8
		[SerializeField]
		private List<Texture> _textures; // 0xE0
		[SerializeField]
		private MeshRenderer _meshRenderer; // 0xE8
		[SerializeField]
		private SortingGroup meshSortingGroup; // 0xF0
		private static readonly int _texture; // 0x00
		private static readonly int _AlphaMul; // 0x04
	
		// Constructors
		public EME_KnifeProjectile_Special_Kaleidoscope() {} // 0x0000000186DBAB20-0x0000000186DBAB70
		static EME_KnifeProjectile_Special_Kaleidoscope() {} // 0x0000000186DBAB70-0x0000000186DBAC00
	
		// Methods
		protected override void Awake() {} // 0x0000000186DBA1C0-0x0000000186DBA360
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DBA360-0x0000000186DBAB20
	}
}

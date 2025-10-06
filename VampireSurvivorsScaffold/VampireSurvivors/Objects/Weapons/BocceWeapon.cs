/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class BocceWeapon : Weapon // TypeDefIndex: 16141
	{
		// Fields
		protected int _radius; // 0x158
		protected string _orbFrame; // 0x160
		private SpriteRenderer _image; // 0x168
		private MultiTargetTween _imageTween; // 0x170
		private List<SpriteRenderer> _orbs; // 0x178
		private List<float> _angles; // 0x180
		private float _angleUnit; // 0x188
		private List<float> _anglesMul; // 0x190
		public float _Alpha; // 0x198
	
		// Constructors
		public BocceWeapon() {} // 0x0000000186F23EC0-0x0000000186F23F90
	
		// Methods
		public override float PAmount() => default; // 0x0000000185C0CCB0-0x0000000185C0CCC0
		public override float PPower() => default; // 0x0000000186F23F90-0x0000000186F24090
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F24090-0x0000000186F24AB0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977B81 */) {} // 0x0000000186F24AB0-0x0000000186F24C10
		public override void Cleanup() {} // 0x0000000186F24C10-0x0000000186F24E30
		public override void InternalUpdate() {} // 0x0000000186F24E30-0x0000000186F25F90
		public override void SetVisible(bool visible) {} // 0x0000000186F25F90-0x0000000186F260D0
	}
}

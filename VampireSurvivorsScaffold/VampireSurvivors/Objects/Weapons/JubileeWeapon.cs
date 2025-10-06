/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class JubileeWeapon : Weapon // TypeDefIndex: 16717
	{
		// Fields
		private List<ParticleSystem> _fwEmitters; // 0x158
		private GravityWell _well; // 0x160
		private List<SpriteRenderer> _rays; // 0x168
		private List<MultiTargetTween> _raysTween; // 0x170
		private int _raysLevel; // 0x178
		private VampireSurvivors.Framework.TimerSystem.Timer _soundTimer; // 0x180
		private SfxType[] _soundArray; // 0x188
		private bool _makeRaysOnUpdate; // 0x190
		private bool _canPlaySounds; // 0x191
		private int _soundIndex; // 0x194
		private ParticleEmitterManager _particles; // 0x198
	
		// Constructors
		public JubileeWeapon() {} // 0x0000000187094800-0x0000000187094AD0
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000187091CD0-0x0000000187091D10
		private void MakeFireworks() {} // 0x0000000187091D10-0x0000000187092C10
		private void MakeRays() {} // 0x0000000187092C10-0x0000000187093D70
		public ParticleSystem GetFwEmitters(int index) => default; // 0x0000000187093D70-0x0000000187093E00
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977DE7 */) {} // 0x0000000187093E00-0x0000000187094330
		protected override void OnUpdate() {} // 0x0000000187094330-0x00000001870944E0
		public override bool LevelUp() => default; // 0x00000001870944E0-0x0000000187094520
		protected override bool OnSecondaryBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000187094520-0x0000000187094800
		public override void CheckArcanas() {} // 0x0000000187039E30-0x0000000187039EF0
	}
}

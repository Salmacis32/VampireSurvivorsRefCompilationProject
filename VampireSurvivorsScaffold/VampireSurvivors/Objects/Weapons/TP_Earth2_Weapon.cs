/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Earth2_Weapon : Weapon // TypeDefIndex: 16339
	{
		// Fields
		[SerializeField]
		[Tooltip("Material to use for the crystals")]
		private Material _Material; // 0x158
		private bool _initialisedParticles; // 0x160
		private ParticleSystem _jewelPickupVfx; // 0x168
		private PhaserSprite _cursor; // 0x170
		private float _topBarHeight; // 0x178
		private bool _hasGemini; // 0x17C
		private TP_Earth1_Weapon _earth1Weapon; // 0x180
		private List<uint> _baseTints; // 0x188
		private List<uint> _rainbowTints; // 0x190
	
		// Properties
		public virtual float PlayerFacing { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
		public virtual bool IsPrimaryWeapon { get => default; } // 0x0000000181958370-0x0000000181958380 
		public List<uint> BaseTints { get => default; } // 0x00000001826DBA40-0x00000001826DBA50 
		public List<uint> RainbowTints { get => default; } // 0x0000000182766A50-0x0000000182766A60 
	
		// Constructors
		public TP_Earth2_Weapon() {} // 0x0000000186FAA7C0-0x0000000186FAAD70
	
		// Methods
		protected override void Awake() {} // 0x0000000186FA8310-0x0000000186FA84E0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FA84E0-0x0000000186FA94A0
		public override void InternalUpdate() {} // 0x0000000186FA94A0-0x0000000186FA97E0
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C61 */) {} // 0x0000000186FA97E0-0x0000000186FA9900
		public void FireProjectiles(Vector2 pos) {} // 0x0000000186FA9900-0x0000000186FA9F90
		public override void CheckArcanas() {} // 0x0000000186FA9F90-0x0000000186FAA100
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186FAA100-0x0000000186FAA420
		private void DisplayCursorVFX(int _times, float _duration) {} // 0x0000000186FAA420-0x0000000186FAA690
		public override void SetVisible(bool visible) {} // 0x0000000186FAA690-0x0000000186FAA7C0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class FB_CrossbowCrashWeapon : FB_BladeCrossbowWeapon // TypeDefIndex: 16226
	{
		// Fields
		private BulletPool _crossPool; // 0x160
		public float defaultWidth; // 0x168
		private float _critChance; // 0x16C
		private VampireSurvivors.Framework.TimerSystem.Timer _evoTimer; // 0x170
		private float _crossTime; // 0x178
		private float _crossBaseDelay; // 0x17C
		private float _nextInterval; // 0x180
		private float _projectileStock; // 0x184
		private float _projectileTime; // 0x188
		private float _projectileInterval; // 0x18C
		private PhaserSprite _lightSprite; // 0x190
		private bool _hasSprites; // 0x198
		private MultiTargetTween _tween1; // 0x1A0
		private MultiTargetTween _tween2; // 0x1A8
		private ParticleEmitterManager _pfxManager; // 0x1B0
		private ParticleSystem _pfx; // 0x1B8
		private Rectangle _pfxRecta; // 0x1C0
	
		// Constructors
		public FB_CrossbowCrashWeapon() {} // 0x0000000186F705F0-0x0000000186F70670
	
		// Methods
		private float Intensity() => default; // 0x0000000186F6E8A0-0x0000000186F6E960
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F6E960-0x0000000186F6F850
		private float GetSpecialInterval() => default; // 0x0000000186F6F850-0x0000000186F6F930
		public override void InternalUpdate() {} // 0x0000000186F6F930-0x0000000186F702C0
		public void FireOneEvoProjectile(Vector2 pos, int index, float duration = 30000f /* Metadata: 0x01977BDE */) {} // 0x0000000186F702C0-0x0000000186F70350
		public override float SecondaryPPower() => default; // 0x0000000186F70350-0x0000000186F705B0
		private void LateUpdate() {} // 0x0000000186F705B0-0x0000000186F705F0
	}
}

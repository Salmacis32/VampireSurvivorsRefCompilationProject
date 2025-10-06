/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class Vento2ExploProjectile : Projectile // TypeDefIndex: 15981
	{
		// Fields
		private MultiTargetTween _tween; // 0xD0
		private uint[] _colorss; // 0xD8
		private SpriteAnimation _anims; // 0xE0
		private PhaserSprite _ghost1; // 0xE8
		private PhaserSprite _ghost2; // 0xF0
		private ParticleEmitterManager _pfxManager; // 0xF8
		private ParticleSystem _emitter1; // 0x100
		private ParticleSystem _emitter2; // 0x108
		private int _repeatCount; // 0x110
		private int _colorCount; // 0x114
		private static float[] s_detunes; // 0x00
		private static int s_detunesIndex; // 0x08
	
		// Constructors
		public Vento2ExploProjectile() {} // 0x0000000186E90D30-0x0000000186E90E20
		static Vento2ExploProjectile() {} // 0x0000000186E90E20-0x0000000186E90F10
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E8F150-0x0000000186E90D30
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Chauve1_Projectile : Projectile // TypeDefIndex: 15510
	{
		// Fields
		protected const float Radius = 16f; // Metadata: 0x0197769B
		protected const float Angle = 15f; // Metadata: 0x0197769F
		protected float _cachedAngle; // 0xD0
		protected float _bodyOffsetX; // 0xD4
		protected float _bodyOffsetY; // 0xD8
		protected bool _flipX; // 0xDC
		protected int _flipSign; // 0xE0
		protected bool _isCrit; // 0xE4
		protected float2 _spawnPos; // 0xE8
		protected float2 _tipTargetPos; // 0xF0
		protected PhaserSprite _displaySprite; // 0xF8
		protected MultiTargetTween _alphaTween; // 0x100
		protected MultiTargetTween _posTween; // 0x108
	
		// Properties
		protected virtual bool IsEvo { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected float BodyOffsetX { get => default; } // 0x0000000186C6F690-0x0000000186C6F6B0 
		protected float BodyOffsetY { get; set; } // 0x0000000185D800D0-0x0000000185D800E0 0x0000000185D800E0-0x0000000185D800F0
		protected virtual string SpriteName { get => default; } // 0x0000000186C6F6B0-0x0000000186C6F6F0 
		protected virtual string SpriteObjectName { get => default; } // 0x0000000186C6F6F0-0x0000000186C6F730 
		protected virtual uint Tint { get => default; } // 0x0000000186C6F730-0x0000000186C6F740 
		public virtual bool IsCrit { get => default; } // 0x0000000186C6F740-0x0000000186C6F750 
	
		// Constructors
		public TP_Chauve1_Projectile() {} // 0x0000000186C706E0-0x0000000186C70730
	
		// Methods
		protected override void Awake() {} // 0x0000000186C6F750-0x0000000186C6F9C0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C6F9C0-0x0000000186C70360
		public override void InternalUpdate() {} // 0x0000000180B15170-0x0000000180B15180
		private void SetOrigin() {} // 0x0000000186C70360-0x0000000186C703D0
		protected virtual void MakeCritProjectile() {} // 0x0000000180B15170-0x0000000180B15180
		private void StartDespawn() {} // 0x0000000186C703D0-0x0000000186C70690
		public override void Despawn() {} // 0x0000000186C70690-0x0000000186C706E0
	}
}

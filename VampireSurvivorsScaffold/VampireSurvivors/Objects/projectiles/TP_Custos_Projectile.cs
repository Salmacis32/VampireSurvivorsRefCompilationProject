/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Custos_Projectile : Projectile // TypeDefIndex: 15527
	{
		// Fields
		private MultiTargetTween _alphaTween; // 0xD0
		private MultiTargetTween _posTween; // 0xD8
		private SpriteAnimation _anim; // 0xE0
		private const int AnimFPS = 24; // Metadata: 0x019776AB
		protected int _startFrame; // 0xE8
		protected float _posX; // 0xEC
		protected float _posY; // 0xF0
		protected VampireSurvivors.Framework.TimerSystem.Timer[] _trailTimers; // 0xF8
		protected const float TweenInDuration = 200f; // Metadata: 0x019776AC
		protected const float TweenOutDuration = 200f; // Metadata: 0x019776B0
		protected const float TweenOutDelay = 300f; // Metadata: 0x019776B4
		protected TP_Custos_Weapon _custosWeapon; // 0x100
		protected TP_Custos4_Weapon _evoWeapon; // 0x108
		private int _biteCounter; // 0x110
		private float2 _startingPoint; // 0x114
	
		// Properties
		protected float2 ExplosionPoint { get => default; } // 0x0000000186C7B700-0x0000000186C7B8A0 
	
		// Constructors
		public TP_Custos_Projectile() {} // 0x0000000186C7D9F0-0x0000000186C7DAC0
	
		// Methods
		protected override void Awake() {} // 0x0000000186C7B8A0-0x0000000186C7B8D0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C7B8D0-0x0000000186C7C510
		private void InitAnimation(int startFrame) {} // 0x0000000186C7C510-0x0000000186C7C850
		public virtual void Bite() {} // 0x0000000186C7C850-0x0000000186C7C8B0
		protected virtual void OnBiteAnimComplete() {} // 0x0000000186C7C8B0-0x0000000186C7CA30
		private protected void InitFireTrails() {} // 0x0000000186C7CA30-0x0000000186C7CE50
		private protected void InitIceTrails() {} // 0x0000000186C7CE50-0x0000000186C7D270
		private protected void InitLightningTrails() {} // 0x0000000186C7D270-0x0000000186C7D690
		private void FadeOut() {} // 0x0000000186C7D690-0x0000000186C7D940
		public override void Despawn() {} // 0x0000000186C7D940-0x0000000186C7D9F0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class FB_PrismCutlassProjectile : Projectile // TypeDefIndex: 15480
	{
		// Fields
		private MultiTargetTween _scaleTween; // 0xD0
		private float2 _lastOwnerPosition; // 0xD8
		private SpriteAnimation _anim; // 0xE0
		private int _directionID; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer[] _timers; // 0xF0
		public bool MirrorFacingAngle; // 0xF8
		private static float2[] _directionVectors; // 0x00
		private static string[] _directionNames; // 0x08
		private static string[] _spriteNames; // 0x10
		private static List<Sprite>[] s_directionSpritesCache; // 0x18
	
		// Constructors
		public FB_PrismCutlassProjectile() {} // 0x0000000186C2A3A0-0x0000000186C2A470
		static FB_PrismCutlassProjectile() {} // 0x0000000186C2A470-0x0000000186C2AA20
	
		// Methods
		public static void ClearDirectionSpritesCache() {} // 0x0000000186C28820-0x0000000186C28900
		public int GetDirectionID(Vector2 direction) => default; // 0x0000000186C28900-0x0000000186C28A30
		public List<Sprite> GetFramesForDirection(int directionID) => default; // 0x0000000186C28A30-0x0000000186C28D70
		protected override void Awake() {} // 0x0000000186C28D70-0x0000000186C28EC0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C28EC0-0x0000000186C298F0
		private void FadeOut() {} // 0x0000000186C298F0-0x0000000186C29CA0
		private void DoSweepHit() {} // 0x0000000186C29CA0-0x0000000186C29D50
		private void StopSweepHit() {} // 0x0000000186C29D50-0x0000000186C29E00
		public override void InternalUpdate() {} // 0x0000000186C29E00-0x0000000186C29F80
		public override void Despawn() {} // 0x0000000186C29F80-0x0000000186C2A0C0
		protected override void OnDestroy() {} // 0x0000000186C2A0C0-0x0000000186C2A290
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C2A290-0x0000000186C2A3A0
	}
}

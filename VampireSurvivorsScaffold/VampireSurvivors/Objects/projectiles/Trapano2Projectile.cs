/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class Trapano2Projectile : Projectile // TypeDefIndex: 15977
	{
		// Fields
		[FormerlySerializedAs("_trail")]
		[SerializeField]
		private TrailRenderer _Trail; // 0xD0
		[SerializeField]
		private TrailRenderer _Trail2; // 0xD8
		[SerializeField]
		private Material _Trail2MaterialLight; // 0xE0
		[SerializeField]
		private Material _Trail2MaterialDark; // 0xE8
		[NonSerialized]
		public bool _isYeeted; // 0xF0
		[NonSerialized]
		public float _durataMillis; // 0xF4
		private Vector2 _aimVec; // 0xF8
		private MultiTargetTween _tween1; // 0x100
		private SpriteRenderer _groundFx; // 0x108
		private PhaserSprite _spikeSprite; // 0x110
		private Vector2 _previousVector; // 0x118
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x120
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x128
		private Trapano2Weapon _trueWeapon; // 0x130
		private uint _tint; // 0x138
		private float _timeStopped; // 0x13C
		private bool _tpDlcLoaded; // 0x140
		private TP_Savrog_Weapon _unionWeapon; // 0x148
		private MultiTargetTween _unionTintTween; // 0x150
		private int _unionTintCounter; // 0x158
		private const int RADIUS = 8; // Metadata: 0x019779C0
	
		// Constructors
		public Trapano2Projectile() {} // 0x0000000186E894D0-0x0000000186E89520
	
		// Methods
		protected override void Awake() {} // 0x0000000186E866E0-0x0000000186E86C40
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E86C40-0x0000000186E87900
		private void InitTrails() {} // 0x0000000186E87900-0x0000000186E87CE0
		private void UpdateUnionTrails() {} // 0x0000000186E87CE0-0x0000000186E87F10
		private void DoUnionTintTween() {} // 0x0000000186E87F10-0x0000000186E88300
		public override void InternalUpdate() {} // 0x0000000186E88300-0x0000000186E88810
		public override void Despawn() {} // 0x0000000186E88810-0x0000000186E88920
		private void FadeOut() {} // 0x0000000186E88920-0x0000000186E88CB0
		private void Yeet() {} // 0x0000000186E88CB0-0x0000000186E89360
		private void YeetUnionProjectiles() {} // 0x0000000180B15170-0x0000000180B15180
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186E89360-0x0000000186E894D0
	}
}

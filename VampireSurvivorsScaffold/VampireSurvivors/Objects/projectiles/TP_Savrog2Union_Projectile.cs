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
	public class TP_Savrog2Union_Projectile : Projectile // TypeDefIndex: 15974
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
		private TP_Savrog2Union_Weapon _trueWeapon; // 0x130
		private uint _tint; // 0x138
		private float _timeStopped; // 0x13C
		private bool _tpDlcLoaded; // 0x140
		private TP_Savrog_Weapon _unionWeapon; // 0x148
		private MultiTargetTween _unionTintTween; // 0x150
		private int _unionTintCounter; // 0x158
		private bool _isInverted; // 0x15C
		private const int RADIUS = 8; // Metadata: 0x019779BE
	
		// Constructors
		public TP_Savrog2Union_Projectile() {} // 0x0000000186E83A60-0x0000000186E83AC0
	
		// Methods
		protected override void Awake() {} // 0x0000000186E80E60-0x0000000186E814E0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E814E0-0x0000000186E822A0
		public void SetInversion(bool isInverted = false /* Metadata: 0x019779BD */) {} // 0x0000000186E822A0-0x0000000186E82340
		private void InitTrails() {} // 0x0000000186E82340-0x0000000186E82740
		private void DoUnionTintTween() {} // 0x0000000186E82740-0x0000000186E82A90
		public override void InternalUpdate() {} // 0x0000000186E82A90-0x0000000186E82CD0
		public override void Despawn() {} // 0x0000000186E82CD0-0x0000000186E82E70
		private void FadeOut() {} // 0x0000000186E82E70-0x0000000186E832F0
		public void Yeet() {} // 0x0000000186E832F0-0x0000000186E838F0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186E838F0-0x0000000186E83A60
	}
}

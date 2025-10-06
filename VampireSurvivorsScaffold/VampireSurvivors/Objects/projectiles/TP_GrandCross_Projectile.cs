/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_GrandCross_Projectile : Projectile // TypeDefIndex: 15578
	{
		// Fields
		[SerializeField]
		private MeshRenderer _PropellerMesh; // 0xD0
		[SerializeField]
		private Transform _Propeller; // 0xD8
		[SerializeField]
		private Transform _Pivot; // 0xE0
		private TP_GrandCross_Weapon _crossbowCrash; // 0xE8
		private MultiTargetTween _scaleTween; // 0xF0
		private MultiTargetTween _moveXTween; // 0xF8
		private MultiTargetTween _moveYTween; // 0x100
		private float _speedXDuration; // 0x108
		private float _pivotRotation; // 0x10C
		private TweenerCore<float, float, FloatOptions> pivotRotationTween; // 0x110
		public float offsetX; // 0x118
		public float offsetY; // 0x11C
		public float targetX; // 0x120
		public float targetY; // 0x124
		public float scaleOffsetX; // 0x128
		private float _bodyPixelSize; // 0x12C
		private float _propellerScale; // 0x130
	
		// Constructors
		public TP_GrandCross_Projectile() {} // 0x0000000186CBD300-0x0000000186CBD380
	
		// Methods
		protected override void Awake() {} // 0x0000000186CBBE70-0x0000000186CBBF10
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CBBF10-0x0000000186CBC750
		private void moveToTargetX() {} // 0x0000000186CBC750-0x0000000186CBCF40
		public override void InternalUpdate() {} // 0x0000000186CBCF40-0x0000000186CBD300
		public override void Despawn() {} // 0x0000000186C1A4D0-0x0000000186C1A550
	}
}

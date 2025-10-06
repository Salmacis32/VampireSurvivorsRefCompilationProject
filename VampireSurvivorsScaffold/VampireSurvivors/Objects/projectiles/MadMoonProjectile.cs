/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Serialization;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class MadMoonProjectile : Projectile // TypeDefIndex: 15919
	{
		// Fields
		private Camera _camera; // 0xD0
		private float bounceBack; // 0xD8
		private float scaleUp; // 0xDC
		private float scaleFactor; // 0xE0
		private bool bigWin; // 0xE4
		private int reel; // 0xE8
		public SpriteTrail trail; // 0xF0
		[FormerlySerializedAs("symbol")]
		public MadMoonSymbol madMoonSymbol; // 0xF8
		public MadMoonSymbolType type; // 0xFC
		private Tween _positionTween; // 0x100
		private Tween _scaleTween; // 0x108
		private Vector3 initialCamPos; // 0x110
		private bool moving; // 0x11C
		private MadMoonWeapon _parentWeapon; // 0x120
		private MultiTargetTween _groundTween; // 0x138
		public float Duration_ScaleAnimation; // 0x140
		public float Duration_FadeOut; // 0x144
		public float Duration_Starting; // 0x148
		public float Duration_Landing; // 0x14C
		public float Duration_Spinning; // 0x150
	
		// Properties
		private PhaserSprite _GroundFx { get; set; } // 0x0000000182937BD0-0x0000000182937BE0 0x0000000182A45B30-0x0000000182A45B90
		private PhaserSprite _GroundFxRing { get; set; } // 0x0000000182A45B90-0x0000000182A45BA0 0x0000000182A45BA0-0x0000000182A45C00
	
		// Constructors
		public MadMoonProjectile() {} // 0x0000000186E439A0-0x0000000186E43A40
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E41180-0x0000000186E41B50
		public void PlayGroundFX() {} // 0x0000000186E41B50-0x0000000186E421D0
		public void SetBigWin(bool _bigWin) {} // 0x0000000186E421D0-0x0000000186E421E0
		public void AfterInit(MadMoonSymbolType type, MadMoonSymbol madMoonSymbol, int reel, Vector2 pos) {} // 0x0000000186E421E0-0x0000000186E42500
		public override void InternalUpdate() {} // 0x0000000186E42500-0x0000000186E42630
		public void setSprite(MadMoonSymbol madMoonSymbol) {} // 0x0000000186E42630-0x0000000186E42820
		private static float map(float value, float fromLow, float fromHigh, float toLow, float toHigh) => default; // 0x0000000186E42820-0x0000000186E42840
		private void DoScaleEffect() {} // 0x0000000180B15170-0x0000000180B15180
		public void startMoving() {} // 0x0000000186E42840-0x0000000186E43130
		private void GetComponents() {} // 0x0000000186E43130-0x0000000186E432E0
		private void KeepUpWithCameraMovement(float f) {} // 0x0000000186E432E0-0x0000000186E43390
		private void LandingFinished() {} // 0x0000000186E43390-0x0000000186E434E0
		public void ScaleAnimation() {} // 0x0000000186E434E0-0x0000000186E43710
		public Tween FadeOut() => default; // 0x0000000186E43710-0x0000000186E438C0
		public Tween FadeOn() => default; // 0x0000000186E438C0-0x0000000186E439A0
	}
}

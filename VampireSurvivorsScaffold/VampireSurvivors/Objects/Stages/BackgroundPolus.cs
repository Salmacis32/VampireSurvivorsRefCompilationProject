/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Graphics;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class BackgroundPolus : BackgroundManager // TypeDefIndex: 15300
	{
		// Fields
		private MeshRenderer _magicWaterImage; // 0x80
		private TileSprite _lavaTile; // 0x88
		private bool _hasShaderBackground; // 0x90
		private PhaserSprite _waterAnim; // 0x98
		private float scrollOffset; // 0xA0
		private bool _hasGeneratedBackgroundSprites; // 0xA4
		private TileSprite _backgroundStars; // 0xA8
		private PhaserSprite _backgroundMountainsFar; // 0xB0
		private PhaserSprite _backgroundMountainsMid; // 0xB8
		private PhaserSprite _backgroundMountainsNear; // 0xC0
		private SpriteScroller _backgroundMountainsFarScroller; // 0xC8
		private SpriteScroller _backgroundMountainsMidScroller; // 0xD0
		private SpriteScroller _backgroundMountainsNearScroller; // 0xD8
		private float _mapHeight; // 0xE0
	
		// Constructors
		public BackgroundPolus() {} // 0x0000000186A94680-0x0000000186A94690
	
		// Methods
		public override void Create() {} // 0x0000000186B51260-0x0000000186B51510
		protected override void OnUpdate() {} // 0x0000000186B51510-0x0000000186B516F0
		private void LateUpdate() {} // 0x0000000186B516F0-0x0000000186B51800
		public override void Cleanup() {} // 0x0000000186B51800-0x0000000186B51870
		private void InitVFX() {} // 0x0000000186B51870-0x0000000186B51D80
		private void MakeTheLava() {} // 0x0000000186B51D80-0x0000000186B521D0
		private void MakeBackgroundSprites() {} // 0x0000000186B521D0-0x0000000186B53210
		private void LockY(Transform trans, float yPos) {} // 0x0000000186B53210-0x0000000186B533E0
		private void ShiftY(Transform trans, float min) {} // 0x0000000186B533E0-0x0000000186B537E0
		private void ForceScrollOffset(SpriteScroller scroller) {} // 0x0000000186B537E0-0x0000000186B538C0
	}
}

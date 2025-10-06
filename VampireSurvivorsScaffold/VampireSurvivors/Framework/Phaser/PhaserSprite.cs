/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Graphics;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Phaser
{
	public class PhaserSprite : GameMonoBehaviour // TypeDefIndex: 18218
	{
		// Fields
		private SpriteRenderer _spriteRenderer; // 0x28
		private SpriteAnimation _spriteAnimation; // 0x30
		[HideInInspector]
		public float _originX; // 0x38
		[HideInInspector]
		public float _originY; // 0x3C
	
		// Properties
		public SpriteAnimation Anim { get => default; } // 0x0000000180B15550-0x0000000180B15560 
		public SpriteAnimation anims { get => default; } // 0x0000000180B15550-0x0000000180B15560 
		public SpriteRenderer Rend { get => default; } // 0x0000000180B15540-0x0000000180B15550 
		public Bounds Bounds { get => default; } // 0x0000000186700770-0x0000000186700850 
		public float X { get => default; set {} } // 0x0000000186700850-0x0000000186700910 0x0000000186700910-0x0000000186700B50
		public float Y { get => default; set {} } // 0x0000000186700B50-0x0000000186700C10 0x0000000186700C10-0x0000000186700E50
		public float2 position { get => default; set {} } // 0x00000001865DBE70-0x00000001865DBF40 0x0000000186700E50-0x0000000186700FE0
		public float Width { get => default; } // 0x0000000186700FE0-0x0000000186701170 
		public float Height { get => default; } // 0x0000000186701170-0x0000000186701300 
		public bool flipX { get => default; } // 0x0000000186701300-0x00000001867013A0 
		public bool flipY { get => default; } // 0x00000001867013A0-0x0000000186701440 
		public float scale { get => default; } // 0x0000000184C46550-0x0000000184C46610 
		public float angle { get => default; set {} } // 0x0000000186701440-0x0000000186701470 0x0000000186701470-0x00000001867014F0
		public float Alpha { get => default; } // 0x0000000186702280-0x0000000186702330 
	
		// Constructors
		public PhaserSprite() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		protected virtual new void Awake() {} // 0x00000001867014F0-0x0000000186701500
		public void InternalForceInit() {} // 0x00000001867014F0-0x0000000186701500
		public PhaserSprite setName(string newName) => default; // 0x00000001866FF470-0x00000001866FF4B0
		public PhaserSprite setOrigin(float2 origin) => default; // 0x0000000186701500-0x0000000186701570
		public PhaserSprite setOrigin(float originX = 0.5f /* Metadata: 0x019788C2 */, float? originY = default) => default; // 0x0000000186701570-0x0000000186701880
		public PhaserSprite setScale(float xScale, float? yScale = default) => default; // 0x0000000186701880-0x00000001867019B0
		public int GetFinalDepthRelative(int sortOrderOffset = 0 /* Metadata: 0x019788C6 */) => default; // 0x00000001867019B0-0x0000000186701B30
		public PhaserSprite setDepth(float depth) => default; // 0x0000000186701B30-0x0000000186701C30
		public PhaserSprite setDepth(int depth) => default; // 0x0000000186701C30-0x0000000186701D30
		public PhaserSprite setFlipX(bool flipX) => default; // 0x0000000186701D30-0x0000000186701E30
		public PhaserSprite setFlipY(bool flipY) => default; // 0x0000000186701E30-0x0000000186701F30
		public PhaserSprite setVisible(bool visible) => default; // 0x0000000186701F30-0x0000000186702030
		public PhaserSprite setFrame(string spriteName, string textureName) => default; // 0x0000000186702030-0x00000001867020B0
		public string getFrameName() => default; // 0x00000001867020B0-0x00000001867020E0
		public PhaserSprite setFrame(Sprite sprite) => default; // 0x00000001867020E0-0x0000000186702280
		public PhaserSprite setAlpha(float alpha) => default; // 0x0000000186702330-0x0000000186702590
		public PhaserSprite setTint(int tintColor) => default; // 0x0000000186702590-0x00000001867025A0
		public PhaserSprite setTint(uint topLeft, uint topRight, uint bottomLeft, uint bottomRight, VampireSurvivors.Framework.Particles.BlendMode blendMode = VampireSurvivors.Framework.Particles.BlendMode.Normal /* Metadata: 0x019788C7 */) => default; // 0x00000001867025A0-0x00000001867027D0
		public PhaserSprite setTint(uint tintColor) => default; // 0x00000001867027D0-0x0000000186702A70
		public PhaserSprite setTintFill(bool isEnabled, uint tintColor) => default; // 0x0000000186702A70-0x0000000186702B70
		public PhaserSprite setTintFill(bool isEnabled, Color? tintColor = default) => default; // 0x0000000186702B70-0x0000000186702E60
		public PhaserSprite setBlendMode(VampireSurvivors.Framework.Particles.BlendMode blendMode) => default; // 0x0000000186702E60-0x0000000186702F80
		public PhaserSprite setPosition(float2 value) => default; // 0x0000000186702F80-0x00000001867030F0
		public PhaserSprite setPosition(float x, float y) => default; // 0x00000001867030F0-0x0000000186703270
		public PhaserSprite setLocalPosition(float2 value) => default; // 0x0000000186703270-0x00000001867033E0
		public PhaserSprite setLocalPosition(float x, float y) => default; // 0x00000001867033E0-0x0000000186703560
		public PhaserSprite setParent(Transform parent, bool keepWorldPos = true /* Metadata: 0x019788C8 */) => default; // 0x0000000186703560-0x00000001867035B0
		public PhaserSprite setDrawModeSliced(float width, float height) => default; // 0x00000001867035B0-0x00000001867036F0
		public PhaserSprite setDrawModeSimple() => default; // 0x00000001867036F0-0x0000000186703800
		public void destroy() {} // 0x0000000186703800-0x00000001867038A0
		public PhaserSprite SetAsTiledSprite() => default; // 0x00000001867038A0-0x00000001867039B0
		public PhaserSprite SetTileSize(float width, float height) => default; // 0x00000001867039B0-0x0000000186703AA0
		public PhaserSprite SetTileWidth(float width) => default; // 0x0000000186703AA0-0x0000000186703BA0
		public PhaserSprite SetTileHeight(float height) => default; // 0x0000000186703BA0-0x0000000186703CA0
		public PhaserSprite SetMaterial(MaterialType material) => default; // 0x0000000186703CA0-0x0000000186703D30
		private void EnsureSpriteRenderer() {} // 0x0000000186703D30-0x0000000186704250
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Graphics
{
	public class TileSprite : GameMonoBehaviour // TypeDefIndex: 14539
	{
		// Fields
		private SpriteRenderer _spriteRenderer; // 0x28
		private SpriteScroller _spriteScroller; // 0x30
		private float _xScrollSpeed; // 0x38
		private float _yScrollSpeed; // 0x3C
		private float _xScrollOffset; // 0x40
		private float _yScrollOffset; // 0x44
		private float _tileWidth; // 0x48
		private float _tileHeight; // 0x4C
		private float _tileScaleX; // 0x50
		private float _tileScaleY; // 0x54
	
		// Properties
		public SpriteRenderer SpriteRenderer { get => default; set {} } // 0x0000000180B15540-0x0000000180B15550 0x0000000180B1D4C0-0x0000000180B1D520
		public SpriteScroller SpriteScroller { get => default; set {} } // 0x0000000180B15550-0x0000000180B15560 0x0000000180B1D520-0x0000000180B1D580
		public float TileWidth { get => default; set {} } // 0x00000001871A8ED0-0x00000001871A8F00 0x00000001871A8F00-0x00000001871A8F60
		public float TileHeight { get => default; set {} } // 0x00000001871A8F60-0x00000001871A8F90 0x00000001871A8F90-0x00000001871A8FF0
		public float TileScaleX { get => default; set {} } // 0x0000000183A343D0-0x0000000183A343E0 0x00000001871A8FF0-0x00000001871A91F0
		public float TileScaleY { get => default; set {} } // 0x0000000184C564B0-0x0000000184C564C0 0x00000001871A91F0-0x00000001871A93F0
	
		// Constructors
		public TileSprite() {} // 0x00000001871A9A00-0x00000001871A9A70
	
		// Methods
		public void SetLocalY(float yPos) {} // 0x00000001871A93F0-0x00000001871A9560
		public void SetFlipY(bool flip) {} // 0x00000001871A9560-0x00000001871A9580
		public void SetFrame(string frameName, string textureName) {} // 0x00000001871A9580-0x00000001871A9630
		public void SetScrollOffsetX(float pos, bool cumulative = true /* Metadata: 0x0197716B */) {} // 0x00000001871A9630-0x00000001871A9670
		public void SetScrollOffsetY(float pos, bool cumulative = true /* Metadata: 0x0197716C */) {} // 0x00000001871A9670-0x00000001871A96B0
		public void SetScrollSpeedX(float speed) {} // 0x00000001871A96B0-0x00000001871A96E0
		public void SetScrollSpeedY(float speed) {} // 0x00000001871A96E0-0x00000001871A9710
		public void SetVisible(bool visible) {} // 0x00000001871A9710-0x00000001871A9780
		public void destroy() {} // 0x00000001871A9780-0x00000001871A9820
		public TileSprite SetDepth(int depth) => default; // 0x00000001871A9820-0x00000001871A98A0
		public TileSprite SetTileScale(float xScale, float? yScale = default) => default; // 0x00000001871A98A0-0x00000001871A9970
		public new TileSprite SetName(string newName) => default; // 0x00000001866FF470-0x00000001866FF4B0
		public TileSprite SetMaterial(MaterialType materialType) => default; // 0x00000001871A9970-0x00000001871A9A00
	}
}

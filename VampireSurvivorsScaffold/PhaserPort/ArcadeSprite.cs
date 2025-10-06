/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

public class ArcadeSprite : PhaserGameObject // TypeDefIndex: 38098
{
	// Fields
	private SpriteRenderer _spriteRenderer; // 0x48
	private Transform _cachedTrans; // 0x50

	// Properties
	public SpriteRenderer Rend { get => default; } // 0x0000000184C45F10-0x0000000184C45F30 
	private Transform CachedTrans { get => default; } // 0x0000000184C45F30-0x0000000184C46050 
	public float2 position { get => default; set {} } // 0x0000000184C46050-0x0000000184C46150 0x0000000184C46150-0x0000000184C46310
	public float2 cachedPosition { get => default; } // 0x0000000184C463A0-0x0000000184C46550 
	public float scale { get => default; } // 0x0000000184C46550-0x0000000184C46610 
	public float angle { get => default; set {} } // 0x0000000184C466B0-0x0000000184C466E0 0x0000000184C466E0-0x0000000184C46760
	public float2 displaySize { get => default; } // 0x0000000184C46760-0x0000000184C46860 
	public bool flipX { get => default; } // 0x0000000184C46860-0x0000000184C46910 
	public bool flipY { get => default; } // 0x0000000184C46910-0x0000000184C469C0 
	public float2 origin { get => default; } // 0x0000000184C469C0-0x0000000184C46A00 
	public float2 size { get => default; } // 0x0000000184C46A00-0x0000000184C46A30 
	public PhaserScene scene { get => default; } // 0x0000000184C46A30-0x0000000184C46A70 
	public int depth { get => default; } // 0x0000000184C473D0-0x0000000184C47480 
	public override Rect? frame { get => default; } // 0x0000000184C48940-0x0000000184C48A50 

	// Constructors
	public ArcadeSprite() {} // 0x0000000184C44C90-0x0000000184C44CE0

	// Methods
	private static bool AreValuesBroken(Vector3 pos, float validRange = 100000f /* Metadata: 0x01AAC32B */) => default; // 0x0000000184C46310-0x0000000184C463A0
	public int GetFinalDepthRelative(int sortOrderOffset = 0 /* Metadata: 0x01AAC32F */) => default; // 0x0000000184C46610-0x0000000184C466B0
	protected void CheckRenderer() {} // 0x0000000184C46A70-0x0000000184C46CC0
	public void SetArcadeSpriteRenderer(SpriteRenderer spriteRenderer) {} // 0x000000018268E650-0x000000018268E6B0
	public void ForceInit() {} // 0x0000000184C46CC0-0x0000000184C46CD0
	public float2 getCenter() => default; // 0x0000000184C46CD0-0x0000000184C46D60
	public ArcadeSprite setOrigin(float oX = 0.5f /* Metadata: 0x01AAC330 */, float? oY = default) => default; // 0x0000000184C46D60-0x0000000184C46E20
	public void setOriginFromFrame() {} // 0x0000000184C46E20-0x0000000184C46FB0
	public ArcadeSprite setScale(float xScale, float? yScale = default) => default; // 0x0000000184C46FB0-0x0000000184C470E0
	public ArcadeSprite setDepth(int depth) => default; // 0x0000000184C470E0-0x0000000184C47250
	public ArcadeSprite setDepth(float depth) => default; // 0x0000000184C47250-0x0000000184C473D0
	public ArcadeSprite setFlipX(bool flipX) => default; // 0x0000000184C47480-0x0000000184C47580
	public ArcadeSprite setFlipY(bool flipY) => default; // 0x0000000184C47580-0x0000000184C47680
	public ArcadeSprite setVisible(bool visible) => default; // 0x0000000184C47680-0x0000000184C47780
	public ArcadeSprite setFrame(Sprite sprite) => default; // 0x0000000184C47780-0x0000000184C47930
	public ArcadeSprite setFrameIncludingOriginalSize(Sprite sprite, float2 originalSize) => default; // 0x0000000184C47930-0x0000000184C47B00
	public ArcadeSprite setAlpha(float alpha) => default; // 0x0000000184C47B00-0x0000000184C47D60
	public ArcadeSprite setTint(uint tint) => default; // 0x0000000184C47D60-0x0000000184C48000
	public ArcadeSprite setColor(Color color) => default; // 0x0000000184C48000-0x0000000184C48180
	public ArcadeSprite setTintFill(bool isEnabled, int tintColor) => default; // 0x0000000184C48180-0x0000000184C48190
	public ArcadeSprite setTintFill(bool isEnabled, uint tintColor) => default; // 0x0000000184C48190-0x0000000184C48290
	public ArcadeSprite setTintFill(bool isEnabled, Color? tintColor = default) => default; // 0x0000000184C48290-0x0000000184C485D0
	public ArcadeSprite setBounce(float2 bounce) => default; // 0x0000000184C485D0-0x0000000184C48610
	public void setVelocity(float xVel, float? yVel = default) {} // 0x0000000184C48610-0x0000000184C486A0
	public void setVelocity(Vector2 velocity) {} // 0x0000000184C486A0-0x0000000184C486E0
	public void setCollideWorldBounds(bool value, float? bounceX = default, float? bounceY = default) {} // 0x0000000184C486E0-0x0000000184C48940
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

public class TilemapSetCollider : Collider // TypeDefIndex: 38134
{
	// Fields
	private TilemapSet[] _tilemapSets; // 0x50
	private float4[] _tilemapSetBounds; // 0x58

	// Nested types
	private struct TilemapSet // TypeDefIndex: 38133
	{
		// Fields
		public List<PhaserTilemap> _tilemaps; // 0x00
	}

	// Constructors
	public TilemapSetCollider() {} // Dummy constructor
	public TilemapSetCollider(World world, bool overlapOnly, ArcadeColliderType object1, ArcadeColliderType object2, ArcadePhysicsCallback collideCallback = null, ArcadePhysicsCallback processCallback = null, CallbackContext callbackContext = null) {} // 0x0000000184C5E570-0x0000000184C5E820

	// Methods
	public void AddTilemap(int setID, PhaserTilemap tilemap) {} // 0x0000000184C5E820-0x0000000184C5E8A0
	public override void update() {} // 0x0000000184C5E8A0-0x0000000184C5EDA0
}


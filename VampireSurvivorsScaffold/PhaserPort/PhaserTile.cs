/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Tilemaps;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

public class PhaserTile : ArcadeColliderType // TypeDefIndex: 38103
{
	// Fields
	public int2 position; // 0x10
	public int _data; // 0x18
	private const int cFaceTop = 1; // Metadata: 0x01AAC335
	private const int cFaceBottom = 2; // Metadata: 0x01AAC336
	private const int cFaceLeft = 4; // Metadata: 0x01AAC337
	private const int cFaceRight = 8; // Metadata: 0x01AAC338
	public const int All = 15; // Metadata: 0x01AAC339
	public const int None = 0; // Metadata: 0x01AAC33A

	// Properties
	public bool faceLeft { get => default; set {} } // 0x0000000184C49C80-0x0000000184C49C90 0x0000000184C49C90-0x0000000184C49CC0
	public bool faceRight { get => default; set {} } // 0x0000000184C49CC0-0x0000000184C49CD0 0x0000000184C49CD0-0x0000000184C49D00
	public bool faceTop { get => default; set {} } // 0x0000000184C49D00-0x0000000184C49D10 0x0000000184C49D10-0x0000000184C49D40
	public bool faceBottom { get => default; set {} } // 0x0000000184C49D40-0x0000000184C49D50 0x0000000184C49D50-0x0000000184C49D80
	public bool collideLeft { get => default; } // 0x0000000181958370-0x0000000181958380 
	public bool collideRight { get => default; } // 0x0000000181958370-0x0000000181958380 
	public bool collideUp { get => default; } // 0x0000000181958370-0x0000000181958380 
	public bool collideDown { get => default; } // 0x0000000181958370-0x0000000181958380 
	public bool isParent { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	public BaseBody body { get => default; } // 0x0000000180B15D70-0x0000000180B15D80 
	public bool isTilemap { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	public GameObject gameObject { get => default; } // 0x0000000180B15D70-0x0000000180B15D80 

	// Constructors
	public PhaserTile() {} // Dummy constructor
	public PhaserTile(int x, int y) {} // 0x0000000184C49D80-0x0000000184C49DA0

	// Methods
	private bool isTileEmpty(Tilemap tiles, int x, int y, BoundsInt bounds) => default; // 0x0000000184C49DA0-0x0000000184C49F20
	private bool isPhaserTileEmpty(PhaserTile[] tiles, int x, int y, BoundsInt layerBounds, BoundsInt mapBounds) => default; // 0x0000000184C49F20-0x0000000184C4A0B0
	public void updateTileFaces(PhaserTile[] tiles, BoundsInt layerBounds, BoundsInt mapBounds, bool isInverse) {} // 0x0000000184C4A0B0-0x0000000184C4A2C0
	public void drawDebug(PhaserTilemap layer) {} // 0x0000000184C4A2C0-0x0000000184C4A6C0
}


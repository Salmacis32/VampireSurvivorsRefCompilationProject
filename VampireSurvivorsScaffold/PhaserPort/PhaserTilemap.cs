/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SuperTiled2Unity;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Tilemaps;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

public class PhaserTilemap : PhaserGameObject // TypeDefIndex: 38104
{
	// Fields
	public Tilemap _layer; // 0x48
	public PhaserTilemapBoundingBoxes _boundingBoxes; // 0x50
	private SuperMap _map; // 0x58
	[NonSerialized]
	public PhaserTile[] _phaserTiles; // 0x60
	[NonSerialized]
	public BoundsInt _bounds; // 0x68
	[NonSerialized]
	public float4 _worldBounds; // 0x80
	[NonSerialized]
	public float4 _parentBounds; // 0x90
	[NonSerialized]
	public int _parentSetID; // 0xA0
	private BoundsInt[] _loadedBounds; // 0xA8
	private bool _isInverse; // 0xB0
	[NonSerialized]
	public float4[] precachedBounds; // 0xB8
	public TilemapDataCache data; // 0xC0

	// Properties
	public override bool isParent { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	public override bool isTilemap { get => default; } // 0x0000000181958370-0x0000000181958380 

	// Constructors
	public PhaserTilemap() {} // 0x0000000184C44C90-0x0000000184C44CE0

	// Methods
	private new void Awake() {} // 0x0000000184C4A6C0-0x0000000184C4AD40
	public void RefreshData() {} // 0x0000000184C4AD40-0x0000000184C4B850
	public void RemoveTileAt(int tileX, int tileY) {} // 0x0000000184C4B850-0x0000000184C4B930
	public void UpdatePrecachedData() {} // 0x0000000184C4B930-0x0000000184C4C0F0
	public void UpdateTilemapBounds(Bounds parentBounds) {} // 0x0000000184C4C0F0-0x0000000184C4C6C0
	public int GetTilesInBounds(BoundsInt targetBounds, PhaserTile[] tileCache) => default; // 0x0000000184C4C6C0-0x0000000184C4C860
	public bool IsTileAtPosition(float2 position) => default; // 0x0000000184C4C860-0x0000000184C4C940
	public bool IsTileAtPositionWrapped(float2 position) => default; // 0x0000000184C4C940-0x0000000184C4CA00
	public PhaserTile GetTileAtCellPosition(int2 cellPos) => default; // 0x0000000184C4CA00-0x0000000184C4CA70
}


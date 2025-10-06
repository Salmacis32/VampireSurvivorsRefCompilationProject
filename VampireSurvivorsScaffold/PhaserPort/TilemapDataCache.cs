/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Tilemaps;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

public struct TilemapDataCache // TypeDefIndex: 38166
{
	// Fields
	public float2 worldpos; // 0x00
	public float2 size; // 0x08
	public BoundsInt worldBounds; // 0x10

	// Constructors
	public TilemapDataCache(Tilemap layer) {
		worldpos = default;
		size = default;
		worldBounds = default;
	} // 0x0000000184C6C8A0-0x0000000184C6CB00
	public TilemapDataCache(PhaserTilemap tilemap) {
		worldpos = default;
		size = default;
		worldBounds = default;
	} // 0x0000000184C6CC00-0x0000000184C6CC20

	// Methods
	public float2 CellToWorld(float2 pos) => default; // 0x0000000184C6CB00-0x0000000184C6CB40
	public float2 CellToWorld(int2 pos) => default; // 0x0000000184C6CB40-0x0000000184C6CB80
	[Il2CppSetOption(Option.DivideByZeroChecks, false)]
	public int2 WorldToCell(float2 pos) => default; // 0x0000000184C6CB80-0x0000000184C6CC00
}


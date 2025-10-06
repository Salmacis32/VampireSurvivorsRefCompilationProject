/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Tilemaps;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

public class PhaserTilemapBoundingBoxesAsset : ScriptableObject // TypeDefIndex: 38114
{
	// Fields
	private const int NotSet = 9999; // Metadata: 0x01AAC365
	public Hash128 hash; // 0x18
	public BoundCombine combine; // 0x28
	public List<BoundsInt> allBounds; // 0x30

	// Nested types
	[Serializable]
	public struct BoundCombine // TypeDefIndex: 38110
	{
		// Fields
		public int bound1; // 0x00
		public int bound2; // 0x04

		// Methods
		public bool IsValid(int count) => default; // 0x0000000184C52190-0x0000000184C521B0
	}

	// Constructors
	public PhaserTilemapBoundingBoxesAsset() {} // 0x0000000184C520C0-0x0000000184C52190

	// Methods
	public static Hash128 CalculateHash(Tilemap tilemap) => default; // 0x0000000184C4FAB0-0x0000000184C4FF10
	public void MakeWholeBound(PhaserTilemap from) {} // 0x0000000184C4FF10-0x0000000184C50190
	public void Setup(PhaserTilemap from) {} // 0x0000000184C50190-0x0000000184C51400
	public void CombineTiles(BoundCombine combineInstance) {} // 0x0000000184C51400-0x0000000184C51660
	private int NumCombinable(List<BoundsInt> nextGroup) => default; // 0x0000000184C51660-0x0000000184C519E0
	private BoundsInt CombineBoundsY(List<BoundsInt> nextGroup) => default; // 0x0000000184C519E0-0x0000000184C51D20
	private BoundsInt CombineBounds(List<BoundsInt> nextGroup) => default; // 0x0000000184C51D20-0x0000000184C51E90
	private BoundsInt Combine(BoundsInt i1, BoundsInt i2) => default; // 0x0000000184C51E90-0x0000000184C520C0
}


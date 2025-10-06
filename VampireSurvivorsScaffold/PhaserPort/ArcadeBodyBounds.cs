/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

[Serializable]
public class ArcadeBodyBounds : RBush.IRectangular // TypeDefIndex: 38135
{
	// Fields
	public float x; // 0x20
	public float y; // 0x24
	public float width; // 0x28
	public float height; // 0x2C

	// Properties
	public float left { get => default; set {} } // 0x0000000181967D10-0x0000000181967D20 0x0000000184C5EF70-0x0000000184C5EF80
	public float top { get => default; set {} } // 0x0000000184C5EF80-0x0000000184C5EF90 0x0000000184C5EF90-0x0000000184C5EFA0
	public float right { get => default; } // 0x0000000184C5EFA0-0x0000000184C5EFB0 
	public float bottom { get => default; } // 0x0000000184C5EFB0-0x0000000184C5EFC0 
	public float minX { get => default; } // 0x0000000181967D10-0x0000000181967D20 
	public float minY { get => default; } // 0x0000000184C5EF80-0x0000000184C5EF90 
	public float maxX { get => default; } // 0x0000000184C5EFA0-0x0000000184C5EFB0 
	public float maxY { get => default; } // 0x0000000184C5EFB0-0x0000000184C5EFC0 

	// Constructors
	public ArcadeBodyBounds() {} // 0x0000000184C5EDA0-0x0000000184C5EDF0
	public ArcadeBodyBounds(float x, float y, float width, float height) {} // 0x0000000184C5EDF0-0x0000000184C5EE80

	// Methods
	public static ArcadeRect FromBounds(float x, float y, float right, float bottom) => default; // 0x0000000184C5EE80-0x0000000184C5EF70
	public void setTo(float x, float y, float width, float height) {} // 0x0000000184C5EFC0-0x0000000184C5EFE0
	public bool contains(float2 position) => default; // 0x0000000184C5EFE0-0x0000000184C5F020
	public float2 randomPoint() => default; // 0x0000000184C5F020-0x0000000184C5F110
}


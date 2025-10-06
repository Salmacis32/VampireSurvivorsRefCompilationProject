/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

[Serializable]
public struct ArcadeRect // TypeDefIndex: 38118
{
	// Fields
	public float x; // 0x00
	public float y; // 0x04
	public float width; // 0x08
	public float height; // 0x0C

	// Properties
	public float left { get => default; set {} } // 0x00000001832F7330-0x00000001832F7340 0x0000000184C548C0-0x0000000184C548D0
	public float top { get => default; set {} } // 0x00000001833571F0-0x0000000183357200 0x0000000184C548D0-0x0000000184C548E0
	public float right { get => default; } // 0x0000000184C548E0-0x0000000184C548F0 
	public float bottom { get => default; } // 0x0000000184C548F0-0x0000000184C54900 

	// Constructors
	public ArcadeRect(float2 pos, float2 size) : this() {
		x = default;
		y = default;
		width = default;
		height = default;
	} // 0x0000000184C54760-0x0000000184C547A0
	public ArcadeRect(float x, float y, float2 size) : this() {
		this.x = default;
		this.y = default;
		width = default;
		height = default;
	} // 0x0000000184C547A0-0x0000000184C547D0
	public ArcadeRect(float x, float y, float width, float height) : this() {
		this.x = default;
		this.y = default;
		this.width = default;
		this.height = default;
	} // 0x0000000180B3E940-0x0000000180B3E960

	// Methods
	public static ArcadeRect FromBounds(float x, float y, float right, float bottom) => default; // 0x0000000184C547D0-0x0000000184C548C0
	public void setTo(float x, float y, float width, float height) {} // 0x0000000180B3E940-0x0000000180B3E960
	public bool contains(float2 position) => default; // 0x0000000184C54900-0x0000000184C54940
}


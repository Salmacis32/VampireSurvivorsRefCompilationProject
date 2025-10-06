/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

[Serializable]
[Obsolete("Vector2Double is obsolete, use float2 instead. Don\'t use double, please.", true)]
public struct Vector2Double // TypeDefIndex: 38106
{
	// Fields
	public double x; // 0x00
	public double y; // 0x08

	// Properties
	public static Vector2Double zero { get => default; } // 0x0000000181B537E0-0x0000000181B537F0 

	// Constructors
	public Vector2Double(double x, double y) : this() {
		this.x = default;
		this.y = default;
	} // 0x0000000183D2E7D0-0x0000000183D2E7E0

	// Methods
	public static Vector2Double operator +(Vector2Double a, Vector2Double b) => default; // 0x0000000184C4DB30-0x0000000184C4DB60
	public static Vector2Double operator -(Vector2Double a, Vector2Double b) => default; // 0x0000000184C4DB60-0x0000000184C4DB90
	public static Vector2Double operator *(Vector2Double a, double scale) => default; // 0x0000000184C4DB90-0x0000000184C4DBB0
	public static Vector2Double operator /(Vector2Double a, double scale) => default; // 0x0000000184C4DBB0-0x0000000184C4DBD0
	public static Vector2Double operator *(Vector2Double a, Vector2Double b) => default; // 0x0000000184C4DBD0-0x0000000184C4DC00
	public static bool operator ==(Vector2Double a, Vector2Double b) => default; // 0x0000000184C4DC00-0x0000000184C4DC20
	public static bool operator !=(Vector2Double a, Vector2Double b) => default; // 0x0000000184C4DC20-0x0000000184C4DC40
	public void Set(double x, double y) {} // 0x0000000183D2E7D0-0x0000000183D2E7E0
	public void Set(double value) {} // 0x0000000184C4DC40-0x0000000184C4DC50
	public Vector2Double setToPolar(double azimuth, double radius = 1 /* Metadata: 0x01AAC359 */) => default; // 0x0000000184C4DC50-0x0000000184C4DD00
	public Vector2Double normalize() => default; // 0x0000000184C4DD00-0x0000000184C4DDC0
	public Vector2Double scale(double scalar) => default; // 0x0000000184C4DB90-0x0000000184C4DBB0
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

public struct ArcadeBodyCollision // TypeDefIndex: 38136
{
	// Fields
	private const int cup = 1; // Metadata: 0x01AAC38D
	private const int cdown = 2; // Metadata: 0x01AAC38E
	private const int cleft = 4; // Metadata: 0x01AAC38F
	private const int cright = 8; // Metadata: 0x01AAC390
	public const int All = 15; // Metadata: 0x01AAC391
	public const int None = 0; // Metadata: 0x01AAC392
	private int _data; // 0x00

	// Properties
	public bool none { get => default; set {} } // 0x0000000184C5F110-0x0000000184C5F120 0x0000000184C5F120-0x0000000184C5F140
	public bool up { get => default; set {} } // 0x0000000184C5F140-0x0000000184C5F150 0x0000000184C5F150-0x0000000184C5F170
	public bool down { get => default; set {} } // 0x0000000184C5F170-0x0000000184C5F180 0x0000000184C5F180-0x0000000184C5F1A0
	public bool left { get => default; set {} } // 0x0000000184C5F1A0-0x0000000184C5F1B0 0x0000000184C5F1B0-0x0000000184C5F1D0
	public bool right { get => default; set {} } // 0x0000000184C5F1D0-0x0000000184C5F1E0 0x0000000184C5F1E0-0x0000000184C5F200

	// Constructors
	public ArcadeBodyCollision(bool none, bool up, bool down, bool left, bool right) : this() {
		_data = default;
	} // 0x0000000184C5F200-0x0000000184C5F240
	public ArcadeBodyCollision(int data = 0 /* Metadata: 0x01AAC38C */) : this() {
		_data = default;
	} // 0x0000000181963E50-0x0000000181963E60

	// Methods
	public void Clear() {} // 0x000000018497C470-0x000000018497C480
}


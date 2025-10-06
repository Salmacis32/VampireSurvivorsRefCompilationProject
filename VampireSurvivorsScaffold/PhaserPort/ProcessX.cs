/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

public class ProcessX // TypeDefIndex: 38129
{
	// Fields
	private static BaseBody body1; // 0x00
	private static BaseBody body2; // 0x08
	private static bool body1Pushable; // 0x10
	private static bool body2Pushable; // 0x11
	private static float body1MassImpact; // 0x14
	private static float body2MassImpact; // 0x18
	private static float body1FullImpact; // 0x1C
	private static float body2FullImpact; // 0x20
	private static bool body1MovingLeft; // 0x24
	private static bool body1MovingRight; // 0x25
	private static bool body1Stationary; // 0x26
	private static bool body2MovingLeft; // 0x27
	private static bool body2MovingRight; // 0x28
	private static bool body2Stationary; // 0x29
	private static bool body1OnLeft; // 0x2A
	private static bool body2OnLeft; // 0x2B
	private static float overlap; // 0x2C

	// Constructors
	public ProcessX() {} // 0x0000000180B15170-0x0000000180B15180

	// Methods
	public static int Set(BaseBody b1, BaseBody b2, float ov) => default; // 0x0000000184C5AB10-0x0000000184C5AEE0
	public static int BlockCheck() => default; // 0x0000000184C5AEE0-0x0000000184C5B0F0
	public static bool Check() => default; // 0x0000000184C5B0F0-0x0000000184C5B2F0
	public static bool Run(int side) => default; // 0x0000000184C5B2F0-0x0000000184C5BA10
	public static void RunImmovableBody1(int blockedState) {} // 0x0000000184C5BA10-0x0000000184C5BC10
	public static void RunImmovableBody2(int blockedState) {} // 0x0000000184C5BC10-0x0000000184C5BE10
}


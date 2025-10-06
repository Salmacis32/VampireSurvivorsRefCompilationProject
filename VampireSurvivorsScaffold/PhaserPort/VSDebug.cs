/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

public class VSDebug // TypeDefIndex: 38108
{
	// Fields
	private static Material _debugMat; // 0x00
	private static Mesh _debugMesh; // 0x08
	private static List<Vector3> _debugLineVerts; // 0x10
	private static List<Color> _debugLineColours; // 0x18
	private static List<int> _debugLineIndices; // 0x20
	public static bool s_drawDebug; // 0x28

	// Constructors
	public VSDebug() {} // 0x0000000180B15170-0x0000000180B15180
	static VSDebug() {} // 0x0000000184C4F320-0x0000000184C4F6E0

	// Methods
	public static void Init() {} // 0x0000000184C4DF50-0x0000000184C4E2B0
	public static void FlushDebugLines(Vector3 offset) {} // 0x0000000184C4E2B0-0x0000000184C4E510
	public static void ClearDebugLines() {} // 0x0000000184C4E510-0x0000000184C4E5F0
	public static void DrawDebugLine(float2 point1, float2 point2) {} // 0x0000000184C4E5F0-0x0000000184C4E690
	public static void DrawDebugLine(float2 point1, float2 point2, Color colour) {} // 0x0000000184C4E690-0x0000000184C4E720
	public static void DrawDebugLine(double x1, double y1, double x2, double y2) {} // 0x0000000184C4E720-0x0000000184C4E7F0
	public static void DrawDebugLine(double x1, double y1, double x2, double y2, Color colour) {} // 0x0000000184C4E7F0-0x0000000184C4E8C0
	public static void DrawDebugLine(float x1, float y1, float x2, float y2, Color colour) {} // 0x0000000184C4E8C0-0x0000000184C4ECC0
	public static void DrawDebugRect(double x, double y, double width, float height) {} // 0x0000000184C4ECC0-0x0000000184C4ED90
	public static void DrawDebugRect(double x, double y, double width, double height, Color colour) {} // 0x0000000184C4ED90-0x0000000184C4EEF0
	public static void DrawDebugCircle(double x, double y, double radius) {} // 0x0000000184C4EEF0-0x0000000184C4EFA0
	public static void DrawDebugCircle(double x, double y, double radius, Color colour) {} // 0x0000000184C4EFA0-0x0000000184C4F1C0
	public static void DrawBounds(Bounds bounds, Color colour) {} // 0x0000000184C4F1C0-0x0000000184C4F320
}


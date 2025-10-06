/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using Unity.Mathematics;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

public class MathUtils // TypeDefIndex: 38105
{
	// Fields
	public const float CONST_EPSILON = 1E-06f; // Metadata: 0x01AAC34D
	public const float Rad2Deg = 57.29578f; // Metadata: 0x01AAC351
	public const float Deg2Rad = 0.017453292f; // Metadata: 0x01AAC355

	// Constructors
	public MathUtils() {} // 0x0000000180B15170-0x0000000180B15180

	// Methods
	public static float Clamp(float v, float min, float max) => default; // 0x0000000184C4CA70-0x0000000184C4CAA0
	public static float DistanceBetweenSqrd(float x1, float y1, float x2, float y2) => default; // 0x0000000184C4CAA0-0x0000000184C4CAC0
	public static float DistanceBetween(float x1, float y1, float x2, float y2) => default; // 0x0000000184C4CAC0-0x0000000184C4CAE0
	public static float AngleBetweenPoints(float2 p1, float2 p2) => default; // 0x0000000184C4CAE0-0x0000000184C4CB10
	public static bool FuzzyEqual(float value, float target, float range = 0.0001f /* Metadata: 0x01AAC33B */) => default; // 0x0000000184C4CB10-0x0000000184C4CB30
	public static bool FuzzyGreaterThan(float value, float target, float range = 0.0001f /* Metadata: 0x01AAC33F */) => default; // 0x0000000184C4CB30-0x0000000184C4CB40
	public static bool FuzzyLessThan(float value, float target, float range = 0.0001f /* Metadata: 0x01AAC343 */) => default; // 0x0000000184C4CB40-0x0000000184C4CB50
	public static float Min(float a, float b, float c, float d) => default; // 0x0000000184C4CB50-0x0000000184C4CBA0
	public static float Max(float a, float b, float c, float d) => default; // 0x0000000184C4CBA0-0x0000000184C4CBF0
	public static int CeilToIntClamped(float v, int minValue = 2147483647 /* Metadata: 0x01AAC347 */, int maxValue = 2147483647 /* Metadata: 0x01AAC348 */) => default; // 0x0000000184C4CBF0-0x0000000184C4CC50
	public static int FloorToIntClamped(float v, int minValue = 2147483647 /* Metadata: 0x01AAC349 */, int maxValue = 2147483647 /* Metadata: 0x01AAC34A */) => default; // 0x0000000184C4CC50-0x0000000184C4CCB0
	public static int RoundToIntClamped(float v, int minValue = 2147483647 /* Metadata: 0x01AAC34B */, int maxValue = 2147483647 /* Metadata: 0x01AAC34C */) => default; // 0x0000000184C4CCB0-0x0000000184C4CD10
	public static float SubtractValueCapped(float baseValue, float valueToSubtract) => default; // 0x0000000184C4CD10-0x0000000184C4CD90
	public static float AddValueCapped(float baseValue, float valueToAdd) => default; // 0x0000000182CA8000-0x0000000182CA8040
	public static float FixFloatOverflowPositive(float value) => default; // 0x0000000184C4CD90-0x0000000184C4CDD0
	public static float TryFixNegativeFloat(float value) => default; // 0x0000000184C4CDD0-0x0000000184C4CE20
	public static int Pow(int num, int exp) => default; // 0x0000000184C4CE20-0x0000000184C4CE40
	[Il2CppSetOption(Option.DivideByZeroChecks, false)]
	public static int DivideRoundingUp(int a, int b) => default; // 0x0000000184C4CE40-0x0000000184C4CE50
	public static bool LineToLineIntersection(float2 startA, float2 endA, float2 startB, float2 endB, out float2 intersection) {
		intersection = default;
		return default;
	} // 0x0000000184C4CE50-0x0000000184C4CFE0
	public static float2 RotateFloat2(float2 vector, float angleDegrees) => default; // 0x0000000184C4CFE0-0x0000000184C4D060
	public static int WrapInsideRange(int value, int range) => default; // 0x0000000184C4D060-0x0000000184C4D080
	public static float2 RandomPointInAnnulus(float2 origin, float minRadius, float maxRadius) => default; // 0x0000000184C4D080-0x0000000184C4D180
	public static bool IsInsideCircle(float x, float y, float radius, float pointX, float pointY) => default; // 0x0000000184C4D180-0x0000000184C4D1B0
	public static float GetOverlapX(BaseBody body1, BaseBody body2, bool overlapOnly, float bias) => default; // 0x0000000184C4D1B0-0x0000000184C4D380
	public static float GetOverlapY(BaseBody body1, BaseBody body2, bool overlapOnly, float bias) => default; // 0x0000000184C4D380-0x0000000184C4D550
	public static bool SeparateX(BaseBody body1, BaseBody body2, bool overlapOnly, float bias) => default; // 0x0000000184C4D550-0x0000000184C4D630
	public static bool SeparateY(BaseBody body1, BaseBody body2, bool overlapOnly, float bias) => default; // 0x0000000184C4D630-0x0000000184C4D710
	public static float TileCheckX(Body body, PhaserTile tile, float tileLeft, float tileRight, float tileBias, bool isLayer) => default; // 0x0000000184C4D710-0x0000000184C4D890
	private static void ProcessTileSeparationX(Body body, float x) {} // 0x0000000184C4D890-0x0000000184C4D920
	public static float TileCheckY(Body body, PhaserTile tile, float tileTop, float tileBottom, float tileBias, bool isLayer) => default; // 0x0000000184C4D920-0x0000000184C4DAA0
	private static void ProcessTileSeparationY(Body body, float y) {} // 0x0000000184C4DAA0-0x0000000184C4DB30
}


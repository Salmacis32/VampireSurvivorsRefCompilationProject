/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Tools
{
	public static class MathTools // TypeDefIndex: 14276
	{
		// Methods
		public static bool ContainsRect(Rect rectA, Rect rectB) => default; // 0x0000000187047760-0x0000000187047810
		public static Vector2 RandomOutside(Rect outer, Rect inner) => default; // 0x0000000187047810-0x0000000187047AB0
		public static List<Vector2> GetPointsOnCircle(int count, float radius = 1f /* Metadata: 0x01977122 */) => default; // 0x0000000187047AB0-0x0000000187047C50
		public static List<Vector2> GetPoints(int count, float spawnAngle, float radius = 1f /* Metadata: 0x01977126 */) => default; // 0x0000000187047C50-0x0000000187047DD0
		public static float DistanceSq(Vector2 v1, Vector2 v2) => default; // 0x00000001851CA8D0-0x00000001851CA910
		public static T FurthestObject<T>(Vector2 source, List<T> targets)
			where T : Component => default;
		public static T FurthestObject<T>(Vector2 source, HashSet<T> targets)
			where T : Component => default;
		public static List<T> ListNearestToFarthest<T>(Vector2 source, HashSet<T> targets)
			where T : Component => default;
		public static GameObject FurthestGameObject(Vector2 source, List<GameObject> targets) => default; // 0x0000000187047DD0-0x00000001870480A0
		public static GameObject FurthestGameObject(Vector2 source, Dictionary<int, GameObject> targets, out float max) {
			max = default;
			return default;
		} // 0x00000001870480A0-0x00000001870483F0
		public static GameObject FurthestGameObject(List<Vector2> sources, Dictionary<int, GameObject> targets) => default; // 0x00000001870483F0-0x00000001870488C0
	
		// Extension methods
		public static Vector2 SetToPolar(this Vector2 v2, float azimuth, float radius) => default; // 0x00000001870476E0-0x0000000187047740
		public static float Remap(this float value, float from1, float to1, float from2, float to2) => default; // 0x0000000187047740-0x0000000187047760
	}
}

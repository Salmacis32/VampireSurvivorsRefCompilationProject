/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using Unity.Burst;
using Unity.IL2CPP.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Tools
{
	[BurstCompile]
	public static class Extensions // TypeDefIndex: 18549
	{
		// Extension methods
		public static void Shuffle<T>(this IList<T> list) {}
		public static void Shuffle<T>(this IList<T> list, Unity.Mathematics.Random random) {}
		public static string Shuffle(this string str) => default; // 0x00000001867CABF0-0x00000001867CADA0
		[IteratorStateMachine(typeof(_SplitList_d__3<T>))]
		public static IEnumerable<List<T>> SplitList<T>(this List<T> locations, int nSize = 30 /* Metadata: 0x0197AA17 */) => default;
		public static void SetPivot(this RectTransform rectTransform, Vector2 pivot) {} // 0x00000001867CADA0-0x00000001867CB2D0
		public static Vector2 GetSize(this RectTransform rTrans) => default; // 0x00000001867CB2D0-0x00000001867CB480
		public static Rect RectTransformToScreenSpace(this RectTransform transform, Camera cam, bool cutDecimals = false /* Metadata: 0x0197AA18 */) => default; // 0x00000001867CB480-0x00000001867CB6F0
		public static Rect GetWorldRect(this RectTransform rectTransform) => default; // 0x00000001867CB6F0-0x00000001867CBA00
		public static Vector3 GetLocalAnchorPosInParent(this RectTransform rectTransform, RectTransform parent) => default; // 0x00000001867CBA00-0x00000001867CBDF0
		public static T PickRnd<T>(this T[] array) => default;
		public static T PickRnd<T>(this IList<T> list) => default;
		public static void RemoveWhere<T>(this ICollection<T> collection, Func<T, bool> condition) {}
		public static T GetOrAddComponent<T>(this GameObject gameObject)
			where T : Component => default;
		public static void RefreshLayoutGroupsImmediateAndRecursive(this RectTransform g) {} // 0x00000001867CBDF0-0x00000001867CBED0
		public static Vector2 GetProperSize(this RectTransform rectTransform) => default; // 0x00000001867CBED0-0x00000001867CC1A0
		public static bool AnyDown(this Player self) => default; // 0x00000001867CC1A0-0x00000001867CC330
		[Il2CppSetOption(Option.NullChecks, false)]
		public static bool ContainsFast(this ref Rect rect, float x, float y) => default; // 0x00000001867CC330-0x00000001867CC370
		[Il2CppSetOption(Option.NullChecks, false)]
		public static bool ContainsFast(this Rect rect, float2 position) => default; // 0x00000001867CC370-0x00000001867CC3C0
		[Il2CppSetOption(Option.NullChecks, false)]
		public static float2 Restrict(this ref Rect rect, float2 position) => default; // 0x00000001867CC3C0-0x00000001867CC430
		public static void SetNavigationUp(this Selectable origin, Selectable target = null) {} // 0x00000001867CC430-0x00000001867CC690
		public static void SetNavigationDown(this Selectable origin, Selectable target = null) {} // 0x00000001867CC690-0x00000001867CC920
		public static void SetNavigationLeft(this Selectable origin, Selectable target = null) {} // 0x00000001867CC920-0x00000001867CCBB0
		public static void SetNavigationRight(this Selectable origin, Selectable target = null) {} // 0x00000001867CCBB0-0x00000001867CCE10
		public static void SetNavigationMode(this Selectable origin, Navigation.Mode mode) {} // 0x00000001867CCE10-0x00000001867CCE60
		public static void ClearNavigation(this Selectable s) {} // 0x00000001867CCE60-0x00000001867CD030
		public static string FirstCharToUpper(this string input) => default; // 0x00000001867CD030-0x00000001867CD1F0
		public static Vector3 GetScreenPosFromAnchorPos(this RectTransform r) => default; // 0x00000001867CD1F0-0x00000001867CD730
		public static void SetCurveLinear(this AnimationCurve curve) {} // 0x00000001867CD730-0x00000001867CDA90
	}
}

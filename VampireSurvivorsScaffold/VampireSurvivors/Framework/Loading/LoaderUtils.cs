/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.ResourceManagement.AsyncOperations;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Loading
{
	public static class LoaderUtils // TypeDefIndex: 18274
	{
		// Fields
		public static readonly System.Type TEX2DType; // 0x00
		public static readonly System.Type VideoClipType; // 0x08
	
		// Constructors
		static LoaderUtils() {} // 0x0000000186726B60-0x0000000186726D30
	
		// Methods
		public static string GetDynamicLabel(DlcType? dlcType) => default; // 0x0000000186726AB0-0x0000000186726B60
		public static void WaitForAsyncLoad<T>(AsyncOperationHandle<T> operationHandle, Action<T> onComplete, Action<T> onError, string errorPrefix = "WaitForAsyncLoad" /* Metadata: 0x01978908 */, bool forceSync = false /* Metadata: 0x01978919 */) {}
	}
}

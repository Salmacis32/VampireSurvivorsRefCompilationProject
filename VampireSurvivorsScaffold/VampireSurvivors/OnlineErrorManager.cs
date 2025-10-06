/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class OnlineErrorManager : MonoBehaviour // TypeDefIndex: 14218
	{
		// Fields
		private static OnlineErrorManager Instance; // 0x00
		[Inject]
		private SignalBus _signalBus; // 0x20
		private LobbiesManager _lobbiesManager; // 0x28
	
		// Constructors
		public OnlineErrorManager() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		[Inject]
		private void Construct(LobbiesManager lobbiesManager) {} // 0x0000000180B1D4C0-0x0000000180B1D520
		private void Awake() {} // 0x0000000186EF0880-0x0000000186EF0920
		public void Initialize() {} // 0x0000000180B15170-0x0000000180B15180
		public void Dispose() {} // 0x0000000180B15170-0x0000000180B15180
		public static void ShowError(OnlineErrorType type, string msg) {} // 0x0000000186EF0920-0x0000000186EF0E90
		private string TypeToString(OnlineErrorType type) => default; // 0x0000000186EF0E90-0x0000000186EF0FC0
	}
}

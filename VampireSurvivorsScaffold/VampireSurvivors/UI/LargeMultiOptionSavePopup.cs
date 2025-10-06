/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class LargeMultiOptionSavePopup : LargeMultiOptionPopup // TypeDefIndex: 14827
	{
		// Fields
		[SerializeField]
		private GameObject _CancelButton; // 0x90
	
		// Constructors
		public LargeMultiOptionSavePopup() {} // 0x00000001867AC2E0-0x00000001867AC2F0
	
		// Methods
		public void Initialize(string id, string title, string description, List<SaveOptionDataSet> options, Action<int> callback, bool hasCancelButton = false /* Metadata: 0x01977213 */, Action onCancel = null) {} // 0x00000001868BA2C0-0x00000001868BB390
		[IteratorStateMachine(typeof(_FrameDelays_d__2))]
		private new IEnumerator FrameDelays() => default; // 0x00000001868BB390-0x00000001868BB430
	}
}

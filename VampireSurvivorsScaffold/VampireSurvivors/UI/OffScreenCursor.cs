/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Framework.Cursors;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class OffScreenCursor : MonoBehaviour // TypeDefIndex: 14875
	{
		// Fields
		[SerializeField]
		private Image _CursorRenderer; // 0x20
		[SerializeField]
		private UISpriteAnimation _ImageSpriteAnimation; // 0x28
		[SerializeField]
		private Image _IconRenderer; // 0x30
		[SerializeField]
		private GameObject _Target; // 0x38
	
		// Properties
		public CursorData Data { get; private set; } // 0x0000000180B15750-0x0000000180B15760 0x000000018260F820-0x000000018260F880
	
		// Constructors
		public OffScreenCursor() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Update() {} // 0x00000001868F62C0-0x00000001868F6340
		public void Init(CursorData cursorData, GameObject target) {} // 0x00000001868F6340-0x00000001868F67D0
		private void InitAnimation(CursorData cursorData) {} // 0x00000001868F67D0-0x00000001868F69A0
	}
}

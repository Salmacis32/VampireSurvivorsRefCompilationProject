/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using QFSW.MOP2;
using TMPro;
using UnityEngine;
using VampireSurvivors.Graphics;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Cursors
{
	public class CursorIndicator : PoolableMonoBehaviour // TypeDefIndex: 18369
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _CursorRenderer; // 0x30
		[SerializeField]
		private SpriteRenderer _IconRenderer; // 0x38
		[SerializeField]
		private SpriteAnimation _CursorAnimation; // 0x40
		[SerializeField]
		private TextMeshPro _Text; // 0x48
	
		// Properties
		public CursorData Data { get; private set; } // 0x000000018197EAB0-0x000000018197EAC0 0x000000018261D810-0x000000018261D870
		public GameObject Target { get; private set; } // 0x0000000180B15730-0x0000000180B15740 0x00000001826E9730-0x00000001826E9790
		public SpriteRenderer CursorRenderer { get => default; } // 0x0000000180B15550-0x0000000180B15560 
	
		// Constructors
		public CursorIndicator() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		public void Init(CursorData cursorData, GameObject target) {} // 0x000000018673CAD0-0x000000018673D420
		public void Despawn() {} // 0x000000018673D420-0x000000018673D4B0
		private void InitAnimation(CursorData cursorData) {} // 0x000000018673D4B0-0x000000018673D5F0
		public void SetVisible(bool visible) {} // 0x000000018673D5F0-0x000000018673D640
	}
}

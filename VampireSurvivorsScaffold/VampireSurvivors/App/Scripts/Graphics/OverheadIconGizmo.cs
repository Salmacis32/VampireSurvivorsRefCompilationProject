/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using QFSW.MOP2;
using UnityEngine;
using VampireSurvivors.App.Graphics;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Graphics
{
	public class OverheadIconGizmo : PoolableMonoBehaviour // TypeDefIndex: 18664
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _Icon; // 0x30
		[SerializeField]
		private GenericShadowText _TextValue; // 0x38
	
		// Properties
		public SpriteRenderer Icon { get => default; } // 0x0000000180B15550-0x0000000180B15560 
		public GenericShadowText TextValue { get => default; } // 0x0000000180B15560-0x0000000180B15570 
	
		// Constructors
		public OverheadIconGizmo() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		public void Play(string frameName, string value, Color? color, VampireSurvivors.Objects.Characters.CharacterController character, float displayTimeMultiplier = 1f /* Metadata: 0x0197AF79 */, Vector2 vOffset = default, string textureName = "items" /* Metadata: 0x0197AF7D */) {} // 0x0000000186818C00-0x0000000186819B70
	}
}

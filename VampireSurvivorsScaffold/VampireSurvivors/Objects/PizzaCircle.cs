/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.App.Objects;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Geom;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public class PizzaCircle : GameMonoBehaviour // TypeDefIndex: 15091
	{
		// Fields
		public EnemyType EnemyTag; // 0x28
		private SpriteRenderer _pizzaSprite; // 0x30
		private SpriteRenderer _warningSprite; // 0x38
		private Circle _circle; // 0x40
		private MapToken _mapToken; // 0x48
	
		// Properties
		public Circle Circle { get => default; } // 0x0000000180B15750-0x0000000180B15760 
	
		// Constructors
		public PizzaCircle() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		private new void Awake() {} // 0x00000001869FEA00-0x00000001869FEEF0
		private void OnDrawGizmos() {} // 0x00000001869FEEF0-0x00000001869FEF90
		public void SetSprite(string texture, string frameName) {} // 0x00000001869FEF90-0x00000001869FF0D0
		public void SetMapToken(string texture, string frameName) {} // 0x00000001869FF0D0-0x00000001869FF400
		public void CleanUp() {} // 0x00000001869FF400-0x00000001869FF490
		public void Init(float radius) {} // 0x00000001869FF490-0x00000001869FF600
		public bool CheckPizzaOverlap(Vector2 point) => default; // 0x00000001869FF600-0x00000001869FF620
		public void ShowWarning() {} // 0x00000001869FF620-0x00000001869FF9F0
		public void ShowFinalWarning() {} // 0x00000001869FF9F0-0x00000001869FFF10
		public void SetAlpha(float alpha) {} // 0x00000001869FFF10-0x00000001869FFF80
		public void SetMapTokenHidden(bool isHidden) {} // 0x00000001869FFF80-0x00000001869FFF90
	}
}

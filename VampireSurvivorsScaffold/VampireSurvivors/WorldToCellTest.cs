/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Tilemaps;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class WorldToCellTest : MonoBehaviour // TypeDefIndex: 14143
	{
		// Fields
		[SerializeField]
		protected PhaserTilemap tilemap; // 0x20
		[SerializeField]
		protected SpriteRenderer targetSprite; // 0x28
		[SerializeField]
		protected bool drawOrig; // 0x30
		[SerializeField]
		protected bool drawCalc; // 0x31
	
		// Constructors
		public WorldToCellTest() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void OnDrawGizmosSelected() {} // 0x0000000186D9F570-0x0000000186DA00C0
		private Vector3Int WorldToCell(Tilemap tilemap, Vector3 point) => default; // 0x0000000186DA00C0-0x0000000186DA0370
	}
}

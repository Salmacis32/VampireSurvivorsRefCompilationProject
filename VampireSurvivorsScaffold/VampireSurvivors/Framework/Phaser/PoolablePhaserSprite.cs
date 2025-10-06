/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using QFSW.MOP2;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Phaser
{
	public class PoolablePhaserSprite : PhaserSprite, IPoolable // TypeDefIndex: 18221
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ObjectPool _ParentPool; // 0x40
	
		// Properties
		public bool PoolReady { get => default; } // 0x0000000186705CC0-0x0000000186705D90 
	
		// Constructors
		public PoolablePhaserSprite() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		void IPoolable.InitializeTemplate(ObjectPool pool) {} // 0x000000018260F820-0x000000018260F880
		public void Release() {} // 0x0000000186705D90-0x0000000186705DC0
	}
}

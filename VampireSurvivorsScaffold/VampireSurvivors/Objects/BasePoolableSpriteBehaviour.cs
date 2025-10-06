/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using QFSW.MOP2;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public class BasePoolableSpriteBehaviour : ArcadeSprite, IPoolable // TypeDefIndex: 15065
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ObjectPool _ParentPool; // 0x58
	
		// Properties
		public bool PoolReady { get => default; } // 0x00000001869D4D50-0x00000001869D4E20 
	
		// Constructors
		public BasePoolableSpriteBehaviour() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		void IPoolable.InitializeTemplate(ObjectPool pool) {} // 0x00000001826E9730-0x00000001826E9790
		public void Release() {} // 0x00000001869D4E20-0x00000001869D4E50
	}
}

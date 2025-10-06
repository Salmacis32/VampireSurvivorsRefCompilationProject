/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Data
{
	public struct UiTransition // TypeDefIndex: 18448
	{
		// Fields
		public Action<CharacterController, Dictionary<string, object>> TransitionPredicate; // 0x00
		public CharacterController TriggeredByPlayer; // 0x08
		public Dictionary<string, object> Arguments; // 0x10
		public UITransitionType TransitionType; // 0x18
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class GameDebugInfo : MonoBehaviour // TypeDefIndex: 14778
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _DebugText; // 0x20
		private VampireSurvivors.Objects.Stage _stage; // 0x28
		private DestructibleFactory _destructibleFactory; // 0x30
	
		// Constructors
		public GameDebugInfo() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		[Inject]
		private void Construct(VampireSurvivors.Objects.Stage stage, DestructibleFactory destructibleFactory) {} // 0x0000000185268990-0x0000000185268A40
		private void Update() {} // 0x0000000186894C80-0x0000000186894D20
		private void BuildDebugInfo() {} // 0x0000000186894D20-0x00000001868953D0
	}
}

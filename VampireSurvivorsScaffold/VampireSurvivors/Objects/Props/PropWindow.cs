/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Props
{
	public class PropWindow : Destructible // TypeDefIndex: 15374
	{
		// Fields
		private VampireSurvivors.Objects.Stage _stage; // 0xF8
		private bool _hasFired; // 0x100
	
		// Constructors
		public PropWindow() {} // 0x00000001869ECEE0-0x00000001869ECF40
	
		// Methods
		[Inject]
		private void Construct(VampireSurvivors.Objects.Stage stage) {} // 0x0000000180B3E800-0x0000000180B3E860
		public override void Init(PropType destructibleType) {} // 0x0000000186BA5760-0x0000000186BA5830
		protected override void OnDestroyed() {} // 0x0000000186BA5830-0x0000000186BA5C20
	}
}

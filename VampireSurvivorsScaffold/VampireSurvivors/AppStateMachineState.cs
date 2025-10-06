/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class AppStateMachineState : StateMachineState // TypeDefIndex: 14105
	{
		// Fields
		protected AppStateMachine appStateMachine; // 0x28
		protected bool UsesBackButton; // 0x30
		protected bool AutoSelectBackButton; // 0x31
		protected LobbiesManager _lobbiesManager; // 0x38
	
		// Constructors
		public AppStateMachineState() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		[Inject]
		private void Construct(LobbiesManager lobbiesManager) {} // 0x0000000181953C20-0x0000000181953C80
		public override void Init(StateMachine stateMachine) {} // 0x0000000186C576C0-0x0000000186C57830
		public override void OnEnter() {} // 0x0000000186C57830-0x0000000186C57910
		private void ShowBackButton() {} // 0x0000000186C57910-0x0000000186C579E0
		public override void OnExit() {} // 0x0000000186C579E0-0x0000000186C57AF0
		private void HideBackButton() {} // 0x0000000186C57AF0-0x0000000186C57BC0
		protected virtual void GoBack() {} // 0x0000000186C57BC0-0x0000000186C57CA0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Objects;
using VampireSurvivors.UI;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.UI
{
	public class StageRandomPanel : MonoBehaviour // TypeDefIndex: 18639
	{
		// Fields
		[SerializeField]
		private TickBoxUI _RandomEventsTickBox; // 0x20
		[SerializeField]
		private TickBoxUI _RandomLevelsTickBox; // 0x28
		private PlayerOptions _playerOptions; // 0x30
		private StageData _stageData; // 0x38
		private StageType _stageType; // 0x40
		private string _pointlessString; // 0x48
	
		// Properties
		public TickBoxUI RandomEventsTickBox { get => default; } // 0x0000000180B15530-0x0000000180B15540 
		public TickBoxUI RandomLevelUpsTickBox { get => default; } // 0x0000000180B15540-0x0000000180B15550 
		private bool HasRandomEvents { get; set; } // 0x000000018264AE80-0x000000018264AE90 0x00000001841A6E80-0x00000001841A6E90
		private bool HasRandomLevels { get; set; } // 0x00000001848FA660-0x00000001848FA670 0x0000000185E0DBC0-0x0000000185E0DBD0
		private bool IsStageUnlocked { get; set; } // 0x0000000185479BF0-0x0000000185479C00 0x0000000185E0DBD0-0x0000000185E0DBE0
	
		// Constructors
		public StageRandomPanel() {} // 0x0000000186808910-0x00000001868089E0
	
		// Methods
		[Inject]
		private void Construct(PlayerOptions playerOptions) {} // 0x0000000180B1D520-0x0000000180B1D580
		public void SetStage(StageData stageData, StageType stageType) {} // 0x00000001868081D0-0x0000000186808550
		public void OnRandomEventsToggled() {} // 0x0000000186808550-0x00000001868085B0
		public void MakeVisuallyDisabled() {} // 0x00000001868085B0-0x0000000186808660
		public void MakeVisuallyEnabled() {} // 0x0000000186808660-0x0000000186808710
		public void OnRandomLevelsToggled() {} // 0x0000000186808710-0x0000000186808770
		private void SetupRandomEventsToggle() {} // 0x0000000186808770-0x0000000186808840
		private void SetupRandomLevelsToggle() {} // 0x0000000186808840-0x0000000186808910
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class StageStatsPanel : MonoBehaviour // TypeDefIndex: 14990
	{
		// Fields
		[SerializeField]
		private StageStatUI _TimeLimit; // 0x20
		[SerializeField]
		private StageStatUI _ClockSpeed; // 0x28
		[SerializeField]
		private StageStatUI _MoveSpeed; // 0x30
		[SerializeField]
		private StageStatUI _GoldBonus; // 0x38
		[SerializeField]
		private StageStatUI _LuckBonus; // 0x40
		[SerializeField]
		private StageStatUI _EnemyHealth; // 0x48
		[SerializeField]
		private StageStatUI _Description; // 0x50
		[SerializeField]
		private StageStatUI _XPBonus; // 0x58
		[SerializeField]
		private GameObject _DescriptionPage; // 0x60
		[SerializeField]
		private UnityEngine.UI.Button _PreviousPage; // 0x68
		[SerializeField]
		private UnityEngine.UI.Button _NextPage; // 0x70
		private StageData _currentStage; // 0x78
		private StageType _currentType; // 0x80
		private bool _hyperSelected; // 0x84
		private bool _hurrySelected; // 0x85
		private bool _inverseSelected; // 0x86
		private Color _darkRed; // 0x88
		private PlayerOptions _playerOptions; // 0x98
		private int _pageCount; // 0xA0
	
		// Constructors
		public StageStatsPanel() {} // 0x0000000186998030-0x0000000186998090
	
		// Methods
		public void SetHyper(bool b) {} // 0x0000000186995C30-0x0000000186995C40
		public void SetHurry(bool b) {} // 0x0000000185691170-0x0000000185691180
		public void SetInverse(bool b) {} // 0x0000000186995C40-0x0000000186995C50
		public void SetPlayerOptions(PlayerOptions playerOptions) {} // 0x0000000182649B10-0x0000000182649B70
		public void Refresh() {} // 0x0000000186995C50-0x0000000186995EF0
		[IteratorStateMachine(typeof(_WaitAndCheckPages_d__24))]
		private IEnumerator WaitAndCheckPages() => default; // 0x0000000186995EF0-0x0000000186995F90
		private bool ShowHyperInfo() => default; // 0x0000000186995F90-0x0000000186995FD0
		public void SetStage(StageData stage, StageType t, PlayerOptions playerOptions) {} // 0x0000000186995FD0-0x00000001869960C0
		private void SetTimeLimit() {} // 0x00000001869960C0-0x00000001869964F0
		private void SetClockSpeed() {} // 0x00000001869964F0-0x0000000186996860
		private void SetMoveSpeed() {} // 0x0000000186996860-0x0000000186996B00
		private void SetGoldBonus() {} // 0x0000000186996B00-0x0000000186996FA0
		private void SetLuckBonus() {} // 0x0000000186996FA0-0x0000000186997360
		private void SetEnemyHealth() {} // 0x0000000186997360-0x0000000186997770
		private void SetDescription() {} // 0x0000000186997770-0x0000000186997C40
		private void SetXPBonus() {} // 0x0000000186997C40-0x0000000186998030
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class Report2Weapon : ReportWeapon // TypeDefIndex: 16203
	{
		// Fields
		[SerializeField]
		private GameObject _votingScreenDisplay; // 0x188
		[SerializeField]
		private Report2VotingScreenOption _votingScreenOptionPrefab; // 0x190
		[SerializeField]
		private Transform _votingScreenOptionsContainer; // 0x198
		[SerializeField]
		private SpriteRenderer _votingScreenBackground; // 0x1A0
		private List<Report2VotingScreenOption> _votingOptions; // 0x1A8
		private int _voteTarget; // 0x1B0
		private float _votingTimer; // 0x1B4
		private bool _isVotingScreenOpen; // 0x1B8
		private float _votingDelay; // 0x1BC
		private MultiTargetTween _screenShakeTween; // 0x1C0
		private bool _shouldBeVisible; // 0x1C8
	
		// Constructors
		public Report2Weapon() {} // 0x0000000186F5BFE0-0x0000000186F5C1A0
	
		// Methods
		public float VotingInterval() => default; // 0x0000000186F5A640-0x0000000186F5A690
		protected override void Awake() {} // 0x0000000186F5A690-0x0000000186F5A770
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F5A770-0x0000000186F5A830
		public override void InternalUpdate() {} // 0x0000000186F5A830-0x0000000186F5A950
		private void EmergencyMeeting() {} // 0x0000000186F5A950-0x0000000186F5A960
		private void ShowVotingScreen() {} // 0x0000000186F5A960-0x0000000186F5AF90
		public void OnlinePerformVote(List<EnemyType> enemyTypes, int voteTarget) {} // 0x0000000186F5AF90-0x0000000186F5B330
		[IteratorStateMachine(typeof(_PerformVote_d__18))]
		private IEnumerator PerformVote(List<EnemyType> enemyTypes) => default; // 0x0000000186F5B330-0x0000000186F5B430
		private float GetTargetVotingScreenDisplayLocalYPos() => default; // 0x0000000186F5B430-0x0000000186F5B520
		private void EraseEnemyType(EnemyType type) {} // 0x0000000186F5B520-0x0000000186F5B760
		private void HideVotingScreen() {} // 0x0000000186F5B760-0x0000000186F5BA40
		private void ScreenShake() {} // 0x0000000186F5BA40-0x0000000186F5BFD0
		public override void SetVisible(bool visible) {} // 0x0000000186F5BFD0-0x0000000186F5BFE0
	}
}
